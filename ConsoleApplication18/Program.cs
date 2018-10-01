using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{  
    class Program
    {  
       struct num
        {  string x;
            string y; }
        static void Main(string[] args)
       {
           int result_1, result_2;
           int[] array = new int[8];
           array[0] = 10;
           array[1] = 7;
           array[2] = 6;
           array[3] = 5;
           array[4] = 8;
           array[5] = 3;
           array[6] = 2;
           array[7] = 1;
           for (int i = 0; i < 4; i++)
           {
               if (array[i] % 2 != 0)
               {
                   {
                       result_1 = (Math.Max(Math.Max(array[0], array[1]), Math.Max(array[2], array[3])));
                       Console.WriteLine(result_1);

                   }

               }
           }

           for (int N = 4; N < 8; N++)
           {
               if (array[N] % 2 == 0)
               {
                   {
                       result_2 = (Math.Max(Math.Max(array[4], array[5]), Math.Max(array[6], array[7])));
                       Console.WriteLine(result_2);


                   }

               }
           }
           num res = new num();

           {
               "odd";
               "even";
           }
           Console.WriteLine();
       }
        }
           

 
                  
}
    
     



       
 