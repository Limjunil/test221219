using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    public class Program3
    {
        public static void Main()
        {
            //Description description = new Description(123);
            //description.ValueTypeAndRefferenceType();
            //description.WhatIsField();

            //TrumpCard card = new TrumpCard();
            //card.RollCard();

            //Parent parent = new Parent();
            //parent.Print();

            //Child child = new Child();
            //child.PrintChild();
            //child.Print();

            //Wolf monsterWolf = new Wolf();
            //monsterWolf.MoveAndAttack();

            //Slime monsterSlime = new Slime();
            //monsterSlime.MoveAndAttack();

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


                    Console.WriteLine("[현재 소지한 몬스터의 드롭 아이템] {0} | {1} | {2}", pigItem, golemItem, bearItem);

                    Console.WriteLine();

                    Console.WriteLine("아이템 3 종류를 전부 획득했습니다.");
                    Console.WriteLine("게임을 종료합니다.");
                    Console.WriteLine();
                    Console.WriteLine("===============================");

                    break;
                }
            }
            



            //Console.WriteLine();
            //Golem myMonsterGolem = new Golem();
            //myMonsterGolem.MoveAndTextAndAttack();
            //Console.WriteLine();

            //Bear myMonsterBear = new Bear();
            //myMonsterBear.MoveAndTextAndAttack();


        }    // Main()
    }
}
