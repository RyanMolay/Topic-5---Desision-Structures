using System.Security.Cryptography;

namespace Topic_5___Desision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectAngle;
            Random randNum = new Random();
            Console.WriteLine("Please enter a number from 0 to 360");
            selectAngle = Convert.ToInt32(Console.ReadLine());
            if (selectAngle > 360)
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

        }
    }
}
