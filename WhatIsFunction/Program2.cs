using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Program2
    {
        
        public static void Main()
        {
            //Hi();
            //Multiply(5, 4);


            /**
             *  예제 1
             *  - 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x, y, z)를 정의할 것.
             */

            //int UserinputNum1 = 0;
            //int UserinputNum2 = 0;
            //int UserinputNum3 = 0;

            //Console.WriteLine("3개의 정수를 입력하시오.");
            //Console.Write("첫 번째 정수를 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out UserinputNum1);

            //Console.Write("두 번째 정수를 입력하시오 : ");

            //int.TryParse(Console.ReadLine(), out UserinputNum2);

            //Console.Write("세 번째 정수를 입력하시오 : ");

            //int.TryParse(Console.ReadLine(), out UserinputNum3);


            //Maximum(UserinputNum1, UserinputNum2, UserinputNum3);

            //Console.WriteLine();

            /** 
             *  예제 2
             *  - 화면에 "Hello"를 출력하는 SayHello() 함수를 작성
             *  ㄴ int 타입 매개변수 받아서 그 횟수만큼 "hello"를 반복해서 출력
             */

            //int HelloCount = 0;
            //Console.Write("Hello를 몇 번 출력할지 입력하시오. : ");
            //int.TryParse(Console.ReadLine(), out HelloCount);

            //SayHello(HelloCount);

            //Console.WriteLine();

            /** 
             *  예제 3
             *  - 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것.
             *  ㄴ 매개변수는 2개 타입은 double형
             *  ㄴ 리턴 타입도 double 형
             */

            //double UserInputTri1 = 0;
            //double UserInputTri2 = 0;


            //Console.Write("직각 삼각형의 첫 번째 변 길이를 입력하시오 : ");
            //double.TryParse(Console.ReadLine(), out UserInputTri1);

            //Console.Write("직각 삼각형의 두 번째 변 길이를 입력하시오 : ");
            //double.TryParse(Console.ReadLine(), out UserInputTri2);

            //double triangleVal = Hypot(UserInputTri1, UserInputTri2);

            //Console.WriteLine("직각 삼각형의 빗변의 길이는 {0:F4} 입니다.", triangleVal);

            //Console.WriteLine();

            /** 
             *  예제 4
             *  - 주어진 숫자가 소수인지 여부를 찾는 함수 Prime() 작성.
             *  ㄴ 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
             */

            //Console.WriteLine("2~100 사이의 소수 값들의 출력입니다.");
            //Prime();

            //Console.WriteLine();

            /** 
             *  예제 5
             *  - 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램 작성(함수 사용)
             *  ㄴ 전화번호를 입력받는다. -> 소괄호를 삭제한 형태로 출력한다.
             *  ㄴ quit 입력하면 프로그램을 종료한다.
             *  ㄴ 프로그램 종료 전까지 전화번호를 입력 받는다.
             */

            //string PhoneNumberVal = string.Empty;

            //Console.WriteLine("전화번호를 입력해주세요.");
            //Console.WriteLine("quit 를 입력하면 끝납니다.");
            //Console.Write("ex) (010)-4544-5454 : ");
            //PhoneNumberVal = Convert.ToString(Console.ReadLine());

            //Console.WriteLine();
            //PhoneNumber(PhoneNumberVal);



            // =========================================


            string NameVal = string.Empty;
            Console.Write("문자열을 입력하시오. : ");
            NameVal = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine();
            Console.WriteLine("입력한 문자열이 반대가 되었습니다.");
            ReversString(NameVal);

        } // Main()

        // 화살표 함수 사용 예시
        //static void Hi() => Console.WriteLine("안녕하세요.");
        //static void Multiply(int a, int b) => Console.WriteLine(a * b);


        //! 최대값을 찾는 함수 
        static void Maximum(int x, int y, int z)
        {
            int MaxValue = int.MinValue;

            if(MaxValue < x)
            {
                MaxValue = x;
                if (MaxValue < y)
                {
                    MaxValue = y;

                    if (MaxValue < z)
                    {
                        MaxValue = z;

                    }
                    else { /* Do Nothing */}
                }
                else if (MaxValue < z)
                {
                    MaxValue = z;
                }
                else { /* Do Nothing */ }
            }
            else if (MaxValue < y)
            {
                MaxValue = y;

                if (MaxValue < z)
                {
                    MaxValue = z;

                }
                else { /* Do Nothing */}
            }
            else
            {
                MaxValue= z;
            }


            Console.WriteLine("3개의 정수 중 최대값은 {0} 입니다.", MaxValue);
        }

        //! int 값 받아서 그 값만큼 hello 출력
        static void SayHello(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        //! 직각삼각형 빗변 길이를 구하는 함수
        static double Hypot(double Triangle1, double Triangle2)
        {
            double TriangleVal = default;

            TriangleVal = (Triangle1 * Triangle1) + (Triangle2 * Triangle2);

            // 제곱근 구합니다.
            TriangleVal = Math.Sqrt(TriangleVal);

            return TriangleVal;
        }


        static void Prime() {
            

            for (int i = 2; i < 100 + 1; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    if (i == 2 || i == 3 || i == 5 || i == 7)
                    {
                        Console.Write("{0} ", i);
                        
                    }
                    else { /* Do Nothing */ }

                    /* Do Nothing */
                }
                else
                {
                    Console.Write("{0} ", i);
                    
                }
                                
            }
            Console.WriteLine();
        }


        static void PhoneNumber(string phoneNumber)
        {
            if(phoneNumber == "quit")
            {
                Console.WriteLine("프로그램을 종료합니다.");
                return;
            }

            // 구분 문자를 정리한 배열
            char[] deleteStr = { '(', ')' };
            // 구분 문자에 해당하는 단어는 빼고 배열에 넣습니다.
            string[] phoneNumberSplit = phoneNumber.Split(deleteStr);
            

            // 배열에 있는 값을 다른 변수에 저장하고 전부 출력합니다.
            foreach(string phoneNumVal in phoneNumberSplit)
            {
                Console.Write(phoneNumVal);
            }
        }


        static void ReversString(string ValName)
        {
            char[] ValNameArray = new char[ValName.Length];

            int loopCount = ValName.Length;

            foreach(char Revesnames in ValName)
            {
                ValNameArray[loopCount - 1] = Revesnames;
                loopCount--;
            }

            foreach(char names in ValNameArray)
            {
                Console.Write(names);
            }
        }

    } // class


}
