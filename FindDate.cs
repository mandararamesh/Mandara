using System;
using System.Text.RegularExpressions;

class FindDate
{
    static void Main()
    {
       // string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
         Console.Write("Enter Input: ");
        string input = Console.ReadLine();

        // Regular expression to match MMDDYYYY
        string pattern = @"\b(\d{2})(\d{2})(\d{4})\b";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);

        if (match.Success)
        {
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;

            if (IsValidDate(month, day, year))
            {
                Console.WriteLine($"Found valid date: {month}/{day}/{year}");
            }
            else
            {
                Console.WriteLine("The date is invalid.");
            }
        }
        else
        {
            Console.WriteLine("No date found.");
        }
    }

    static bool IsValidDate(string month, string day, string year)
    {
        if (!int.TryParse(month, out int m) || !int.TryParse(day, out int d) || !int.TryParse(year, out int y))
        {
            return false;
        }

        if (m < 1 || m > 12)
        {
            return false;
        }

        if (d < 1 || d > DateTime.DaysInMonth(y, m))
        {
            return false;
        }

        return true;
    }
}
