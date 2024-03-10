namespace Zodiac
{
    public class ZodiacSign
    {
        public static void ReturnEN()
        {
            string x = GetZodiacEnglish();
            Console.WriteLine($"Your Zodiac Sign is: {x}");
        }

        public static void ReturnVN()
        {
            string y = GetZodiacVietnamese(GetZodiacEnglish());
            Console.WriteLine($"Your Zodiac Sign is: {y}");
        }
        public static string GetZodiacEnglish()
        {
            int day, month;
            do
            {
                Console.Write("Input your DAY: ");
                day = int.Parse(Console.ReadLine());
                if(day > 31 || day <= 0)
                {
                    Console.WriteLine("Please input DAY again!");
                }
            } while (day <1 || day >31);

            do
            {
                Console.Write("Input your MONTH: ");
                month = int.Parse(Console.ReadLine());
                if (month > 12 || month <= 0)
                {
                    Console.WriteLine("Please input MONTH again!");
                }
            } while (month > 12 || month == 0);
            
                switch (month)
                {
                    case 1://Jan
                        if (day <= 19)
                            return "Capricorn"; //ma kết
                        return "Aquarius"; // bảo bình

                    case 2://Feb
                        if (day <= 18)
                            return "Aquarius"; // bảo bình
                        return "Pisces";

                    case 3://Mar
                        if (day <= 20)
                            return "Pisces";
                        return "Aries";

                    case 4:
                        if (day <= 19)
                            return "Aries";
                        return "Taurus";

                    case 5:
                        if (day <= 19)
                            return "Taurus";
                        return "Gemini";

                    case 6:
                        if (day <= 19)
                            return "Gemini";
                        return "Cancer";

                    case 7:
                        if (day <= 19)
                            return "Cancer";
                        return "Leo";

                    case 8:
                        if (day <= 19)
                            return "Leo";
                        return "Virgo";

                    case 9:
                        if (day <= 19)
                            return "Virgo";
                        return "Libra";

                    case 10:
                        if (day <= 19)
                            return "Libra";
                        return "Scorpio";

                    case 11:
                        if (day <= 19)
                            return "Scorpio";
                        return "Sagittarius";

                    case 12:
                        if (day <= 19)
                            return "Sagittarius";
                        return "Capricorn";
                    default:
                        return "em của ngày hôm qua";
                }
        }

        public static string GetZodiacVietnamese(string zodiacEnglish)
        {
            switch (zodiacEnglish)
            {
                case "Capricorn":
                    return "Ma Kết";
                case "Aquarius":
                    return "Bảo Bình";
                case "Pisces":
                    return "Song Ngư";
                case "Aries":
                    return "Bạch Dương";
                case "Taurus":
                    return "Kim Ngưu";
                case "Gemini":
                    return "Song Tử";
                case "Cancer":
                    return "Cự Giải";
                case "Leo":
                    return "Sư Tử";
                case "Virgo":
                    return "Xử Nữ";
                case "Libra":
                    return "Thiên Bình";
                case "Scorpio":
                    return "Bọ Cạp";
                case "Sagittarius":
                    return "Nhân Mã";
                default:
                    return "Ngọc Trinh";  //one of my dream girls
            }
        }

    }
}
