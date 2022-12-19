using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatisOperator
{
    internal class Program2
    {
        
        static void Main(string[] args)
        {
            /**
             * 1 최대한도의 사탕사기
             * 현재 1000원이 있고 사탕의 가격이 300원일 때, 최대 살 수 있는 사탕의 개수와 나머지 돈은 얼마인지 출력하는 프로그램
             * ex) 현재 가지고 있는 돈 : 1000(유저가 입력)
             * 캔디의 가격 : 300(캔디의 가격은 상수)
             * 최대로 살 수 있는 캔디의 개수 = 3
             * 캔디 구입 후 남은 돈 = 100
             */

            //Console.Write("현재 가지고 있는 돈 : ");
            //int money = Convert.ToInt32(Console.ReadLine());

            //const int CANDY = 300;

            //Console.WriteLine("캔디의 가격 : {0}", CANDY);

            //Console.WriteLine("최대로 살 수 있는 캔디의 개수 = {0}", (money/CANDY));
            //Console.WriteLine("캔디 구입 후 남은 돈 = {0}", (money % CANDY));


            //Console.WriteLine();

            ///**
            // * 2. 화씨 온도를 섭씨 온도로 바꾸기
            // * 우리나라는 섭씨 온도를 사용하지만, 미국에서는 화씨 온도를 사용한다.
            // * 화씨 온도를 섭씨 온도로 바꾸는 프로그램을 작성
            // * ex) 화씨 온도 60도는 섭씨 온도 ?? 입니다.
            // */

            //float celc = 0.0f;
            //float fahre = 0.0f;


            //Console.Write("현재 화씨 온도 : ");
            //float.TryParse(Console.ReadLine(), out fahre);

            //celc = (float)((fahre - 32.0f) / 1.8f);

            //Console.WriteLine("화씨 온도 60도는 섭씨 온도 {0} 입니다.", celc);

            //Console.WriteLine();


            //// 교수님이 하신 문제풀이
            
            //const string desc = "섭씨 온도 {0}도는 화씨온도 {1}도 입니다.";
            //float fremp = 0.0f;
            //Console.Write("화씨 온도를 입력하시오 : ");
            //float.TryParse(Console.ReadLine(), out fremp);
            //float ctemp = (5.0f / 9.0f * (fremp - 32.0f));
            //Console.WriteLine(desc, ctemp, fremp);

            //Console.WriteLine();


            ///**
            // * 3. 주사위 게임
            // * 2개의 주사위를 던져 주사위의 합을 표시하는 프로그램 작성, 주사위를 던지면 랜덤한 수가 나와야 한다.
            // * ex)  첫 번째 주사위 (0)
            // *      두번째 주사위 (0)
            // *      두 주사위 합 (0)
            // */

            //Random dice1 = new Random();
            //int val1 = dice1.Next(1, 6 + 1 );

            //Random dice2 = new Random();
            //int val2 = dice2.Next(1, 6 + 1 );

            //Console.WriteLine("첫 번째 주사위 ({0})", val1);
            //Console.WriteLine("두 번째 주사위 ({0})", val2);

            //Console.WriteLine("두 주사위 합 ({0})", val1 + val2);


            //Console.WriteLine();

            ////교수님이 하신 문제 풀이
            //Random dice3 = new Random();
            //Random dice4 = new Random();

            //int dice3Value = dice3.Next(1, 6 + 1 );
            //int dice4Value = dice4.Next(1, 6 + 1 );

            //Console.WriteLine("주사위의 값 : {0}, {1}", dice3Value, dice4Value);

            //Console.WriteLine("두 주사위 합 : {0}", dice3Value + dice4Value);

            //Console.WriteLine();


            /**
             * 제어문 소개
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문),
             * 반복 구조(반복문)가 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로
             * 실행 후 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             * 하기도 한다.
             * 
             * 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
             */

            /**
             * if / else 문
             * 프로그램 흐름을 여러 가지 갈래로 가지치기(Breanching)할 수 있는데, 이때 if 문을 사용한다.
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.
             */

            // 02.3 예제 #1
            /**
             * 두 개의 정수 중에서 더 큰 수를 찾는 프로그램
             */

            //int numberX, numberY;
            //Console.Write("x의 값을 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("y의 값을 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out numberY);

            //if (numberY < numberX)
            //{
            //    Console.WriteLine("x가 y보다 큽니다.");

            //}
            //else
            //{
            //    Console.WriteLine("y가 x보다 큽니다.");

            //}


            /**
             * 02.4 중간 점검 1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미만은 mediam,
             * 200ml 이상은 large라고 출력하는 if-else 문을 작성
             */

            //Console.Write("물의 양을 입력하시오 : ");
            //int cupwat = Convert.ToInt32(Console.ReadLine());


            //if (100 > cupwat)
            //{
            //    Console.WriteLine("small");

            //}
            //else if (cupwat >= 200)
            //{
            //    Console.WriteLine("large");
            //} 
            //else
            //{
            //    Console.WriteLine("mediam");
            //}


            /**
             * 3. 비밀코드 맞추기
             * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
             * 비밀 코드는 A~Z 사이의 문자
             * 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다.
             * ex)  컴퓨터의 비밀코드 : h (미리 초기화해서 변수에 가지고 있음)
             *      비밀코드를 맞춰보세요 : {0} -> (유저입력)
             *      c 뒤에 있음
             *      ---프로그램 종료됨---
             *      비밀코드를 맞춰보세요 : h (유저 입력)
             *      정답입니다.
             */


            const char SECRET_CODE = 'h';

            bool charBiggerTest = false;

            Console.Write("비밀코드를 맞춰보세요 : ");
            char pas_s = Convert.ToChar(Console.ReadLine());

            if (pas_s < SECRET_CODE)
            {
                Console.WriteLine("{0}보다 뒤에 있습니다.", pas_s);
                Console.WriteLine("프로그램 종료됨");
            }
            else if (pas_s > SECRET_CODE)
            {
                Console.WriteLine("{0}보다 앞에 있습니다.", pas_s);
                Console.WriteLine("프로그램 종료됨");
            }
            else
            {
                Console.WriteLine("정답입니다.");
            }





            const char SECRET_CODE2 = '%';

            bool isSmallalphabet = false;
            bool isBigalphabet = false;
            bool isalphabet = false;

            isSmallalphabet = ('a' <= SECRET_CODE2 && SECRET_CODE2 <= 'z');
            isBigalphabet = ('A' <= SECRET_CODE2 && SECRET_CODE2 <= 'Z');

            isalphabet = isSmallalphabet || isBigalphabet;
            if (isalphabet)
            {
                Console.WriteLine("{0}은 알파벳이 맞습니다.", SECRET_CODE2);
            } else
            {
                Console.WriteLine("{0}은 알파벳이 아닙니다.", SECRET_CODE2);

            }



            /**
             * 4. 세 개의 정수 중에서 큰 수 찾기
             * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성
             * ex) 3개의 정수를 입력하시오 : 20 10 30
             * 1번 정수를 입력하시오 : 10
             * 2번 정수를 입력하시오 : 20
             * 3번 정수를 입력하시오 : 30
             * =======================
             * 가장 큰 정수는 : 30
             */

            Console.Write("1번 정수를 입력하시오 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2번 정수를 입력하시오 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3번 정수를 입력하시오 : ");

            int number3 = Convert.ToInt32(Console.ReadLine());

            int max = int.MinValue;

            if ( max < number1)
            {
                max = number1;
                if ( max < number2)
                {
                    max = number2;
                    if ( max < number3)
                    {
                        max = number3;
                        Console.WriteLine("가장 큰 정수는 : {0}", max);

                    } 
                    else
                    {
                        Console.WriteLine("가장 큰 정수는 : {0}", max);
                    }
                } 
                else if ( max < number3 )
                {
                    max = number3;
                    Console.WriteLine("가장 큰 정수는 : {0}", max);

                } 
                else
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", max);

                }



            } 
            else if ( max < number2)
            {
                max = number2;
                if ( max < number3)
                {
                    max= number3;

                    Console.WriteLine("가장 큰 정수는 : {0}", max);
                }
            } else if ( max < number3 )
            {
                max= number3;
                Console.WriteLine("가장 큰 정수는 : {0}", max);

            } else
            {
                Console.WriteLine("가장 큰 정수는 : {0}", max);
            }









        }// main
    }
}
