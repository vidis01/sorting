using System;

namespace SortingAPI.Exceptions
{
    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message):base(message)
        {
        }
    }
}
