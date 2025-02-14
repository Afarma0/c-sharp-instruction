using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    public interface ICountable
    {
        //abstract method - IncrementCount()
        //abstract method - ResetCount()
        //abstract method - GetCountString()
        public void IncrementCount();
        public void ResetCount();
        public string GetCountString();
    }
}
