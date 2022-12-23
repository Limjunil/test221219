using System;

namespace TextRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 레퍼런스 게임 직접해보면서 내가 지금까지 배운 것들로 무엇을 어디까지
             * 구현할 수 있을지 마인드맵을 그려보기
             * 
             * - 타이틀 씬
             * - 선택지를 포함한 이벤트 -> 유저가 뭔가 선택 가능
             * - 보상 또는 패널티를 얻을 수 있는 이벤트 -> 유저가 골드를 얻거나 아이템을 얻거나, 스텟치가 떨어지거나...
             * - 전투 씬 -> 오크가 등장하거나 늑대가 등장하거나 해서 싸워서 결과를 내는 형태(어려움)
             */

            // tapToStart : 문자열 아무거나 받아줍니다.
            string tapToStart =String.Empty;

            // 내용을 출력합니다.
            Console.WriteLine("=====================");
            Console.WriteLine("=== 모험자 이야기 ===");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("|   Tap To Start   |");

            // 사용자 입력을 받습니다.
            tapToStart = Console.ReadLine();




            // Classchoice : 시작지 선택 값을 저장할 변수에 값 0을 선언
            int Classchoice = 0;

            // myClass : 직업 선택 값 저장할 변수에 값에 0을 선언
            int myClass = 0;

            // health : 체력에 대한 값을 보여줄 변수
            // health 값에 5을 선언한다.
            int health = 5;
            // Reputation : 평판에 대한 값을 보여줄 변수
            // Reputation 값에 0을 선언한다.
            int Reputation = 0;
            // Golds : 돈에 대한 값을 보여줄 변수
            // Golds 값에 0을 선언한다.
            int Golds = 0;
            // 현재 직업을 저장할 Class_my 선언
            string Class_my=string.Empty;

            // 힘 + 민첩 + 지능 + 카리스마 + 건강 + 지혜
            int[] stauts = new int[6] { 5, 5, 5, 5, 5, 5 };


            // Items 배열 : 아이템을 가지고 있을 배열을 선언, 총 5개만 된다.
            string[] Items = new string[8];
            // Class_s 배열 : 직업들을 담고 있는 배열을 선언 총 4개이다.
            string[] Class_s = new string[4] { "전사", "마법사", "사냥꾼", "사제" };

            // 직업과 스탯 정하기
            while (true)
            {
                Console.WriteLine("| [새로운 모험] |");
                Console.WriteLine("무작위 또는 당신만의 모험가로 모험을 시작하세요.");

                Console.WriteLine("1. 무작위 모험가");
                Console.WriteLine("2. 커스텀");
                int.TryParse(Convert.ToString(Console.ReadLine()), out Classchoice);

                if (Classchoice == 1 || Classchoice == 2)
                {
                    switch (Classchoice)
                    {
                        case 1:
                            Random number4 = new Random();
                            int Randomnumber1 = number4.Next(0, 4);


                            Class_my = Class_s[Randomnumber1];

                            //힘 + 민첩 + 지능 + 카리스마 + 건강 + 지혜
                            // 12번 랜덤하게 넣기
                            for (int i = 1; i < 12 + 1; i++)
                            {
                                Random number5 = new Random();
                                int Randomnumber2 = number5.Next(0, 6);

                                stauts[Randomnumber2]++;

                            } // loop : 12번 도는 반복
                            break;

                        case 2:

                            while (true)
                            {

                                Console.WriteLine("| [새로운 직업!] |");
                                Console.WriteLine("아래의 직업 중 하나를 선택하세요.");

                                Console.WriteLine("1. 전사");
                                Console.WriteLine("2. 마법사");
                                Console.WriteLine("3. 사냥꾼");
                                Console.WriteLine("4. 사제");
                                int.TryParse(Convert.ToString(Console.ReadLine()), out myClass);

                                if (myClass == 1 || myClass == 2 || myClass == 3 || myClass == 4)
                                {
                                    switch (myClass)
                                    {
                                        case 1:
                                            Class_my = Class_s[0];
                                            break;
                                        case 2:
                                            Class_my = Class_s[1];
                                            break;
                                        case 3:
                                            Class_my = Class_s[2];
                                            break;
                                        case 4:
                                            Class_my = Class_s[3];
                                            break;
                                    }


                                    while (true)
                                    {
                                        // 총 입력 점수가 12점을 안넘어가게 확인하기 위한 변수 선언
                                        int[] totalstauts = new int[6];


                                        Console.WriteLine("추가 스텟을 입력해주세요. 총 12점이 넘어가면 안됩니다.");
                                        //힘 + 민첩 + 지능 + 카리스마 + 건강 + 지혜
                                        Console.Write("힘 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[0]);

                                        Console.Write("민첩 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[1]);

                                        Console.Write("지능 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[2]);

                                        Console.Write("카리스마 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[3]);

                                        Console.Write("건강 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[4]);

                                        Console.Write("지혜 추가 스탯 입력 : ");
                                        int.TryParse(Convert.ToString(Console.ReadLine()), out totalstauts[5]);

                                        int totalstautVal = totalstauts[0] + totalstauts[1] + totalstauts[2] + totalstauts[3] + totalstauts[4] + totalstauts[5];

                                        if (totalstautVal < 12 + 1 && 0 < totalstautVal)
                                        {
                                            stauts[0] += totalstauts[0];
                                            stauts[1] += totalstauts[1];
                                            stauts[2] += totalstauts[2];
                                            stauts[3] += totalstauts[3];
                                            stauts[4] += totalstauts[4];
                                            stauts[5] += totalstauts[5];
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("총 스탯 입력이 12를 넘습니다. 다시 입력해주세요.");
                                        }
                                    }
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("이상한 입력이 감지되었습니다.");
                                    Console.WriteLine("선택지에 있는 번호로 다시 입력해주세요.");
                                }


                               
                            }

                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("이상한 입력이 감지되었습니다.");
                    Console.Write("선택지에 있는 번호로 다시 입력해주세요.");
                }

            }


            while (true)
            {
                Random number = new Random();
                int Eventnumber = number.Next(1, 2 + 1);

                Console.WriteLine("자신의 직업 : {0}", Class_my);
                Console.WriteLine("현재 체력 : {0}", health);
                Console.WriteLine("현재 평판 : {0}", Reputation);
                Console.WriteLine("현재 골드 : {0}", Golds);

                //힘 + 민첩 + 지능 + 카리스마 + 건강 + 지혜
                Console.WriteLine("| 현재 스탯 |");
                Console.WriteLine("힘 {0} |민첩 {1} |지능 {2} |", stauts[0], stauts[1], stauts[2]);
                Console.WriteLine("카리스마 {0} |건강 {1} |지혜 {2} |", stauts[3], stauts[4], stauts[5]);

                // 선택지 값을 저장할 변수 선언
                int choice = 0;

                // if : Eventnumber 값이 1이면 실행
                if (Eventnumber == 1)
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine("[평판 이벤트]");
                    Console.WriteLine("알 수 없는 이유로, 마을에서 동네 사람들이 싸우고 있습니다.");
                    Console.WriteLine("그 모습을 본 동료들은 말리자고 하고 있습니다.");
                    Console.WriteLine("==========================================");

                    while (true)
                    {
                        Console.WriteLine("1. 싸움을 막는다.");
                        Console.WriteLine("2. 지나친다.");
                        int.TryParse(Convert.ToString(Console.ReadLine()), out choice);

                        

                        if (choice == 1 || choice == 2)
                        {
                            switch (choice)
                            {
                                case 1:

                                    Console.WriteLine();
                                    Console.WriteLine("==========================================");
                                    Console.WriteLine("싸움을 막아서 평판이 좋아집니다.");
                                    Console.WriteLine("평판이 1 증가했습니다.");
                                    Console.WriteLine("힘이 1 증가했습니다.");
                                    Console.WriteLine("==========================================");
                                    Reputation++;
                                    stauts[0]++;
                                    break;

                                case 2:
                                    Console.WriteLine();
                                    Console.WriteLine("==========================================");
                                    Console.WriteLine("싸우는 모습을 보고도 도망을 갔습니다.");
                                    Console.WriteLine("그 모습을 본 동료가 당신을 한심하게 여깁니다.");
                                    Console.WriteLine("평판이 1 줄었습니다.");
                                    Console.WriteLine("==========================================");
                                    
                                    Reputation--;
                                    break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("이상한 입력이 감지되었습니다.");
                            Console.WriteLine("선택지에 있는 번호로 다시 입력해주세요.");
                        }

                    } // loop : 무한 반복하는 루프
                }
                else
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine("[골드와 아이템 이벤트]");
                    Console.WriteLine("산적을 만났습니다.");
                    Console.WriteLine("동료들은 싸울 준비를 합니다.");
                    Console.WriteLine("==========================================");

                    while (true)
                    {
                        Console.WriteLine("1. 산적과 싸운다. (50% 확률로 집니다.)");
                        Console.WriteLine("2. 도망친다.");

                        int.TryParse(Convert.ToString(Console.ReadLine()), out choice);

                        if (choice == 1 || choice == 2)
                        {
                            switch (choice)
                            {
                                case 1:

                                    Random number2 = new Random();
                                    int Battlenumber = number2.Next(1, 100 + 1);

                                    if(Battlenumber > 50)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("==========================================");
                                        Console.WriteLine("싸움을 막아서 평판이 좋아집니다.");
                                        Console.WriteLine("평판이 1 증가했습니다.");
                                        Console.WriteLine("골드가 1 증가했습니다.");
                                        Console.WriteLine("아이템 1개를 획득합니다.");
                                        Console.WriteLine("==========================================");
                                        
                                        Reputation++;
                                        Golds++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("==========================================");
                                        Console.WriteLine("생각보다 강한 산적에 의해 패했습니다.");
                                        Console.WriteLine("체력이 1 줄었습니다.");
                                        Console.WriteLine("평판이 1 줄었습니다.");
                                        Console.WriteLine("==========================================");

                                        health--;
                                        Reputation--;
                                    }
                                    break;

                                case 2:

                                    Console.WriteLine();
                                    Console.WriteLine("==========================================");
                                    Console.WriteLine("싸우는 모습을 보고도 도망을 갔습니다.");
                                    Console.WriteLine("그 모습을 본 동료가 당신을 한심하게 여깁니다.");
                                    Console.WriteLine("평판이 1 줄었습니다.");
                                    Console.WriteLine("==========================================");
                                    Reputation--;
                                    break;
                            }
                            break;
                        } 
                        else
                        {
                            Console.WriteLine("이상한 입력이 감지되었습니다.");
                            Console.WriteLine("선택지에 있는 번호로 다시 입력해주세요.");
                        }
                    } // loop : 무한 반복하는 루프


                }

                if (health == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("체력이 0이 되었습니다.");
                    Console.WriteLine("게임을 끝냅니다.");
                    break;
                } else { /* Do Nothing */ }

            }



        }
    }
}