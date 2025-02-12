using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap14Demos_Inheritance_
{
    public sealed class Software : Product
    {

        public string Version { get; set; }

        public Software(string code, string description, decimal price, string version) :
            base(code, description, price)
        {
            this.Version = version;
        }
        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)} ({Version})";
        }
    }
}
