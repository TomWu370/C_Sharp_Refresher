using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    class Bird
    {
        private string name;
        public Bird(string name) { 
            this.name = name;
        }

        public string Name
        {
            get {  return name; }
            set { name = value; }
        }

        public virtual string shout() { 
            return "shouting " + this.name; 
        }
        public void announce()
        {
            Console.WriteLine("bird");
        }
    }

    class ExtremeBird : Bird
    {
        private string name;
        public int speed;
        public ExtremeBird(string name, int speed) : base(name)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string shout()
        {
            return "SCREAMING " + this.name;
        }
    }
    internal class SimpleOOP
    {
        public static void Run()
        {
            Object[] birds = new Object[3]; // array of different types
            try
            {
                Bird bird0 = new Bird("penguin");
                ExtremeBird bird1 = new ExtremeBird("chicken", 5);
                Bird bird2 = new Bird("peacock");
                Bird bird3 = new Bird("crow");
                birds[0] = bird0;
                birds[1] = bird1;
                birds[2] = bird2;
                birds[3] = bird3;
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString() + "\ncan't put anymore birds into the bird array");
            }

            foreach (Bird birb in birds)
            {
                Console.WriteLine(birb.Name);
                Console.WriteLine(birb.shout());
                Console.Write("my species is a ");
                birb.announce();
            }

            Console.ReadLine();
        }

    }
}
