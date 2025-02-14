using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    public class Sheep : Animal
    {
        public string Name { get; set; }    

        Sheep(string name)
        {
            this.Name = name;
        }
        public override string GetCountString()
        { 
        }
    }
}
