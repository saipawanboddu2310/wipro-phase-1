using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] jgArray = new int[4][];
            jgArray[0] = new int[2] { 12, 45 };
            jgArray[1] = new int[3] { 11, 33, 56 };
            jgArray[2] = new int[1] { 100 };
            jgArray[3] = new int[5] { 11, 22, 33, 44, 55 };

            Console.WriteLine("\n Displaying jagged array ...");
            for (i = 0; i < jgArray.Length; i++)
            {
                Console.WriteLine($"I am in row :{i + 1} and having {jgArray[i].Length} elements");
                for (j = 0; j < jgArray[i].Length; j++)
                {
                    Console.WriteLine($"{jgArray[i][j]}");
                }
            }
            Console.ReadLine();
        }
    }
   
}


/*          int[][] jgArray=new int[4][];
            int i, j;

            //jgArray[0] = new int[2] { 12, 34 };
            //jgArray[1] = new int[1] { 1000 };
            //jgArray[2] = new int[4] { 20,78,14,76 };
            //jgArray[3] = new int[3] { 11,33,51};
            
            Console.WriteLine("read from the user ..");
            for (i = 0; i < jgArray.Length; i++)
            {
                Console.WriteLine($"\n I am in row :{i + 1} asking u to enter  ");
                   
                Console.WriteLine("\nenter columns or elemnts in the row ");
                int colsize = Convert.ToInt32(Console.ReadLine());
                jgArray[i] = new int[colsize];
                for (j = 0; j < jgArray[i].Length; j++)
                {
                    Console.WriteLine($"\nenter element at [{i+1},{j+1}]");
                    jgArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //displayng jagged array 
            Console.WriteLine("\n displaying jagged array ");
            for(i=0;i<jgArray.Length;i++)
            {
                Console.WriteLine($"I am in row : {i + 1} an having {jgArray[i].Length}");
                for(j=0;j<jgArray[i].Length;j++)
                {
                    Console.WriteLine($"{jgArray[i][j]}  ");
                }
            }

            Console.ReadLine();

*/