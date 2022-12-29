using System;
using System.Net.NetworkInformation;

namespace Work221229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 아이템 3종류를 얻으면 끝나는 게임을 만들었습니다.
             * 
             */
            
            
            BattleMonsters battle_monster = new BattleMonsters();
            PlayerOne player_ = new PlayerOne();

            Pig pig_ = new Pig();
            string pigItem = pig_.MonsterDrop();

            Golem golem_ = new Golem();
            string golemItem = golem_.MonsterDrop();

            Bear bear_ = new Bear();
            string bearItem = bear_.MonsterDrop();

            int NowPlayerHP = player_.HpVal();

            int iTEM_Count = 0;

            while (true)
            {
                NowPlayerHP = battle_monster.BattleLst(NowPlayerHP);
                iTEM_Count = battle_monster.ItemThree(iTEM_Count);

                if (iTEM_Count == 3)
                {
                    Console.WriteLine("===============================");


                    Console.WriteLine("[현재 소지한 드롭 아이템]\n{0} | {1} | {2}", pigItem, golemItem, bearItem);

                    Console.WriteLine();

                    Console.WriteLine("아이템 3 종류를 전부 획득했습니다.");
                    Console.WriteLine("게임을 종료합니다.");
                    Console.WriteLine();
                    Console.WriteLine("===============================");

                    break;
                }
            }
        }
    }
}