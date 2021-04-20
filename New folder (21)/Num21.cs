using System;

namespace Assingment
{
    public class Num21
    {
        public static void Num21(){

            int[] arr1 = {2, 4, 4, 5, 4, 5, 5, 3, 7, 9, 1};
           

            Console.Write("Input {0} elements in the array :\n", arr1);
            for (i = 0; i < arr1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < arr1; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
           
        }
    }
}