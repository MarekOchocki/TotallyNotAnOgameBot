using System;

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
