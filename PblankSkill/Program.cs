using System;
using System.Collections.Generic;
using System.Linq;

namespace PblankSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Input Data :");
            string inputData = Console.ReadLine();

            string[] valueData = new string[] { "a", "e", "i", "o", "u" };
            int[] scoreTable = new int[] { 2, 3, 4, 5, 6 };

            List<string> listData = new List<string>();
            string getChecker;

            for (int i = 0; i < inputData.Length; i++)
            {
                getChecker = inputData[i].ToString();
                NewMethodDataToUpper(inputData, listData, getChecker, i);
            }
            foreach (var item in listData)
            {
                Console.Write(item);
            }
            int total = 0;

            getChecker = "";
            Console.WriteLine();

            int score = 0;
            int temp = 0;
            int count = 0;

            for (int i = 0; i < inputData.Length; i++)
            {
                getChecker = inputData.Substring(i,1);

                total = NewMethodChechTotal(getChecker);
                if (getChecker == "a")
                {
                    count++;
                    temp = temp + 2;
                }
                else if (getChecker == "e")
                {
                    count++;
                    temp = temp + 3;
                }
                else if (getChecker == "i")
                {
                    count++;
                    temp = temp + 4;
                }
                else if (getChecker == "o")
                {
                    count++;
                    temp = temp + 5;
                }
                else if (getChecker == "u")
                {
                    count++;
                    temp = temp + 6;
                }
                else
                {
                    if (i == inputData.Count()-1)
                    {
                        NewMethodCheckScore(ref score, ref temp, ref count);
                    }
                    else
                    {
                        NewMethodCheckScore(ref score, ref temp, ref count);
                    } 
                }
                if (count >= 1 && i == inputData.Count() - 1)
                {
                    NewMethodCheckScoreLast(ref score, ref temp, ref count);
                }
            }
            Console.WriteLine(score);
        }

        private static void NewMethodCheckScoreLast(ref int score, ref int temp, ref int count)
        {
            if (count == 1 || count == 0)
            {
                score = score + temp;
                count = 0;
                temp = 0;
            }
            else
            {
                score = score + (temp * 2);
                temp = 0;
                count = 0;
            }
        }

        private static void NewMethodCheckScore(ref int score, ref int temp, ref int count)
        {
            if (count == 1 || count == 0)
            {
                score = score + temp + 1;
                count = 0;
                temp = 0;
            }
            else
            {
                score = score + (temp * 2);
                temp = 0;
                count = 0;
            }
        }

        private static int NewMethodChechTotal(string getChecker)
        {
            int total;
            if (getChecker == "a")
            {
                total = 2;
            }
            else if (getChecker == "e")
            {
                total = 3;
            }
            else if (getChecker == "i")
            {
                total = 4;
            }
            else if (getChecker == "o")
            {
                total = 5;
            }
            else if (getChecker == "u")
            {
                total = 6;
            }
            else
            {
                total = 1;
            }

            return total;
        }

        private static void NewMethodDataToUpper(string inputData, List<string> listData, string getChecker, int i)
        {
            if (getChecker == "a")
            {
                listData.Add(inputData.Substring(i, 1).ToUpper());
            }
            else if (getChecker == "e")
            {
                listData.Add(inputData.Substring(i, 1).ToUpper());
            }
            else if (getChecker == "i")
            {
                listData.Add(inputData.Substring(i, 1).ToUpper());
            }
            else if (getChecker == "o")
            {
                listData.Add(inputData.Substring(i, 1).ToUpper());
            }
            else if (getChecker == "u")
            {
                listData.Add(inputData.Substring(i, 1).ToUpper());
            }
            else
            {
                listData.Add(inputData.Substring(i, 1));
            }
        }
    }
}
