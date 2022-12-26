using System;

namespace Work221226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 과제
             * 5 x 5 보드(사이즈 줘도 ok)
             * □ □ □ □ □
             * □ .  .  . □
             * □ .  옷 . □
             * □ .  .  . □
             * □ □ □ □ □
             * 
             * .(닷)은 빈 곳, □는 벽을 의미
             * 
             * 빈 곳 중에 아무 곳(정중앙)이나 사람(이모티콘 또는 옷)을 초기화 해서
             * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동(입력 받으면)하는 프로그램 작성하기
             * 
             * ex ) (벽이라서 못갑니다) 출력
             * - 사람은 빈 곳을 다닐 수 있음
             * - 사람은 벽을 넘어다닐 수 없음
             */

            bool isGameOver = false; // 게임 종료

            // 보드 사이즈
            const int BOARD_SIZE_X = 5;
            const int BOARD_SIZE_Y = 5;

            // 5 x 5 보드에 벽과 .을 배치한다.

            int[,] playBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    playBoard[y, x] = -1; // 점 취급

                    if (y == 0 || x == 4 || y == 4 || x==0 )
                    {
                        playBoard[y, x] = -2; // 벽 취급
                    }
                }
            }
            int playerX = 2; 
            int playerY = 2;
            playBoard[playerX, playerY] = 0; // "옷" 모양을 중앙 위치 선언

            // 게임 시작
            while (isGameOver == false)
            {
                
                for(int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch(playBoard[y, x])
                        {
                            case -2:
                                Console.Write("□".PadRight(2, ' '));
                                break;
                            case -1:
                                Console.Write(".".PadRight(3, ' '));
                                break;
                            case 0:
                                Console.Write("옷".PadRight(2, ' '));
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                string wayWhat = string.Empty;

                int[,] WayWhere = new int[5, 5];


                while (true)
                {


                    Console.Write("w, a, s, d 키를 입력해주세요 : ");
                    wayWhat = Convert.ToString(Console.ReadLine());

                    Console.WriteLine();

                    if (wayWhat == "w")
                    {
                        int WallChack1 = 0;
                        WallChack1 = playerY - 1;

                        if (WallChack1 == 0)
                        {
                            Console.WriteLine("벽이라서 못갑니다. 다시 입력해주세요.");
                            Console.WriteLine();
                            break;
                        }
                        
                        
                        playBoard[playerY, playerX] = -1;
                        playBoard[playerY - 1, playerX] = 0;

                        playerY = playerY - 1;


                        break;
                    }
                    else if (wayWhat == "a")
                    {
                        int WallChack2 = 0;
                        WallChack2 = playerX - 1;

                        if (WallChack2 == 0)
                        {
                            Console.WriteLine("벽이라서 못갑니다. 다시 입력해주세요.");
                            Console.WriteLine();
                            break;
                        }

                        playBoard[playerY, playerX] = -1;
                        playBoard[playerY, playerX - 1] = 0;

                        playerX = playerX - 1;
                        break;
                    }
                    else if (wayWhat == "s")
                    {
                        int WallChack3 = 0;
                        WallChack3 = playerY + 1;

                        if (WallChack3 == 4)
                        {
                            Console.WriteLine("벽이라서 못갑니다. 다시 입력해주세요.");
                            Console.WriteLine();
                            break;
                        }

                        playBoard[playerY, playerX] = -1;
                        playBoard[playerY + 1, playerX] = 0;

                        playerY = playerY + 1;

                        break;
                    }
                    else if (wayWhat == "d")
                    {
                        int WallChack4 = 0;
                        WallChack4 = playerX + 1;

                        if (WallChack4 == 4)
                        {
                            Console.WriteLine("벽이라서 못갑니다. 다시 입력해주세요.");
                            Console.WriteLine();
                            break;
                        }

                        playBoard[playerY, playerX] = -1;
                        playBoard[playerY, playerX + 1] = 0;

                        playerX = playerX + 1;
                        break;
                    }
                    // # 입력 하면 탈출
                    else if(wayWhat == "#")
                    {
                        isGameOver = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                        Console.WriteLine();
                    }
                    Console.WriteLine();




                }

                


                
            }


        }
    }
}