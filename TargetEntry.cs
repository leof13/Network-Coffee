using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Coffee
{
    public class TargetEntry
    {
        public string MAC;
        public string Nickname;

        public TargetEntry(string MAC, string Nickname)
        {
            this.MAC = MAC;
            this.Nickname = Nickname;
        }
    }
}
