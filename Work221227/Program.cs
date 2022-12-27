using System;
using System.Runtime.CompilerServices;

namespace Work221227
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 과제
             * 슬라이딩 퍼즐 프로그램 작성하기
             * - 움직인 횟수
             * - 클리어시 게임 클리어 출력 및 총 움직인 횟수 출력
             */

            bool isGameOver = false;

            // 3 x 3 보드 배치
            const int BOARD_A = 3;
            const int BOARD_B = 3;

            // 잠시 1~9까지 숫자를 넣어둘 배열
            int[] ValArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random random2 = new Random(); // 난수 생성

            int Vals = 0; // 0~8 난수 값 저장할 변수
            int Check = 0; // 배열에서 빼온 값이 0인지 체크할 변수

            int[,] playBorad = new int[BOARD_B, BOARD_A]; // 3 x 3 보드 설정

            
            int playery = 0; // 움직일 좌표 저장할 값
            int playerx = 0; // 움직일 좌표 저장할 값

            for (int y = 0; y < BOARD_B; y++)
            {
                for(int x = 0; x < BOARD_A; x++)
                {
                    Vals = random2.Next(0, 9);
                    Check = ValArray[Vals];


                    if (Check == 0)
                    {
                        while (Check == 0)
                        {
                            Vals = random2.Next(0, 9);
                            Check = ValArray[Vals];

                            if (Check == 0)
                            {

                            }
                            else if (Check == 9)
                            {
                                playBorad[y, x] = Check;
                                playery = y;
                                playerx = x;
                                ValArray[Vals] = 0;
                                break;
                            }
                            else
                            {
                                playBorad[y, x] = Check;
                                ValArray[Vals] = 0;
                                break;

                            }
                        }

                    } 
                    else if (Check == 9)
                    {
                        playBorad[y, x] = Check;
                        playery = y;
                        playerx = x;
                        ValArray[Vals] = 0;

                    }
                    else
                    {
                        playBorad[y, x] = Check;
                        ValArray[Vals] = 0;
                    }

                }
            }

            int loopcount = 0;



            while (isGameOver == false)
            {
                ClearLine(20);

                Console.WriteLine("======================================================");
                Console.WriteLine("슬라이딩 퍼즐 게임".PadLeft(27, ' '));
                Console.WriteLine("======================================================");


                for (int y = 0; y < BOARD_B; y++)
                {
                    for (int x = 0; x < BOARD_A; x++)
                    {
                        switch (playBorad[y, x])
                        {
                            case 9:
                                Console.Write("\t X \t");
                                break;
                            default:
                                Console.Write("\t {0} \t", playBorad[y, x]);
                                break;
                         }
                    }
                    Console.WriteLine();
                }
                

                Console.WriteLine("======================================================");

                Console.WriteLine("움직인 횟수 : {0}".PadLeft(48, ' '), loopcount);
                Console.WriteLine();
                string wayWhat = string.Empty;

                while (true)
                {

                    if (playBorad[0, 0] == 1 && playBorad[0, 1] == 2 && playBorad[0, 2] == 3 &&
                        playBorad[1, 0] == 4 && playBorad[1, 1] == 5 && playBorad[1, 2] == 6 &&
                        playBorad[2, 0] == 7 && playBorad[2, 1] == 8 && playBorad[2, 2] == 9) 
                    {
                        isGameOver = true;
                        Console.WriteLine("======================================================");

                        Console.WriteLine("게임 클리어".PadLeft(28, ' '));
                        Console.WriteLine();
                        Console.WriteLine("총 움직인 횟수 : {0}".PadLeft(47, ' '), loopcount);
                        Console.WriteLine("======================================================");

                        break;
                    };
                    
                    
                    
                    Console.Write("w, a, s, d 키를 입력해주세요 : ".PadLeft(42, ' '));

                    wayWhat = Convert.ToString(Console.ReadLine());

                    if(wayWhat == "w")
                    {
                        int Check1 = 0;
                        Check1 = playery - 1;
                        if(Check1 < 0)
                        {
                            break;
                        }


                        playBorad[playery, playerx] = playBorad[playery - 1, playerx];
                        playBorad[playery - 1, playerx] = 9;
                        playery--;
                        loopcount++;
                        break;

                    }
                    else if(wayWhat == "a")
                    {
                        int Check2 = 0;
                        Check2 = playerx - 1;
                        if (Check2 < 0)
                        {
                            break;
                        }


                        playBorad[playery, playerx] = playBorad[playery, playerx - 1];
                        playBorad[playery, playerx - 1] = 9;
                        playerx--;
                        loopcount++;

                        break;
                    }
                    else if (wayWhat == "s")
                    {
                        int Check3 = 0;
                        Check3 = playery + 1;
                        if (3 <= Check3)
                        {
                            break;
                        }


                        playBorad[playery, playerx] = playBorad[playery + 1, playerx];
                        playBorad[playery + 1, playerx] = 9;
                        playery++;
                        loopcount++;

                        break;
                    }
                    else if (wayWhat == "d")
                    {
                        int Check4 = 0;
                        Check4 = playerx + 1;
                        if (3 <= Check4)
                        {
                            
                            break;
                        }


                        playBorad[playery, playerx] = playBorad[playery, playerx + 1];
                        playBorad[playery, playerx + 1] = 9;
                        playerx++;
                        loopcount++;

                        break;
                    }
                    // # 입력 하면 탈출
                    else if (wayWhat == "#")
                    {
                        isGameOver = true;
                        Console.WriteLine("======================================================");

                        Console.WriteLine("게임 클리어!!".PadLeft(28, ' '));
                        Console.WriteLine();
                        Console.WriteLine("총 움직인 횟수 : {0}".PadLeft(47, ' '), loopcount);
                        Console.WriteLine("======================================================");

                        break;
                    }
                    else
                    { /* Do Nothing */ }

                    

                }

                

            }



        } // Main()


        //! 콘솔 클리어하는 함수

        static void ClearLine(int lineNumber)
        {
            for(int i = 0; i < lineNumber; i++)
            {
                Console.WriteLine();
            }
        } //ClearLine()
    } //class
}