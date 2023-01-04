using System;

namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Description desc = new Description();


            int number1 = 10;
            int number2 = 20;

            // 값 전달 방식
            desc.ValueTypeParam(number1, number2);

            // 바뀐 값을 보여졌지만 원본 변수는 그대로다.
            Console.WriteLine("[Main]first : {0}, second : {1}",
                number1, number2);


            Console.WriteLine();
            //================

            // 참조 전달 방식(ref) : 원본 변수를 수정할 수 있다.
            desc.RefTypeParam(ref number1, ref number2);

            // 원본 변수도 같이 바뀐걸 볼 수 있다.
            Console.WriteLine("[Main]first : {0}, second : {1}",
                number1, number2);

            //================
            Console.WriteLine();


            int number;
            // 반환형 전달 방식(out) : 변수를 초기화 해서 넘겨준다.
            desc.OutTypeParam(out number);
            Console.WriteLine("[Main] number : {0}", number);


            string strNumber = "100";
            int intNumber;
            // strNumber 값을 받으면 int 변환하고 intNumber로 반환한다.
            int.TryParse(strNumber, out intNumber);
            Console.WriteLine("{0}", intNumber + 10);
            Console.WriteLine();

            //================

            // 가변형 전달 방식(params)

            Console.WriteLine("{0}{1}", intNumber, intNumber);

            // 여러 값을 배열 형태로 저장하고 함수 출력함
            desc.FlexibleTypeParam(1, 2, 3, 10, 40, 100, 111, 123, 130);


            // 미리 배열을 만들어 놓았으면 아래 형태가 좋다.
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            desc.ArrayParam(numbers);
        }

    }
}