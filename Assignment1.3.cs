using System;

class Assignment1_3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type of Conversion: \n (a) Seconds to Minutes \n (b) Minutes to Hours \n (c) Hours to Days \n (d) Days to Months");
        Console.Write("Select Your Prefer Conversion: ");
        string choice = Console.ReadLine();
        Console.WriteLine(choice);

        if (choice == "a")
        {
            Console.Write("Enter the Seconds You Want to Convert: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            double answer = seconds / 60.0;
            Console.WriteLine($"{answer} minutes");
        }
        else if (choice == "b")
        {
            Console.Write("Enter the Minutes You Want to Convert: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            double answer = minutes / 60.0;
            Console.WriteLine($"{answer} hours");
        }
        else if (choice == "c")
        {
            Console.Write("Enter the Hours You Want to Convert: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            double answer = hours / 24.0;
            Console.WriteLine($"{answer} days");
        }
        else if (choice == "d")
        {
            Console.Write("Enter the Days You Want to Convert: ");
            int days = Convert.ToInt32(Console.ReadLine());
            double answer = days / 30.0;
            Console.WriteLine($"{answer} months");
        }
        else
        {
            Console.WriteLine("Your Choice is Not Recognized. Please Try Again Later.");
        }

    }
}
