using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenti
{
    internal class Gitara : Instrument
    {
        private int strNumber = 6;

        public void setStrNumber(int strNumber) 
        { 
            this.strNumber = strNumber; 
        }

        public int getStrNumber() 
        { 
            return strNumber; 
        }

        public void play() 
        { 
            Console.WriteLine("гитара играет. " + toString()); 
        }

        public String toString() 
        { 
            return "количество струн: " + strNumber; 
        }
    }
}
