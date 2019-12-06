/**
 * ######################################################
 * ##    Programming Exercise Chapter 2 #2             ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: December 5 2019               ##
 * ##    Purpose: Width & numeric format specifiers    ##
 * ######################################################
 */

using System;
using static System.Console;

namespace mi_ft_km
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles,
                   feet,
                   kilometers;
            miles = 42.75;
            feet = miles * 5280;
            kilometers = miles * 1.609;
            WriteLine("{0, 12}{1, 12}{2, 12}", "Miles", "Feet", "Kilometers");
            WriteLine("{0, 12:N2}{1, 12:N0}{2, 12:N2}", miles, feet, kilometers);
        }
    }
}
