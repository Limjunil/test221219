using System;

namespace Work221228
{
    public class Program
    {
        static void Main(string[] args)
        {

            int playerMoney = 10000;
            
            bool isGameOver = false;

            while (isGameOver == false)
            {
                
                int CompurtCardVal1 = 0;
                int CompurtCardVal2 = 0;
                int PlayerCardVal = 0;
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
                // 컴퓨터가 뽑는 카드 2개
                trumpCard.SetupTrumpCards();
                trumpCard.ShuffleCards();

                CompurtCardVal1 = trumpCard.RollCard(0);
                Console.WriteLine();

                CompurtCardVal2 = trumpCard.RollCard(1);

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
                    Console.WriteLine("======================================");


                    Console.WriteLine("[플레이어의 턴]".PadLeft(20, ' '));

                    PlayerCardVal = trumpCard.RollCard(2);

                    if ((CompurtCardVal1 < PlayerCardVal && PlayerCardVal < CompurtCardVal2) ||
                        (CompurtCardVal2 < PlayerCardVal && PlayerCardVal < CompurtCardVal1))
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
                }

                

            }


        } // Main()
    }

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
            trumpCardMark = new string[4] { "♥", "♠", "◆", "♣" };
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

            return cardVal;

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
}