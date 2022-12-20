using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            /**
             * 선택문인 Switch문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리
             * 할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             * 
             */

            //Console.Write("정수 1, 2, 3 중에 하나를 입력하시오 : ");
            //int switchNumber = 0;
            //int.TryParse(Console.ReadLine(), out switchNumber);

            //switch(switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2을(를) 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //} // switch

            /**
             * 02.5 중간점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?
             * 
             * case 절 안을 비워버리면 에러가 나지 않는다.
             */

            //switch (switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        goto case 3; // switch 문에서 goto는 잘 사용되지 않는다.
            //    case 2:

            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //} // switch 

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.Write("1. c \t");
            //Console.Write("2. c++ \t");
            //Console.Write("3. c# \t");
            //Console.Write("4. Java \t");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch(choice)
            //{
            //    case 1:
            //        Console.WriteLine("c 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("c++ 선택"); 
            //        break;
            //    case 3:
            //        Console.WriteLine("c# 선택");
            //        break;
            //    case 4:
            //        Console.WriteLine("Java 선택");
            //        break;
            //    default:
            //        Console.WriteLine("[System] 처리하지 않은 예외 입력입니다.");
            //        break;
            //} // switch


            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string weather = Console.ReadLine();

            //switch(weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("혹시 눈이 내리나요?");
            //        break;
            //} // switch



            // while 문은 조건식이 참일 동안 문장을 반복 실행한다.

            // while 문은 반복문인데 5번 실행할 예정
            //int loopCounter = 0;
            //while(loopCounter < 5)
            //{
            //    Console.WriteLine("{0} 반복문이 정말로 5번만 실행되나?", loopCounter + 1);
            //    loopCounter++;
            //} // loop : 5번만 도는 루프


            //// 10 ~ 1 카운트 후 발사 출력하는 프로그램 작성

            //int loopCounter1 = 10;

            //while (loopCounter1 > 0)
            //{
            //    Console.WriteLine("{0} ", loopCounter1);
            //    loopCounter1 -= 1;
            //} // loop:
            //Console.WriteLine("발사");



            // 예제 #1 - 구구단 출력하는 프로그램 작성. User input 받아서 해당 단을 출력

            //int userGugudan = 0;
            //Console.Write("구구단 중 출력하고 싶은 단 입력 : ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //const int GUGU_LOOP_COUNT = 9;

            //int guguLoopIdx = 1;
            //while(guguLoopIdx <= GUGU_LOOP_COUNT)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx );
            //    guguLoopIdx++;
            //} // loop : 9번을 도는 루프


            /**
             * while 연습
             * 
             * 1. 프로그램 사용자로부터 양의 정수를 하나 입력 받아서, 그 수 만큼 "Hello, world!"를 출력하는 프로그램 작성
             * 
             * ex) User input -> 3
             *      "Hello, world!"
             *      "Hello, world!"
             *      "Hello, world!"
             *      
             */

            //Console.Write("양의 정수 하나를 입력하시오 : ");
            //int hellocount = Convert.ToInt32(Console.ReadLine());


            //while (hellocount > 0) {
            //    Console.WriteLine("Hello, world!");
            //    hellocount--;
            //}


            //Console.WriteLine();


            /**
             * 2. 프로그램 사용자로부터 양의 정수를 하나 입력 받은 다음, 그 수만큼 3의 배수를 출력하는 프로그램 작성
             * ex) User input -> 5
             *       "3, 6, 9, 12, 15"
             */

            //Console.Write("양의 정수 하나를 입력하시오 : ");
            //int threecount = Convert.ToInt32(Console.ReadLine());

            //const int THRE_E = 3;

            //int loopthreecount = 1;

            //while (threecount > 0)
            //{
            //    Console.Write("{0} ", THRE_E * loopthreecount);
            //    loopthreecount++;
            //    threecount--;
            //}

            //Console.WriteLine();


            /**
             * 3. 프로그램 사용자로부터 계속해서 정수를 입력 받는다. 그리고 그 값을 계속해서 더해 나간다.
             * 이러한 작업은 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며, 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료
             * 
             * ex) User input -> 1
             * User input -> 10
             * User input -> 0
             * "모든 정수의 합 : 11"
             * 
             */


            //int Loopvaladd = 0;


            //Console.Write("정수를 입력하시오.(0 입력 시 끝) : ");
            //int Loopval1 = Convert.ToInt32(Console.ReadLine());

            //Loopvaladd += Loopval1;

            //while (Loopval1 > 0)
            //{
            //    Console.Write("정수를 입력하시오.(0 입력 시 끝) : ");
            //    int Loopval = Convert.ToInt32(Console.ReadLine());

            //    Loopvaladd += Loopval;
            //    Loopval1 = Loopval;

            //}

            //Console.WriteLine("모든 정수의 합 : {0}", Loopvaladd);


            /**
             * 4. 프로그램 사용자로부터 입력받은 숫자에 해당하는 구구단을 출력하되, 역순으로 출력하는 프로그램 작성
             * ex) User input -> 2
             *  "18, 16, 14, 12, 10, 8, 6, 4, 2"
             */


            //int userGugudan = 0;

            //Console.Write("구구단 중 출력하고 싶은 단 입력 : ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //int guguLoopIdx = 9;

            //while (guguLoopIdx > 0)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx);
            //    guguLoopIdx--;
            //}


            /**
             * 5. 프로그램 사용자로부터 입력받은 정수의 평균을 출력하는 프로그램을 작성하되, 다음 두 가지의 조건을 만족할 것.
             * - 먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 그리고 그 수만큼 정수를 입력 받는다.
             * - 평균 값은 소수점 이하까지 계산해서 출력한다.
             * 
             * ex) User input(Loop count) -> 3
             * User input -> 10
             * User input -> 10
             * User input -> 10
             * "평균 값 : 10.0"
             * 
             */


            //float avrvalue2 = 0;
            //int loopcount3 = 0;
            //int loopAdd1 = 0;

            //Console.Write("몇 개의 정수를 입력하십니까? : ");
            //int loopcount2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("반복 횟수는 {0} 회입니다.", loopcount2);

            //while (loopcount2 > 0)
            //{
            //    Console.Write("정수를 입력하시오. : ");
            //    int loopValue2 = Convert.ToInt32(Console.ReadLine());

            //    loopAdd1 += loopValue2;
            //    loopcount3++;
            //    loopcount2--;
            //}

            //avrvalue2 = (float)loopAdd1 / loopcount3; 

            //Console.WriteLine("평균 값 : {0}", avrvalue2 );


            ////

            //const float FLOAT_VALUE = 0.1F;
            //float sumFloatValue = 0.0F;
            //int loopCount = 10;

            //while (0 < loopCount)
            //{
            //    sumFloatValue += FLOAT_VALUE;
            //    loopCount--;
            //} // loop : 10번 돈다
            //Console.WriteLine("무슨 값이 나오나? {0}", sumFloatValue); // 근사값이 나옴

            //// 6. 두 실수(float)를 입력받아서 값이 같은지 다른지 출력하는 프로그램 작성(Equal 메서드 등 금지)

            //float Value1 = 0.0F;
            //float Value2 = 0.0F;



            //Console.Write("첫 번째 실수를 입력하시오 : ");
            //float.TryParse(Console.ReadLine(), out Value1);

            //Console.Write("두 번째 실수를 입력하시오 : ");
            //float.TryParse(Console.ReadLine(), out Value2);


            //if (Value1 == Value2)
            //{
            //    Console.WriteLine("두 실수는 값이 다릅니다.");

            //} else
            //{
            //    Console.WriteLine("두 실수는 값이 같습니다.");
            //}

            /**
             * 
             * For 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 
             * 한번 반복이 끝날 때마다 증감식이 실행된다.
             */

            // 1~10 까지 정수의 합

            //int sumNumber = 0;

            ////                     5번          7번
            ////      1번            2번          4번
            ////for (int index = 1; index <= 10; index++)


            //    for (int index = 1; index <= 10; index++)
            //{
            //    // 3번, 6번
            //    sumNumber += index;
            //} // 조건식이 참인 동안 실행

            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumNumber}");
            //Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNumber);



            /**
             * 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
             */

            //int Threeadd = 0;

            //Console.Write("1~100 사이의 숫자를 입력하시오. : ");
            //int intValue1 = Convert.ToInt32(Console.ReadLine());

            //for (int index2 = 1; index2 <= 100; index2++ )
            //{
            //    if (index2 % 3 == 0)
            //    {
            //        /* Do nothing */
            //    }
            //    else
            //    {
            //        Threeadd += index2;
            //    }
            //} // loop : 100번 도는 루프

            //Console.WriteLine(Threeadd);


            /**
             * break 문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue 문
             * continue 문은 현재 수행하고 있는 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로
             * 시작하게 만든다. 반복 루프에서 continue 문은 만나게 되면 continue 문 다음에 있는 후속 코드들은
             * 실행되지 않고 건너뛰게 된다.
             */

            //int Threeadd2 = 0;

            //Console.Write("1~100 사이의 숫자를 입력하시오. : ");
            //int intValue2 = Convert.ToInt32(Console.ReadLine());

            //for (int index2 = 1; index2 <= 100; index2++)
            //{
            //    if (index2 % 3 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Threeadd2 += index2;
            //    }
            //} // loop : 100번 도는 루프

            //Console.WriteLine(Threeadd2);


            //for (int index = 1; index <= 10; index++)
            //{
            //    if (index == 4) { break;}
            //    Console.WriteLine("현재 인덱스 : {0}", index);
            //} // loop : 10번 도는 루프


            /**
             * 1. 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * (대, 소문자 모두 카운트)
             * ex) a
             * b
             * c
             * d
             * e
             * #
             * 모음: 2
             * 자음: 3
             */

            //int vowelscount = 0;   // 모음 개수 
            //int consonantscount = 0; // 자음 개수
            //char alphaBatcount = '$'; // 입력되는 알파벳을 끝낼 특수문자

            //while ( alphaBatcount != '#')  // while 반복 처리(!= : 같지 않으면 true 처리)
            //{
            //    Console.Write("영문자를 입력하시오. : ");      // 무슨 값을 입력해야 하는지 알려주는 출력문
            //    char alphaBat = Convert.ToChar(Console.ReadLine()); // 입력받은 알파벳을 char 선언 처리

            //    switch (alphaBat)         // 입력한 알파벳에 따라 처리
            //    {
            //        case 'a':             // case에 모음 알파벳들을 분류했습니다. 'a' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'A':             // 'A' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'e':             // 'e' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'E':             // 'E' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'i':             // 'i' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'I':             // 'I' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'o':             // 'o' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'O':             // 'O' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'u':             // 'u' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case 'U':             // 'U' 입력 값을 받을 때
            //            vowelscount++;    // vowelscount 변수 값에 1을 더합니다.
            //            break;            // switch 문을 종료
            //        case '#':                // #을 입력 받을때
            //            alphaBatcount = '#'; // alphaBatcount 변수를 #으로 바꿈
            //            break;               // switch 문 탈출
            //        default:                  // 나머지 입력 값들
            //            consonantscount++;    // consonantscount 변수 값에 1을 더합니다.
            //            break;                   // switch 문 탈출

            //    } // switch : 알파벳 찾는 switch

            //} // while : #이 입력될 때까지 반복


            //Console.WriteLine("모음의 개수 : {0}", vowelscount);       // 모음의 개수를 모아둔 변수 vowelscount를 출력
            //Console.WriteLine("자음의 개수 : {0}", consonantscount);   // 자음의 개수를 모아둔 변수 consonantscount를 출력


            //Console.WriteLine();      // 한줄 내림
            //Console.WriteLine();      // 한줄 내림

            ///**
            // * 2. 숫자 맞추기 게임
            // * 숫자 알아맞히기 게임이다. 프로그램은 1~100 사이의 정수를 저장하고 있음.
            // * 사용자는 질문을 통해서 숫자를 알아 맞힌다. 사용자가 답을 제시하면 프로그램은 제시된
            // * 정수가 더 낮은 값인지, 높은 값인지 알려준다.
            // * 사용자가 알아맞힐 때까지 루프한다.(기본형)
            // */

            //Random Dice1 = new Random();          // 랜덤 선언
            //int Dice1val = Dice1.Next(1, 100+1);  // Dice1val 변수에 Dice1의

            //while ( Dice1val > 0 )
            //{
            //    Console.Write("1~100 사이의 정답을 맞추시오 : ");
            //    int sltNumber = Convert.ToInt32(Console.ReadLine());

            //    if ( Dice1val > sltNumber)
            //    {
            //        Console.WriteLine("더 큰 값입니다.");

            //    } else if ( Dice1val < sltNumber ) {
            //        Console.WriteLine("더 작은 값입니다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("정답입니다.");
            //        Dice1val = 0;
            //    }

            //}


            //Console.WriteLine(); // 보기 편하게 줄 내림
            //Console.WriteLine();


            ///**
            // * 3. 프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에 사용자가 결정한
            // * 번호를 컴퓨터가 추측하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를
            // * 컴퓨터에 알려야한다. 컴퓨터가 맞힐때까지 반복.(어려움 1)
            // */



            //Console.Write("1~100 사이의 정답이 될 숫자를 골라주세요. : ");
            //int PassNumber = Convert.ToInt32(Console.ReadLine());

            //Random ComputerNumber = new Random();
            //int ComputerNumberval = ComputerNumber.Next(1, 100 + 1);

            //while (PassNumber != ComputerNumberval )
            //{


            //    if (PassNumber > ComputerNumberval)
            //    {
            //        Console.WriteLine("입력된 값이 낮습니다.");
            //        ComputerNumberval++;

            //    } 
            //    else
            //    {
            //        Console.WriteLine("입력된 값이 높습니다.");
            //        ComputerNumberval--;
            //    } 
            //}
            //Console.WriteLine("정답입니다.");

            ///**
            // * 4. 사용자가 결정한 값의 범위는 (1~100) 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수
            // * 있도록 어려움 1을 수정하시오. (어려움 2)
            // */
            //int Valuecount = 0;

            //Console.Write("1~100 사이의 정답이 될 숫자를 골라주세요. 기회는 7번 주어집니다. : ");
            //int PassNumber2 = Convert.ToInt32(Console.ReadLine());


            //Random ComputerNumber2 = new Random();
            //int ComputerNumberval2 = ComputerNumber2.Next(1, 100 + 1);

            //while (Valuecount < 7 + 1)
            //{

            //    if (PassNumber2 > ComputerNumberval2)
            //    {
            //        Console.WriteLine("입력된 값이 낮습니다.");
            //        ComputerNumberval2++;
            //        Valuecount++;

            //    }
            //    else if (PassNumber2 < ComputerNumberval2)
            //    {
            //        Console.WriteLine("입력된 값이 높습니다.");
            //        ComputerNumberval2--;
            //        Valuecount++;
            //    } else
            //    {
            //        Console.WriteLine("정답입니다.");
            //        Valuecount = 8;
            //    }
            //}
            //Console.WriteLine("끝났습니다.");



            /**
             * 5. 산수 문제 자동 출제
             * 산수 문제를 자동으로 출제하는 프로그램을 작성해보자.
             * 덧셈 문제들을 자동으로 생성해야 한다.
             * 
             * 피연산자는 0~99 사이의 숫자 (난수) 한 번이라도 맞으면 종료 틀리면 리트라이(기본형)
             * 
             */
            //Random numberplus = new Random();
            //int number1val1plus = numberplus.Next(0, 99 + 1);
            //int number1val2plus = numberplus.Next(0, 99 + 1);

            //int numberplusadd = number1val1plus + number1val2plus;

            //int correct1 = 0;

            //while ( numberplusadd != correct1 )
            //{
            //    Console.Write("{0} + {1} 의 정답을 맞추시오 : ", number1val1plus, number1val2plus);
            //    correct1 = Convert.ToInt32(Console.ReadLine());

            //    if (correct1 == numberplusadd)
            //    {
            //        Console.WriteLine("정답입니다.");
            //        break;
            //    } else
            //    {
            //        Console.WriteLine("다시 한번 풀어보세요.");
            //    }


            //}



            ///**
            // * 6. 뺄셈, 곱셉, 나눗셈 문제도 출제 -> 나눗셈 예외처리 (무한대값 주의)
            // */

            //// 뺄셈 문제
            //Random numberminus = new Random();
            //int number1valminus = numberminus.Next(0, 99 + 1);
            //int number1val2minus = numberminus.Next(0, 99 + 1);

            //int number3minus = number1valminus - number1val2minus;
            //int correct2 = 0;

            //while (number3minus != correct2)
            //{
            //    Console.Write("{0} - {1} 의 정답을 맞추시오 : ", number1valminus, number1val2minus);
            //    correct2 = Convert.ToInt32(Console.ReadLine());

            //    if (correct2 == number3minus)
            //    {
            //        Console.WriteLine("정답입니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("다시 한번 풀어보세요.");
            //    }
            //}

            //// 곱셈 문제
            //Random numbertimes = new Random();
            //int number1valtimes = numbertimes.Next(0, 99 + 1);
            //int number1val2times = numbertimes.Next(0, 99 + 1);

            //int number3times = number1valtimes * number1val2times;
            //int correct3 = 0;

            //while (number3times != correct3)
            //{
            //    Console.Write("{0} * {1} 의 정답을 맞추시오 : ", number1valtimes, number1val2times);
            //    correct3 = Convert.ToInt32(Console.ReadLine());

            //    if (correct3 == number3times)
            //    {
            //        Console.WriteLine("정답입니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("다시 한번 풀어보세요.");
            //    }
            //}


            // 나눗셈 문제

            //Random numberdivi = new Random();
            //int number1valdivi = numberdivi.Next(0, 99 + 1);
            //int number1val2divi = numberdivi.Next(0, 99 + 1);


            //float correct4 = 0.00F;
            //double number3divi = 0;

            //number3divi = number1valdivi / number1val2divi;


            //while (number3divi != correct4)
            //{
            //    Console.Write("{0} / {1} 의 정답을 맞추시오 : ", number1valdivi, number1val2divi);
            //    float.TryParse(Console.ReadLine(), out correct4);

            //    if (correct4 == number3divi)
            //    {
            //        Console.WriteLine("정답입니다.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("다시 한번 풀어보세요.");
            //    }
            //}


            /**
             * foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
             */

            // string 에서 글자를 하나씩 출력

            string stringText = "Hello world!";

            int loopcount = 0;

            foreach(char oneCharactor in stringText)
            {
                Console.Write("{0} ", oneCharactor);
                loopcount++;

            } // loop : stringText의 길이만큼 도는 루프
            Console.WriteLine();
            Console.WriteLine("Loop count : {0}, stringText`s length : {1}",
                loopcount, stringText.Length);


            /**
             * 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기
             */

            const int TWTHREE = 12; // 상수 12 선언
            int Inttwthree = 0;     // 3의 배수이면서 4의 배수인 정수를 담아두는 변수 선언
            int InttwthreeAdd = 0;  // 3의 배수이면서 4의 배수인 정수의 합을 구하는 변수 선언
            int twthreecount = 1;   // 횟수 카운트


            while (Inttwthree < 100)
            {
                InttwthreeAdd += (twthreecount * TWTHREE);
                Inttwthree = (twthreecount * TWTHREE);
                twthreecount++;
            } // while : 12배수가 100을 넘기 전까지 반복

            Console.WriteLine("3의 배수이면서 4의 배수인 정수의 합 : {0}", InttwthreeAdd);





            /**
             * 두 개의 정수를 입력받아서 두 수의 차를 출력하는 프로그램 작성
             * - 항상 큰수에서 작은 수를 뺀 결과를 출력할 것.
             * - 결과는 언제나 0 이상이어야 함.
             */

            int intminus = 0; // 뺀 값을 저장할 변수 선언

            Console.Write("첫 번째 정수를 입력하시오. : ");
            int Number1int = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하시오. : ");
            int Number2int = Convert.ToInt32(Console.ReadLine());

            
            if (Number1int > Number2int)
            {
                intminus = Number1int - Number2int;
                Console.WriteLine("두 수의 차는 {0} 입니다.", intminus);
            } else
            {
                intminus = Number2int - Number1int;
                Console.WriteLine("두 수의 차는 {0} 입니다.", intminus);
            }



            /**
             * 
             * 구구단을 출력하되 짝수 (2, 4, 6, 8단)만 출력되도록 하는 프로그램 작성
             * - 2단은 2 x 2까지, 4단은 4 x 4까지만... 8단은 8 x 8 까지 출력
             * - break와 continue 사용할 것
             */


            int gugutwo = 1;
            int gugucount = 1;

            while (gugutwo < 9)
            {
                if (gugutwo % 2 == 0 )
                {
                    while (gugutwo >= gugucount)
                    {
                        Console.WriteLine("{0} * {1} = {2}", gugutwo, gugucount, gugutwo * gugucount);
                        gugucount++;
                    } 
                } else
                {
                    gugutwo++;
                }
            }



            /**
             * 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램 작성
             *         AZ
             * +       ZA
             * ------------
             *         99
             */

        } // Main()
    }
}