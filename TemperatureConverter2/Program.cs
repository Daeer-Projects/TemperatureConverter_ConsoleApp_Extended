using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables.
            double temp = 0;
            double centTemp = 0;
            double farenTemp = 0;
            double kelvinTemp = 0;
            string getTemp = "";
            string getChoice1 = "";
            string getChoice2 = "";
            int choice1 = 1;
            int choice2 = 0;
            int intTemp = 0;
         
            // Say hello.
            Console.WriteLine("Hello and welcome to the all new temperature converter!");

            while (choice1 != 0)
            {


            // Get the user to choose what they want converted.
            Console.WriteLine("\n\nPlease choose the type of temperature that you want to be converted:");
            Console.WriteLine("1 - Celcius");
            Console.WriteLine("2 - Farenheight");
            Console.WriteLine("3 - Kelvin");
            Console.WriteLine("Or 0 - To Quit");
            getChoice1 = Console.ReadLine();

            choice1 = int.Parse(getChoice1);
            if (choice1 == 0)
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {

                // Ask the user for the figure.
                Console.Write("Enter the figure that you want to convert: ");
                getTemp = Console.ReadLine();

                // Ask the user for the type of conversion that they want.
                Console.WriteLine("What do you want to convert the figure to?");
                Console.WriteLine("1 - Celcius");
                Console.WriteLine("2 - Farenheight");
                Console.WriteLine("3 - Kelvin");
                getChoice2 = Console.ReadLine();

                // Start the conversion.
                Console.WriteLine("Converting now...");

                // Convert the strings to doubles or ints.
                temp = double.Parse(getTemp);

                choice2 = int.Parse(getChoice2);

                //   while (choice1 != 0)
                //   {
                //switch (choice1)
                //{
                //    case 1:
                if (choice1 == 1)
                {
                    // The Celcius conversions...
                    Console.WriteLine("You picked {0} Celcius.", temp);
                    if (choice2 == 1)
                    {
                        Console.WriteLine("Your temperature converted to Celcius is: {0}", temp);
                        Console.WriteLine("The same as you selected...  Funnily enough!");
                    }
                    else if (choice2 == 2)
                    {
                        farenTemp = (1.8 * temp) + 32;
                        Console.WriteLine("Your temperature converted to Farenheight is: {0}", farenTemp);
                    }
                    else if (choice2 == 3)
                    {
                        kelvinTemp = temp + 273.15;
                        Console.WriteLine("Your temperature converted to Kelvin is: {0}", kelvinTemp);
                    }
                    else
                        Console.WriteLine("Unable to convert to that choice...");
                    //break;
                }
                else if (choice1 == 2)
                {
                    // case 2:
                    // The Farenheight conversions...
                    Console.WriteLine("You picked {0} Farenheight.", temp);
                    if (choice2 == 1)
                    {
                        centTemp = (temp - 32) / 1.8;
                        Console.WriteLine("Your temperature converted to Celcius is: {0}", centTemp);
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("Your temperature converted to Farenheight is: {0}", temp);
                        Console.WriteLine("The same as you selected...  Funnily enough!");
                    }
                    else if (choice2 == 3)
                    {
                        centTemp = (temp - 32) / 1.8;
                        kelvinTemp = centTemp + 273.15;
                        Console.WriteLine("Your temperature converted to Kelvin is: {0}", kelvinTemp);
                    }
                    else
                        Console.WriteLine("Unable to convert to that choice...");
                    //  break;
                }
                else if (choice1 == 3)
                {
                    //   case 3:
                    // The Kelvin conversions.
                    Console.WriteLine("You picked {0} Kelvin.", temp);
                    if (choice2 == 1)
                    {
                        centTemp = temp - 273.15;
                        Console.WriteLine("Your temperature converted to Celcius is: {0}", centTemp);
                    }
                    else if (choice2 == 2)
                    {
                        centTemp = temp - 273.15;
                        farenTemp = (1.8 * centTemp) + 32;
                        Console.WriteLine("Your temperature converted to Farenheight is: {0}", farenTemp);
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine("Your temperature converted to Kelvin is: {0}", temp);
                        Console.WriteLine("The same as you selected...  Funnily enough!");
                    }
                    else
                        Console.WriteLine("Unable to convert to that choice...");
                    //break;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }

            }
            }

        }
    }
}
