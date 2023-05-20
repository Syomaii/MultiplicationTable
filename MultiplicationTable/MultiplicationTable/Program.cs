/*
    Name: Christian Jay Putol
    Date Created: 02/25/2023
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t       ---------------Multiplication Table-----------------\n");
            for(int row = 1; row <= 10; row++) 
            {
                for (int col = 1; col <= 10; col++)
                {
                    int product = row * col;
                    Console.Write("\t    "+product);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
