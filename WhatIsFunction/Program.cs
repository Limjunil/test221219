﻿using System;

namespace WhatIsFunction
{
    internal class Program
    {

        static int _number1 = 1;
        static int _number2 = 3;
        static void Main(string[] args)
        {

            //string[,] starArray = new string[5, 5];

            //// 별찍기 직각 삼각형 했었던거
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        starArray[y, x] = "*";
            //    }
            //} // loop : 별을 배열에 초기화 하는 루프

            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = y; x < 5; x++)
            //    {
            //        if (starArray[y, x].Equals("*"))
            //        {
            //            Console.Write("{0}", starArray[y, x]);
            //        }
            //    }
            //    Console.WriteLine();
            //} // loop : 배열에 담긴 별을 출력하는 루프



            // Show();


            //Hi();
            //Hi();
            //Hi();

            //int someValue = 100;
            //Console.WriteLine(someValue);

            //someValue = Hi();
            //Console.WriteLine(someValue);


            //Hi("Hi i`m junil");


            //ShowMessage("매개변수");
            //ShowMessage("Parameter");


            //string returnValue = GetString();
            //Console.WriteLine(returnValue);



            //=======================================

            // 제곱값 출력
            //int r = SquareFunction(14);
            //Console.WriteLine(r);

            //=======================================

            // 연습 1. 두 수의 합을 구하는 함수를 작성하기
            //int number1 = 0;
            //int number2 = 0;


            //Console.WriteLine("두 수의 합과 최댓값과 최솟값을 구할 두 수를 입력해주세요");
            //Console.Write("첫 번째 값을 입력해주세요 : ");

            //int.TryParse(Console.ReadLine(), out number1);

            //Console.Write("두 번째 값을 입력해주세요 : ");

            //int.TryParse(Console.ReadLine(), out number2);

            //Console.WriteLine();

            //int numberAdd = TwoValueAdd(number1, number2);
            //Console.WriteLine("두 수의 합은 {0} 입니다.", numberAdd);

            //Console.WriteLine();


            // 연습 2. 함수를 사용하여 큰 값과 작은 값, 절댓값 구하기
            //int number3 = 0;

            //int maxValue = MaxValue(number1, number2);
            //Console.WriteLine("두 수의 최댓값은 {0} 입니다.", maxValue);
            //Console.WriteLine();

            //int minValue = MinValue(number1, number2);
            //Console.WriteLine("두 수의 최솟값은 {0} 입니다.", minValue);

            //Console.WriteLine();

            //Console.Write("절댓값을 구할 값을 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out number3);

            //int absoluteValue = AbsoluteValue(number3);
            //Console.WriteLine("절댓값은 {0} 입니다.", absoluteValue);
            //Console.WriteLine();


            //=========================================

            // 함수가 받는 값에 따라서 알맞는 함수 오버로드로 출력된다.
            //Multi();
            //Multi("반갑습니다.");
            //Multi("또 만나요.", 3);

            //Factorial(10);
            //Console.WriteLine("Factorial : {0}", Factorial(3));

            //=========================================

            int number1 = 10;
            int number2 = 30;

            //Swap(number1, number2);

            // 함수 내에서 새로 변수를 선언해서 사용하기에 값이 변하지 않는다.
            // 즉, 값만 함수로 보냈다.
            Console.WriteLine("Main의 number 값은? {0}, {1}", number1, number2);

        } // Main()

        static void Swap(int intValue1, int intValue2)
        {
            Console.WriteLine("바뀌기 전의 값 {0}, {1}", intValue1, intValue2);

            int temp;
            temp = intValue1;
            intValue1 = intValue2;
            intValue2 = temp;

            Console.WriteLine("바뀐 후의 값 {0}, {1}", intValue1, intValue2);
        }

