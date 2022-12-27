using System;

namespace _39기_보강_2일차
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("문자");
            //int a;
            //a = 10;

            //float b;
            //b = 3.14f;

            //string input;
            //input = "긴 문자열";

            ////Console.WriteLine(a);
            ////Console.WriteLine(input);

            //Console.WriteLine("나이를 입력하세요.");
            //input = Console.ReadLine();
            //Console.WriteLine("당신의 나이는 {0} 입니다.", input);


            //// 문자열 뒤에 1만 붙었다.
            //input = input + 1;
            //Console.WriteLine("당신의 나이는 내년에 {0} 입니다.", input);
            //// input이 13이길 바랬지만 사실 "13" 문자열인 string이었다.
            //// 값은 "131"


            // 박스긴 박스인데, true, false
            //bool isTrue;

            // Console.WriteLine("나이를 입력하세요.");

            //int age;
            // 입력 받은 값을 int형으로 나눠달라
            //age = int.Parse(Console.ReadLine());

            // int형식으로 나누어본다. 결과물을 age에 저장해라
            //isTrue = int.TryParse(Console.ReadLine(), out age);
            //int.TryParse(Console.ReadLine(), out age);


            //Console.WriteLine(age);
            //age = age + 1;
            //Console.WriteLine("제대로 담겼나요? : " + isTrue);


            //float age;
            //float.TryParse(Console.ReadLine(), out age);

            //Console.WriteLine("당신의 내년 나이는 : "+ age);



            //두 실수를 유저로부터 입력 받고, float형 변수에 저장
            //둘의 합 출력

            //float firstNum;
            //float secondNum;

            //Console.WriteLine("첫째 수 입력 : ");
            //// firstNum 여기에 첫째 입력을 받고 싶다.
            //float.TryParse(Console.ReadLine(), out firstNum);

            //Console.WriteLine("둘째 수 입력 : ");
            //float.TryParse(Console.ReadLine(), out secondNum);

            //Console.WriteLine("최종 합은 : " + (firstNum + secondNum));


            /**
             * if(여기 조건문, 이것이 참일 때)
             * {
             *      참일 때 여기 내용을 실행
             * }
             */
            //bool isBigger;
            //isBigger = (toDetermine > 50);

            //if(toDetermine > 50)
            //{
            //    Console.WriteLine("50보다 큽니다.");
            //}
            //else if(toDetermine > 30)
            //{
            //    Console.WriteLine("30보다 큽니다.");

            //}
            //else
            //{
            //    Console.WriteLine("이도 저도 아닙니다.");

            //}

            //Console.WriteLine("판단할 수를 입력해주세요.");
            //int toDetermine;
            ////bool isParsed;

            //int.TryParse(Console.ReadLine(), out toDetermine);

            //isParsed = int.TryParse(Console.ReadLine(), out toDetermine);

            //if (isParsed)
            //{
            //    Console.WriteLine("정수가 정상적으로 입력되었습니다.");
            //    Console.WriteLine("입력된 숫자는 : " + toDetermine + "입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("정수가 아닌 것이 입력되었습니다.");

            //}

            // if : 한번에 한번 씩만 비교해야 한다.

            // && 조건 둘 다 참이어야 실행한다.
            //if ((100 > toDetermine) && (toDetermine > 30))
            //{

            //}
            //// || 조건 중 하나라도 참이면 실행
            //if(toDetermine % 2 == 0 || toDetermine % 3 == 0)
            //{
            //    if(toDetermine % 2 == 0)
            //    {
            //        Console.WriteLine("2의 배수 입니다.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("3의 배수 입니다.");
            //    }

            //    Console.WriteLine("2의 배수 이거나 3의 배수 입니다.");


            //}
            //else
            //{
            //    Console.WriteLine("이도 저도 아닙니다.");

            //}

            //if (toDetermine % 2 == 0 && toDetermine % 3 == 0)
            //{
            //    Console.WriteLine("2의 배수 혹은 3의 배수 입니다.");

            //}
            //else
            //{
            //    Console.WriteLine("이도 저도 아닙니다.");

            //}



            //Console.WriteLine("이동할 장소를 골라주세요.");
            //Console.WriteLine("1. 마을");
            //Console.WriteLine("2. 사냥터");
            //Console.WriteLine("3. 상점");
            //int toDetermine;

            //int.TryParse(Console.ReadLine(), out toDetermine);

            //// 콘솔에 적힌 이전 내용을 지웁니다.
            //Console.Clear();

            //Console.WriteLine("판단할 수를 입력해주세요.");
            //int toDetermine;
            ////bool isParsed;

            //int.TryParse(Console.ReadLine(), out toDetermine);

            // if 문은 참 거짓으로 실행 여부 결정
            // switch 문은 문자 혹은 숫자로 분기를 설정

            //switch (toDetermine)
            //{
            //    case 1:
            //        Console.WriteLine("마을로 이동합니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("사냥터로 이동합니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("상점으로 이동합니다.");
            //        break;
            //    default:
            //        Console.WriteLine("이도 저도 아닙니다.");
            //        break;
            //}


            // 반복문 : 초기식; 조건식; 증감식 순으로 써야한다.
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}




            // 반복문 : 초기식; 조건식; 증감식 순으로 써야한다.
            //for (int i = 0; i < 10; i++)
            //{

            //    if(i == 0)
            //    {
            //        Console.WriteLine(i + " 은 0 입니다.");
            //    }
            //    else if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " 는 2의 배수 입니다.");

            //    }

            //    else
            //    {
            //        Console.WriteLine(i + " 는 홀수 입니다.");
            //    }


            //    //Console.WriteLine("저거 사줘!");
            //    //Console.WriteLine(i);
            //}



            // 반복문 : 초기식; 조건식; 증감식 순으로 써야한다.
            //for (int i = 1; i < 10; i++)
            //{
            //    for(int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine(i + "\tx\t" + j + "\t=\t" + i * j);
            //    }
            //}



            // 반복문 while

            //bool flag;
            //int counter = 0;
            //flag = true;


            //while (flag)
            //{
            //    counter = counter + 1;
            //    Console.WriteLine(counter);

            //    if(counter == 10)
            //    {
            //        flag = false;
            //    }
            //}



            //break 문

            //int counter = 0;

            //while (true)
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;

            //    if (counter == 10)
            //    {
            //        break;
            //    }
            //}


            //continue 문 : 다시 올라가서 반복해라
            //int counter = 0;

            //while (counter < 13)
            //{
            //    counter++;
            //    if (counter % 2 == 0)
            //    {
            //        continue;
                    
            //    }
            //    Console.WriteLine(counter);
            //    Console.WriteLine("으앙 전 짝수일때 씹힙니다.");
            //}




        } // Main()
    }
}