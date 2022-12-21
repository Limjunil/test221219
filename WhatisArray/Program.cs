// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용하겠다.
using System;

// 내 프로그램 이름이다. 내가 정했다.
namespace WhatisArray
{
    
    // 클래스 라는 것인데, c#에서는 모든 요소들이 클래스 안에 있어야 함.
    internal class Program
    {
        // 무조건 1개는 있어야 함. -> c# 콘솔(검은 창)을 사용할 때
        static void Main(string[] args)
        {
            //프로그램은 여기서부터 읽기 시작한다.
            //Console.WriteLine("Hello, World!");

            //3의 배수를 제외한 수
            //int sumOfNumber = 0;
            //int variable_ = 100;

            //횟수가 정해진 건 for, 횟수를 모르는 건 while



            //for (int variable_ = 1; variable_ <= 100; variable_++)
            //        {
            //            bool isRealmultipleOfThree = (variable_ % 3 == 0);

            //            Console.WriteLine("{0} -> isRealmultipleOfThree : {1}",
            //                variable_, isRealmultipleOfThree);

            //            if (isRealmultipleOfThree == false)
            //            {
            //                3의 배수가 아닌 건 다 여기로 오겠네?
            //                여기서 값을 계속 더해주면 되겠네?
            //        sumOfNumber += variable_;
            //                Console.WriteLine("잘 더해지고 있나? : {0}",
            //                    sumOfNumber);

            //            }
            //            else
            //            {
            //                여기로 오겠네?
            //     그러면 여기서 코딩해야지
            //            }
            //            Console.WriteLine();


            //        } // loop : 100번 도는 루프
            //1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기

            // 루프가 끝나면 여기로 오니까 다 끝날 때 까지는 더해서 마지막 값을 눈으로
            // 보고 싶으니까.
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("================================");
            //Console.WriteLine("sumOfNumber : {0}", sumOfNumber);
            //Console.WriteLine("================================");

            //if (variable_ % 3 == 0)


            //    if (/* 여기서 조건문 검사함*/)
            //    {
            //        // 저 조건문이 참(True)이면 여기로 옴.
            //        // 조건문은 여기서부터 읽기 시작한다.
            //        // 조건문은 여기서 끝난다.


            //    }
            //    else
            //    {
            //        // 저 조건문이 거짓(False)이면 여기로 옴.
            //        // 조건문은 여기서부터 읽기 시작한다.
            //        // 조건문은 여기서 끝난다.
            //    }

            //어떤변수 = "여자"
            //string personalGender = "여자";

            //너 남자니? 물어보는 조건문
            //if (personalGender.Equals("남자")) // 조건문 A
            //{
            //    조건문 A가 참(True)이면 여기로 옴.

            //     조건문 A가 여기서부터 읽기 시작한다.

            //    Console.WriteLine("아 남자구나 ok");

            //    조건문 A는 여기서 끝난다.
            //}

            //너 여자니? 물어보는 조건문
            //else if (personalGender == "여자") // 조건문 B
            //{
            //    조건문 B가 참(True)이면 여기로 옴.

            //     조건문 B가 여기서부터 읽기 시작한다.

            //    Console.WriteLine("아 여자구나 ok");

            //    조건문 B는 여기서 끝난다.
            //}
            //else
            //{
            //    저 조건문이 거짓(False)이면 여기로 옴.

            //     조건문은 여기서부터 읽기 시작한다.

            //    Console.WriteLine("아 남자도 여자도 아닌가 보구나");

            //    조건문은 여기서 끝난다.
            //}



            //조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.

            // 콘솔 정리를 위해 Console.WriteLine(); 50번 반복한다.
            //for (int index = 1; index <= 50; index++)
            //{
            //    Console.WriteLine();
            //} // loop : 50번 도는 루프
            //Console.WriteLine("정말로 콘솔이 정리가 되나?");



            //프로그램 사용자로부터 양의 정수를 하나 입력 받아서
            //그 수 만큼 "Hello world!"를 출력하는 프로그램 작성
            //int someNumber = 100;
            //bool isPositiveInteger = (0 < someNumber);

            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력 받는다.
            // * 그리고 그 값을 계속해서 더해 나간다.
            // * 이러한 작업은 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며,
            // * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            // */

            //0이면 true 아니면 false 이 나옴
            //bool inNumberZero = (someNumber == 0);

            // 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되,
            // 역순으로 출력하는 프로그램 작성.

            //int userInputNumber = 3;
            //for (int index = 9; 1 <= index; index--)
            //{
            //    Console.WriteLine("{0} X {1} = {2}", userInputNumber, index,
            //        userInputNumber * index);

            //} // loop : 9번 도는 루프


            ///**
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성
            // * 다음 두 가지의 조건을 만족할 것.
            // * - 먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다.
            // * 그리고 그 수 만큼 정수를 입력 받는다.
            // * - 평균 값은 소수점 이하까지 계산해서 출력한다.
            // */

            ///**
            // * LAB1 비밀코드 맞추기
            // * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            // * 비밀 코드는 a~z 사이의 문자
            // * 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지 알려준다.
            // * (즉, 사용자에게 힌트를 준다)
            // */

            //// a <= 유저가_입력한_알파벳 && 유저가_입력한_알파벳 <= z : 조건
            //char scretCode = 'y';
            //char userInputAlphabet = 'c';
            //bool inSmallAlphabet =
            //    ( 'a' <= userInputAlphabet && userInputAlphabet <= 'z');

            //// 앞에 있는지, 뒤에 있는지 알려줌
            //bool isAlphabetfore = ( userInputAlphabet <= scretCode );
            //bool isAlphabetBack = ( scretCode <= userInputAlphabet );

            //if (inSmallAlphabet)
            //{
            //    /* Do Nothing */
            //}
            //else {
            //    Console.WriteLine("{0} {1}",
            //        "[System] 당신의 입력은 처리할 수 없습니다.",
            //        "알파벳 소문자만을 입력해주세요.");
            //}


            //if (isAlphabetfore)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");
            //}
            //else { /* Do Nothing */ }

            //if(isAlphabetBack)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");

            //}
            //else { /* Do Nothing */ }



            ///**
            // * 1~100 숫자 중에서 3의 배수이면 4의 배수인 정수 합 구하기
            // * 
            // */

            //int sumNumber = 0;
            //int someNumber = 100;
            //bool isMultipleOfThree = (someNumber % 3 == 0);
            //bool isMultipleOfFour = (someNumber % 4 == 0);

            //bool isSatisfyCondition = isMultipleOfThree && isMultipleOfFour;

            //if (isSatisfyCondition)
            //{
            //    sumNumber += someNumber;
            //} // if : 3의 배수이면서 4의 배수인 값


            /**
             * 별을 100번 찍는 법
             */
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");

            //for(int index = 1; index <= 100; index++)
            //{
            //    Console.Write("{0} ", "*");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //for (int index = 1; index <= 10; index++)
            //{
            //    for(int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.Write("{0} ", "*");

            //    } // loop : 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //    Console.WriteLine();
            //} // loop : 이건 10번을 도는 루프

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int hundreaCount = 0;

            //// 3중 for문
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for (int index3 = 1; index3 <= 10; index3++)
            //        {
            //            hundreaCount++;
            //            if (100 < hundreaCount) { break; }
            //            else { /* Do Nothing */ }

            //            // 여기가 별을 찍는 지점
            //            Console.Write("{0} ", "*");

            //            // 여기서 10번마다 한 줄을 띄어 줄거임
            //            if (hundreaCount % 10 == 0) {
            //                Console.WriteLine();
            //            } // if : 별을 10번 찍을 때마다 한 줄 띄어주는 중


            //        } // loop : 이건 1번 루프가 10번 도는 동안 2번 루프가 10번을 돌고
            //        // 그 동안 다시 10번 도는 루프

            //    } // loop : 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프

            //} // loop : 이건 10번을 도는 루프


            // 프로그램은 여기서 끝난다.


            /**
             * 유저 입력을 받아서 (1~20 줄 이내로 입력 받음)
             * 유저 입력은 줄, 단의 개수 임.
             * 등차 수열로 한 단이 내려 갈 때마다 별 1개씩 추가로 증가하는 프로그램 작성
             * ex) user input : 5
             * *
             * **
             * ***
             * ****
             * *****
             */

            //// isLinecount : 사용자가 선언한 줄 수를 저장할 변수 선언
            //int isLinecount = 0;


            //// 유저 입력을 받아서 isLinecount에 int 형식으로 값을 저장
            //Console.Write("User Input : ");
            //isLinecount = Convert.ToInt32(Console.ReadLine());

            ////iscount : loop 반복 횟수에 대한 변수 선언
            ////int iscount = 1 : iscount 변수에 1 값을 저장합니다.
            ////iscount 값이 isLinecount 보다 작거나 같을 때까지 반복합니다.
            ////iscount++ : loop 할 때마다 변수 값에 1을 더합니다.
            //for (int iscount = 1; iscount <= isLinecount; iscount++)
            //{
            //
            //    
            //    for (int iscount2 = 1; iscount2 <= iscount; iscount2++)
            //    {
            //        Console.Write("{0}", "*");

            //    } // loop : iscount 값만큼 * 출력
            //    Console.WriteLine();

            //} // loop : 입력 받은 줄 수 만큼 반복

            //Console.WriteLine("===========================================");
            //Console.WriteLine("===========================================");


            /**
             * 유저 입력을 받아서 (1~20 줄 이내로 입력 받음)
             * 유저 입력은 줄, 단의 개수 임.
             * 다이아몬드 표현
             * ex) user input : 5
             *   *
             *  * *
             * * * *
             *  * *
             *   *
             */

            ////줄 수을 저장할 변수를 선언한다.
            //int isdiaiLine = 0;

            //// 유저 입력을 받아 선언한 isdiaiLine 변수에 값을 저장한다.
            //Console.Write("다이아 모양의 줄 수를 입력하시오 : ");
            //isdiaiLine = Convert.ToInt32(Console.ReadLine());

            //// 입력 받은 값이 짝수 인지, 홀수 인지 구분하기 위해서 나머지 값을 살펴본다.
            //// 나머지가 0이면 참이니 짝수, 나머지가 0 이외라면 거짓이니 홀수
            //bool isEvennumber = (isdiaiLine % 2 == 0);

            //// 양수일때 반으로 나눠진 값
            //int isdiaiLinehalf = (isdiaiLine / 2);
            //// 홀수 일때 반으로 나눈 나머지 값
            //int isRemainderval = (isdiaiLine / 2) + 1;

            //// isEvennumber가 참이면 실행하고 거짓이면 else로 넘어간다.
            //// 여기서 참은 짝수쪽이고, else는 홀수쪽 실행이다.
            //if (isEvennumber)
            //{
            //    // loopDiaiCount는 짝수 쪽의 반복 횟수 변수1이다.
            //    // 미리 선언한 isdiaiLinehalf를 이용하여 절반만 반복하도록 한다.
            //    // loop 할 때마다 loopDiaiCount++로 인해 변수 값에 1 더합니다.
            //    for (int loopDiaiCount = 1; loopDiaiCount <= isdiaiLinehalf; loopDiaiCount++)
            //    {
            //        // isSpacecount1는 앞 공백을 만들기 위해서 선언하며, 그 값은 (isdiaiLinehalf - loopDiaiCount)이다.
            //        // isSpacecount1가 0보다 클 때만 실행된다.
            //        // loop 할 때마다 isSpacecount1--로 인해 변수 값에 1을 뺍니다.
            //        for (int isSpacecount1 = (isdiaiLinehalf - loopDiaiCount); isSpacecount1 > 0; isSpacecount1--)
            //        {
            //            // 공백 생성을 위해 " "를 출력한다.
            //            Console.Write(" ");
            //        }

            //        // loop2Diaistar는 별을 출력하는 쪽의 반복 횟수 변수이다.
            //        // loop2Diaistar가 현재 밖에서 돌고 있는 loopDiaiCount 값보다 작거나 같을 때만 실행한다.
            //        // loop 할 때마다 loop2Diaistar++로 인해 변수 값에 1을 더합니다.
            //        for (int loop2Diaistar = 1; loop2Diaistar <= loopDiaiCount; loop2Diaistar++)
            //        {
            //            // 문자열 보간법을 이용해서 "*"를 출력합니다.
            //            Console.Write("{0} ", "*");

            //        }
            //        // 한 줄 내립니다.
            //        Console.WriteLine();

            //    }// loop : 입력 받은 수 만큼 반복


            //    // loopDiaiCount2는 짝수 쪽의 반복 횟수 변수2이다.
            //    // loopDiaiCount2 값에 미리 선언한 isdiaiLinehalf의 값을 받아와서 절반만 반복하도록 한다.
            //    // loop 할 때마다 loopDiaiCount2--로 인해 변수 값에 1을 뺍니다.
            //    for (int loopDiaiCount2 = isdiaiLinehalf; loopDiaiCount2 > 0; loopDiaiCount2--)
            //    {
            //        // isSpacecount2는 앞 공백을 만들기 위해서 선언하며, 그 값은 (isdiaiLinehalf - loopDiaiCount2)이다.
            //        // isSpacecount1가 0보다 클 때만 실행된다.
            //        // loop 할 때마다 isSpacecount1--로 인해 변수 값에 1을 뺍니다.
            //        for (int isSpacecount2 = (isdiaiLinehalf - loopDiaiCount2); isSpacecount2 > 0; isSpacecount2--)
            //        {
            //            // 공백 생성을 위해 " "를 출력한다.
            //            Console.Write(" ");
            //        }

            //        for (int loop4DiaiCount = 1; loop4DiaiCount <= loopDiaiCount2; loop4DiaiCount++)
            //        {
            //            Console.Write("{0} ", "*");

            //        }
            //        Console.WriteLine();

            //    }// loop : 입력 받은 수 만큼 반복
            //    Console.WriteLine();

            //} // 입력 받은 값이 짝수면 실행

            //else
            //{
            //    for (int oddCount1 = 1; oddCount1 <= isRemainderval; oddCount1++)
            //    {
            //        for (int isaddSpacecount1 = (isRemainderval - oddCount1); isaddSpacecount1 > 0; isaddSpacecount1--)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int loopOddDivai1 = 1; loopOddDivai1 <= oddCount1; loopOddDivai1++)
            //        {
            //            Console.Write("{0} ", "*");

            //        }
            //        Console.WriteLine();



            //    }

            //    for (int oddCount2 = isRemainderval - 1; oddCount2 > 0; oddCount2--)
            //    {
            //        // 
            //        //
            //        // 
            //        for (int isaddSpacecount2 = (isRemainderval - oddCount2); isaddSpacecount2 > 0; isaddSpacecount2--)
            //        {
            //            // 공백 생성을 위해 " "를 출력한다.
            //            Console.Write(" ");
            //        }


            //        for (int loopOddDivai2 = 1; loopOddDivai2 <= oddCount2; loopOddDivai2++)
            //        {
            //            Console.Write("{0} ", "*");

            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();


            //} // 입력 받은 값이 홀수면 실행


            //Console.WriteLine("===========================================");
            //Console.WriteLine("===========================================");


            /**
             * 숫자야구
             * - 20번 내로 스트라이크 못하면 "승리 못함" 하고 종료
             * - 20번 내로 스트라이크 하면 "승리" 하고 종료
             * 3/4자리 숫자를 임의로 정한뒤 서로의 3/4자리 숫자를 불러서
             * 결과 확인
             * 사용되는 숫자는 0~9 숫자(서로 달라야 함) 경우에 따라 0은 사용하지 않기도 한다.
             * 숫자는 맞지만 위치가 틀렸을 때는 볼
             * 숫자 위치가 전부 맞으면 스트라이크
             * 숫자와 위치가 전부 틀리면 아웃
             * 무엇이 볼이고 스트라이크인지 알려주지 않음
             * 두 숫자가 중복되지 않게 
             */

            //// 컴퓨터의 3개의 난수 선언
            //Random BasesBall = new Random();
            //int BasesBallval1 = BasesBall.Next(0, 9 + 1); // BasesBallval1 : 컴퓨터가 정할 0~9 사이의 난수 값 저장
            //int BasesBallval2 = BasesBall.Next(0, 9 + 1); // BasesBallval3 : 컴퓨터가 정할 0~9 사이의 난수 값 저장
            //int BasesBallval3 = BasesBall.Next(0, 9 + 1); // BasesBallval3 : 컴퓨터가 정할 0~9 사이의 난수 값 저장

            //// basecount : 야구 loop에 대한 횟수 저장할 변수
            //int basecount = 0;


            //while (true) // 무한 반복
            //{
            //    // if : BasesBallval1 값이 BasesBallval2 와 같지 않으면 실행합니다.
            //    if (BasesBallval1 != BasesBallval2)
            //    {
            //        // if : BasesBallval1 값이 BasesBallval3 과 같지 않으면 실행합니다.
            //        if (BasesBallval1 != BasesBallval3)
            //        {
            //            // if : BasesBallval2 값이 BasesBallval3 과 같지 않으면 실행합니다.
            //            if (BasesBallval2 != BasesBallval3)
            //            {
            //                break; // 반복문을 탈출합니다.
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 중복된 값이 나왔으니 BasesBallval3에 0~9 사이의 새로운 난수 값 저장
            //                BasesBallval3 = BasesBall.Next(0, 9 + 1); 
            //            }
            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // 중복된 값이 나왔으니 BasesBallval3에 0~9 사이의 새로운 난수 값 저장
            //            BasesBallval3 = BasesBall.Next(0, 9 + 1);
            //        }
            //    }
            //    // else : if 조건에 맞지 않다면 실행합니다.
            //    else
            //    {
            //        // 중복된 값이 나왔으니 BasesBallval2에 0~9 사이의 새로운 난수 값 저장
            //        BasesBallval2 = BasesBall.Next(0, 9 + 1);
            //    }
            //} // loop : 서로 다른 값이 나올 때까지 반복합니다.

            //// 컴퓨터가 정한 난수의 값을 출력합니다.
            //Console.WriteLine("{0} {1} {2}", BasesBallval1, BasesBallval2, BasesBallval3);


            //// basecount가 9보다 커질 때까지 반복합니다.
            //while (basecount <= 9)
            //{
            //    // Ballscount : 볼 카운트를 저장할 변수를 선언합니다.
            //    // loop 할 때마다 0으로 초기화하도록 0을 선언합니다.
            //    int Ballscount = 0;
            //    // strikecount : 스트라이크 카운트를 저장할 변수를 선언합니다.
            //    // loop 할 때마다 0으로 초기화하도록 0을 선언합니다.
            //    int strikecount = 0;


            //    // 사용자의 입력을 받아 userVal1에 int 형식으로 저장합니다.
            //    Console.Write("첫 번째 숫자를 입력하시오 : ");
            //    int userVal1 = Convert.ToInt32(Console.ReadLine());

            //    // 사용자의 입력을 받아 userVal2에 int 형식으로 저장합니다.
            //    Console.Write("두 번째 숫자를 입력하시오 : ");
            //    int userVal2 = Convert.ToInt32(Console.ReadLine());

            //    // 사용자의 입력을 받아 userVal3에 int 형식으로 저장합니다.
            //    Console.Write("세 번째 숫자를 입력하시오 : ");
            //    int userVal3 = Convert.ToInt32(Console.ReadLine());


            //    // if : userVal1 값이 userVal2와 같지 않으면 실행합니다.
            //    if (userVal1 != userVal2)
            //    {
            //        // if : userVal1 값이 userVal3과 같지 않으면 실행합니다.
            //        if (userVal1 != userVal3)
            //        {
            //            // if : userVal2 값이 userVal3과 같지 않으면 실행합니다.
            //            if (userVal2 != userVal3)
            //            {
            //                /* Do Nothing */
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 중복된 값이 나왔으니 새로운 숫자를 입력받습니다.
            //                Console.WriteLine("중복된 숫자입니다.");
            //                Console.Write("다시 세 번째 숫자를 입력하시오 : ");
            //                // userVal3에 입력받은 값을 int 형식으로 저장합니다.
            //                userVal3 = Convert.ToInt32(Console.ReadLine());
            //            }
            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // 중복된 값이 나왔으니 새로운 숫자를 입력받습니다.
            //            Console.WriteLine("중복된 숫자입니다.");
            //            // userVal3에 입력받은 값을 int 형식으로 저장합니다.
            //            Console.Write("다시 세 번째 숫자를 입력하시오 : ");
            //            userVal3 = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    // else : if 조건에 맞지 않다면 실행합니다.
            //    else
            //    {
            //        // 중복된 값이 나왔으니 새로운 숫자를 입력받습니다.
            //        Console.WriteLine("중복된 숫자입니다.");
            //        Console.Write("다시 두 번째 숫자를 입력하시오 : ");
            //        // userVal2에 입력받은 값을 int 형식으로 저장합니다.
            //        userVal2 = Convert.ToInt32(Console.ReadLine());
            //    }

            //    // if : userVal1 값과 BasesBallval1 값이 같다면 실행합니다.
            //    if (userVal1 == BasesBallval1)
            //    {
            //        // strikecount 변수에 값을 1 더합니다.
            //        strikecount++;

            //        // if : userVal2 값과 BasesBallval2 값이 같다면 실행합니다.
            //        if (userVal2 == BasesBallval2)
            //        {
            //            // strikecount 변수에 값을 1 더합니다.
            //            strikecount++;

            //            // if : userVal2 값과 BasesBallval2 값이 같다면 실행합니다.
            //            if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //                // "스트라이크에 성공했습니다. 승리입니다."를 출력합니다.
            //                Console.WriteLine("스트라이크에 성공했습니다. 승리입니다.");
            //                break;  // 현재 반복문을 탈출합니다.
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }

