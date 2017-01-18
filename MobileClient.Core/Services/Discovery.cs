using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sockets.Plugin;

namespace MobileClient.Core.Services
{
  class Discovery
  {
    UdpSocketMulticastClient receiver_;
    Discovery()
    {
      
      receiver_ = new UdpSocketMulticastClient();
      receiver_.TTL = 5;

      receiver_.MessageReceived += (sender, args) =>
      {
        var from = String.Format("{0}:{1}", args.RemoteAddress, args.RemotePort);
        var data = Encoding.UTF8.GetString(args.ByteData, 0, args.ByteData.Length);

        //Debug.WriteLine("{0} - {1}", from, data);
      };
      join();
    }
    private async void join()
    {
      var port = 10001;
      var address = "239.255.255.255";
      await receiver_.JoinMulticastGroupAsync(address, port);
    }
  }
}
