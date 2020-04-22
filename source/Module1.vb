Imports System
Imports System.Text
Imports System.Net.Sockets
Imports System.Linq

Module Module1

    Public Sub Main()
        Dim arguments As [String]() = Environment.GetCommandLineArgs()
        Dim ip As String
        Dim port As String
        Dim relaynum As String

        ip = Environment.GetCommandLineArgs(1)
        port = Environment.GetCommandLineArgs(2)

        'note first argument (index 0) is the name of the exe itself
        'so if there are over 4 arguments (relaynum is really the 5th) only then should we use it
        If arguments.Count > 4 Then
            relaynum = Environment.GetCommandLineArgs(4)
        End If

        If Environment.GetCommandLineArgs(3) = "Off" Then
            If relaynum <> "" Then
                sendRequest(ip, port, "0", relaynum)
            Else
                sendRequest(ip, port, "0", "0")
            End If
        End If
        If Environment.GetCommandLineArgs(3) = "On" Then
            If relaynum <> "" Then
                sendRequest(ip, port, "1", relaynum)
            Else
                sendRequest(ip, port, "1", "0")
            End If
        End If
        If Environment.GetCommandLineArgs(3) = "Pulse" Then
            If relaynum <> "" Then
                sendRequest(ip, port, "2", relaynum)
            Else
                sendRequest(ip, port, "2", "0")
            End If
        End If
    End Sub

    Private Sub sendRequest(ByVal ip As String, ByVal port As Integer, ByVal val As String, ByVal relaynum As Integer)

        Dim tcpClient As New System.Net.Sockets.TcpClient()

        Try
            'Connect to device
            tcpClient.Connect(ip, port)

            If tcpClient.Connected Then

                'Create a network stream object
                Dim netStream As NetworkStream = tcpClient.GetStream()

                'If we can read and write to the stream then do so
                If netStream.CanWrite And netStream.CanRead Then

                    'Send the command to webrelay
                    If relaynum = "0" Then
                        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes("GET /state.xml?relayState=" & val & " HTTP/1.1" & vbCrLf & "Authorization: Basic bm9uZTp3ZWJyZWxheQ==" & vbCrLf & vbCrLf)
                        netStream.Write(sendBytes, 0, sendBytes.Length)
                    Else
                        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes("GET /state.xml?relay" & relaynum & "State=" & val & " HTTP/1.1" & vbCrLf & "Authorization: Basic bm9uZTp3ZWJyZWxheQ==" & vbCrLf & vbCrLf)
                        netStream.Write(sendBytes, 0, sendBytes.Length)
                    End If

                    'Get the response from webrelay
                    Dim bytes(tcpClient.ReceiveBufferSize) As Byte
                    netStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))

                End If

                'Close the connection
                tcpClient.Close()

            End If

        Catch e As Exception
            'Do nothing
        End Try

    End Sub

End Module
