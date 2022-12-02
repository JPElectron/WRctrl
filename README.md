# WRctrl

Connects to WebRelay, changes relay state

Designed to be run from the command-line with parameters to control the relay

This program requires: Microsoft .NET Framework 4 Client Profile

## Usage

WRctrl.exe [IP_Address] [Port] [Off/On/Pulse] [Relay Number (optional)]

   Examples for WebRelay (single relay):

      WRctrl.exe 127.0.0.1 80 Off      ... connects to IP 127.0.0.1 on port 80 and turns relay Off

      WRctrl.exe 127.0.0.1 8080 On     ... connects to IP 127.0.0.1 on port 8080 and turns relay On

      WRctrl.exe 127.0.0.1 80 Pulse    ... connects to IP 127.0.0.1 on port 80 and pulse relay (for whatever duration is set in WebRelay)

   Examples for WebRelay Dual/Quad (and all others with multiple relays)

      WRctrl.exe 127.0.0.1 80 Off 2      ... connects to IP 127.0.0.1 on port 80 and turns relay 2 Off

      WRctrl.exe 127.0.0.1 8080 On 1     ... connects to IP 127.0.0.1 on port 8080 and turns relay 1 On

      WRctrl.exe 127.0.0.1 80 Pulse 3    ... connects to IP 127.0.0.1 on port 80 and pulse relay 3 (for whatever duration is set in WebRelay)

Don't use 127.0.0.1 silly, put the IP address of your own WebRelay.

## Related Links

WebRelay from http://www.controlbyweb.com/webrelay

## License

GPL does not allow you to link GPL-licensed components with other proprietary software (unless you publish as GPL too).

GPL does not allow you to modify the GPL code and make the changes proprietary, so you cannot use GPL code in your non-GPL projects.

If you wish to integrate this software into your commercial software package, or you are a corporate entity with more than 10 employees, then you should obtain a per-instance license, or a site-wide license, from http://jpelectron.com/purchase.html

For all other use cases please consider: <a href='https://ko-fi.com/C0C54S4JF' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi2.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

[End of Line]
