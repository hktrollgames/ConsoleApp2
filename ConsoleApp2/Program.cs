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
            List<int>   testList    = new List<int> { 1, 56, 2, 3, 4, 6 };
            int[]       testArray   = new int[]     { 1, 56, 2, 3, 4, 6 };
            int returnNumber = testList.Where(x => x > 3 && x % 2 == 0)
                .OrderBy(x => x)
                .First();

            Console.WriteLine(returnNumber);

            //&& -> And 조건 : true true일때 참
            // a && b : a, b랑 둘다 참일때 참
            bool a = true;
            bool b = true;
            bool c = a && b;// true or false; -> true
            b = false;
            c = a && b;     // c -> false

            //||// or : 둘중 하나라도 참이면 true;
            c = a || b;     // c : true;
        }
    }
}
