using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM9
{
    internal class Task3
    {
        public class MusicalInstrument
        {
            protected string name;

            public MusicalInstrument(string name)
            {
                this.name = name;
            }

            public virtual void Sound()
            {
                Console.WriteLine($"The {name} makes a musical sound.");
            }

            public void Show()
            {
                Console.WriteLine($"Musical Instrument: {name}");
            }

            public virtual void Desc()
            {
                Console.WriteLine($"Description of {name}:");
            }

            public virtual void History()
            {
                Console.WriteLine($"History of {name}:");
            }
        }

        public class Violin : MusicalInstrument
        {
            public Violin(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"The {name} produces melodious tunes.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a violin, a string instrument.");
            }

            public override void History()
            {
                base.History();
                Console.WriteLine($"The violin has a long history dating back several centuries.");
            }
        }

        public class Trombone : MusicalInstrument
        {
            public Trombone(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"The {name} produces bold, resonant tones.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a trombone, a brass instrument.");
            }

            public override void History()
            {
                base.History();
                Console.WriteLine($"The trombone evolved from earlier brass instruments in the 15th century.");
            }
        }

        public class Ukulele : MusicalInstrument
        {
            public Ukulele(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"The {name} produces cheerful, bright tones.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a ukulele, a small guitar-like instrument.");
            }

            public override void History()
            {
                base.History();
                Console.WriteLine($"The ukulele originated in the 19th century in Hawaii.");
            }
        }

        public class Cello : MusicalInstrument
        {
            public Cello(string name) : base(name)
            {
            }

            public override void Sound()
            {
                Console.WriteLine($"The {name} produces rich, deep tones.");
            }

            public override void Desc()
            {
                base.Desc();
                Console.WriteLine($"This is a cello, a string instrument.");
            }

            public override void History()
            {
                base.History();
                Console.WriteLine($"The cello has a long history dating back to the 16th century.");
            }
        }
    }
}
