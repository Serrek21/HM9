using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM9
{
    internal class Task2
    {
        public class Device
        {
            protected string name;

            public Device(string name)
            {
                this.name = name;
            }

            public virtual void Sound()
            {
                Console.WriteLine($"Device {name} makes a sound.");
            }

            public void Show()
            {
                Console.WriteLine($"Device: {name}");
            }

            public virtual void Desc()
            {
                Console.WriteLine($"Description of {name}:");
            }
        }

        public class Kettle : Device
        {
            public Kettle(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"Kettle {name} makes boiling sound.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a kettle used for boiling water.");
            }
        }

        public class Microwave : Device
        {
            public Microwave(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"Microwave {name} makes beeping sound.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a microwave used for heating food.");
            }
        }

        public class Car : Device
        {
            public Car(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"Car {name} makes engine noise.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a car used for transportation.");
            }
        }

        public class Steamboat : Device
        {
            public Steamboat(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"Steamboat {name} makes steam whistle sound.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a steamboat powered by steam engines.");
            }
        }

    }
}
