﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM9
{
    internal class Task4
    {
        public abstract class Worker
        {
            protected string name;

            public Worker(string name)
            {
                this.name = name;
            }

            // Абстрактний метод Print
            public abstract void Print();
        }

        // Похідні класи
        public class President : Worker
        {
            public President(string name) : base(name)
            {
            }

            // Перевизначений метод Print
            public override void Print()
            {
                Console.WriteLine($"President {name}");
            }
        }

        public class Security : Worker
        {
            public Security(string name) : base(name)
            {
            }

            // Перевизначений метод Print
            public override void Print()
            {
                Console.WriteLine($"Security guard {name}");
            }
        }

        public class Manager : Worker
        {
            public Manager(string name) : base(name)
            {
            }

            // Перевизначений метод Print
            public override void Print()
            {
                Console.WriteLine($"Manager {name}");
            }
        }

        public class Engineer : Worker
        {
            public Engineer(string name) : base(name)
            {
            }

            // Перевизначений метод Print
            public override void Print()
            {
                Console.WriteLine($"Engineer {name}");
            }
        }
    }
}
