using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Minegame
    {
        public static void Main()
        {
            /**
             * 지뢰 찾기
             * 10 x 10 보드에 지뢰를 숨김(n% 확률로 지뢰 매설)
             * debug mode 에서 지뢰가 아닌 곳은 .(닷), 지뢰인 곳은 #(샵)으로 표현
             * play mode 에서 확인 되지 않은 곳은 전부 □(스퀘어)로 표현
             * 첫 턴에 지뢰를 밟으면 해당 칸에 지회를 지워 줌
             */

            Random randomMine = new Random(); // 난수 생성 함수
            const int MINE_PERCENTAGE = 30;  // 지뢰의 생성 확률 30을 위해 30 값 선언
            const int BOARD_SIZE_X = 10;   // 보드의 가로 크기
            const int BOARD_SIZE_Y = 10;   // 보드의 세로 크기

            bool isDebugMode = false;
            bool isGameOver = false;
            bool isPlayerWin = false;
            int playerTurnCnt = 0;

            /**
             * 10 x 10 보드에 지뢰 초기화 한다.
             * 
             * gameBoard 상태
             * 지뢰 : MINE_PERCENTAGE 미만의 값
             * 빈 칸 : MINE_PERCENTAGE 이상의 값
             * 
             * playBoard 상태
             * -2 : 지뢰 있음
             * -1 : 초기값
             *  n : 주변 9타일 이내에 지뢰 수(0일 경우 ■ 표기, 양수일 경우 정수 표시)
             *  
             *  mineCntBoard 상태
             *  -1 : 지뢰 있음
             *   n : 주변 9타일 이내에 지뢰 수
             */

            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] playBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] mineCntMap = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for(int x = 0; x < BOARD_SIZE_X; x++)
                {
                    gameBoard[y, x] = randomMine.Next(1, 100 + 1);
                    playBoard[y, x] = -1;

                    if (gameBoard[y, x] < MINE_PERCENTAGE)
                    {
                        mineCntMap[y, x] = -1;
                    } // if : 지뢰가 셋업된 경우
                    else
                    {
                        mineCntMap[y, x] = 0;
                    } // else : 지뢰가 없는 경우
                }
            } // loop : 지뢰를 초기화 하는 루프

            // 게임 시작
            while(isGameOver == false)
            {
                // { 현재 보드의 상태를 플레이 시점으로 보여준다.
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch(playBoard[y, x])
                        {
                            case -2:
                                Console.Write("X".PadRight(3, ' '));
                                break;
                            case -1:
                                Console.Write("□".PadRight(2, ' '));
                                break;
                            case 0:
                                Console.Write("■".PadRight(2, ' '));
                                break;
                            default:
                                Console.Write("{0}".PadRight(5, ' '), playBoard[y, x]);
                                break;
                        } // switch
                    } // loop
                    Console.WriteLine();
                } // loop : 현재 보드의 상태를 출력하는 루프
                Console.WriteLine();
                // } 현재 보드의 상태를 플레이 시점으로 보여준다.


                int playerX = 0;
                int playerY = 0;
                bool isLocationValid = false;
                // { 플레이어 좌표 입력
                while(isLocationValid == false)
                {
                    Console.Write("[플레이어] x 좌표 입력 : ");
                    int.TryParse(Console.ReadLine(), out playerX);

                    Console.Write("[플레이어] y 좌표 입력 : ");
                    int.TryParse(Console.ReadLine(), out playerY);

                    // 플레이어가 입력한 좌표의 유효성을 검사한다.
                    isLocationValid =
                        (0 <= playerX && playerX < BOARD_SIZE_X) &&
                        (0 <= playerY && playerY < BOARD_SIZE_Y);

                    if (isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 유효하지 않습니다.",
                            "다른 좌표를 입력하세요. \n");
                        continue;
                    } // if : 좌표를 잘못 입력한 경우

                    // 좌표를 제대로 입력한 경우만 이 아래로 코드가 진행됨.
                    // 왜냐면 유효하지 않은 경우 위에서 continue 만나기 때문에


                    // 플레이 보드에서 선택 가능한지 검사한다.
                    isLocationValid = isLocationValid && playBoard[playerY, playerX].Equals(-1);

                    if(isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 이미 오픈되었습니다.",
                            "다른 좌표를 입력하세요.");
                        continue;
                    } // if : 오픈된 좌표를 선택한 경우

                    // 좌표를 제대로 입력한 경우만 이 아래로 코드가 진행됨.
                    // 왜냐면 유효하지 않은 경우 위에서 continue 만나기 때문에

                } // loop
                playerTurnCnt++;

                // } 플레이어 좌표 입력


                // 현재 첫 턴이라면 해당 좌표에 지뢰가 있어도 지워준다.
                if (playerTurnCnt.Equals(1))
                {
                    gameBoard[playerY, playerX] = MINE_PERCENTAGE + 1;
                    mineCntMap[playerY, playerX] = 0;
                    playBoard[playerY, playerX] = -1;

                    // { 지뢰의 수를 세어서 지도를 생성한다.
                    for(int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            // 지뢰가 없는 곳은 넘어간다.
                            if (mineCntMap[y, x].Equals(-1) == false) { continue; }

                            // 지뢰 주변 9타일에 수를 1씩 추가한다.
                            bool isSerachTileValid = false;
                            for (int searchY = y - 1; searchY <= y + 1; searchY++)
                            {
                                for (int serachX = x - 1; serachX <= x + 1; serachX++)
                                {
                                    // 유효하지 않은 좌표는 패스한다.
                                    isSerachTileValid =
                                        (0 <= serachX && serachX < BOARD_SIZE_X) &&
                                        (0 <= searchY && searchY < BOARD_SIZE_Y);
                                    if (isSerachTileValid == false) { continue; }
                                    // 9타일 서치 중에 지뢰가 있다면 패스한다.
                                    if (mineCntMap[searchY, serachX].Equals(-1)) { continue; }

                                    mineCntMap[searchY, serachX]++;


                                }
                            } // loop : 지뢰 주변 9타일을 순회하는 루프
                        }

                    } // loop : 게임 보드를 순회하는 루프

                    // } 지뢰의 수를 세어서 지도를 생성한다.


                } // if : 첫 턴인 경우

                // { 선택한 좌표에서 지뢰를 검사한다.
                if (gameBoard[playerY, playerX] < MINE_PERCENTAGE)
                {
                    isGameOver = true;
                    isPlayerWin = false;
                    playBoard[playerY, playerX] = -2;
                } // if : 지뢰를 선택한 경우
                else
                {

                } // else : 지뢰가 아닌, 빈 타일을 선택한 경우


                // } 선택한 좌표에서 지뢰를 검사한다.



            } // loop : 게임 루프


        }
    }
}