            //        } 
            //        else if (userVal2 == BasesBallval3)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;
            //            // if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            if (userVal3 == BasesBallval2)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            if (userVal3 == BasesBallval2)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval3과 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        } 
            //    }
            //    // else if : userVal1 값이 BasesBallval2와 같다면 실행합니다.
            //    else if (userVal1 == BasesBallval2)
            //    {
            //        // Ballscount 변수에 값을 1 더합니다.
            //        Ballscount++;

            //        // if : userVal2 값이 BasesBallval1과 같다면 실행합니다.
            //        if (userVal2 == BasesBallval1)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;

            //            // if : userVal3 값이 BasesBallval3과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else if : userVal2 값이 BasesBallval3과 같다면 실행합니다.
            //        else if (userVal2 == BasesBallval3)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;

            //            // if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //    }
            //    // else if : userVal1 값이 BasesBallval3과 같다면 실행합니다.
            //    else if (userVal1 == BasesBallval3)
            //    {
            //        // Ballscount 변수에 값을 1 더합니다.
            //        Ballscount++;

            //        // if : userVal2 값이 BasesBallval1과 같다면 실행합니다.
            //        if (userVal2 == BasesBallval1)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;

            //            // if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            if (userVal3 == BasesBallval2)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else if : userVal2 값이 BasesBallval2와 같다면 실행합니다.
            //        else if (userVal2 == BasesBallval2)
            //        {
            //            // strikecount 변수에 값을 1 더합니다.
            //            strikecount++;

