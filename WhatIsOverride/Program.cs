using System;

namespace WhatIsOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent();
            //parent.Say();
            //parent.Run();
            //parent.Walk();

            //Child child_ = new Child();
            //child_.Say();
            //child_.Run();
            //child_.Walk();
           

            //StoreButton storeButton = new StoreButton();
            //storeButton.OnClickButton();


            //QuestButton questButton = new QuestButton();
            //questButton.OnClickButton();


            Slime slime = new Slime();
            //slime.Name = "이거 사실 슬라임 아님";
            Console.WriteLine("[Main] 슬라임 클래스에서 필드를 가져옴 -> {0}", slime.Name);
        }
    }
}