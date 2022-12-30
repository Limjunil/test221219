using System;
using System.Threading.Tasks;

namespace Work221230
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**
             * 10x 10
             * - 위에 코인 몇개 먹었는지 보이게
             * - 플레이어 위치에 코인이 생성 x
             * - $(코인) 먹으면 카운트
             * - c버튼을 누르면 5군데에 코인이 생성되게 한다.
             */

            // 코인 10개를 먹으면 끝나는 게임
            //c누르면 코인이 보이면서 전체 맵이 한번 보이고
            //행동하면 시야각이 좁아집니다.

            GameSet gameSet_ = new GameSet();

            

        }   // Main()
    }   // class Program


    public class GameSet
    {




        public bool isGameOver = false;  //!< 게임 종료를 위한 참 거짓 선언
        public int CoinGetVal;

        public const int BOARDX = 10; // 보드판 길이 설정 상수로
        public const int BOARDY = 10;

        public int[,] playBoard = new int[BOARDY, BOARDX]; // 보드판 배열 선언

        string wayWhat = string.Empty; // 입력받은 값 저장할 변수 선언


        int player_Gps0; // 플레이어 위치 값 선언
        int player_Gps1;
        public GameSet() // 생성자
        {
            GameBoardSet();
            GamePlay();
        }

        public void GameBoardSet() // 게임 셋팅을 위한 함수
        {

            CoinGetVal = 0; // 코인 먹은 수




            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    playBoard[y, x] = -1;

                    // 외곽 값이 0, 9이니 조건을 달아서 벽으로 취급 시킨다.
                    if (y == 0 || x == 9 || y == 9 || x == 0)
                    {
                        playBoard[y, x] = -2; // 벽 취급
                    }
                }
            }


            
        }

        


        public void GamePlay()
        {
            Random random = new Random();
            int player_Gps0 = random.Next(4, 5 + 1);
            int player_Gps1 = random.Next(4, 5 + 1);

            playBoard[player_Gps0, player_Gps1] = 0; //!< 옷 모양의 위치를 정할 줄


            while (isGameOver == false)
            {


                Console.Clear();


                Console.WriteLine("==============================");
                Console.WriteLine("==============================");

                Console.WriteLine("코인을 먹은 개수 : {0}".PadLeft(20, ' '), CoinGetVal);
                Console.WriteLine("==============================");
                Console.WriteLine("==============================");

                if (wayWhat == "c")
                {
                    GameBoardCoin();
                }
                else
                {
                    for (int y = 0; y < BOARDY; y++)
                    {
                        for (int x = 0; x < BOARDX; x++)
                        {
                            switch (playBoard[y, x])
                            {
                                case -2:
                                    Console.Write("□".PadRight(2, ' '));
                                    break;
                                case -1:
                                    // 플레이어의 위치에서 2 또는 -2 값을 보고 설정한다.
                                    if(2 >= player_Gps0 - y && player_Gps0 - y >= -2)
                                    {
                                        if (2 >= player_Gps1 - x && player_Gps1 - x >= -2)
                                        {
                                            Console.Write(".".PadRight(3, ' '));

                                        }
                                        else
                                        {
                                            Console.Write(" ".PadRight(3, ' '));

                                        }
                                    }
                                    else
                                    {

                                        Console.Write(" ".PadRight(3, ' '));
                                    }
                                    break;
                                case 0:
                                    Console.Write("▲".PadRight(2, ' '));
                                    break;
                                case 1:
                                    if (2 >= player_Gps0 - y && player_Gps0 - y >= -2)
                                    {
                                        if (2 >= player_Gps1 - x && player_Gps1 - x >= -2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            
                                            Console.Write("$".PadRight(3, ' '));
                                            Console.ForegroundColor = ConsoleColor.White;

                                        }
                                        else
                                        {
                                            Console.Write(" ".PadRight(3, ' '));

                                        }
                                    }
                                    else
                                    {

                                        Console.Write(" ".PadRight(3, ' '));
                                    }
                                    break;
                                case 2:
                                    Console.Write("◀".PadRight(2, ' '));
                                    break;
                                case 3:
                                    Console.Write("▼".PadRight(2, ' '));
                                    break;
                                case 4:
                                    Console.Write("▶".PadRight(2, ' '));
                                    break;
                            }





                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

                

                if (CoinGetVal == 10)
                {

                    isGameOver = true;

                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    Console.WriteLine("코인 10개를 모아, 게임에서 승리했습니다.");
                    Console.WriteLine();

                    Console.WriteLine("==============================");

                    Console.WriteLine("[System] 아무 키나 입력하면 넘어갑니다.");
                    Console.WriteLine();

                    Console.WriteLine("==============================");
                    Console.ReadLine();
                    break;

                }

                

                int[,] WayWhere = new int[BOARDY, BOARDX];
                Console.WriteLine("==============================");
                Console.WriteLine("[c 입력시 코인 추가]".PadLeft(18, ' '));
                Console.WriteLine();



                Console.WriteLine("[w, a, s, d 키를 입력해주세요]");
                Console.Write("[# 입력 시 게임 탈출] : ".PadLeft(20, ' '));


                wayWhat = Convert.ToString(Console.ReadLine());

                Console.WriteLine();

                int checkCoin = 0;

                if (wayWhat == "w")
                {
                    int WallChack1 = 0;
                    WallChack1 = player_Gps0 - 1;

                    if (WallChack1 == 0)
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine();

                        Console.WriteLine("[System] 벽이라서 못갑니다.");
                        Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                        Console.WriteLine("==============================");
                        Console.ReadLine();


                    }
                    else
                    {
                        checkCoin = playBoard[player_Gps0 - 1, player_Gps1];

                        playBoard[player_Gps0, player_Gps1] = -1;
                        playBoard[player_Gps0 - 1, player_Gps1] = 0;

                        player_Gps0 = player_Gps0 - 1;

                        if (checkCoin == 1) { CoinGetVal++; }
                        else
                        { /* Do Nothing */ }



                    }



                }

                else if (wayWhat == "a")
                {
                    int WallChack2 = 0;
                    WallChack2 = player_Gps1 - 1;

                    if (WallChack2 == 0)
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine();

                        Console.WriteLine("[System] 벽이라서 못갑니다.");
                        Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                        Console.WriteLine("==============================");
                        Console.ReadLine();
                    }
                    else
                    {
                        checkCoin = playBoard[player_Gps0, player_Gps1 - 1];

                        playBoard[player_Gps0, player_Gps1] = -1;
                        playBoard[player_Gps0, player_Gps1 - 1] = 2;

                        player_Gps1 = player_Gps1 - 1;

                        if (checkCoin == 1) { CoinGetVal++; }
                        else
                        { /* Do Nothing */ }



                    }



                }


                else if (wayWhat == "s")
                {
                    int WallChack3 = 0;
                    WallChack3 = player_Gps0 + 1;

                    if (WallChack3 == 9)
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine();
                        Console.WriteLine("[System] 벽이라서 못갑니다.");
                        Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                        Console.WriteLine("==============================");
                        Console.ReadLine();

                    }
                    else
                    {
                        checkCoin = playBoard[player_Gps0 + 1, player_Gps1];

                        playBoard[player_Gps0, player_Gps1] = -1;
                        playBoard[player_Gps0 + 1, player_Gps1] = 3;

                        player_Gps0 = player_Gps0 + 1;

                        if (checkCoin == 1) { CoinGetVal++; }
                        else
                        { /* Do Nothing */ }

                    }



                }

                else if (wayWhat == "d")
                {
                    int WallChack4 = 0;
                    WallChack4 = player_Gps1 + 1;

                    if (WallChack4 == 9)
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine();
                        Console.WriteLine("[System] 벽이라서 못갑니다.");
                        Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                        Console.WriteLine("==============================");
                        Console.ReadLine();

                    }
                    else
                    {
                        checkCoin = playBoard[player_Gps0, player_Gps1 + 1];

                        playBoard[player_Gps0, player_Gps1] = -1;
                        playBoard[player_Gps0, player_Gps1 + 1] = 4;

                        player_Gps1 = player_Gps1 + 1;

                        if (checkCoin == 1) { CoinGetVal++; }
                        else
                        { /* Do Nothing */ }

                    }


                }

                else if (wayWhat == "c")
                {

                    int ZerooneCheck = 0;
                    int coinSetCount = 0;
                    bool CoinOkSet = false;


                    while (CoinOkSet == false)
                    {

                        int CoinVal0 = random.Next(1, 8 + 1);
                        int CoinVal1 = random.Next(1, 8 + 1);

                        ZerooneCheck = playBoard[CoinVal0, CoinVal1];

                        if (ZerooneCheck == 0) { /* Do Nothing */ }
                        else if (ZerooneCheck == 1) { /* Do Nothing */ }

                        else
                        {
                            playBoard[CoinVal0, CoinVal1] = 1;
                            coinSetCount++;
                        }


                        if (coinSetCount == 5)
                        {
                            CoinOkSet = true;
                        }
                        else {/* Do Nothing */ }



                    }
                }

                // # 입력 하면 탈출
                else if (wayWhat == "#")
                {
                    isGameOver = true;
                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    Console.WriteLine("게임에서 탈출했습니다.");
                    Console.WriteLine();

                    Console.WriteLine("==============================");


                }


                else
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    Console.WriteLine("[System] 잘못된 입력입니다.".PadLeft(21, ' '));
                    Console.WriteLine("다시 입력해주세요.\n".PadLeft(17, ' '));
                    Console.WriteLine("==============================");

                    Console.ReadLine();
                }




            } // loop : isGameOver이 false면 반복
        }


        public void GameBoardCoin()
        {

            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (playBoard[y, x])
                    {
                        case -2:
                            Console.Write("□".PadRight(2, ' '));
                            break;
                        case -1:
                            Console.Write(".".PadRight(3, ' '));
                            break;
                        case 0:
                            Console.Write("▲".PadRight(2, ' '));
                            break;
                        case 1:
                            // 코인에 노란색 색상을 추가한다.
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            // 딜레이를 부여한다.
                            Task.Delay(300).Wait();
                            Console.Write("$".PadRight(3, ' '));
                            // 다시 하얀색으로 바꾼다.
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.Write("◀".PadRight(2, ' '));
                            break;
                        case 3:
                            Console.Write("▼".PadRight(2, ' '));
                            break;
                        case 4:
                            Console.Write("▶".PadRight(2, ' '));
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }

    } // class GameSet


    

}