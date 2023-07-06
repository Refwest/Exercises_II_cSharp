
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        //!Exercise II.1 

        Console.WriteLine("Enter value __ zł");
        double value = double.Parse(Console.ReadLine());
        if (value < 7.50 || value > 49)
        {
            Console.WriteLine("Error, try again");

        }
        else
        {
            Console.WriteLine("This rate is ok");
        }

        // !Exercise II.2

        Console.WriteLine("What is width of your lawn?");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("What is lenght of your lawn?");
        Double lenght = double.Parse(Console.ReadLine());

        double lawnArea = width * lenght;

        if (lawnArea < 400)
        {
            Console.WriteLine("Weekly mowing fee is {0}, total fee for 20 week season is {1}", 25, 25 * 20);
        }
        else if (lawnArea >= 600)
        {
            Console.WriteLine("Weekly mowing fee is {0}, total fee for 20 week season is {1}", 50, 50 * 20);
        }
        else
        {
            Console.WriteLine("Weekly mowing fee is {0}, total fee for 20 week season is {1}", 35, 35 * 20);
        }

        // !Couerse way - to practic

        Console.WriteLine("What is width of your lawn?");
        double width2 = double.Parse(Console.ReadLine());

        Console.WriteLine("What is lenght of your lawn?");
        Double lenght2 = double.Parse(Console.ReadLine());

        double lawnArea2 = width2 * lenght2;
        int weeklyFee;

        if (lawnArea2 < 400)
        {
            weeklyFee = 25;
            Console.WriteLine("The weekly fee is {0}", weeklyFee);
            Console.WriteLine("The 20 week season price is {0}", weeklyFee * 20);
        }
        else if (lawnArea2 >= 400 && lawnArea2 < 600)
        {
            weeklyFee = 35;
            Console.WriteLine("The weekly fee is {0}", weeklyFee);
            Console.WriteLine("The 20 week season price is {0}", weeklyFee * 20);
        }
        else
        {
            weeklyFee = 50;
            Console.WriteLine("The weekly fee is {0}", weeklyFee);
            Console.WriteLine("The 20 week season price is {0}", weeklyFee * 20);
        }

        // !Exercise II.3

        Random random = new Random();
        int randomNumber = random.Next(1,11);
        

        Console.WriteLine("I chose number 1 to 10, guess what is the number!");
        Console.WriteLine("Number is...");
        int Number = int.Parse(Console.ReadLine());

        if (Number > 10)
        { 
            Console.WriteLine("Next time you have to be more focused on the question"); 
        }
        else if (Number == randomNumber) 
        {
            Console.WriteLine("That's it! You used 10% wisly");
        }
        else if (Number > randomNumber)
        {
            Console.WriteLine("My number is {0}, your number is to high", randomNumber);
        }
        else if (Number < randomNumber)
        {
            Console.WriteLine("My number is {0}, your number is to low", randomNumber);
        }
    }
}

