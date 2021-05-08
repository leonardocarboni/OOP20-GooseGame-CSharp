using System;

namespace Ongaro.exception
{
    public class IllegalArgumentException : Exception
    {
        public IllegalArgumentException()
        {
        }

        public IllegalArgumentException(string message)
            : base(message)
        {
        }

        public IllegalArgumentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
