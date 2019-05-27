using System;

namespace Pointers
{
    class MainClass
    {
        public static unsafe void Method()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);
            Console.WriteLine((int)ptr2);
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
        }
        public static void Main(string[] args)
        {
            //int x = 100;
            //int *ptr = &x;  
            //Console.WriteLine((int)ptr) // Displays the memory address  
            //Console.WriteLine(*ptr) // Displays the value at the memory address.   
            Method();
            
        }
    }
}
