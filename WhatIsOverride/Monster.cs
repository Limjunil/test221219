using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride
{
    public class Monster
    {
        protected string name;
        protected int hp;
        protected int damage;
        protected int defence;

        public void move(string name)
        {
            Console.WriteLine("{0}가 움직인다.", name);
        }
        public void Attack(string name, int damage)
        {
            Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
        }

        public void MoveAndAttack()
        {
            this.move(this.name);
            this.Attack(this.name, this.damage);
        }
    } // Monster

    // Monster 상속 받아와서 생성자만 생성하면 되니 좋다.
    class Slime : Monster
    {
        // 프로퍼티 기능
        public string Name
        {
            get { return this.name; }

            // private 로 보호한다.
            private set { this.name = value; } 
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string value_)
        {
            this.name = value_;
        }



        public Slime()
        {
            this.name = "푸른 슬라임";
            this.hp = 100;
            this.damage = 2;
            this.defence = 1;
        }

    }

    class Wolf : Monster
    {
        public Wolf()
        {
            this.name = "하얀 늑대";
            this.hp = 200;
            this.damage = 10;
            this.defence = 2;
        }
    }
}
