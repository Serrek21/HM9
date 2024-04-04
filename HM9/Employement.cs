using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HM9.Task1;
using static HM9.Task2;
using static HM9.Task3;
using static HM9.Task4;

namespace HM9
{
    internal class Employement
    {
        
            static void Main(string[] args)
            {
                Money money = new Money(10, 50);
                money.DisplayMoney();

                Product product = new Product("Apple", new Money(5, 25));
                product.ReducePrice(2, 30);

                Console.ReadLine();
            Console.WriteLine("Devices:");
            Device kettle = new Kettle("Electric Kettle");
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();

            Device microwave = new Microwave("Microwave Oven");
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();

            Device car = new Car("SUV");
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();

            Device steamboat = new Steamboat("Steamboat");
            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();
            Console.WriteLine();

            // Завдання 3: Музичні інструменти
            Console.WriteLine("Musical Instruments:");
            MusicalInstrument violin = new Violin("Violin");
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();
            Console.WriteLine();

            MusicalInstrument trombone = new Trombone("Trombone");
            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();
            Console.WriteLine();

            MusicalInstrument ukulele = new Ukulele("Ukulele");
            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();
            Console.WriteLine();

            MusicalInstrument cello = new Cello("Cello");
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
            Console.ReadLine();


            President president = new President("John Doe");
            Security security = new Security("Jane Smith");
            Manager manager = new Manager("Alice Johnson");
            Engineer engineer = new Engineer("Bob Williams");

            // Виклик методу Print для кожного працівника
            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();

            Console.ReadLine();



        }
    }
}
