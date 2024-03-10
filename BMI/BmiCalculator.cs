using System.Reflection.PortableExecutable;
using System.Threading.Channels;

namespace BMI
{
    public class BmiCalculator
    {

        public static void UseBMI()
        {
            double height;
            double weight;
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to BMI INDEX !!!");
            do
            {
                Console.Write("Input your height (centimeters): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Please input your height again!!");
                } 
            } while (height <= 0);

            do
            {
                Console.Write("Input your weight (kilograms): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Please input your weight again!!");
                }
            } while (weight <= 0);

            double bmi = GetBMI(height, weight);
            if(bmi > 50)
            {
                Console.WriteLine("You're not a person, right?");
            }
            else
            {
                string status = BmiStatus(bmi);
                Console.WriteLine($"Your BMI is {bmi} based on {height} centimeters and {weight} kilograms ");
                Console.WriteLine($"And your WeightStatus is {status}");
            }
        }

        static double GetBMI(double height, double weight)
        {
            height = height / 100;
            return weight / (height * height);
        }


        static string BmiStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            if (bmi < 23)
            {
                return "Normal weight";
            }
            if (bmi < 25)
            {
                return "Overweight";
            }
            if (bmi < 30)
            {
                return "Obese level I";
            }
            if (bmi < 35)
            {
                return "Obese level II";
            }
            return "Obese level III";
        }

    }
}
