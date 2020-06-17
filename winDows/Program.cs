using System;
using System.Collections.Generic;

namespace winDows
{
    class Program
    {
        static void Main(string[] args)
        {
            List<setInput> DataSetInput = new List<setInput>();
            int[] num1 = new int[] { 6, 8, 1, 7, 9, 2 ,4 , 5};
            int[] num2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(" Plase Your Input Number : ");
            int numInput = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num1.Length; i++)
            {
                var getSetInput = new setInput();
                getSetInput.num1 = num1[i];
                getSetInput.num2 = num2[i];
                getSetInput.num1ORnum2 = num1[i] + num2[i];
                DataSetInput.Add(getSetInput);
            }

            for (int i = 0; i < num1.Length; i++)
            {
                var getSetInput = DataSetInput[i];
                int dataGet = getSetInput.num1ORnum2;
                if(dataGet == numInput)
                {
                    Console.WriteLine(" num {0} + {1} :" , getSetInput.num1 , getSetInput.num2);
                    Console.WriteLine(getSetInput.num1ORnum2);
                    break;
                }
                else
                {

                }
            }
            Console.ReadKey();
        }
    }
    public class setInput
    {
        public int num1;
        public int num2;
        public int num1ORnum2;
    }
}