        //! Hello world! 출력하는 사용자 정의 함수
        static void Show()
        {
            Console.WriteLine("Hello world!");

            /**
             * 함수(Function) 또는 메서드(Method)는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다.
             * 함수를 부르는 다양한 명칭
             * 함수(Function)
             * 메서드(Method)
             * 프로시저(Procedure)
             * 서브루틴(Subroutine)
             * 서브모듈(Submodule)
             * 
             * 프로그래밍을 하다 보면 같은 유형의 코드를 반복할 때가 많다. 이 코드들을 매번 입력하면 불편하고
             * 입력하다 실수도 할 수 있다. 이때 '함수'를 사용한다.
             * 
             * 프로그래밍 언어에서 함수는 어떤 동작 및 행위를 표현한다. 함수의 사용 목적은 코드 재사용에 있다.
             * 한 번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다.
             * 지금까지 사용한 Main() 메서드는 c#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
             * 또, Console 클래스의 WriteLine() 메서드도 함수로 볼 수 있다.
             * 
             * - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과값을 반환시켜 주는 코드이다.
             * - 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
             * 
             * 입력 -> 처리 -> 출력
             * 
             * 함수의 종류(내장 함수와 사용자 정의 함수)
             * 함수에는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 c#이 자주 사용하는 기능을 미리 만들어서
             * 제공하는 함수로, 특정 클래스의 함수로 표현된다.
             * 내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수, 수학 관련 함수, 형식 변환 관련 함수
             * 등으로 나눌 수 있다. 이러한 내장 함수를 API(Application Program Interface)로 표현된다.
             * 사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.
             * 
             * 함수 정의하고 사용하기
             * 함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는 작업이다. 함수 생성 및
             * 호출은 반드시 소괄호가 들어간다. 함수를 정의하는 형태는 지금까지 사용한 Main() 메서드와 유사하다.
             * 
             * 다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
             * 
             * static void [함수이름]()
             * {
             *      함수내용
             * }
             * 
             * 만든 함수를 호출하는 형태는 다음 세 가지가 있다.
             * [함수이름]();
             * [함수이름](매개변수);
             * 변수(결과값) = 함수이름(매개변수);
             * 
             */

            /**
             * 이 함수는 가장 간단한 형태의 함수로, 매개변수(Parameter)도 없고 반환 값(Return value)도 
             * 없는 형태이다.
             */
        }

        //! 안녕하세요 출력하는 함수
        static int Hi()
        {
            /**
             * 함수를 만들고 반복해서 사용하기
             * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 
             * 함수를 만들고 여러 번 호출해서 사용하는 방법을 알아보자.
             * 
             */
            Console.WriteLine("안녕하세요.");

            return 0;
        }


        // () 안에 인자가 들어가면 함수 중복이 가능하다.
        static int Hi(string text)
        {
            Console.WriteLine(text);

            return 0;
        }

