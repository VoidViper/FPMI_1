using System;
namespace Exceptions
{
    public class DoubleDevideByZeroException : Exception
    {
        public DoubleDevideByZeroException() : base ("You cannot devide by zero"){}
    }
}
