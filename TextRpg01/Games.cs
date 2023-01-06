using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg01
{
    
    public class Games
    {
        public const int BOARDX = 31;
        public const int BOARDY = 31;
        public int[,] gameboard = new int[BOARDX, BOARDY];

        public bool isGameOver;
        public bool TitleCheck;
        public bool OccupationCheck;
        public bool StatusCheck;
        public bool ChoiceCheck;


        public int ArrowY;
        public int ArrowX;
        public int CheckStack = 0;

        public string PlayerOccupation = string.Empty;

        public int[] StatusValues = new int[6];

        
        public Games()
        {
            
            GameSet();
            GamePlay();
        }

        public void GameSet()
        {
            for(int y = 0; y < BOARDY; y++)
            {
                for(int x = 0; x < BOARDX; x++)
                {
                    
                    if (x == 1)
                    {
                        gameboard[y, x] = -1;

                    }

                    
                    // 테두리
                    if (x == 0 || x == 30 || y == 0 || y == 30)
                    {
                        gameboard[y, x] = -2;

                    }


                    // 제목 좌표
                    if (x == 1 && y == 8)
                    {
                        gameboard[y, x] = -3;

                    }

                    

                    // 시작하기 좌표
                    if (x == 1 && y == 22)
                    {
                        gameboard[y, x] = 2;

                    }

                    if (x==2 && y == 22)
                    {
                        gameboard[y, x] = -5;

                    }




                    // 종료하기 좌표
                    if (x == 1 && y == 24)
                    {
                        gameboard[y, x] = 3;

                    }

                    if (x == 2 && y == 24)
                    {
                        gameboard[y, x] = -6;

                    }

                    
                }
            }

           
        }   // GameSet()


        public void GamePlay()
        {
            isGameOver = false;
            TitleCheck = false;
            OccupationCheck = false;
            StatusCheck = false;


            while (isGameOver == false)
            {
                //while (TitleCheck == false)
                //{
                //    Console.Clear();

                //    Title();


                //}
                //if (isGameOver == true)
                //{
                //    break;
                //}

                //// 직업 선택 좌표 설정
                //OccupationSet();

                //// 직업 선택
                //while (OccupationCheck == false)
                //{
                //    Console.Clear();

                //    Occupation();
                //}

                //// 스탯 선택 좌표 설정

                //StatusSet();

                //while (StatusCheck == false)
                //{
                //    Console.Clear();

                //    Status();
                //}

                //// 마을, 모험, 아이템, 끝내기 선택지
                //ChoiceActSet();

                //while (ChoiceCheck == false)
                //{
                //    Console.Clear();

                //    ChoiceAct();

                //}


                // 마을 구현
                VillageSet();

                while (true)
                {
                    Console.Clear();


                    Village();
                }

                Console.ReadLine();
            }


        } // GamePlay()


        

        // 타이틀 화면 구현 함수
        public void Title()
        {
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (gameboard[y, x])
                    {

                        case -6:
                            Console.Write("종료 하기".PadLeft(8, ' ') + "".PadRight(38, ' '));

                            break;
                        case -5:
                            Console.Write("시작 하기".PadLeft(8, ' ') + "".PadRight(38, ' '));
                            break;
                        case -3:
                            Console.Write("[제목 테스트]".PadLeft(45, ' ') + "".PadRight(37, ' '));
                            break;

                        case -2:
                            Console.Write("■".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write("".PadLeft(87, ' '));
                            break;

                        case 2:
                            Console.Write("▶".PadLeft(36, ' '));
                            break;
                        case 3:
                            Console.Write(" ".PadLeft(37, ' '));
                            break;


                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            ConsoleKeyInfo Move;

            Move = Console.ReadKey();

            switch (Move.Key)
            {
                case ConsoleKey.W:
                    gameboard[22, 1] = 2;
                    gameboard[24, 1] = 3;

                    break;

                case ConsoleKey.S:
                    gameboard[22, 1] = 3;
                    gameboard[24, 1] = 2;

                    break;

                case ConsoleKey.UpArrow:
                    gameboard[22, 1] = 2;
                    gameboard[24, 1] = 3;

                    break;
                case ConsoleKey.DownArrow:
                    gameboard[22, 1] = 3;
                    gameboard[24, 1] = 2;

                    break;

                default:

                    if (gameboard[22, 1] == 2)
                    {
                        // 게임 시작
                        TitleCheck = true;
                    }
                    else
                    {
                        // 게임 종료
                        TitleCheck = true;
                        isGameOver = true;
                    }
                    break;

            }
        }


        // 직업 선택 좌표 구현

        public void OccupationSet()
        {
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    gameboard[y, x] = 0;

                    if (x == 1)
                    {
                        gameboard[y, x] = -1;

                    }


                    // 테두리
                    if (x == 0 || x == 30 || y == 0 || y == 30)
                    {
                        gameboard[y, x] = -2;

                    }


                    // 제목 좌표
                    if (x == 1 && y == 8)
                    {
                        gameboard[y, x] = -3;

                    }

                    // 화살표 좌표
                    if (x == 1 && y == 12)
                    {
                        gameboard[y, x] = 2;

                    }

                    // 선택지 앞 공백 좌표
                    if ((x == 1 && y == 16) || (x == 1 && y == 20) || (x == 1 && y == 24))
                    {
                        gameboard[y, x] = 3;

                    }

                    // 전사 좌표
                    if (x == 2 && y == 12)
                    {
                        gameboard[y, x] = 4;

                    }


                    // 마법사 좌표
                    if (x == 2 && y == 16)
                    {
                        gameboard[y, x] = 5;

                    }


                    // 도적 좌표
                    if (x == 2 && y == 20)
                    {
                        gameboard[y, x] = 6;

                    }

                    // 랜덤 선택 좌표
                    if (x == 2 && y == 24)
                    {
                        gameboard[y, x] = 7;

                    }


                }
            }

            // 화살표 좌표 저장
            ArrowY = 12;
            ArrowX = 1;

        } // OccupationSet()

        // 직업 선택 구현 함수
        public void Occupation()
        {
            
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (gameboard[y, x])
                    {

                        case -3:
                            Console.Write("[직업을 선택해주세요]".PadLeft(45, ' ') + "".PadRight(33, ' '));
                            break;

                        case -2:
                            Console.Write("■".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write("".PadLeft(87, ' '));
                            break;

                        case 2:
                            Console.Write("▶".PadLeft(34, ' '));
                            break;
                        case 3:
                            Console.Write(" ".PadLeft(35, ' '));
                            break;
                        case 4:
                            Console.Write("전사".PadLeft(8, ' ') + "".PadRight(42, ' '));
                            break;
                        case 5:
                            Console.Write("마법사".PadLeft(8, ' ') + "".PadRight(41, ' '));
                            break;
                        case 6:
                            Console.Write("도적".PadLeft(8, ' ') + "".PadRight(42, ' '));
                            break;
                        case 7:
                            Console.Write("랜덤 선택".PadLeft(8, ' ') + "".PadRight(40, ' '));
                            break;

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            ConsoleKeyInfo Move;

            Move = Console.ReadKey();

            switch (Move.Key)
            {
                case ConsoleKey.W:
                    if (gameboard[12, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY -= 4;
                        gameboard[ArrowY, 1] = 2;
                    }

                    break;

                case ConsoleKey.S:
                    
                    if (gameboard[24, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY += 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (gameboard[12, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY -= 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (gameboard[24, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY += 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;

                default:

                    if (gameboard[12, 1] == 2)
                    {
                        // 전사 선택
                        PlayerOccupation = "전사";
                        OccupationCheck = true;

                    }
                    else if (gameboard[16, 1] == 2)
                    {
                        // 마법사 선택
                        PlayerOccupation = "마법사";
                        OccupationCheck = true;


                    }
                    else if (gameboard[20, 1] == 2)
                    {
                        // 도적 선택
                        PlayerOccupation = "도적";
                        OccupationCheck = true;


                    }
                    else
                    {
                        // 랜덤 선택
                        Random random = new Random();

                        int RandomOcc = random.Next(1, 3 + 1);

                        switch (RandomOcc)
                        {
                            case 1:
                                PlayerOccupation = "전사";
                                break;
                            case 2:
                                PlayerOccupation = "마법사";
                                break;
                            case 3:
                                PlayerOccupation = "도적";
                                break;
                        }
                        OccupationCheck = true;

                    }
                    break;

            }



        } // Occupation()

        // 스탯 선택 좌표 구현
        public void StatusSet()
        {
            StatusValues = new int[7] { 5, 5, 5, 5, 5, 5, 10 };

            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    gameboard[y, x] = 0;

                    if (x == 1)
                    {
                        gameboard[y, x] = -1;

                    }


                    // 테두리
                    if (x == 0 || x == 30 || y == 0 || y == 30)
                    {
                        gameboard[y, x] = -2;

                    }


                    // 제목 좌표
                    if (x == 1 && y == 8)
                    {
                        gameboard[y, x] = -3;

                    }

                    // 왼쪽 화살표 좌표
                    if (x == 1 && y == 12)
                    {
                        gameboard[y, x] = 2;

                    }



                    // 스탯 앞 공백 좌표

                    if (x == 1 && y == 15)
                    {
                        gameboard[y, x] = 5;
                    }
                    if (x == 1 && y == 18)
                    {
                        gameboard[y, x] = 5;

                    }


                    // 스탯 오른쪽 공백 좌표
                    if ((x == 3 && y == 12) || (x == 3 && y == 15) || (x == 3 && y == 18))
                    {
                        gameboard[y, x] = -5;

                    }

                    // 남은 스탯 및 랜덤 선택 앞 공백 좌표

                    if ((x == 1 && y == 21) || (x == 1 && y == 24) || (x == 1 && y == 27))
                    {
                        gameboard[y, x] = 3;

                    }

                    // 스탯 좌표 

                    // 힘 좌표
                    if (x == 2 && y == 12)
                    {
                        gameboard[y, x] = 6;

                    }

                    // 체력 좌표
                    if (x == 4 && y == 12)
                    {
                        gameboard[y, x] = 7;

                    }

                    // 마법 좌표
                    if (x == 2 && y == 15)
                    {
                        gameboard[y, x] = 8;

                    }

                    // 지혜 좌표
                    if (x == 4 && y == 15)
                    {
                        gameboard[y, x] = 9;

                    }

                    // 행운 좌표
                    if (x == 2 && y == 18)
                    {
                        gameboard[y, x] = 10;

                    }

                    // 회피 좌표
                    if (x == 4 && y == 18)
                    {
                        gameboard[y, x] = 11;

                    }

                    // 남은 스탯 표기 좌표
                    if (x == 2 && y == 21)
                    {
                        gameboard[y, x] = 12;

                    }


                    // 랜덤 선택 좌표
                    if (x == 2 && y == 24)
                    {
                        gameboard[y, x] = 13;

                    }

                    // 스텟 초기화 좌표
                    if (x == 2 && y == 27)
                    {
                        gameboard[y, x] = 14;

                    }


                }
            }

            // 화살표 좌표 저장
            ArrowY = 12;
            ArrowX = 1;

            
        } // StatusSet()

        // 스탯 선택 구현 함수
        public void Status()
        {
                       
            
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (gameboard[y, x])
                    {

                        case -3:
                            Console.Write("[스텟을 입력해주세요]".PadLeft(45, ' ') + "".PadRight(33, ' '));
                            break;

                        case -2:
                            Console.Write("■".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write("".PadLeft(87, ' '));
                            break;

                        case 2:
                            Console.Write("▶".PadLeft(29, ' '));
                            break;
                        case 3:
                            Console.Write(" ".PadLeft(35, ' '));
                            break;

                        // 오른쪽 스탯 화살표
                        case 4:
                            Console.Write("▶".PadLeft(9, ' '));
                            break;
                        case 5:
                            Console.Write("".PadLeft(30, ' '));
                            break;
                        case -5:
                            Console.Write("".PadLeft(10, ' '));
                            break;
                        case 6:
                            if(10 <= StatusValues[0])
                            {
                                Console.Write("힘 : {0}".PadLeft(9, ' '), StatusValues[0]);
                            }
                            else
                            {
                                Console.Write("힘 : {0}".PadLeft(10, ' '), StatusValues[0]);

                            }
                            break;
                        case 7:
                            if(10 <= StatusValues[1])
                            {
                                Console.Write("체력 : ".PadLeft(6, ' ') + "{0}".PadRight(31, ' '), StatusValues[1]);

                            }
                            else
                            {
                                Console.Write("체력 : ".PadLeft(6, ' ')+"{0}".PadRight(32, ' '), StatusValues[1]);
                            }
                            break;
                        case 8:
                            if (10 <= StatusValues[2])
                            {
                                Console.Write(" 마법 : {0}".PadLeft(9, ' '), StatusValues[2]);

                            }
                            else
                            {
                                Console.Write(" 마법 : {0}".PadLeft(10, ' '), StatusValues[2]);

                            }
                            break;
                        case 9:
                            if(10 <= StatusValues[3])
                            {
                                Console.Write("지혜 : {0}".PadRight(36, ' '), StatusValues[3]);
                                                                
                            }
                            else
                            {
                                Console.Write("지혜 : {0}".PadRight(37, ' '), StatusValues[3]);
                            }
                            break;
                        case 10:
                            if (10 <= StatusValues[4])
                            {
                                Console.Write("행운 : {0}".PadLeft(9, ' '), StatusValues[4]);

                            }
                            else
                            {
                                Console.Write("행운 : {0}".PadLeft(10, ' '), StatusValues[4]);

                            }

                            break;
                        case 11:
                            if(10 <= StatusValues[5] )
                            {
                                Console.Write("회피 : {0}".PadRight(36, ' '), StatusValues[5]);

                                
                            }
                            else
                            {
                                Console.Write("회피 : {0}".PadRight(37, ' '), StatusValues[5]);

                            }
                            break;
                        case 12:
                            if (StatusValues[6] < 10)
                            {
                                Console.Write("남은 스탯 : {0}".PadLeft(13, ' ') + "".PadRight(37, ' '), StatusValues[6]);

                            }
                            else
                            {
                                Console.Write("남은 스탯 : {0}".PadLeft(13, ' ') + "".PadRight(36, ' '), StatusValues[6]);
                            }
                            break;

                        case 13:
                            Console.Write("랜덤 선택".PadLeft(9, ' ') + "".PadRight(39, ' '));
                            break;
                        case 14:
                            Console.Write("초기화".PadLeft(8, ' ') + "".PadRight(41, ' '));
                            break;
                        case 15:
                            Console.Write("▶".PadLeft(34, ' '));
                            break;
                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            ConsoleKeyInfo Move;

            Move = Console.ReadKey();

            switch (Move.Key)
            {
                case ConsoleKey.W:
                    if (ArrowY == 12) { /* Do Nothing */ }
                    else
                    {
                        if (ArrowX == 1)
                        {
                            if (ArrowY < 21)
                            {
                                                                
                                gameboard[ArrowY, 1] = 5;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 2;

                            }

                            else if (ArrowY == 21)
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 2;
                            }
                            else
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 15;
                            }

                        }

                        else
                        {
                            gameboard[ArrowY, ArrowX] = -5;

                            ArrowY -= 3;
                            gameboard[ArrowY, ArrowX] = 4;
                            
                        }
                    }

                    break;
                case ConsoleKey.A:
                    if(ArrowX == 1) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -5;

                        ArrowX -= 2;
                        gameboard[ArrowY, ArrowX] = 2;
                    }
                    break;

                case ConsoleKey.S:
                    if (ArrowY == 27) { /* Do Nothing */ }
                    else
                    {
                        if (ArrowX == 1)
                        {
                            if ( ArrowY < 18)
                            {
                                gameboard[ArrowY, 1] = 5;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 2;

                            }

                            else if (ArrowY == 18)
                            {
                                gameboard[ArrowY, 1] = 5;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 15;
                            }
                            else
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 15;
                            }

                        }

                        else
                        {
                            if (ArrowY == 18)
                            {
                                gameboard[ArrowY, ArrowX] = -5;
                                ArrowY += 3;
                                ArrowX -= 2;
                                gameboard[ArrowY, ArrowX] = 15;
                            }
                            else
                            {
                                gameboard[ArrowY, ArrowX] = -5;

                                ArrowY += 3;
                                gameboard[ArrowY, ArrowX] = 4;
                            }
                        }
                    }


                    break;
                case ConsoleKey.D:
                    if (ArrowX == 3) { /* Do Nothing */ }
                    else
                    {
                        if (21 <= ArrowY) { /* Do Nothing */ }
                        else
                        {

                            gameboard[ArrowY, ArrowX] = 5;

                            ArrowX += 2;
                            gameboard[ArrowY, ArrowX] = 4;
                        }
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (ArrowY == 12) { /* Do Nothing */ }
                    else
                    {
                        if (ArrowX == 1)
                        {
                            if (ArrowY < 21)
                            {
                                gameboard[ArrowY, 1] = 5;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 2;

                            }

                            else if (ArrowY == 21)
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 2;
                            }
                            else
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY -= 3;
                                gameboard[ArrowY, 1] = 15;
                            }

                        }

                        else
                        {
                            gameboard[ArrowY, ArrowX] = -5;

                            ArrowY -= 3;
                            gameboard[ArrowY, ArrowX] = 4;

                        }
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (ArrowX == 1) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -5;

                        ArrowX -= 2;
                        gameboard[ArrowY, ArrowX] = 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (ArrowY == 27) { /* Do Nothing */ }
                    else
                    {
                        if (ArrowX == 1)
                        {
                            if (ArrowY < 18)
                            {
                                gameboard[ArrowY, 1] = 5;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 2;

                            }

                            else if (ArrowY == 18)
                            {
                                gameboard[ArrowY, 1] = 5;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 15;
                            }
                            else
                            {
                                gameboard[ArrowY, 1] = 3;
                                ArrowY += 3;
                                gameboard[ArrowY, 1] = 15;
                            }

                        }

                        else
                        {
                            if (ArrowY == 18)
                            {
                                gameboard[ArrowY, ArrowX] = -5;
                                ArrowY += 3;
                                ArrowX -= 2;
                                gameboard[ArrowY, ArrowX] = 15;
                            }
                            else
                            {
                                gameboard[ArrowY, ArrowX] = -5;

                                ArrowY += 3;
                                gameboard[ArrowY, ArrowX] = 4;
                            }
                        }
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (ArrowX == 3) { /* Do Nothing */ }
                    else
                    {
                        if (21 <= ArrowY) { /* Do Nothing */ }
                        else
                        {

                            gameboard[ArrowY, ArrowX] = 5;

                            ArrowX += 2;
                            gameboard[ArrowY, ArrowX] = 4;
                        }
                    }
                    break;
                default:

                    if (gameboard[12, 1] == 2)
                    {
                        // 힘 스텟 선택
                        StatusValues[0]++;
                        CheckStack++;
                        StatusValues[6]--;
                    }
                    else if (gameboard[12, 3] == 4)
                    {
                        // 체력 선택
                        StatusValues[1]++;
                        CheckStack++;
                        StatusValues[6]--;


                    }
                    else if (gameboard[15, 1] == 2)
                    {
                        // 마법 선택
                        StatusValues[2]++;
                        CheckStack++;
                        StatusValues[6]--;

                    }
                    else if (gameboard[15, 3] == 4)
                    {
                        // 지혜 선택
                        StatusValues[3]++;
                        CheckStack++;
                        StatusValues[6]--;

                    }
                    else if (gameboard[18, 1] == 2)
                    {
                        // 행운 선택
                        StatusValues[4]++;
                        CheckStack++;
                        StatusValues[6]--;

                    }
                    else if (gameboard[18, 3] == 4)
                    {
                        // 회피 선택
                        StatusValues[5]++;
                        CheckStack++;
                        StatusValues[6]--;

                    }

                    else if (gameboard[20, 1] == 2)
                    {
                        // 도적 선택
                        PlayerOccupation = "도적";
                        OccupationCheck = true;


                    }
                    // 랜덤 선택
                    else if (gameboard[24, 1] == 15)
                    {
                        // 랜덤 선택
                        Random random = new Random();

                       
                        for (int i = 0; i < 10; i++)
                        {
                            int RandomOcc = random.Next(1, 6 + 1);
                            switch (RandomOcc)
                            {
                                case 1:
                                    StatusValues[0]++;
                                    break;
                                case 2:
                                    StatusValues[1]++;
                                    break;
                                case 3:
                                    StatusValues[2]++;
                                    break;
                                case 4:
                                    StatusValues[3]++;
                                    break;
                                case 5:
                                    StatusValues[4]++;
                                    break;
                                case 6:
                                    StatusValues[5]++;
                                    break;
                            }
                        }
                        StatusCheck = true;
                    }
                    // 초기화
                    else if (gameboard[27, 1] == 15)
                    {
                        CheckStack = 0;
                        StatusSet();
                    }
                    break;

            }

            if (CheckStack == 10)
            {
                StatusCheck = true;
            }

        } // Status()

        // 다음 행동 선택 좌표 구현
        public void ChoiceActSet()
        {

            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    gameboard[y, x] = 0;

                    if (x == 1)
                    {
                        gameboard[y, x] = -1;

                    }


                    // 테두리
                    if (x == 0 || x == 30 || y == 0 || y == 30)
                    {
                        gameboard[y, x] = -2;

                    }


                    // 제목 좌표
                    if (x == 1 && y == 8)
                    {
                        gameboard[y, x] = -3;

                    }

                    // 화살표 좌표
                    if (x == 1 && y == 12)
                    {
                        gameboard[y, x] = 2;

                    }

                    // 선택지 앞 공백 좌표
                    if ((x == 1 && y == 16) || (x == 1 && y == 20) || (x == 1 && y == 24))
                    {
                        gameboard[y, x] = 3;

                    }

                    // 마을 좌표
                    if (x == 2 && y == 12)
                    {
                        gameboard[y, x] = 4;

                    }


                    // 모험 좌표
                    if (x == 2 && y == 16)
                    {
                        gameboard[y, x] = 5;

                    }


                    // 아이템 좌표
                    if (x == 2 && y == 20)
                    {
                        gameboard[y, x] = 6;

                    }

                    // 끝내기 좌표
                    if (x == 2 && y == 24)
                    {
                        gameboard[y, x] = 7;

                    }


                }
            }

            // 화살표 좌표 저장
            ArrowY = 12;
            ArrowX = 1;



        } // ChoiceActSet()

        // 다음 행동 선택 구현
        public void ChoiceAct()
        {
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (gameboard[y, x])
                    {

                        case -3:
                            Console.Write("[다음 행동을 선택해주세요]".PadLeft(45, ' ') + "".PadRight(31, ' '));
                            break;

                        case -2:
                            Console.Write("■".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write("".PadLeft(87, ' '));
                            break;

                        case 2:
                            Console.Write("▶".PadLeft(34, ' '));
                            break;
                        case 3:
                            Console.Write(" ".PadLeft(35, ' '));
                            break;
                        case 4:
                            Console.Write("마을로 항하기".PadLeft(9, ' ') + "".PadRight(37, ' '));
                            break;
                        case 5:
                            Console.Write("모험 떠나기".PadLeft(9, ' ') + "".PadRight(38, ' '));
                            break;
                        case 6:
                            Console.Write("아이템 확인하기".PadLeft(9, ' ') + "".PadRight(36, ' '));
                            break;
                        case 7:
                            Console.Write("종료하기".PadLeft(8, ' ') + "".PadRight(40, ' '));
                            break;

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            ConsoleKeyInfo Move;

            Move = Console.ReadKey();

            switch (Move.Key)
            {
                case ConsoleKey.W:
                    if (gameboard[12, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY -= 4;
                        gameboard[ArrowY, 1] = 2;
                    }

                    break;

                case ConsoleKey.S:

                    if (gameboard[24, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY += 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (gameboard[12, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY -= 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (gameboard[24, 1] == 2) { /* Do Nothing */ }
                    else
                    {
                        gameboard[ArrowY, 1] = 3;

                        ArrowY += 4;
                        gameboard[ArrowY, 1] = 2;
                    }
                    break;

                default:

                    if (gameboard[12, 1] == 2)
                    {
                        // 마을로 떠나기


                    }
                    else if (gameboard[16, 1] == 2)
                    {
                        // 모험 떠나기



                    }
                    else if (gameboard[20, 1] == 2)
                    {
                        // 아이템 확인하기


                    }
                    else
                    {
                        // 게임 종료
                        ChoiceCheck = true;
                        isGameOver = true;

                    }
                    break;

            }
        } // ChoiceAct()


        // 마을 좌표 구현
        public void VillageSet()
        {
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    gameboard[y, x] = -1;

                    


                    // 테두리
                    if (x == 0 || x == 30 || y == 0 || y == 30)
                    {
                        gameboard[y, x] = -2;

                    }

                    // 플레이어 좌표
                    if (x == 16 && y == 24)
                    {
                        gameboard[y, x] = 2;

                    }


                    if (y == 25)
                    {
                        gameboard[y, x] = -2;
                    }

                    


                }
            }

            int e = 0;
            foreach(int s in gameboard)
            {
                Console.Write($"{s}");
                e++;
                if(e % 31 == 0)
                {
                    Console.WriteLine();
                }
            }


            ArrowY = 24;
            ArrowX = 16;

        } //  VillageSet()

        // 마을 좌표 구현
        public void Village()
        {
            for (int y = 0; y < BOARDY; y++)
            {
                for (int x = 0; x < BOARDX; x++)
                {
                    switch (gameboard[y, x])
                    {

                        

                        case -2:
                            Console.Write("■".PadRight(2, ' '));
                            break;

                        case -1:
                            Console.Write("□".PadRight(2, ' '));
                            break;

                        case 2:
                            Console.Write("◎".PadRight(2, ' '));
                            break;

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            ConsoleKeyInfo Move;

            Move = Console.ReadKey();

            switch (Move.Key)
            {
                case ConsoleKey.W:
                    if (ArrowY == 1) { }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -1;
                        ArrowY--;
                        gameboard[ArrowY, ArrowX] = 2;
                    }

                    break;
                case ConsoleKey.A:
                    if (ArrowX == 1) { }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -1;
                        ArrowX--;
                        gameboard[ArrowY, ArrowX] = 2;
                    }
                    break;

                case ConsoleKey.S:

                    if (ArrowY == 24) { }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -1;
                        ArrowY++;
                        gameboard[ArrowY, ArrowX] = 2;
                    }
                    break;

                case ConsoleKey.D:
                    if (ArrowX == 29) { }
                    else
                    {
                        gameboard[ArrowY, ArrowX] = -1;
                        ArrowX++;
                        gameboard[ArrowY, ArrowX] = 2;
                    }
                    break;

                //case ConsoleKey.UpArrow:
                //    if (gameboard[12, 1] == 2) { /* Do Nothing */ }
                //    else
                //    {
                //        gameboard[ArrowY, 1] = 3;

                //        ArrowY -= 4;
                //        gameboard[ArrowY, 1] = 2;
                //    }
                //    break;
                //case ConsoleKey.DownArrow:
                //    if (gameboard[24, 1] == 2) { /* Do Nothing */ }
                //    else
                //    {
                //        gameboard[ArrowY, 1] = 3;

                //        ArrowY += 4;
                //        gameboard[ArrowY, 1] = 2;
                //    }
                //    break;

                default:

                    if (gameboard[12, 1] == 2)
                    {
                        // 마을로 떠나기


                    }
                    else if (gameboard[16, 1] == 2)
                    {
                        // 모험 떠나기



                    }
                    else if (gameboard[20, 1] == 2)
                    {
                        // 아이템 확인하기


                    }
                    else
                    {
                        // 게임 종료
                        ChoiceCheck = true;
                        isGameOver = true;

                    }
                    break;

            }

        }


    } // class Games
}
