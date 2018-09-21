using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Exceptions
{
    class EqualZeroException: Exception
    {
        public EqualZeroException()
            :base("Set Zero value ")
        {

        }
    }
}
