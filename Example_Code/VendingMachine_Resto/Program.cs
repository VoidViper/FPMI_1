using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Resto
{
    class Program
    {
        static void Main(string[] args)
        {
            //moneti - 1, 2, 5, 10, 20, 50, 100
            double resto = 0; //restoto
            int monetiAmount = 0;
            Console.Write("Enter the resto: ");
            resto = Convert.ToDouble(Console.ReadLine());
            while (resto > 0)
            {
                
                if(resto >= 2.0d) resto -= 2.0d;             
                else if (resto >= 1.0d) resto -= 1.0d;                
                else if (resto >= 0.5d) resto -= 0.5d;               
                else if (resto >= 0.2d) resto -= 0.2d;                
                else if (resto >= 0.1d) resto -= 0.1d;               
                else if (resto >= 0.05d) resto -= 0.05d;                
                else if (resto >= 0.02d) resto -= 0.02;
                else if (resto >= 0.01d) resto -= 0.01;
                
                monetiAmount++;
            }
            Console.WriteLine($"Minimum amount of coins is: {monetiAmount}");
        }
    }
}
