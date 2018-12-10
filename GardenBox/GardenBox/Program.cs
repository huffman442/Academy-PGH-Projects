using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in Width & Length
            Console.WriteLine("What is the width of your garden box?");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the length of your garden box?");
            double length = Convert.ToDouble(Console.ReadLine());

            //Calculate Area
            double area = width * length;

            //Veggies Per Sq. Ft.
            double carrots = 1;
            double corn = 3.0 / 16;
            double beets = 4.0 / 16;

            //Display Veggies Per Box

            Console.ReadLine();
        }
    }
}
