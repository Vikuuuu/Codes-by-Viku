using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля, въведете размера на първия масив: ");
            int array1Size = int.Parse(Console.ReadLine());
            Console.WriteLine("Моля, въведете размера на втория масив: ");
            int array2Size = int.Parse(Console.ReadLine());

            int[] array1 = new int[array1Size];
            int[] array2 = new int[array2Size];

            for (int i = 0; i < array1.Length; i++) 
            {
                Console.WriteLine("Моля, въведете поредния елемент в масив 1: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < array2.Length; i++) 
            {
                Console.WriteLine("Моля, въведете поредния елемент в масив 2: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            
            bool arraysAreEqual = ArraysEqual(array1, array2);
            
            Console.WriteLine("Еднакви ли са масивите? " + arraysAreEqual);
        }


        public static bool ArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
