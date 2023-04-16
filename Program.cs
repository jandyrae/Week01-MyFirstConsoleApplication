using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {

        static void Main()
        {

            string myName, myLocation, widthString, heightString; 
            DateTime currentDate, christmas;
            double width, height, woodLength, glassArea;
            TimeSpan untilChristmas;
            int day, month, year;

            Console.WriteLine("What is your name? ");
            myName = Console.ReadLine();
            Console.WriteLine("What is your location? ");
            myLocation = Console.ReadLine();
            // Console.WriteLine("My name is " + myName + " and I live in " + myLocation);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I live in " + myLocation);

            Console.WriteLine("\n****************\n");
            currentDate = System.DateTime.Today;
            christmas = new DateTime(2023, 12, 25);
            untilChristmas = christmas - currentDate;
            day = currentDate.Day;
            month = currentDate.Month;
            year = currentDate.Year;
            Console.WriteLine(month + "/" + day + "/" + year);
            Console.WriteLine("There are " + untilChristmas.Days + " days until Christmas!");

            Console.WriteLine("\n****************\n");
            Console.WriteLine("What is the width of the window in meters? ");
            widthString = Console.ReadLine(); 
            width = double.Parse(widthString);
            Console.WriteLine("What is the length of the window in meters? ");
            heightString = Console.ReadLine(); 
            height = double.Parse(heightString); 
            woodLength = 2 * (width + height) * 3.25; 
            glassArea = 2 * (width * height); 
            Console.WriteLine("The length of the wood is " + woodLength + " feet"); 
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

        }
    }
}
/*
Create a new Visual C# Console App using .NET Framework project and name it "MyFirstConsoleApplication."

Output two WriteLine statements that display those two variables with proper labels (My name is ... , I am from ...) using String Interpolation.
Output the current date, but not the current time. (Ex: 04/06/1830)
Output the number of days until Christmas this year and, of course, apply an appropriate label to that output.
Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
Add these requirements to the code:
Provide appropriate text labels when requesting dimensional input.
Cause the program to pause in the console so that the application does not automatically terminate when launched from the Visual Studio run debugger tool. 
Hint: Consider Console.ReadKey()
You do NOT need to add any sort of input validation.
Push your completed solution to a GitHub repository.
Submit the URL to your GitHub repository and a short video demo of your application.
*/