            //            // if : userVal3 값이 BasesBallval1 과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;

            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //        else if (userVal3 == BasesBallval1)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;
            //            // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //            Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //            Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //        }

            //    }
            //    // else : if 조건에 맞지 않다면 실행합니다.
            //    else
            //    {
            //        // if : userVal2 값이 BasesBallval1과 같다면 실행합니다.
            //        if (userVal2 == BasesBallval1)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;
            //            // if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            if (userVal3 == BasesBallval2)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval3과 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else if : userVal2 값이 BasesBallval2와 같다면 실행합니다.
            //        else if (userVal2 == BasesBallval2)
            //        {
            //            // strikecount 변수에 값을 1 더합니다.
            //            strikecount++;
            //            // if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval3과 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //        }
            //        // else if : userVal2 값이 BasesBallval3과 같다면 실행합니다.
            //        else if (userVal2 == BasesBallval3)
            //        {
            //            // Ballscount 변수에 값을 1 더합니다.
            //            Ballscount++;

            //            // if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval2) {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);

            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }


            //        }
            //        // else : if 조건에 맞지 않다면 실행합니다.
            //        else
            //        {
            //            // if : userVal3 값이 BasesBallval1과 같다면 실행합니다.
            //            if (userVal3 == BasesBallval1)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval2와 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval2)
            //            {
            //                // Ballscount 변수에 값을 1 더합니다.
            //                Ballscount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else if : userVal3 값이 BasesBallval3과 같다면 실행합니다.
            //            else if (userVal3 == BasesBallval3)
            //            {
            //                // strikecount 변수에 값을 1 더합니다.
            //                strikecount++;
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3, strikecount, Ballscount 값을 문자열 보간법으로 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} {4}S {5}B", basecount, userVal1, userVal2, userVal3,
            //                    strikecount, Ballscount);
            //            }
            //            // else : if 조건에 맞지 않다면 실행합니다.
            //            else
            //            {
            //                // 지금까지 입력된 basecount, userVal1, userVal2, userVal3 값과 "아웃"을 출력합니다.
            //                Console.WriteLine("{0} | {1} {2} {3} 아웃", basecount, userVal1, userVal2, userVal3);
            //            }
            //        }


            //    }

            //    // basecount 값에 1을 더합니다.
            //    basecount++;
            //}

            //// "끝났습니다."를 출력합니다.
            //Console.WriteLine("끝났습니다.");






            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(collection) 또는
             * 컨테이너(Container)라고 한다.
             * C#에서 다루는 컬렉션은 배열(array), 리스트(list), 사전(dictionary) 등이 있다. 
             * 
             * 배열
             * 배열은(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다.
             * 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근된다. 
             * 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스를
             *    사용하여 접근할 수 있다.
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고,
             *    성능이 향상된다.
             *    
             * 배열에는 세 가지 종류가 있다.
             * 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열 : 첨자 2개 이상을 사용하는 배열(2차원, 3차원, ... n차원 배열)
             * 가변(Jagged) 배열 : '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             */

            // 배열의 선언과 초기화
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //numbers.Length 배열 길이

            // 메모리 여기저기에 저장되서 난잡함
            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            // 배열은 메모리에 낭비를 줄일 수 있다.
            Console.WriteLine(numbers);


            //for(int index = 0; index < numbers.Length; index++)
            //{
            //    Console.Write("{0} ", numbers[index]);
            //}

            //// numbers에 있는 걸 element에 하나 하나 저장하겠다.
            //foreach (int element in numbers) 
            //{
            //    Console.Write("{0} ", element);
            //}

        }
    }
}