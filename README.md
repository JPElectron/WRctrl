# WRctrl
Connects to WebRelay, changes relay state

Designed to be run from the command-line with parameters to control the relay

This program requires: Microsoft .NET Framework 4 Client Profile

<b>Usage:</b>

WRctrl.exe [IP_Address] [Port] [Off/On/Pulse] [Relay Number (optional)]

   Examples for WebRelay (single relay):

      WRctrl.exe 127.0.0.1 80 Off      ... connects to IP 127.0.0.1 on port 80 and turns relay Off

      WRctrl.exe 127.0.0.1 8080 On     ... connects to IP 127.0.0.1 on port 8080 and turns relay On

      WRctrl.exe 127.0.0.1 80 Pulse    ... connects to IP 127.0.0.1 on port 80 and pulse relay (for whatever duration is set in WebRelay)

   Examples for WebRelay Dual (and all others with multiple relays)

      WRctrl.exe 127.0.0.1 80 Off 2      ... connects to IP 127.0.0.1127.0.0.1 on port 80 and turns relay 2 Off

      WRctrl.exe 127.0.0.1 8080 On 1     ... connects to IP 127.0.0.1 on port 8080 and turns relay 1 On

      WRctrl.exe 127.0.0.1 80 Pulse 2    ... connects to IP 127.0.0.1 on port 80 and pulse relay 2 (for whatever duration is set in WebRelay)

Don't use 127.0.0.1 silly, put the IP address of your own WebRelay.

<b>Related Links:</b>

WebRelay from http://www.controlbyweb.com/webrelay
