using System;

namespace OOPlab1
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Name = "Szarik";

            Car Ford = new Car { Make = "Ford", Model = "Fiesta", Value = 3000, Color = "Blue" };
            Car BMW = new Car { Make = "BMW", Model = "e36", Value = 2000, Color = "Silver" };


            dog.TakeForWalk(3.0);
            dog.Feed(1.0);
            dog.PrintWeight();


            Human me = new Human();
            me.FirstName = "Marek";
            me.LastName = "Towarek";
            me.Pet = dog;
            me.Salary = 2800;
            me.Automobile = Ford;
            me.Automobile = BMW;



            Console.WriteLine(me.Salary);
            Console.WriteLine(Ford);
            Console.WriteLine(BMW);


        }
    }
}