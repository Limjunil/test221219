using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    public class Description
    {
        private string stringField = "이것은 어디까지 접근할까?"; // 필드다

        //public Description()
        //{
        //    // 인스턴스 화하면서 실행시킬 수 있다, 이 생성자는.
        //    Console.WriteLine("이것이 바로 숨어 있는 생성자?");
        //}

        //public Description(int number)
        //{
        //    Console.WriteLine("Number를 받는 생성자 {0} 이것이 바로 숨어 있는 생성자?", number);
        //}

        public void ValueTypeAndRefferenceType()
        {
            /**
             * 값 형식과 참조 형식
             * 클래스나 구조체 같은 데이터 형식을 말할 때 값 형식(Value type)과 참조 형식(Reference type)
             * 으로 구분 짓기도 한다.
             * 
             * 값 형식(c드라이브에서 d드라이브로 파일 복사되는 것)
             * 개체에 값 자체를 담고 있는 구조이다.
             * 지금까지 다룬 int, double 등은 내부적으로 구조체로 된 전형적인 값 형식의 데이터 구조이다.
             * 통 복사해와서 값 수정이 영향을 끼치지 않음
             * 
             * 참조 형식(아이콘 바로가기 같은거)
             * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조이다.
             * 여러 값이 동일한 개체를 가리킬 수 있다.
             * 주소 값을 가져오는 거라 원본이 수정되면 반영됨
             * 
             */

            //int number = 10;
            //Console.WriteLine("number에 저장된 값은 {0}이고, 주소는 {1} 입니다.",
            //    number);


            /**
             * 박싱과 언박싱
             * 프로그래밍을 하다 보면 데이터의 형식 변환이 필요하다.
             * 이러한 변환 과정에서 값 형식의 데이터를 참조 형식의 데이터로 변경하는 겻을 박싱(Boxing)이라고 한다.
             * 반대로 참조 형식의 데이터를 값 형식의 데이터로 변경하는 것을 언박싱(Unboxing)이라고 한다.
             * 
             * 박싱
             * 박싱이란 말 그대로 박스에 포장을 하는 것이다.
             * c#에서 박싱은 값 형식의 데이터를 참조 형식의 데이터로 변환하는 작업을 의미한다.
             * 예를 들어 다음 코드처럼 정수 형식의 데이터를 오브젝트 형식의 데이터에 담는 형태를 박싱이라고 한다.
             * 
             * int number = 1234;
             * // object 는 모든 자료형의 타입이다.
             * object objectValue = number;
             * 
             * 좀 더 어렵게 말하면 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는
             * 단계를 거치기 때문에 시간과 공간이 소비되는 비용이 발생한다.
             */

            //int number = 1234;
            //// object 는 모든 자료형의 타입이다.
            //object objectValue = number;

            //Console.WriteLine("{0}", objectValue);

            /**
             * 언박싱
             * 다음 코드는 object 변수에 저장된 1234를 실제 정수 형식의 데이터로 변환하는 모습을 보여준다.
             * 참조 형식의 데이터를 값 형식의 데이터로 변환하는 과정이 포장을 푸는 것과 비슷해 보여서 언박싱
             * 이라고 한다.
             * 언박싱을 캐스트(Cast) 또는 캐스팅(Casting)으로 표현한다.
             * 
             * object objectValue = 1234;
             * //object를 (int) 형식으로 풀었다는 의미이다.
             * int number = (int)objectValue;
             * 
             * object 형 변수에 들어있는 데이터 중에서 숫자 형식의 데이터는 바로 int 형 변수에 대입할 수 없다.
             * object 형 변수 값을 int 형 변수에 대입하려면 형식 변환을 해야한다.
             * 형식 변환은 캐스팅이나 Convert 클래스 같은 변환 API를 사용하면 된다.
             * 즉, (int) 또는 Convert.ToInt32() 같은 형식 변환 관련 기능을 명시적으로 지정해 주어야 한다.
             */

            // object 형식 선언
            object objectValue;

            char charValue = 'a';
            int intValue = 97;
            char charValue2;

            // object에 'a' 값을 저장하면 숫자 97로 저장한다.
            objectValue = charValue;
            // 그러므로 저장한 값의 데이터 형식을 ()안에 적어서 다시 변환해줘야 한다.
            charValue2 = (char)objectValue;

            Console.WriteLine("{0}", charValue2);

            Console.WriteLine("ValueTypeAndRefferenceType -> {0}", stringField);




        } // ValueTypeAndRefferenceType()

        public void WhatIsField()
        {
            /**
             * 필드(Field)는 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇을 의미한다.
             * 예를 들어 필드는 자동차 클래스에 선언된 변수로 자동차 부품에 해당한다고 할 수 있다.
             * 
             * 필드
             * 클래스 내에서 선언된 변수 또는 배열 등을 c#에서는 필드라고 한다.
             * 필드는 일반적으로 클래스의 부품 역할을 하며, 대부분 private 액세스 한정자(Access modifier)
             * 가 붙고 클래스 내에서 데이터를 담는 그릇 역할을 한다.
             * // 밖에서 고칠 필요가 없기에 private로 쓴다.
             * 
             * 이러한 필드는 개체 상태로 보관한다.
             * 필드는 선언한 후 초기화하지 않아도 자동으로 초기화한다.
             * 예를 들어 int 형 필드는 0으로, string 형 필드는 String.Empty, 즉 공백으로 초기화된다.
             * 
             * 
             * 지역 변수와 전역 변수
             * c#에서 변수를 선언할 때는 Main() 메서드와 같은 메서드 내에서 선언하거나 메서드 밖에서,
             * 즉 메서드와 동등한 레벨에서 변수를 선언할 수 있다.
             * 메서드 내에서 선언된 변수 또는 배열을 지역 변수(Local variable)라고 하며, 메서드 밖에서 선언된 변수를
             * 전역 변수(Global variable) 라고 한다.
             * 다만 c#에서는 전역 변수라는 용어를 사용하지 않고 메서드와 동일하게 액세스 한정자를 붙여
             * 필드라고 한다.
             * 
             * 
             * 지역 변수
             * 변수는 Main() 메서드가 종료되면 자동으로 소멸된다.
             * 변수가 살아 있는 영역은 Main() 메서드의 중괄호 시작({)과 끝 사이(})이다.
             * 특정 지역을 범위로 하기에 변수를 일반적으로 지역 변수라고 표현한다.
             * 
             * 
             * 전역 변수
             * Main() 메서드가 아닌 클래스 내에 선언된 변수를 필드라고 한다.
             * c#에서 필드는 변수와 마찬가지로 주로 소문자 또는 언더스코어(_)로 시작한다.
             * 이러한 필드는 메서드 내에 선언된 지역 변수와 달리 전역 변수라고도 한다.
             */

            Console.WriteLine("WhatIsField -> {0}", stringField);



        } // WhatIsField()


        public void WhatIsConstructor()
        {
            /**
             * c#에서 생성자는 클래스에서 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 설정한다.
             * 자동차 클래스를 예로 들면, 자동차의 시동 걸기에 해당하는 것이 바로 생성자이다.
             * 
             * 생성자
             * 클래스의 구성 요소 중에는 생성자(Constructor)라는 메서드가 숨어 있다.
             * 단어 그대로 개체를 생성하면서 무엇인가를 하고자 할 때 사용되는 메서드이다.
             * 일반적으로 생성자는 개체를 초기화(주로 클래스 내 필드를 초기화) 하는 데 사용된다.
             * 생성자는 생성자 메서드라고도 한다.
             * 이러한 생성자는 독특한 규칙이 있는데, 바로 생성자 이름이 클래스 이름과 동일하는 것이다.
             * 클래스 내에서 클래스 이름과 동일한 이름을 갖는 메서드는 모두 생성자이다.
             * 
             * 생성자는 매개 변수가 없는 기본(Default) 생성자가 있고, 매개변수를 원하는 만큼 정의해서
             * 사용할 수도 있다.
             * 이때 리턴 값은 가지지 않는다. 또 생성자도 static 생성자(정적 생성자)와 public 생성자
             * (인스턴스 생성자)로 구분된다.
             * 일반적으로 public 키워드를 사용하는 인스턴스 생성자를 많이 사용한다.
             */
        }// WhatIsConstructor()

        public void WhatIsDestructor()
        {
            /**
             * 소멸자는 생성자와 반대 개념으로 클래스에서 인스턴스화된 개체가 메모리 상에서 없어질 때
             * 실행되는 메서드이다. 자동차 클래스를 예로 들면 자동차 주차 대행, 시동 끄기 등으로 볼 수 있다.
             * 
             * 종료자
             * 종료자(Finalizer)라고도 하는 소멸자(Destructor)는 닷넷의 가비지 수집기
             * (Garbage Collector, GC)에서 클래스의 인스턴스를 사용한 후 최종 정리할 때 실행되는 클래스에서
             * 가장 늦게 호출되는 메서드이다.
             * C#에서는 닷넷 가비지 수집기(GC)가 개체를 소멸할 때 메모리를 해제하는 등 역할을 대신해 주기
             * 때문에 이 책에서는 소멸자에 직접 접근할 일이 없다.
             * 
             * - 자동자 시동을 끄는 것에 비유할 수 있으며, 운전수가 주차하고 시동을 끄는 것이 아니라
             *   주차 요원(GC)이 대신 주차하고 시동을 끄는 것과 의미가 비슷하다.
             * - 소멸자는 클래스 이름과 동일한 메서드로 앞에 물결 기호인 ~(틸드)를 붙여 만든다.
             * - 소멸자도 특별한 형태의 메서드이다. 소멸자 또한 소멸자 메서드라고도 한다. 생성자와 달리
             *   매개 변수를 받을 수 없다.
             * - 소멸자는 오버로딩을 지원하지 않으며 직접 호출할 수도 없다.
             */
        } // WhatIsDestructor()

        

        public void WhatIsInheritance()
        {
            /**
             * 클래스 간에는 부모와 자식 관게를 설정할 수 있다.
             * 이러한 내용을 개체 관계 프로그래밍(Object relationship programming)이라고도 한다.
             * 상속은 부모 클래스에 정의된 기능을 다시 사용하거나 확장 또는 수정하여 자식 클래스로 만드는 것이다.
             * 특정 클래스에서 만든 기능을 다른 클래스에 상속으로 물려주면 장점이 많이 있다.
             * 
             * 클래스 상속하기
             * 개체 지향 프로그래밍의 장점 중 하나는 이미 만든 클래스를 재사용하는 것이다.
             * 이 재사용의 핵심 개념이 바로 상속이다.
             * 부모 재산을 자식에게 상속하듯이 부모 클래스(기본 클래스)의 모든 멤버를 자식 클래스(파생 클래스)
             * 가 재사용하도록 허가하는 기능이다.
             * 여러 클래스 간의 관계를 설정할 때 수평 관계가 아닌 부모와 자식 간 관계처럼 계층적인 관계를 표현할 때
             * 사용하는 개념을 상속이라고 한다.
             * 클래스 상속은 단일 상속(Single inheritance)과 다중 상속(Multiple inheritance) 으로 구분할 수 있다.
             * 단, c#의 클래스 상속은 단일 상속만 지원한다.
             * 다중 상속은 나중에 배울 인터페이스로 지원받을 수 있다.
             * 
             * 클래스 상속 구문
             * c#에서는 다음과 같이 클래스 이름 뒤에 콜론(:) 기호와 부모가 되는 클래스 이름을 붙인다.
             * 
             * public class [기본 클래스 이름]
             * {
             *      // 기본 클래스 멤버를 정의
             * }
             * 
             * public class [파생 클래스 이름] : [기본 클래스 이름]
             * {
             *      // 기본 클래스의 멤버를 포함한 자식 클래스의 멤버를 정의
             * }
             * 
             * - System.Object 클래스 : System.Object 클래스는 모든 클래스의 부모 클래스이다.
             *                         닷넷에서 가장 높은 계층에 속하는 시조(조상) 클래스라고 할 수 있다.
             *                         새롭게 만드는 c#의 모든 클래스는 자동으로 Object 클래스에서 상속받기에
             *                         Object 클래스를 상속하는 코드는 생략 가능하다.
             *                         
             * - 기본 클래스(Base) : 다른 클래스의 부모 클래스가 되는 클래스로 기본 클래스라고 한다.
             *                     기본 클래스를 다른 말로 Base 클래스, Super 클래스, 부모 클래스라고도 한다.
             * 
             * - 파생 클래스(Dereved) : 다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스라고 한다.
             *                        파생 클래스는 다른 클래스에서 멤버를 물려받은 것으로, Dereved 클래스,
             *                        Sub 클래스, 자식 클래스로 표현한다.
             * 
             * 부모 클래스와 자식 클래스
             * 프로그래밍에서 상속을 표현할 때 상속을 주는 클래스를 부모 클래스라고 하며, 상속을 받는 클래스를
             * 자식 클래스라고 한다.
             * 콜론(:) 기호로 상속 관계를 지정하면 부모 클래스의 public 멤버들을 자식 클래스에서 그대로 물려받아 사용할
             * 수 있다.
             * public, protected로 선언된 멤버들도 자식 클래스에서 사용 가능하다.
             * (private 로 선언된 멤버는 상속이 안된다.)
             */



        }

    } // class Description()


    //class Parent
    //{

    //    public string stringValue = "stringValue -> 부모 클래스의 멤버 변수";
    //    protected int intValue = 1234;
    //    private float floatValue = 3.14f;
    //    public void Print()
    //    {
    //        Console.WriteLine("부모 클래스의 멤버 호출");
    //    }
    //}

    //class Child : Parent
    //{
    //    public void PrintChild()
    //    {
            
    //        Console.WriteLine("자식 클래스의 멤버 호출");
    //        Console.WriteLine("부모 클래스의 멤버 변수 호출 : {0}, {1}", 
    //            base.stringValue, base.intValue);
    //    }
    //}



    //class Monster
    //{
    //    protected string name;
    //    protected int hp;
    //    protected int damage;
    //    protected int defence;

    //    public void move(string name) 
    //    {
    //        Console.WriteLine("{0}가 움직인다.", name);
    //    }
    //    public void Attack(string name, int damage)
    //    {
    //        Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
    //    }

    //    public void MoveAndAttack()
    //    {
    //        this.move(this.name);
    //        this.Attack(this.name, this.damage);
    //    }
    //}

    //// Monster 상속 받아와서 생성자만 생성하면 되니 좋다.
    //class Slime : Monster
    //{

    //    public Slime()
    //    {
    //        this.name = "푸른 슬라임";
    //        this.hp = 100;
    //        this.damage = 2;
    //        this.defence = 1;
    //    }

    //}

    //class Wolf : Monster
    //{ 
    //    public Wolf()
    //    {
    //        this.name = "하얀 늑대";
    //        this.hp = 200;
    //        this.damage = 10;
    //        this.defence = 2;
    //    }

        
    //}
    //==========================================
    //위는 예제

    /**
     * Monster 라는 부모 클래스를 만들어서 이런저런 기능을 구현하기
     * - Monster 클래스를 상속 받은 서로 다른 3 종류의 몬스터를 구현하기
     */
    class MyMonster
    {
        protected string name;
        public int hp;
        protected int damage;
        protected int defence;
        protected string MonsterItem;



        public void TextLine(string name, int hp, int damage, int defence)
        {
            Console.WriteLine("몬스터 이름 : {0}\n체력 : {1}\n공격력 : {2}\n방어력 : {3}", name, hp, damage, defence);
        }
        public void Attack(string name, int damage)
        {
            Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
        }

      
        public string Monstername()
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

        public string MonsterDrop()
        {
            return this.MonsterItem;
        }

    }

    class Pig : MyMonster
    {
        public Pig()
        {
            this.name = "갈색 돼지";
            this.hp = 15;
            this.damage = 15;
            this.defence = 3;
            this.MonsterItem = "돼지고기";

        }
        

    }

    class Golem : MyMonster
    {
        public Golem()
        {
            this.name = "골렘";
            this.hp = 25;
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
            this.hp = 35;
            this.damage = 35;
            this.defence = 8;
            this.MonsterItem = "곰의 발톱";

        }
    }

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
        

        int iTEM_Count=0;
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




            monster[0] = monsterKind.HpVal();

            monster[1] = monsterKind.AttackVal();
            monster[2] = monsterKind.DefenceVal();
            monsterName = monsterKind.Monstername();


            

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

                    Console.WriteLine("[현재 소지한 몬스터의 드롭 아이템] {0} | {1} | {2}", playItem[0], playItem[1], playItem[2]);

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
                        
                        
                        if(randomVal_ == 1)
                        {
                            if (playItem[0] == monsterKind.MonsterDrop())
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[0] = monsterKind.MonsterDrop();
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
                            
                            if (playItem[1] == monsterKind.MonsterDrop())
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[1] = monsterKind.MonsterDrop();
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
                            if (playItem[2] == monsterKind.MonsterDrop())
                            {
                                Console.WriteLine("===============================");

                                Console.WriteLine();
                                Console.WriteLine("[[이미 얻은 아이템입니다. 패스합니다.]]");
                                Console.WriteLine();
                                Console.WriteLine("===============================");


                            }
                            else
                            {
                                playItem[2] = monsterKind.MonsterDrop();
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