        static int ParameterAndReturn()
        {
            /**
             * 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다.
             * 호출할 때마다 조금씩 다른 기능을 적용할 때는 함수의 매개변수를
             * 달리하여 호출할 수 있다.
             * 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를 나타낸다.
             * 이러한 매개변수는 콤마를 기준으로 여러 개 설정할 수 있으며, 문자열과 숫자 등 모든 데이터 형식을
             * 사용할 수 있다.
             * 
             * 매개변수(인자, 파라미터)가 없는 함수 : 매개변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
             * 앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString() 메서드처럼 빈 괄호만 있는
             * 함수 형식을 나타낸다.
             * 
             * 매개변수가 있는 함수 : 특정 함수에 인자 값을 1개 이상 전달하는 방식이다.
             * 정수형, 실수형, 문자형, 문자열형, 개체형 등 여러 가지 데이터 형식을 인자 값으로 전달할 수 있다.
             * 
             * 반환값이 있는 함수(결과값이 있는 함수) : 함수의 처리 결과를 함수를 호출한 쪽으로 반환할 때는 return 키워드를
             * 사용하여 데이터를 돌려줄 수 있다.
             * 
             * 매개변수가 가변(여러 개)인 함수 : c#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한
             * 함수를 여러 개 만들 수 있다. 이를 가리켜 함수 중복 또는 함수 오버로드(Overload)라고 한다.
             * 
             * 
             */

            return 0;
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // string 으로 받아라
        static string GetString()
        {
            return "반환값(Return Value)";
        }

        static int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        // 연습 1. 두 수의 합을 구하는 함수를 작성하기
        static int TwoValueAdd(int number1, int number2)
        {
            int numberAdd = number1 + number2;
            return numberAdd;
        }

        // 연습 2. 함수를 사용하여 큰 값과 작은 값, 절댓값 구하기
        // 최댓값
        static int MaxValue(int number1, int number2)
        {
            int maxValue = 0;

            // 최댓값
            if (number2 <= number1)
            {
                maxValue = number1;
                return maxValue;
            } 
            else
            {
                maxValue = number2;
                return maxValue;
            }
 
        }

        // 최솟값
        static int MinValue(int number1, int number2)
        {
            
            int minValue = 0;

            // 최솟값
            if (number2 <= number1)
            {
                minValue = number2;
                return minValue;
            }
            else
            {
                minValue = number1;
                return minValue;
            }

        }

        //절댓값
        static int AbsoluteValue(int number1)
        {
            int absoluteValue1 = 0;



            if (0 < number1)
            {
                absoluteValue1 = number1;
            }
            else
            {
                absoluteValue1 = (-1 * number1);
            }

            return absoluteValue1;

        }   


        static void FunctionOverloading()
        {
            /**
             * 함수 오버로드 : 다중 정의
             * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의할 수 있는데, 이를 함수 오버로드라고 한다.
             * 우리말로는 여러 번 정의한다는 의미이다.
             * 
             */


        }

        //! 숫자를 받아서 출력하는 함수
        /**
         * @param number int type number for print
         */
        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32 : {number}");
            Console.WriteLine($"4바이트 정수 : {number}");

        }

        //! 숫자를 받아서 출력하는 함수
        /**
         * @param number long type number for print
         */
        static void GetNumber(long number)
        {
            Console.WriteLine($"Int64 : {number}");
            Console.WriteLine($"8바이트 정수 : {number}");

        }


        static void Multi()
        {
            Console.WriteLine("안녕하세요.");
        }

        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", message);
            }
        }


        static void RecursionFunction()
        {
            /**
             * 재귀 함수
             * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion) 또는 재귀 함수라고 한다.
             */
        }

        static int Factorial(int n)
        {
            // 여기서 탈출할 것임.
            if(n == 0 || n == 1)
            {
                return 1;
            }

            Console.WriteLine("n의 값은 : {0}", n);
            
            return n * Factorial(n - 1); // 여기서 재귀 호출했음.
        }

        static void FunctionScope()
        {
            /**
             * 함수 범위: 전역 변수와 지역 변수
             * 
             * 클래스와 같은 레벨에서 선언된 변수를 전역 변수(Global Variable) 또는 필드(Field)라고 하며,
             * 함수 레벨에서 선언된 변수를 지역 변수(Local Variable)라고 한다. 
             * 이때 동일한 이름으로 변수를 전역 변수와 함수 내의 지역 변수로 선언할 수 있다.
             * 함수 내에서는 함수 범위에 있는 지역 변수를 사용하고, 함수 범위 내에 선언된 변수가 없으면
             * 전역 변수 내에 선언된 변수를 사용한다.
             * 
             * 단, c#에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 언더스코어(_) 또는 m_ 접두사를
             * 붙이는 경향이 있다.
             */

            // 함수 내의 변수가 지역 변수(Local Variable)
        }


        static void ArrowFunction()
        {
            /**
             * 화살표 함수
             * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용하여 메서드 코드를 줄일 수 있다.
             * 이를 화살표 함수(Arrow Function)라고 한다.
             * 프로그래밍에서 화살표 함수 또는 화살표 메서드는 람다 식(Lambda expression)의 또다른 이름이다.
             * 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다.
             * 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있다.
             * 하지만 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다.
             */
        }

    } // class
}