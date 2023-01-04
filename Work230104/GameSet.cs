using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work230104
{
    public class GameSet
    {

        public bool isGameOver = false;  //!< 게임 종료를 위한 참 거짓 선언
        public int CoinGetVal;

        public const int BOARDX = 10; // 보드판 길이 설정 상수로
        public const int BOARDY = 10;

        private int[,] playBoard = new int[BOARDY, BOARDX]; // 보드판 배열 선언

        public int player_Gps0; // 플레이어 위치 값 선언
        public int player_Gps1;

        string wayWhat = string.Empty; // 입력받은 값 저장할 변수 선언

        public GameSet()
        {
            Loading();
            GameBoardSet();
            GamePlay();

        }

        //! 시작할 때 보드에 값을 넣는 함수
        public void GameBoardSet()
        {
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


                    //포탈 위치 취급 설정

                    if ((y == 4 && x == 9) || (y == 5 && x == 9))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 4 && x == 0) || (y == 5 && x == 0))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 0 && x == 4) || (y == 0 && x == 5))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 9 && x == 4) || (y == 9 && x == 5))
                    {
                        playBoard[y, x] = -3;
                    }


                }
            }

            
        } // GameBoardSet()


        //! 본격적인 게임을 할 함수
        public void GamePlay()
        {

            // 랜덤 난수를 위한 랜덤 인스턴스화
            Random random = new Random();

            // 플레이어의 위치 중앙 값 랜덤
            int player_Gps0 = random.Next(4, 5 + 1);
            int player_Gps1 = random.Next(4, 5 + 1);
            playBoard[player_Gps0, player_Gps1] = 0; 

            // 플레이어가 중앙으로 돌아가는지 확인하는 참 거짓 선언
            bool Up_Check = true;




            while (isGameOver == false)
            {
                Console.Clear();


                Console.WriteLine("==============================");
                Console.WriteLine("==============================");
                Console.WriteLine("코인을 먹은 개수 : {0}".PadLeft(20, ' '), CoinGetVal);
                Console.WriteLine("==============================");
                Console.WriteLine("==============================");


                for (int y = 0; y < BOARDY; y++)
                {
                    for (int x = 0; x < BOARDX; x++)
                    {
                        switch (playBoard[y, x])
                        {
                            case -3:
                                // 포탈에 파란색을 부여한다.
                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Write("■".PadRight(2, ' '));
                                // 다시 하얀색으로 바꾼다.
                                Console.ForegroundColor = ConsoleColor.White;

                                break;

                            case -2:
                                Console.Write("□".PadRight(2, ' '));
                                break;
                            case -1:
                                
                                // 플레이어의 위치에서 2 또는 -2 값을 보고 설정한다.
                                if (2 >= player_Gps0 - y && player_Gps0 - y >= -2)
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
                                // 플레이어의 보는 방향 설정
                                Console.Write("▲".PadRight(2, ' '));
                                break;
                            case 1:
                                // 플레이어의 위치에서 2 또는 -2 값을 보고 설정한다.
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


                // 승리 조건

                if (CoinGetVal == 10)
                {

                    isGameOver = true;

                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    Console.WriteLine("코인 10개를 모아, 게임에서 승리했습니다.");
                    Console.WriteLine();

                    Console.WriteLine("==============================");
                    Console.WriteLine();

                    Console.WriteLine("[System] 아무 키나 입력하면 넘어갑니다.");
                    Console.WriteLine();

                    Console.WriteLine("==============================");
                    break;

                }


                // 게임 입력


                Console.WriteLine("[w, a, s, d 키를 입력해주세요]");
                Console.Write("[# 입력 시 게임 탈출] : ".PadLeft(20, ' '));


                wayWhat = Convert.ToString(Console.ReadLine());

                Console.WriteLine();


                int WallChack = 0;
                int PotalCheck = 0;
                int checkCoin = 0; // 움직이려는 자리 값이 1인지 확인하여 코인인지 체크하는 변수 값 선언

                if (wayWhat == "w")
                {
                    
                    PotalCheck = player_Gps1;
                    WallChack = player_Gps0 - 1;

                    if ((PotalCheck == 4 && WallChack == 0) || (PotalCheck == 5 && WallChack == 0))
                    {
                        if (playBoard[WallChack, PotalCheck] == -3)
                        {
                            // 새로운 위치로 가야함
                            playBoard[player_Gps0, player_Gps1] = -1;
                            playBoard[player_Gps0 = 8, player_Gps1] = 0;

                            // 포탈 전부 삭제
                            PotalDelete();
                            // 포탈 셋팅
                            playBoard[9, 4] = -3;
                            playBoard[9, 5] = -3;

                            if (Up_Check == false)
                            {
                                // 포탈 재세팅
                                PotalSet();
                                Up_Check = true;

                                ClearCoin();
                                Console.Clear();
                            }
                            else
                            {
                                Up_Check = false;

                                ClearCoin();
                                Console.Clear();
                                GameBoardCoin();
                            }

                             
                        }
                        else
                        {
                            Console.WriteLine("==============================");
                            Console.WriteLine();
                            Console.WriteLine("[System] 벽이라서 못갑니다.");
                            Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                            Console.WriteLine("==============================");
                            Console.ReadLine();
                        }
                         
                    }


                    else if (WallChack == 0)
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
                    PotalCheck = player_Gps0;
                    WallChack = player_Gps1 - 1;

                    if ((PotalCheck == 4 && WallChack == 0) || (PotalCheck == 5 && WallChack == 0))
                    {
                        if (playBoard[PotalCheck, WallChack] == -3)
                        {
                            // 새로운 위치로 가야함
                            playBoard[player_Gps0, player_Gps1] = -1;
                            playBoard[player_Gps0, player_Gps1 = 8] = 2;

                            // 포탈 전부 삭제
                            PotalDelete();

                            // 포탈 셋팅
                            playBoard[4, 9] = -3;
                            playBoard[5, 9] = -3;

                            if (Up_Check == false)
                            {
                                // 포탈 재세팅
                                PotalSet();
                                Up_Check = true;

                                ClearCoin();
                                Console.Clear();
                            }
                            else
                            {
                                Up_Check = false;

                                ClearCoin();
                                Console.Clear();
                                GameBoardCoin();
                            }
                        }
                        else
                        {
                            Console.WriteLine("==============================");
                            Console.WriteLine();
                            Console.WriteLine("[System] 벽이라서 못갑니다.");
                            Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                            Console.WriteLine("==============================");
                            Console.ReadLine();
                        }


                    }


                    else if (WallChack == 0)
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
                    PotalCheck = player_Gps1;

                    WallChack = player_Gps0 + 1;


                    if ((PotalCheck == 4 && WallChack == 9) || (PotalCheck == 5 && WallChack == 9))
                    {
                        if (playBoard[WallChack, PotalCheck] == -3)
                        {
                            // 새로운 위치로 가야함
                            playBoard[player_Gps0, player_Gps1] = -1;
                            playBoard[player_Gps0 = 1, player_Gps1] = 3;

                            // 포탈 전부 삭제
                            PotalDelete();

                            // 포탈 셋팅
                            playBoard[0, 4] = -3;
                            playBoard[0, 5] = -3;

                            if (Up_Check == false)
                            {
                                // 포탈 재세팅
                                PotalSet();
                                Up_Check = true;

                                ClearCoin();
                                Console.Clear();
                            }
                            else
                            {
                                Up_Check = false;

                                ClearCoin();
                                Console.Clear();
                                GameBoardCoin();
                            }
                        }
                        else
                        {
                            Console.WriteLine("==============================");
                            Console.WriteLine();
                            Console.WriteLine("[System] 벽이라서 못갑니다.");
                            Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                            Console.WriteLine("==============================");
                            Console.ReadLine();
                        }


                    }


                    else if (WallChack == 9)
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
                    PotalCheck = player_Gps0;
                    WallChack = player_Gps1 + 1;

                    if ((PotalCheck == 4 && WallChack == 9) || (PotalCheck == 5 && WallChack == 9))
                    {
                        if (playBoard[PotalCheck, WallChack] == -3)
                        {
                            // 새로운 위치로 가야함
                            playBoard[player_Gps0, player_Gps1] = -1;
                            playBoard[player_Gps0, player_Gps1 = 1] = 4;

                            // 포탈 전부 삭제
                            PotalDelete();

                            // 포탈 셋팅
                            playBoard[4, 0] = -3;
                            playBoard[5, 0] = -3;


                            if (Up_Check == false)
                            {
                                // 포탈 재세팅
                                PotalSet();
                                Up_Check = true;

                                ClearCoin();
                                Console.Clear();
                            }
                            else
                            {
                                Up_Check = false;

                                ClearCoin();
                                Console.Clear();
                                GameBoardCoin();
                            }
                        }
                        else
                        {
                            Console.WriteLine("==============================");
                            Console.WriteLine();
                            Console.WriteLine("[System] 벽이라서 못갑니다.");
                            Console.WriteLine("다시 입력해주세요.\n".PadLeft(20, ' '));

                            Console.WriteLine("==============================");
                            Console.ReadLine();
                        }


                    }

                    else if (WallChack == 9)
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
            } // loop : 게임이 끝날때까지
        } // GamePlay()


        public void GameBoardCoin()
        {

            Console.WriteLine("==============================");
            Console.WriteLine("==============================");

            Console.WriteLine("코인을 먹은 개수 : {0}".PadLeft(20, ' '), CoinGetVal);
            Console.WriteLine("==============================");
            Console.WriteLine("==============================");

            int ZerooneCheck = 0;
            int coinSetCount = 0;
            bool CoinOkSet = false;
            Random random = new Random();

            while (CoinOkSet == false)
            {

                int CoinVal0 = random.Next(1, 8 + 1);
                int CoinVal1 = random.Next(1, 8 + 1);

                ZerooneCheck = playBoard[CoinVal0, CoinVal1];

                if (ZerooneCheck == 0) { /* Do Nothing */ }
                else if (ZerooneCheck == 1) { /* Do Nothing */ }
                else if (ZerooneCheck == 2) { /* Do Nothing */ }
                else if (ZerooneCheck == 3) { /* Do Nothing */ }
                else if (ZerooneCheck == 4) { /* Do Nothing */ }

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

            for (int y = 0; y < BOARDY; y++)
            {
                
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (playBoard[y, x])
                    {
                        case -3:
                            // 포탈에 파란색을 부여한다.
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.Write("■".PadRight(2, ' '));
                            // 다시 하얀색으로 바꾼다.
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
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

            Console.ReadLine();
        } // GameBoardCoin()

        public void ClearCoin() 
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (playBoard[y, x] == 1)
                    {
                        playBoard[y, x] = -1;
                    }

                    else { /* Do Nothing */ }
                }
            }
        }

        // 포탈 재생성
        public void PotalSet()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //포탈 위치 취급 설정

                    if ((y == 4 && x == 9) || (y == 5 && x == 9))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 4 && x == 0) || (y == 5 && x == 0))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 0 && x == 4) || (y == 0 && x == 5))
                    {
                        playBoard[y, x] = -3;
                    }

                    if ((y == 9 && x == 4) || (y == 9 && x == 5))
                    {
                        playBoard[y, x] = -3;
                    }
                }
            }
        }


        // 포탈 닫기
        public void PotalDelete()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //포탈 위치 취급 설정

                    if ((y == 4 && x == 9) || (y == 5 && x == 9))
                    {
                        playBoard[y, x] = -2;
                    }

                    if ((y == 4 && x == 0) || (y == 5 && x == 0))
                    {
                        playBoard[y, x] = -2;
                    }

                    if ((y == 0 && x == 4) || (y == 0 && x == 5))
                    {
                        playBoard[y, x] = -2;
                    }

                    if ((y == 9 && x == 4) || (y == 9 && x == 5))
                    {
                        playBoard[y, x] = -2;
                    }
                }
            }
        }

        //! 로딩 화면처럼 보이는 함수
        public void Loading()
        {
            string[] loading = new string[10] {"□", "□" , "□" , "□" , "□" ,
                "□" , "□" , "□"  , "□" , "□" };

            

            for (int i = 0; i < loading.Length; i++)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("==============================");

                Console.WriteLine();

                Console.WriteLine("[System] 포탈 게임을\n".PadLeft(21, ' ')+
                    "로딩하고 있습니다.".PadLeft(17, ' '));
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("==============================");
                Console.WriteLine();


                foreach (string Value in loading)
                {
                    Console.Write("{0} ", Value);
                }
                Task.Delay(300).Wait();

                Console.Clear();

                loading[i] = "■";
            }
        }


    }

    
}
