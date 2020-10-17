using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Network_Coffee
{
    public class NetInterface
    {
        public IPAddress IP;
        public IPAddress SubnetMask;
        public IPAddress BroadcastAddress;
        public bool Enabled;

        public NetInterface(IPAddress IP, IPAddress SubnetMask)
        {
            this.IP = IP;
            this.SubnetMask = SubnetMask;

            string[] subnets = SubnetMask.ToString().Split('.');
            string[] IPBits = IP.ToString().Split('.');
            string BroadcastAddressStr = string.Empty;

            for(int i = 0; i < 4; i++)
            {
                string oct;
                if(Convert.ToInt32(subnets[i]) != 255)
                {
                    oct = "255.";
                }
                else
                {
                    oct = IPBits[i] + ".";
                }
                BroadcastAddressStr = BroadcastAddressStr + oct;
            }
            BroadcastAddressStr = BroadcastAddressStr.Remove(BroadcastAddressStr.Length - 1);
            this.BroadcastAddress = IPAddress.Parse(BroadcastAddressStr);
            this.Enabled = true;
        }
    }
}
