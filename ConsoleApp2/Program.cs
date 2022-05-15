using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열에서 3보다 큰 짝수를 찾는 함수 만들기
            int[] testArray = new int[] { 1, 56, 2, 3, 4, 6 };
            int returnNumber = FindNumber(testArray);
            Console.WriteLine(returnNumber);
        }

        private static int FindNumber(int[] testArray)
        {
            for (int i = 0; i < testArray.Length; i++)
            {
                int number = testArray[i];
                int remain = number % 2;
                if (remain == 0)
                {
                    return number;
                }
            }

            return -1;
        }
    }
}
