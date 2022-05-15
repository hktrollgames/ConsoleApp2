using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 배열에서 3보다 큰 짝수를 찾는 함수 만들기
            // 2. 가장 작은 짝수를 리턴하자
            List<int> testArray = new List<int>{ 1, 56, 2, 3, 4, 6 };
            int returnNumber = testArray.Where(x => x > 3 && x % 2 == 0)
                .OrderBy(x => x)
                .First();

            Console.WriteLine(returnNumber);
        }
    }
}
