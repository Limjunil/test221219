using System;

namespace _39기_보강_3일차
{
    internal class Program
    {

               
        static void Main(string[] args)
        {

            //int toDetermine;
            //// 입력이 잘못되었을 때 참 거짓 판단할 변수
            //bool incorrectInput = false;

            //Console.WriteLine("이동 할 장소를 설정해주세요");

            //// 정수 값이면 참
            //incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);

            //if (incorrectInput == false)
            //{

            //    while (incorrectInput == false)
            //    {
            //        Console.WriteLine("제대로 된 입력을 다시 해주세요");
            //        incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);
            //    }
            //}


            //// =================================================
            //Console.WriteLine("1. 마을");
            //Console.WriteLine("2. 사냥터");
            //Console.WriteLine("3. 상점");


            //int toDetermine;
            //bool incorrectInput = false;
            //Console.WriteLine("이동 할 장소를 설정해주세요");
            //incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);

            //if (incorrectInput == false)
            //{

            //    while (incorrectInput == false)
            //    {
            //        Console.WriteLine("제대로 된 입력을 다시 해주세요");
            //        incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);
            //    }
            //}

            //// 추후 열거형이랑 쓰면 직관성이 좋다.
            //switch (toDetermine)
            //{
            //    case 1:
            //        Console.WriteLine("마을로 이동합니다");
            //        break;
            //    case 2:
            //        Console.WriteLine("사냥터로 이동합니다");
            //        break;
            //    case 3:
            //        Console.WriteLine("상점으로 이동합니다");
            //        break;
            //    default:
            //        Console.WriteLine("1,2,3 어느것도 아니에요");
            //        break;

            //}

            //// =================================================


            //int SS = 1;
            //int S = 2;
            //int R = 7;
            //int C = 9;

            //int[] cards;
            //// new : 뒤에 있는 걸 만들고 위치를 변수에 알려준다.
            //cards = new int[4];

            //cards[0] = 1;
            //cards[1] = 2;
            //cards[2] = 7;
            //cards[3] = 9;

            // 배열 범위를 벗어나면 오류가 난다.
            //cards[4] = 10;


            //Console.WriteLine(cards[0]);
            //Console.WriteLine(cards[1]);
            //Console.WriteLine(cards[2]);
            //Console.WriteLine(cards[3]);

            //for(int i = 0; i < cards.Length; i++)
            //{
            //    Console.WriteLine(cards[i]);
            //
            //}


            // in 뒤에는 집합체가 들어간다.
            //foreach(int element in cards)
            //{
            //    Console.WriteLine(element);
            //}

            //int[,] cards2 = new int[2,2];
            //cards2[0, 0] = 1;
            //cards2[0, 1] = 2;
            //cards2[1, 0] = 7;
            //cards2[1, 1] = 9;


            // ===============================================

            // 함수 시작

            // 덧셈 과정의 중복이 보인다.
            //int x = 5;
            //int y = 4;
            //int z = x + y;

            //Console.WriteLine(z);

            //int a = 10;
            //int b = 20;
            //int c = a + b;

            //Console.WriteLine(c);

            // ===============================================

            //int a = 4;
            //double b;

            ////PrintHello();
            ////PrintIntByinput(a);

            //b = PrintOneAndReturn();

            //Console.WriteLine(b);


            // 기능을 하나 만들고 싶어요
            // 정수형 하나를 받고
            // 해당 값을 2배로 만들어서 정수형으로 반환하는 기능

            //Console.WriteLine(UnityDouble(5));


            // 두 float 실수를 입력받고, 두 수의 합을 더블형으로 반환하는 함수를 만들고 싶다.

            float x = 4.123f;
            float y = 6.1254f;

            Console.WriteLine(AddTwoNumbers(x, y) + UnityDouble(5));


            AddTwoNumbers(3f, 4f);


        } // Main()


        //void 비어있다.

        /**
         * [반환 타입][함수 이름] ([매개변수])
         * {
         *      실행될 내용
         *      return;
         * }
         */

        // void : 반환이 없다.
        // () : 매개변수가 없다 -> 외부에서 가져올 게 없다.
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        static void PrintIntByinput(int i)
        {
            Console.WriteLine(i);
        }

        static float PrintOneAndReturn()
        {
            Console.WriteLine("123");
            return 1.465f;
        }

        string GetOneAndReturn(int input)
        {
            Console.WriteLine(input);

            return "Hello";
        }

        bool TryParse()
        {
            return true;
        }

        static int UnityDouble(int toDouble)
        {
            int a;
            a = toDouble * 2;
            
            return a;
        }

        static double AddTwoNumbers(float firstNumber , float secondNumber )
        {

            double answer;

            answer = firstNumber + secondNumber;
            
            return answer;
        }

        

    }

}

        
    
