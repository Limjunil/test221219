using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work221229
{
    public class Description
    {
    }

    /**
     * Monster 라는 부모 클래스를 만들어서 이런저런 기능을 구현하기
     * - Monster 클래스를 상속 받은 서로 다른 3 종류의 몬스터를 구현하기
     */

    //! 프로퍼티 이용해봄
    class MyMonster
    {
        protected string name = string.Empty;       //!< 
        protected int hp;
        protected int damage;
        protected int defence;
        protected string MonsterItem = string.Empty;


        public void TextLine(string name, int hp, int damage, int defence)
        {
            Console.WriteLine("몬스터 이름 : {0}\n체력 : {1}\n공격력 : {2}\n방어력 : {3}", name, hp, damage, defence);
        }
        public void Attack(string name, int damage)
        {
            Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
        }


        //public string Monstername()
        //{
        //    return this.name;
        //}

        public string Name
        {
            get { return this.name; }

            // private 로 보호한다.
            private set { this.name = value; }
        }

        public int Hp
        {
            get { return this.hp; }

            // private 로 보호한다.
            private set { this.hp = value; }
        }

        //public int HpVal()
        //{
        //    return this.hp;
        //}
        //public int AttackVal()
        //{
        //    return this.damage;
        //}

        public int Attacks
        {
            get { return this.damage; }

            // private 로 보호한다.
            private set { this.damage = value; }
        }

        //public int DefenceVal()
        //{
        //    return this.defence;
        //}
        public int Defence
        {
            get { return this.defence; }

            // private 로 보호한다.
            private set { this.defence = value; }
        }

        //public string MonsterDrop()
        //{
        //    return this.MonsterItem;
        //}

        public string MonsterItems
        {
            get { return this.MonsterItem; }

            // private 로 보호한다.
            private set { this.MonsterItem = value; }
        }



    }

    class Pig : MyMonster
    {

        
        public Pig()
        {
            this.name = "갈색 돼지";
            this.hp = 40;
            this.damage = 15;
            this.defence = 5;
            this.MonsterItem = "돼지고기";

        }



    }

    class Golem : MyMonster
    {
        public Golem()
        {
            this.name = "골렘";
            this.hp = 50;
            this.damage = 20;
            this.defence = 10;
            this.MonsterItem = "골렘의 파편";

        }
    }
    class Bear : MyMonster
    {
        public Bear()
        {
            this.name = "검은 곰";
            this.hp = 70;
            this.damage = 35;
            this.defence = 8;
            this.MonsterItem = "곰의 발톱";

        }
    }


    // 프로퍼티 이용 안함
    class Player
    {
        protected string name;
        protected int hp;
        protected int damage;
        protected int defence;



        public void TextLine(string name, int hp, int damage, int defence)
        {
            Console.WriteLine("플레이어 이름 : {0}\n체력 : {1}\n공격력 : {2}\n방어력 : {3}", name, hp, damage, defence);
        }

        public void Attack(string name, int damage)
        {
            Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
        }



        public string Playername()
        {
            return this.name;
        }

        public int HpVal()
        {
            return this.hp;
        }
        public int AttackVal()
        {
            return this.damage;
        }

        public int DefenceVal()
        {
            return this.defence;
        }

    }

    class PlayerOne : Player
    {
        public PlayerOne()
        {
            this.name = "용사";
            this.hp = 500;
            this.damage = 50;
            this.defence = 8;
        }



    }


    class BattleMonsters
    {
        string[] playItem = new string[3] { "□", "□", "□" };


        int iTEM_Count = 0;
        public int BattleLst(int number)
        {
            int[] monster = new int[3];

            bool isGameOver = false;
            int CheckSwitch = 0;
            int BattleCount = 1;

            int[] playerOne = new int[3];

            string playerName = string.Empty;

            PlayerOne myplayerOne = new PlayerOne();


            playerOne[0] = number;
            playerOne[1] = myplayerOne.AttackVal();
            playerOne[2] = myplayerOne.DefenceVal();
            playerName = myplayerOne.Playername();

            string monsterName = string.Empty;

            Random random1 = new Random();
            int randomVal_ = random1.Next(0, 2 + 1);

            MyMonster monsterKind = new MyMonster();
            int[] monsterType = new int[3] { 1, 2, 3 };


            switch (monsterType[randomVal_])
            {
                case 1:
                    monsterKind = new Pig();
                    break;
                case 2:
                    monsterKind = new Golem();
                    break;
                case 3:
                    monsterKind = new Bear();
                    break;
            }




            monster[0] = monsterKind.Hp;

            monster[1] = monsterKind.Attacks;
            monster[2] = monsterKind.Defence;
            monsterName = monsterKind.Name;




            while (isGameOver == false)
            {

                bool Checkloop = false;

                while (Checkloop == false)
                {
                    Console.WriteLine("===============================");

                    Console.WriteLine("===============================");

                    Console.WriteLine("[{0} 의 {1}턴]", playerName, BattleCount);
                    Console.WriteLine("===============================");
                    Console.WriteLine("===============================");

                    monsterKind.TextLine(monsterName, monster[0], monster[1], monster[2]);
                    Console.WriteLine("===============================");

                    myplayerOne.TextLine(playerName, playerOne[0], playerOne[1], playerOne[2]);
                    Console.WriteLine("===============================");

                    Console.WriteLine("[현재 소지한 드롭 아이템]\n{0} | {1} | {2}", playItem[0], playItem[1], playItem[2]);

                    Console.WriteLine();
                    Console.WriteLine("1. 공격");
                    Console.WriteLine("2. 도망간다");


                    int.TryParse(Console.ReadLine(), out CheckSwitch);
                    Console.WriteLine("===============================");

                    switch (CheckSwitch)
                    {
                        case 1:

                            if (monster[2] < playerOne[1])
                            {

                                Console.WriteLine();

                                Console.WriteLine("{0} 가 {1} 에게 공격을 성공했습니다.", playerName, monsterName);
                                Console.WriteLine("플레이어가 반격을 합니다. {0}의 피해를 입혔습니다.", playerOne[1] - monster[2]);
                                monster[0] -= (playerOne[1] - monster[2]);
                                Console.WriteLine();


                            }
                            else
                            {
                                Console.WriteLine();

                                Console.WriteLine("공격에 실패했습니다.");
                                Console.WriteLine("몬스터가 반격합니다. {0}의 피해를 받습니다.", monster[1] - playerOne[2]);

                                Console.WriteLine();
                                playerOne[0] -= (monster[1] - playerOne[2]);

                            }
                            Checkloop = true;

                            break;
                        case 2:
                            Random random = new Random();
                            int randomDICE = random.Next(1, 6 + 1);

                            if (3 < randomDICE)
                            {
                                Console.WriteLine();

                                Console.WriteLine("{0}에게서 도망에 성공했습니다.", monsterName);
                                Console.WriteLine();
                                isGameOver = true;

                            }
                            else
                            {
                                Console.WriteLine();

                                Console.WriteLine("{0}에게서 도망에 실패했습니다.", monsterName);
                                Console.WriteLine("몬스터가 공격합니다. {0}의 피해를 받습니다.", monster[1] - playerOne[2]);
                                Console.WriteLine();
                                playerOne[0] -= (monster[1] - playerOne[2]);


                            }
                            Checkloop = true;
                            break;
                        default:
                            Console.WriteLine();

                            Console.WriteLine(" 잘못된 값을 입력했습니다. 다시 입력하세요.");
                            Console.WriteLine();

                            break;


                    }
                }
                if (isGameOver == true)
                {
                    int LastCheck1 = 0;
                    Console.WriteLine("[System] 아무 키나 입력하면 다음으로 넘어갑니다.");
                    int.TryParse(Console.ReadLine(), out LastCheck1);
                    Console.Clear();

                    break;
                }
                else { /* Do Nothing */}

                // 몬스터 턴
                Console.WriteLine("===============================");
                Console.WriteLine("===============================");

                Console.WriteLine("[{0} 의 {1} 턴]", monsterName, BattleCount);

                Console.WriteLine("===============================");

                Console.WriteLine("===============================");

                if (playerOne[2] < monster[1])
                {
                    Console.WriteLine();

                    Console.WriteLine("몬스터가 공격에 성공했습니다.");
                    Console.WriteLine("{0}의 피해를 받습니다.", monster[1] - playerOne[2]);

                    Console.WriteLine();
                    playerOne[0] -= (monster[1] - playerOne[2]);
                }
                else
                {
                    Console.WriteLine();

                    Console.WriteLine("몬스터가 공격에 실패했습니다.");
                    Console.WriteLine("플레이어가 반격을 합니다. {0}의 피해를 입혔습니다.", playerOne[1] - monster[2]);
                    monster[0] -= (playerOne[1] - monster[2]);
                    Console.WriteLine();


                }



                if (playerOne[0] <= 0)
                {
                    Console.WriteLine();

                    Console.WriteLine("전투에서 패배하셨습니다.");
                    Console.WriteLine();

                    isGameOver = true;


                }
                else if (monster[0] <= 0)
                {
                    Console.WriteLine();

                    Console.WriteLine("전투에서 승리했습니다.");
                    Console.WriteLine();
                    Random random2 = new Random();
                    int drop_Item = random2.Next(1, 6 + 1);

                    if (3 < drop_Item)
                    {


                        if (randomVal_ == 1)
                        {
                            if (playItem[0] == monsterKind.MonsterItems)
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[0] = monsterKind.MonsterItems;
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[{0} 아이템을 얻었습니다.]]", playItem[0]);
                                Console.WriteLine();
                                Console.WriteLine("===============================");

                                iTEM_Count++;
                            }
                        }
                        else if (randomVal_ == 2)
                        {

                            if (playItem[1] == monsterKind.MonsterItems)
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[1] = monsterKind.MonsterItems;
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[{0} 아이템을 얻었습니다.]]", playItem[1]);
                                Console.WriteLine();
                                Console.WriteLine("===============================");

                                iTEM_Count++;
                            }
                        }
                        else
                        {
                            if (playItem[2] == monsterKind.MonsterItems)
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[2] = monsterKind.MonsterItems;
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[{0} 아이템을 얻었습니다.]]", playItem[2]);
                                Console.WriteLine();
                                Console.WriteLine("===============================");

                                iTEM_Count++;
                            }
                        }
                    }


                    isGameOver = true;

                }
                else if (playerOne[0] <= 0 && monster[0] <= 0)
                {
                    Console.WriteLine("===============================");

                    Console.WriteLine();

                    Console.WriteLine("무승부");
                    Console.WriteLine();
                    Console.WriteLine("===============================");


                    isGameOver = true;

                }
                else { /* Do Nothing */ }



                BattleCount++;

                int LastCheck = 0;
                Console.WriteLine("===============================");

                Console.WriteLine("[System] 아무 키나 입력하면 다음으로 넘어갑니다.");
                Console.WriteLine("===============================");

                int.TryParse(Console.ReadLine(), out LastCheck);

                Console.Clear();


            }

            return playerOne[0];
        }



        public int ItemThree(int itemNum)
        {

            itemNum = iTEM_Count;

            return itemNum;
        }

    }
}
