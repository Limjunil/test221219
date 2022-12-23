namespace Program1223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
             * ex) 첫 번째 문자열 : Hello
             *      두 번째 문자열 : World
             *      2개의 문자열은 다릅니다.
             *      
             * - Equals 메서드를 사용하지 않을 것.
             * - Length를 비교한다던지?
             */
            
            // FirstVal : 아무거나 문자열로 값을 받는다.
            string FirstVal = string.Empty;
            Console.Write("첫 번째 문자열 : ");
            FirstVal = Console.ReadLine();

            // SecondVal : 아무거나 문자열로 값을 받는다.
            string SecondVal = string.Empty;
            Console.Write("두 번째 문자열 : ");
            SecondVal = Console.ReadLine();

            // Check1 : FirstVal와 SecondVal 문자 길이가 같으면 참, 아니면 거짓
            bool Check1 = (FirstVal.Length == SecondVal.Length);

            if (Check1)
            {
                if (FirstVal == SecondVal)
                {
                    Console.WriteLine("2개의 문자열은 같습니다.");
                } else
                {
                    Console.WriteLine("2개의 문자열은 다릅니다.");

                }
            }
            else 
            {
                Console.WriteLine("2개의 문자열은 다릅니다.");

            }

            Console.WriteLine("===================================");


            /** 
             * 2. 5개의 음료(콜라, 물, 스프라이트, 주스, 커피)를 판매하는 자판기 머신을 구현해보자
             * - 사용자가 1부터 5사이의 숫자를 입력함
             * - 선택한 음료를 출력함
             * - 1~5 이외의 숫자를 선택하면 오류메시지를 출력함
             * - switch 문이나, if/else 문을 사용한다.
             * 
             * ex) 콜라, 물, 스프라이트, 주스, 커피(1~5) 중에서 하나를 선택하세요. : 1
             *      콜라를 선택하였습니다.
             *      - 프로그램 종료 -
             */

            string[] drinks = new string[5] { "콜라", "물", "스프라이트", "주스", "커피" };

            int drinknum = 0;

            Console.Write("콜라, 물, 스프라이트, 주스, 커피(1~5) 중에서 하나를 선택하세요. : ");


            while (true)
            {
                int.TryParse(Convert.ToString(Console.ReadLine()), out drinknum);

                if(0 < drinknum && drinknum < 6) {
                    switch(drinknum)
                    {
                        case 1:
                            Console.WriteLine("{0} 를 선택하였습니다.", drinks[0]);
                            break;
                        case 2:
                            Console.WriteLine("{0} 를 선택하였습니다.", drinks[1]);
                            break;
                        case 3:
                            Console.WriteLine("{0} 를 선택하였습니다.", drinks[2]);
                            break;
                        case 4:
                            Console.WriteLine("{0} 를 선택하였습니다.", drinks[3]);
                            break;
                        case 5:
                            Console.WriteLine("{0} 를 선택하였습니다.", drinks[4]);
                            break;
                    }
                    break;
                }
                else
                {
                    Console.Write("이상한 입력입니다. 1~5 사이의 숫자를 입력하시오. : ");
                }
            }
            Console.WriteLine("- 프로그램 종료 -");

            Console.WriteLine("===================================");



            /** 3. 배열 days[]를 아래와 같이 초기화하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성
             * - 배열 days[] 는 -> 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
             * ex) 1월은 31일까지 입니다.
             *     2월은 29일까지 입니다.
             *     배열의 초기화는 중괄호를 사용한다.
             */

            int monthcount = 1;

            int[] days = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for(int monthcount2 = 0; monthcount2 < 12; monthcount2++)
            {
                Console.WriteLine("{0}월은 {1}일까지 입니다.", monthcount, days[monthcount2]);
                Console.WriteLine("=======================");
                monthcount++;
            }


        }
    }
}