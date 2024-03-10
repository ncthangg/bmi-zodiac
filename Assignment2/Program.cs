using BMI;
using Zodiac;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Menu();
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        BmiCalculator.UseBMI();
                        break;
                    case 2:
                        ZodiacCalculate();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Please input your choose again!!!");
                        break;
                }
            } while (x != 3);

        }

        public static void Menu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("-Menu-");
            Console.WriteLine("1. Comute BMI Index.");
            Console.WriteLine("2. Get The Zodiac Sign.");
            Console.WriteLine("3. Exit!!!.");
            Console.Write("Choose an option (1, 2, or 3): ");
        }

        public static void ZodiacMenu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("-Zodiac Sign Menu-");
            Console.WriteLine("1. Zodiac English.");
            Console.WriteLine("2. Zodiac Vietnamese.");
            Console.WriteLine("3. Back.");
            
        }

        public static void ZodiacCalculate()
        {
            int y;
            do
            {
                ZodiacMenu();
                Console.Write("Choose an option (1, 2, or 3): ");
                y = int.Parse(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        ZodiacSign.ReturnEN();
                        break;
                    case 2:
                        ZodiacSign.ReturnVN();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Please input your choose again!!!");
                        break;
                }
            } while (y != 3);
        }
    }
}
