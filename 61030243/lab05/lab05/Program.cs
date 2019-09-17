using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = null;
            string color = null ;

            Console.Write("Input day name : ");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "sun":
                    day = "Sunday";
                    color = "Red";
                    break;

                case "mon":
                    day = "Monday";
                    color = "Yellow";
                    break;

                case "tue":
                    day = "Tuesday";
                    color = "Pink";
                    break;

                case "wed":
                    day = "Wednesday";
                    color = "Green";
                    break;

                case "thu":
                    day = "Thursday";
                    color = "Orange";
                    break;

                case "fri":
                    day = "Friday";
                    color = "Blue";
                    break;

                case "sat":
                    day = "Saturday";
                    color = "Purple";
                    break;

                defult:
                    day = color = "Invalid";
                    break;

            }

            Console.WriteLine("{0} is {1}, color {2}", name, day, color);
        }
    }
}
