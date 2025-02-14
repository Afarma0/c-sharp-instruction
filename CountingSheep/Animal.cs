using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    public abstract class Animal : ICountable

    {
        protected int count;

        public Animal()
        {
            count = 0;
        }

        public string GetCountString()
        {
            
            throw new NotImplementedException();
        }

        public void IncrementCount()
        {
            count++;
        }

        public void ResetCount()
        {
            count = 0;
        }

        
        
 
        
        //Property - Count: int
        //should implement IncrementCount() and ResetCount() methods

        //implements the Countable interface.
        //This class should include an instance variable that stores the count.

    }
}
