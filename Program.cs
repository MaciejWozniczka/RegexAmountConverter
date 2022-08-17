using System;
using System.Text.RegularExpressions;

namespace RegexAmountConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValueAndCurrencyFromAmount();
        }

        private static void GetValueAndCurrencyFromAmount()
        {
            string amount = Console.ReadLine();
            //string amount = "150.05PLN";

            string resultValueString = "";
            decimal resultValue;
            string resultString = "";

            string[] result = Regex.Split(amount, "[a-z]+", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));
            for (int i = 0; i < result.Length; i++)
                resultValueString += result[i];

            resultValue = decimal.Parse(resultValueString.Replace(".", ","));

            result = Regex.Split(amount, "[0-9.,]+", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));
            for (int i = 0; i < result.Length; i++)
                resultString += result[i];

            Console.WriteLine(resultValue);
            Console.WriteLine(resultString);

            Console.ReadLine();
        }
    }
}
