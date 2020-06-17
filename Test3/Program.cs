using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charTable = new string[] { "a","e","i","o","u"};
            int[] scoreTable = new int[] {2,3,4,5,6};
            var score = 0;

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string getChecker = input[i].ToString();//Chat String
                Console.WriteLine("getChecker :" + getChecker);

                int foundIndex = Array.IndexOf(charTable,getChecker);  //  Data => index      
                if (foundIndex == -1)
                {
                    score++;
                }
                else
                { //เจอว่าเป็นสระ
                    var tempScore = scoreTable[foundIndex];
                    var skip = 1;
                    var next = i + skip;
                    var nextChar = input[next].ToString(); //n
                    int foundIndex2 = Array.IndexOf(charTable, nextChar);
                    while (foundIndex2 != -1)
                    {

                    }

                    //var foundIndex3 = Array.IndexOf(charTable, nextChar);
                    //if (foundIndex3 == -1)
                    //{
                    //    score += tempScore;
                    //}
                    //else
                    //{

                    //}
                    Console.WriteLine("nextChar :" + nextChar);
                }
            }
            Console.WriteLine(score);
        }
    }
}
