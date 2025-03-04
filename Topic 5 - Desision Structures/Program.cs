using System.Security.Cryptography;

namespace Topic_5___Desision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1
            int selectAngle;
            Random randNum = new Random();
            Console.WriteLine("Please enter a number from 0 to 360");

            while (!Int32.TryParse(Console.ReadLine(), out selectAngle))
            {
                Console.WriteLine("Invalid input, try again.");
            }
            if (selectAngle > 360 || selectAngle < 0)
            {
                Console.WriteLine("Because you could not make up your mind your number will be random");
                selectAngle = randNum.Next(0, 360);
                Console.WriteLine($"Your number is {selectAngle}");
            }

            if (selectAngle <= 22)
            {
                Console.WriteLine("You are facing North");
            }
            else if (selectAngle <= 67)
            {
                Console.WriteLine("You are facing North East");
            }
            else if (selectAngle <= 112)
            {
                Console.WriteLine("You are facing East");
            }
            else if (selectAngle <= 157)
            {
                Console.WriteLine("You are facing South East");

            }
            else if (selectAngle <= 202)
            {
                Console.WriteLine("You are facing South");
            }
            else if (selectAngle <= 247)
            {
                Console.WriteLine("You are facing South West");
            }
            else if (selectAngle <= 292)
            {
                Console.WriteLine("You are facing West");
            }
            else if (selectAngle <= 337)
            {
                Console.WriteLine("You are facing North West");
            }
            else if (selectAngle <= 360)
            {
                Console.WriteLine("You are facing North");

            }
            */

            /*
             * 
            //2
            int finalPrice, firstHour, hours, minutes;
            firstHour = 4;
            Console.WriteLine("Greetings! Please enter the amount of hours you've stayed at the parking garage");
            while (!Int32.TryParse(Console.ReadLine(), out hours)) 
            {
                Console.WriteLine("Invalid input, try again");
            }
            if (hours > 24)
            {
                hours = 20;
            }
            if (hours < 0) 
            {
                hours = 0;
            }

                Console.WriteLine("How many minutes have you stayed at the parking garage");
            while (!Int32.TryParse(Console.ReadLine(), out minutes))
            {
                Console.WriteLine("Invalid input, try again");
            }

            if (minutes > 60) 
            { 
                minutes = 60;
            }


            if (minutes < 0) 
            { 
                minutes = 0;
            }


            if (minutes >= 30) 
            {
                Console.WriteLine($"You have stayed at the parking garage for a total of { hours + 1} hours");
            }


            else if (minutes < 30) 
            { 
                Console.WriteLine($"You have stayed at the parking garage for a total of {hours} hours and {minutes} minutes");
            }

           
            finalPrice = (firstHour + (2 * (hours - 1)));
            if (finalPrice > 42) 
            { 
                finalPrice = 42;
            }

            if (finalPrice == 42)
            {
                Console.WriteLine($"Your final price is {finalPrice}$ becuase we only charge for 20 hours out of the day");
            }
            else if (finalPrice < 42) 
            {
                Console.WriteLine($"Your final price is {finalPrice}$");
            }
            */
            /*
            // 3
            int windSpeed;

            Console.WriteLine("What is the current wind speed? (In mph)");

            while (!Int32.TryParse(Console.ReadLine(), out windSpeed))
            {
                Console.WriteLine("Invalid input, try again.");
            }
            if (windSpeed <= 74)
            {
                Console.WriteLine("Its just really windy, your chillin");
            }
            else if (windSpeed <= 95)
            {
                Console.WriteLine("This is a catagory one huriccane, move electronics and valubles away from windows");
            }
            else if (windSpeed <= 110) 
            { 
                Console.WriteLine("This is a catagory two hurricane take refuge in a room with no windows (NOT THE BASEMENT) ");
            }
            else if (windSpeed <= 130)
            {
                Console.WriteLine("This is a catagory three hurricane seek shelter in a bathroom on the main level in your house away from windows ");
            }
            else if (windSpeed <= 155)
            {
                Console.WriteLine("This is a catagory four hurricane evacuate the area if told to by authorities ");
            }
            else if (windSpeed >= 155)
            {
                Console.WriteLine("This is a catagory five hurricane evacuate the area if told to by authorities ");
            }
            */

        }
    }
}
