using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeding_Cat
{
    public class Cat
    {
        public string name;
        public int age;

        private int happiness = 50;

        public Cat(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void play()
        {
            happiness += 10;
            if (happiness >= 100)
            {
                happiness = 100;
            }
        }

        public void eat()
        {
            happiness += 20;
            if (happiness >= 100)
            {
                happiness = 100;
            }
        }

        public string express()
        {
            string message = "";
            if (happiness >= 80)
                message = "I'm so happy.";
            else if (happiness >= 60)
                message = "I'm happy.";
            else if (happiness >= 40)
                message = "I'm so so.";
            else if (happiness >= 20)
                message = "I'm gloomy.";
            else
                message = "I'm sad.";

            return this.name + " : " + message;
        }

        public void GetBord()
        {
            happiness = happiness - 10;

            if (happiness < 0)
                happiness = 0;
        }
    }
}
