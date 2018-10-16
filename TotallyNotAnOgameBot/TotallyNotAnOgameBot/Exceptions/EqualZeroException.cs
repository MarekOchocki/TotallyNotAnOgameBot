using System;

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
