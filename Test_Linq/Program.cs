using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Test_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Input Dtaa A-Z");
            string InputData = Console.ReadLine();
            string CheckData = PostDataInput(InputData);
        }

        private static string PostDataInput(string inputNumber)
        {
            string[] Data = { "a", "e", "i", "o", "u" };
            bool check = false;
            List<string> list = new List<string>();
            List<int> Total = new List<int>();
            int sumTotal = 0;
            for (int i = 0; i < inputNumber.Count(); i++)
            {
                string dataGet = inputNumber.Substring(i, 1);
                check = MethodinputNumber(Data, check, dataGet);
                if (check == true)
                {
                    list.Add(inputNumber.Substring(i, 1).ToUpper());
                    sumTotal = NewMethodAddTotalInt(list, Total, sumTotal, i);
                }
                else
                {
                    list.Add(inputNumber.Substring(i, 1));
                    sumTotal = NewMethodAddTotalInt(list, Total, sumTotal, i);
                }
                check = false;
            }
            /////////////////////////
            check = false;
            bool check2 = false;

            int numArray = 0;
            string[] list2 = null;

            string[] srt = null;
            int numCount = 0;
            for (int i = 0; i < inputNumber.Count(); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (Total[i] == j)
                    {
                        check = true;
                    }
                }
                for (int o = 0; o < 7; o++)
                {
                    if (Total[i] == o)
                    {
                        check2 = true;
                    }
                }
             
                check = false;
                check2 = false;
            }
            foreach (var item in list)
            {
                Console.Write( item);
            }
            Console.WriteLine();
            Console.WriteLine("Sum :" + Total);
            return "";
        }

        private static int NewMethodAddTotalInt(List<string> list, List<int> Total, int sumTotal, int i)
        {
            if (list[i] == "A")
            {
                Total.Add(Int32.Parse("2"));
                sumTotal += 2;
            }
            else if (list[i] == "E")
            {
                Total.Add(Int32.Parse("3"));
                sumTotal += 3;
            }
            else if (list[i] == "I")
            {
                Total.Add(Int32.Parse("4"));
                sumTotal +=  4;
            }
            else if (list[i] == "O")
            {
                Total.Add(Int32.Parse("5"));
                sumTotal +=  5;
            }
            else if (list[i] == "U")
            {
                Total.Add(Int32.Parse("6"));
                sumTotal +=  6;
            }
            else
            {
                Total.Add(Int32.Parse("1"));
                sumTotal +=  1;
            }

            return sumTotal;
        }

        private static bool MethodinputNumber(string[] Data, bool check, string dataGet)
        {
            for (int j = 0; j < Data.Count(); j++)
            {
                if (dataGet == Data[j])
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
