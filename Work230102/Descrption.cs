using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work230102
{
    public class Descrption
    {

    } // class Descrption




    public class TrumpCard
    {
        /**
         * 1~10 K, Q, J -> 13개(하트, 다이아몬드, 스페이드, 클로버)
         * 13 * 4 -> 52개의 카드가 있음.
         * 
         * 1~13 하트
         * 14~26
         */

        private int[] trumpCardSet; // 내가 사용할 카드 세트
        private string[] trumpCardMark; // 트럼프 카드의 마크

       

        public void SetupTrumpCards()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
            } // loop 카드를 셋업하는 루프

            //trump카드의 마크 셋업
            trumpCardMark = new string[4] { "♣", "♥", "◆", "♠" };
        } // SetupTrumpCards()

        //! 카드를 섞는 함수
        public void ShuffleCards()
        {
            ShuffleCards(200);
        }// ShuffleCards()


        //! 한장의 카드를 뽑아서 보여주는 함수
        public int RollCard(int ComPLay)
        {

            int cardVal = 0;
            int card = trumpCardSet[ComPLay];

            string cardMark = trumpCardMark[(card - 1) / 13];
            string cardNumber = Math.Ceiling(card % 13.1).ToString();

            cardVal = (int)Math.Ceiling(card % 13.1);


            switch (cardNumber)
            {
                case "11":
                    cardNumber = "J";
                    break;
                case "12":
                    cardNumber = "Q";
                    break;
                case "13":
                    cardNumber = "k";
                    break;
                default:
                    /* Do Nothing*/
                    break;

            } // switch


            Console.WriteLine(" ----");
            Console.WriteLine("|{0}{1} |", cardMark, cardNumber);
            Console.WriteLine("|    |");
            Console.WriteLine("| {0}{1}|", cardNumber, cardMark);
            Console.WriteLine(" ----");
            Console.WriteLine("뽑은 카드는 {0}{1} 입니다.", cardMark, cardNumber);

            return card;

        }// RollCard()


        //! 한장의 카드를 뽑아서 값을 가져오는 함수
        public int RollCardValAdd(int ComPLay)
        {

            int cardVal = 0;
            int card = trumpCardSet[ComPLay];

            string cardMark = trumpCardMark[(card - 1) / 13];
            string cardNumber = Math.Ceiling(card % 13.1).ToString();

            cardVal = (int)Math.Ceiling(card % 13.1);


            switch (cardNumber)
            {
                case "11":
                    cardNumber = "J";
                    break;
                case "12":
                    cardNumber = "Q";
                    break;
                case "13":
                    cardNumber = "k";
                    break;
                default:
                    /* Do Nothing*/
                    break;

            } // switch

            return card;

        }// RollCard()


        //! 컴퓨터가 2 장의 카드를 더 뽑아서 보여주는 함수
        public void RollCardTwo(int CardValue)
        {

            int[] card = new int[CardValue + 2];
            int[] cardVal = new int[CardValue + 2];
            string[] cardMark = new string[CardValue + 2];
            string[] cardNumber = new string[CardValue + 2];

            for (int i = CardValue; i < CardValue + 2; i++)
            {

                card[i] = trumpCardSet[i];

                cardMark[i] = trumpCardMark[(card[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(card[i] % 13.1).ToString();

                cardVal[i] = (int)Math.Ceiling(card[i] % 13.1);

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "k";
                        break;
                    default:
                        /* Do Nothing*/
                        break;

                } // switch
            }


            Console.WriteLine(" ----\t ----");
            Console.WriteLine("|{0}{1} |\t|{2}{3} |",
                cardMark[CardValue + 0], cardNumber[CardValue + 0], cardMark[CardValue + 1], cardNumber[CardValue + 1]);
            Console.WriteLine("|    |\t|    |");
            Console.WriteLine("| {0}{1}|\t| {2}{3}|",
                cardNumber[CardValue + 0], cardMark[CardValue + 0], cardNumber[CardValue + 1], cardMark[CardValue + 1]);
            Console.WriteLine(" ----\t ----");

            for (int i = CardValue; i < CardValue + 2; i++)
            {
                Console.WriteLine("뽑은 카드는 {0}{1} 입니다.", cardMark[i], cardNumber[i]);
                Console.WriteLine();
            }


        }// RollCard()


        //! 5 장의 카드를 뽑아서 보여주는 함수
        public void RollCardFive(int CardValue)
        {

            int[] card = new int[CardValue+5];
            //int[] cardVal = new int[CardValue+5];
            string[] cardMark = new string[CardValue+5];
            string[] cardNumber = new string[CardValue+5];

            for (int i = CardValue; i < CardValue + 5; i++)
            {

                card[i] = trumpCardSet[i];

                cardMark[i] = trumpCardMark[(card[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(card[i] % 13.1).ToString();

                //cardVal[i] = (int)Math.Ceiling(card[i] % 13.1);

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "k";
                        break;
                    default:
                        /* Do Nothing*/
                        break;

                } // switch
            }


            Console.WriteLine(" ----\t ----\t ----\t ----\t ----");
            Console.WriteLine("|{0}{1} |\t|{2}{3} |\t|{4}{5} |\t|{6}{7} |\t|{8}{9} |",
                cardMark[CardValue+0], cardNumber[CardValue + 0], cardMark[CardValue + 1], cardNumber[CardValue + 1], cardMark[CardValue + 2], cardNumber[CardValue + 2],
                cardMark[CardValue + 3], cardNumber[CardValue + 3], cardMark[CardValue + 4], cardNumber[CardValue + 4]);
            Console.WriteLine("|    |\t|    |\t|    |\t|    |\t|    |");
            Console.WriteLine("| {0}{1}|\t| {2}{3}|\t| {4}{5}|\t| {6}{7}|\t| {8}{9}|",
                cardNumber[CardValue + 0], cardMark[CardValue + 0], cardNumber[CardValue + 1], cardMark[CardValue + 1], cardNumber[CardValue + 2], cardMark[CardValue + 2],
                cardNumber[CardValue + 3], cardMark[CardValue + 3], cardNumber[CardValue + 4], cardMark[CardValue + 4]);
            Console.WriteLine(" ----\t ----\t ----\t ----\t ----");

            for (int i = CardValue; i < CardValue + 5; i++)
            {
                Console.WriteLine("뽑은 카드는 {0}{1} 입니다.", cardMark[i], cardNumber[i]);
                Console.WriteLine();
            }
            

        }// RollCard()

        //! 사용자의 변경된 카드를 보여주는 함수
        public void RollCardFivePlayer(int CardValue1, int CardValue2, int CardValue3,
            int CardValue4, int CardValue5)
        {

            int[] card = new int[5] { CardValue1, CardValue2, CardValue3, CardValue4, CardValue5 };
            int[] cardVal = new int[5];
            string[] cardMark = new string[5];
            string[] cardNumber = new string[5];

            for (int i = 0; i < 5; i++)
            {

                cardMark[i] = trumpCardMark[(card[i] - 1) / 13];
                cardNumber[i] = Math.Ceiling(card[i] % 13.1).ToString();

                cardVal[i] = (int)Math.Ceiling(card[i] % 13.1);

                switch (cardNumber[i])
                {
                    case "11":
                        cardNumber[i] = "J";
                        break;
                    case "12":
                        cardNumber[i] = "Q";
                        break;
                    case "13":
                        cardNumber[i] = "k";
                        break;
                    default:
                        /* Do Nothing*/
                        break;

                } // switch
            }


            Console.WriteLine(" ----\t ----\t ----\t ----\t ----");
            Console.WriteLine("|{0}{1} |\t|{2}{3} |\t|{4}{5} |\t|{6}{7} |\t|{8}{9} |",
                cardMark[0], cardNumber[0], cardMark[1], cardNumber[1], cardMark[2], cardNumber[2],
                cardMark[3], cardNumber[3], cardMark[4], cardNumber[4]);
            Console.WriteLine("|    |\t|    |\t|    |\t|    |\t|    |");
            Console.WriteLine("| {0}{1}|\t| {2}{3}|\t| {4}{5}|\t| {6}{7}|\t| {8}{9}|",
                cardNumber[0], cardMark[0], cardNumber[1], cardMark[1], cardNumber[2], cardMark[2],
                cardNumber[3], cardMark[3], cardNumber[4], cardMark[4]);
            Console.WriteLine(" ----\t ----\t ----\t ----\t ----");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("뽑은 카드는 {0}{1} 입니다.", cardMark[i], cardNumber[i]);
                Console.WriteLine();
            }


        }// RollCard()



        private void PrintCardSet()
        {
            foreach (int card in trumpCardSet)
            {
                Console.Write("{0} ", card);
            }
        }// PrintCardSet()


        //! 카드를 섞는 함수

        private void ShuffleCards(int howManyLoop)
        {
            for (int i = 0; i < howManyLoop; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);

            }
        } // ShuffleCards()


        //! 내부에서 사용하는 배열을 1번 섞는 함수
        private int[] ShuffleOnce(int[] intArray)
        {
            Random random = new Random();

            int sourIndex = random.Next(0, intArray.Length);
            int destIndex = random.Next(0, intArray.Length);

            int tempVarible = intArray[sourIndex];

            intArray[sourIndex] = intArray[destIndex];

            intArray[destIndex] = tempVarible;

            return intArray;
        } // ShuffleOnce()
    } // class TrumpCard


    public class TrumpGame
    {
        public TrumpGame()
        {
            GameStart();
        }

        public void GameStart()
        {
            int playerMoney = 10000;

            bool isGameOver = false;
            bool isCardChange = false;

            while (isGameOver == false)
            {
                // 컴퓨터가 뽑은 7장의 카드 값을 저장할 배열 선언
                int[] ComputerCards = new int[7];
                // 플레이어가 뽑은 5장의 카드 값을 저장할 배열 선언
                int[] playerCards = new int[5];
                int checkloopCard1 = 0;

                bool WinCheck = false;

                int batting = 0;
                int CheckPass = 0;

                // 트럼프 카드 인스턴트 화
                TrumpCard trumpCard = new TrumpCard();
                Console.WriteLine("======================================");

                Console.WriteLine("======================================");
                Console.WriteLine("카드 뽑기 게임".PadLeft(20, ' '));
                Console.WriteLine("======================================");

                Console.WriteLine("======================================");
                Console.WriteLine("[컴퓨터의 턴]".PadLeft(20, ' '));
                Console.WriteLine();

                // 컴퓨터가 뽑는 카드 5개
                trumpCard.SetupTrumpCards();
                trumpCard.ShuffleCards();

                trumpCard.RollCardFive(checkloopCard1);

                for (int i = 0; i < 5; i++)
                {
                    ComputerCards[i] = trumpCard.RollCardValAdd(checkloopCard1);
                    checkloopCard1++;
                }
                Console.WriteLine();


                Console.WriteLine("======================================");

                //foreach(int i in ComputerCards)
                //{
                //    Console.WriteLine("{0} ", i);
                //}


                Console.WriteLine("[플레이어의 턴]".PadLeft(20, ' '));
                Console.WriteLine();

                trumpCard.RollCardFive(checkloopCard1);

                for (int i = 0; i < 5; i++)
                {
                    playerCards[i] = trumpCard.RollCardValAdd(checkloopCard1);
                    checkloopCard1++;
                }

                

                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine();

                Console.WriteLine("현재 가지고 있는 포인트 : {0}", playerMoney);
                Console.WriteLine();


                Console.WriteLine("배팅 하시겠습니까?".PadLeft(18, ' '));
                Console.Write("(0과 숫자 의외 값을 입력시 패스) : ");
                int.TryParse(Console.ReadLine(), out batting);


                if (batting == 0)
                {

                    Console.WriteLine();
                    Console.WriteLine("======================================");
                    Console.WriteLine("[플레이어의 턴]".PadLeft(20, ' '));

                    Console.WriteLine();
                    Console.WriteLine("배팅을 패스 하셨습니다.");
                    Console.WriteLine("현재 가지고 있는 포인트는 {0} 입니다.", playerMoney);

                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("======================================");
                    Console.WriteLine("[컴퓨터의 턴]".PadLeft(20, ' '));
                    Console.WriteLine();

                    trumpCard.RollCardFive(checkloopCard1 - 10);
                    Console.WriteLine();
                    Console.WriteLine("추가로 2장 더 뽑았습니다.");

                    trumpCard.RollCardTwo(checkloopCard1);

                    for (int i = 0 + 5; i < 2 + 5; i++)
                    {
                        ComputerCards[i] = trumpCard.RollCardValAdd(checkloopCard1);
                        checkloopCard1++;
                    }



                    int ChangeCardLoop = 0;

                    while (isCardChange == false)
                    {
                        int ChangeCard = 0;
                        Console.WriteLine("======================================");

                        Console.WriteLine("[플레이어의 턴]".PadLeft(20, ' '));
                        Console.WriteLine();
                        trumpCard.RollCardFivePlayer(playerCards[0], playerCards[1], playerCards[2],
                            playerCards[3], playerCards[4]);


                        Console.WriteLine();

                        if (ChangeCardLoop == 2)
                        {
                            break;
                        }
                        else { /* Do Nothing */ }


                        Console.WriteLine("몇 번째 카드를 교체하시겠습니까? : ");
                        int.TryParse(Console.ReadLine(), out ChangeCard);

                        switch (ChangeCard)
                        {
                            case 0:
                                Console.WriteLine("[System] 패스했습니다.");
                                isCardChange = true;
                                break;
                            case 1:
                                playerCards[ChangeCard - 1] = trumpCard.RollCard(checkloopCard1);

                                checkloopCard1++;
                                ChangeCardLoop++;
                                break;
                            case 2:
                                playerCards[ChangeCard - 1] = trumpCard.RollCard(checkloopCard1);
                                checkloopCard1++;
                                ChangeCardLoop++;
                                break;
                            case 3:
                                playerCards[ChangeCard - 1] = trumpCard.RollCard(checkloopCard1);
                                checkloopCard1++;
                                ChangeCardLoop++;
                                break;
                            case 4:
                                playerCards[ChangeCard - 1] = trumpCard.RollCard(checkloopCard1);
                                checkloopCard1++;
                                ChangeCardLoop++;
                                break;
                            case 5:
                                playerCards[ChangeCard - 1] = trumpCard.RollCard(checkloopCard1);
                                checkloopCard1++;
                                ChangeCardLoop++;
                                break;
                            default:
                                Console.WriteLine("[System] 이상한 입력입니다. 다시 입력하세요.");
                                Console.ReadLine();
                                break;

                        }
                        Console.WriteLine();
                        Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("======================================");

                        Console.WriteLine("[컴퓨터의 턴]".PadLeft(20, ' '));
                        Console.WriteLine();

                        trumpCard.RollCardFive(0);
                        trumpCard.RollCardTwo(10);

                    }

                    Array.Sort(ComputerCards);
                    Array.Sort(playerCards);

                    int[] CheckComputer = new int[13];
                    int[] CheckPlayer = new int[13];



                    for (int i = 0; i < ComputerCards.Length; i++)
                    {
                        if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 1)
                        {
                            CheckComputer[0]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 2)
                        {
                            CheckComputer[1]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 3)
                        {
                            CheckComputer[2]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 4)
                        {
                            CheckComputer[3]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 5)
                        {
                            CheckComputer[4]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 6)
                        {
                            CheckComputer[5]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 7)
                        {
                            CheckComputer[6]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 8)
                        {
                            CheckComputer[7]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 9)
                        {
                            CheckComputer[8]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 10)
                        {
                            CheckComputer[9]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 11)
                        {
                            CheckComputer[10]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 12)
                        {
                            CheckComputer[11]++;
                        }
                        else if ((int)Math.Ceiling(ComputerCards[i] % 13.1) == 13)
                        {
                            CheckComputer[12]++;
                        }

                    }

                    for (int i = 0; i < playerCards.Length; i++)
                    {
                        if ((int)Math.Ceiling(playerCards[i] % 13.1) == 1)
                        {
                            CheckPlayer[0]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 2)
                        {
                            CheckPlayer[1]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 3)
                        {
                            CheckPlayer[2]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 4)
                        {
                            CheckPlayer[3]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 5)
                        {
                            CheckPlayer[4]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 6)
                        {
                            CheckPlayer[5]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 7)
                        {
                            CheckPlayer[6]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 8)
                        {
                            CheckPlayer[7]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 9)
                        {
                            CheckPlayer[8]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 10)
                        {
                            CheckPlayer[9]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 11)
                        {
                            CheckPlayer[10]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 12)
                        {
                            CheckPlayer[11]++;
                        }
                        else if ((int)Math.Ceiling(playerCards[i] % 13.1) == 13)
                        {
                            CheckPlayer[12]++;
                        }

                    }

                    int ComputerFour = 0;
                    int ComputerThree = 0;
                    int ComputerOne = 0;
                    int ComputerTwo = 0;
                    int Computerstraight = 0;
                    int ComputerNotpeir = 0;
                    int CheckCompTwoPeir = 0;
                    int straightCompCount = 0;


                    int PlayerFour = 0;
                    int PlayerThree = 0;
                    int PlayerOne = 0;
                    int PlayerTwo = 0;
                    int Playerstraight = 0;
                    int PlayerNotpeir = 0;

                    int CheckPlayTwoPeir = 0;
                    int straightplayCount = 0;


                    int[] Computerflush = new int[4];
                    int[] Playerflush = new int[4];

                    // 포카드, 트리플, 원페어, 투페어 등등 체크
                    for (int i = 0; i < CheckComputer.Length; i++)
                    {
                        if (CheckComputer[i] == 4)
                        {
                            ComputerFour = i + 1;

                        }
                        else if (CheckComputer[i] == 3)
                        {

                            ComputerThree = i + 1;
                        }
                        else if (CheckComputer[i] == 2)
                        {
                            ComputerOne = i + 1;
                            CheckCompTwoPeir++;

                            if (CheckCompTwoPeir == 2)
                            {
                                ComputerTwo = i + 1;
                            }

                        }
                        else
                        {
                            ComputerNotpeir = i + 1;
                        }
                    }


                    for (int i = 0; i < CheckPlayer.Length; i++)
                    {
                        if (CheckPlayer[i] == 4)
                        {
                            PlayerFour = i + 1;
                        }
                        else if (CheckPlayer[i] == 3)
                        {

                            PlayerThree = i + 1;
                        }
                        else if (CheckPlayer[i] == 2)
                        {
                            PlayerOne = i + 1;
                            CheckPlayTwoPeir++;

                            if (CheckPlayTwoPeir == 2)
                            {
                                PlayerTwo = i + 1;
                            }

                        }
                        else
                        {
                            PlayerNotpeir = i + 1;
                        }
                    }

                    // 플러쉬 체크기 


                    for (int i = 0; i < ComputerCards.Length; i++)
                    {
                        if (0 < ComputerCards[i] && ComputerCards[i] <= 13)
                        {
                            Computerflush[0]++;
                        }
                        else if (13 < ComputerCards[i] && ComputerCards[i] <= 26)
                        {
                            Computerflush[1]++;

                        }
                        else if (26 < ComputerCards[i] && ComputerCards[i] <= 39)
                        {
                            Computerflush[2]++;

                        }
                        else if (39 < ComputerCards[i] && ComputerCards[i] <= 52)
                        {
                            Computerflush[3]++;

                        }

                    }

                    for (int i = 0; i < playerCards.Length; i++)
                    {
                        if (0 < playerCards[i] && playerCards[i] <= 13)
                        {
                            Playerflush[0]++;
                        }
                        else if (13 < playerCards[i] && playerCards[i] <= 26)
                        {
                            Playerflush[1]++;

                        }
                        else if (26 < playerCards[i] && playerCards[i] <= 39)
                        {
                            Playerflush[2]++;

                        }
                        else if (39 < playerCards[i] && playerCards[i] <= 52)
                        {
                            Playerflush[3]++;

                        }

                    }



                    // 스트레이트 체크
                    for (int i = 0; i < CheckComputer.Length; i++)
                    {
                        if (CheckComputer[i] == 0)
                        {
                            straightCompCount = 0;
                        }
                        else
                        {
                            straightCompCount++;
                        }

                        if (straightCompCount == 5)
                        {
                            Computerstraight = i + 1;
                        }
                        else { /* Do Nothing */ }
                    }

                    for (int i = 0; i < CheckPlayer.Length; i++)
                    {
                        if (CheckPlayer[i] == 0)
                        {
                            straightplayCount = 0;
                        }
                        else
                        {
                            straightplayCount++;
                        }

                        if (straightplayCount == 5)
                        {
                            Playerstraight = i + 1;
                        }
                        else { /* Do Nothing */ }
                    }

                    Console.WriteLine("======================================");

                    // 승리 판단
                    if (0 < ComputerFour || 0 < PlayerFour)
                    {
                        Console.WriteLine("포카드 결과");

                        if (ComputerFour < PlayerFour)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (PlayerFour < ComputerFour)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");
                        }
                    }

                    else if (Computerflush[0] == 5 || Computerflush[1] == 5 || Computerflush[2] == 5 ||
                        Computerflush[3] == 5 || Playerflush[0] == 5 || Playerflush[1] == 5 ||
                        Playerflush[2] == 5 || Playerflush[3] == 5)
                    {
                        Console.WriteLine("플러쉬 결과");
                        if (Computerflush[3] == 1 || Playerflush[3] == 1)
                        {

                            if (Computerflush[3] < Playerflush[3])
                            {
                                Console.WriteLine("플레이어 승리");
                                WinCheck = true;

                            }
                            else if (Playerflush[3] < Computerflush[3])
                            {
                                Console.WriteLine("컴퓨터 승리");

                            }
                            else
                            {
                                Console.WriteLine("무승부");

                            }
                        }
                        else if (Computerflush[2] == 1 || Playerflush[2] == 1)
                        {
                            if (Computerflush[2] < Playerflush[2])
                            {
                                Console.WriteLine("플레이어 승리");
                                WinCheck = true;

                            }
                            else if (Playerflush[2] < Computerflush[2])
                            {
                                Console.WriteLine("컴퓨터 승리");

                            }
                            else
                            {
                                Console.WriteLine("무승부");

                            }
                        }
                        else if (Computerflush[1] == 1 || Playerflush[1] == 1)
                        {
                            if (Computerflush[1] < Playerflush[1])
                            {
                                Console.WriteLine("플레이어 승리");
                                WinCheck = true;

                            }
                            else if (Playerflush[1] < Computerflush[1])
                            {
                                Console.WriteLine("컴퓨터 승리");

                            }
                            else
                            {
                                Console.WriteLine("무승부");

                            }
                        }
                        else if (Computerflush[0] == 1 || Playerflush[0] == 1)
                        {
                            if (Computerflush[0] < Playerflush[0])
                            {
                                Console.WriteLine("플레이어 승리");
                                WinCheck = true;

                            }
                            else if (Playerflush[0] < Computerflush[0])
                            {
                                Console.WriteLine("컴퓨터 승리");


                            }
                            else
                            {
                                Console.WriteLine("무승부");

                            }
                        }
                        else { /* Do Nothing */}


                    }

                    else if (0 < Computerstraight || 0 < Playerstraight)
                    {
                        Console.WriteLine("스트레이트 결과");

                        if (Computerstraight < Playerstraight)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (Playerstraight < Computerstraight)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");

                        }
                    }

                    else if (0 < ComputerThree || 0 < PlayerThree)
                    {
                        Console.WriteLine("트리플 결과");

                        if (ComputerThree < PlayerThree)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (PlayerThree < ComputerThree)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");

                        }
                    }

                    else if (0 < ComputerTwo || 0 < PlayerTwo)
                    {
                        Console.WriteLine("투페어 결과");

                        if (ComputerTwo < PlayerTwo)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (PlayerTwo < ComputerTwo)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");

                        }
                    }

                    else if (0 < ComputerOne || 0 < PlayerOne)
                    {
                        Console.WriteLine("원 페어 결과");

                        if (ComputerOne < PlayerOne)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (PlayerOne < ComputerOne)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");

                        }
                    }

                    else if (0 < ComputerNotpeir || 0 < PlayerNotpeir)
                    {
                        Console.WriteLine("노페어 결과");

                        if (ComputerNotpeir < PlayerNotpeir)
                        {
                            Console.WriteLine("플레이어 승리");
                            WinCheck = true;

                        }
                        else if (PlayerNotpeir < ComputerNotpeir)
                        {
                            Console.WriteLine("컴퓨터 승리");

                        }
                        else
                        {
                            Console.WriteLine("무승부");

                        }
                    }
                    else { /*Do Nothing */}


                    if (WinCheck == true)
                    {
                        playerMoney += batting * 2;

                        Console.WriteLine();
                        Console.WriteLine("======================================");

                        Console.WriteLine();
                        Console.WriteLine("배팅이 성공했습니다.");

                        Console.WriteLine("현재 가지고 있는 포인트는 {0} 입니다.", playerMoney);
                        Console.WriteLine();

                    }
                    else
                    {
                        playerMoney -= batting;
                        Console.WriteLine();
                        Console.WriteLine("======================================");
                        Console.WriteLine();
                        Console.WriteLine("배팅에 패배했습니다.");
                        Console.WriteLine("현재 가지고 있는 포인트는 {0} 입니다.", playerMoney);
                        Console.WriteLine();
                    }
                }



                if (100000 <= playerMoney)
                {
                    isGameOver = true;
                    Console.WriteLine("======================================");

                    Console.WriteLine("======================================");
                    Console.WriteLine();
                    Console.WriteLine("{0} 포인트를 모으셨습니다!", playerMoney);
                    Console.WriteLine("게임에서 승리하셨습니다.");
                    Console.WriteLine();

                    Console.WriteLine("======================================");
                    Console.WriteLine("======================================");

                }
                else if (playerMoney <= 0)
                {
                    isGameOver = true;
                    Console.WriteLine("======================================");

                    Console.WriteLine("======================================");
                    Console.WriteLine();
                    Console.WriteLine("더 이상 포인트가 없습니다!");
                    Console.WriteLine("게임에서 패배하셨습니다.");
                    Console.WriteLine();

                    Console.WriteLine("======================================");
                    Console.WriteLine("======================================");
                }
                else
                {
                    Console.WriteLine("[아무 키나 입력하면 다음으로 넘어갑니다.]");
                    int.TryParse(Console.ReadLine(), out CheckPass);
                    Console.Clear();
                }



            }
        }
    }

}
