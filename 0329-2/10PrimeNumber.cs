using System;

namespace Example2
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int index;
            for (index = 2; index < num; index++)
            {
                if (num % index == 0)
                {
                    Console.WriteLine("{0}는 소수가 아닙니다", num);
                    break;
                }
            }
            if (index == num)
                Console.WriteLine("{0}는 소수입니다", num);

        }
    }
}
