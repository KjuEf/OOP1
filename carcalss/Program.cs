using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameOne;

namespace carcalss
{
    class car
    {
        //int speed;
        //string color;

        public int speed;
        public string color;

        public void print()
        {
            Console.WriteLine(speed + "  " + color);
        }
        /*public void carset(int Speed , string Color)
        {
            speed = Speed;
            color = Color;
        }*/
    }


    class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            //mycar.carset(150,"Blue");

            mycar.speed = 150;
            mycar.color = "Blue";
            mycar.print();

            //--------

            NameOne.car2 carr22 = new NameOne.car2();
            carr22.speed2 = 130;
            carr22.color2 = "Red";
            carr22.print2();

            //---------

            car2 carr21 = new car2();
            carr21.speed2 = 100;
            carr21.color2 = "black";
            carr21.print2();
            
            Console.ReadKey();
        }
    }
}

namespace NameOne
{
    class car2
    {
        //int speed;
        //string color;

        public int speed2;
        public string color2;

        public void print2()
        {
            Console.WriteLine(speed2 + "  " + color2);
        }
    }
}
