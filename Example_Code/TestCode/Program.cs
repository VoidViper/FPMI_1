using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Name;
            int fNum;
            int[] grades;
            string gradesBufferSource = "";
            string[] gradesBufferResult;
            
            Console.Write("How many students would you like to add? : ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a faculty number: ");
                fNum = int.Parse(Console.ReadLine());
                Console.Write("Enter a name: ");
                Name = Console.ReadLine();
                Console.Write("Enter the student's grades with spaces in between them. [From 2 to 6 / max 40 grades]: ");
                gradesBufferSource = Console.ReadLine(); 
            }
            gradesBufferResult = gradesBufferSource.Split(' ');
            for (int i = 0; i < gradesBufferResult.Length; i++)
            {
                Console.WriteLine(gradesBufferResult[i]);
            }
            
            

        }
    }
}