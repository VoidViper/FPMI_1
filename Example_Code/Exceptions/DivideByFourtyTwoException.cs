using System;


namespace Exceptions
{
    class DivideByFourtyTwoException : Exception
    {
        public DivideByFourtyTwoException() : base("Division by 42") { }
    }
}
