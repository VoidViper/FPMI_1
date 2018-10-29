using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArr, currIndex = 0;
            Console.Write("Enter the number of elements in your array: ");
            numArr = Convert.ToInt32(Console.ReadLine());
            int[] intArr = new int[numArr]; // zadavame nashiq array da ima broi na elementi kolkoto sme poeli ot user-a
            int[] TimesInArr = new int[intArr.Length];

            for (int i = 0; i < numArr; i++) //cikul s koito zadavame int stoinosti za broq elementi na array-a
            {
                Console.Write("Enter the int value for element {0}: ", i);
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxVal = intArr[0];

            for (int i = 1; i < intArr.Length; i++) //obhojdame masiva kakto leka jena obhojda sugar daddies za da namerim maxVal i negovata poziciq
            {
                if (maxVal < intArr[i])
                {
                    maxVal = intArr[i];
                }
            }
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] == maxVal)
                {
                    TimesInArr[currIndex] = i;
                    currIndex++; //currIndex pokazva po vsqko edno vreme v masiva kolko chisla ima
                }
            }
            for (int i = 0; i < currIndex; i++)
            {
                Console.WriteLine("The elements with maxVal are in positions {0}", TimesInArr[i]);
            }
            Console.WriteLine("The highest value in the int array is: {0}", maxVal);
            Console.ReadLine();
        }
    }
}
