using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Exceptions
{
    class LessThanZeroException : Exception
    {
        public LessThanZeroException()
            : base("Value less than 0 ")
        {
            
        }
    }
}
