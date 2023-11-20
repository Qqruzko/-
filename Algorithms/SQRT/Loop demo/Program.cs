using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modu_2_
{


    class LoopProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            GetIntArray(number); 
            
            int[] GetIntArray(int num)
            {
                List<int> listOfInts = new List<int>();
                while (num > 0)
                {
                    listOfInts.Add(num % 10);
                    num = num / 10;
                }
                listOfInts.Reverse();
                int x = 0;
                foreach (int element in listOfInts)
                {
                    x = x + element;
                    Console.WriteLine(x);
                }
                return listOfInts.ToArray();

                
            }

            Console.ReadLine();
        }
    }
}
