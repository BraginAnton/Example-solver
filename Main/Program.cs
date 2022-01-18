using System;

namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Example: ");
                    Console.WriteLine(ResultExample(Console.ReadLine()));
                } 
                catch (FormatException)
                {
                    Console.WriteLine("Error");
                }
            }   
        }

        static string ResultExample(string example)
        {
            double result = 0;

            if (example.Contains('+'))
            {
                double OneExNum = Convert.ToDouble(example.Substring(0, example.IndexOf('+')).Trim());
                double TwoExNum = Convert.ToDouble(example.Substring(example.IndexOf('+') + 1).Trim());
                result = OneExNum + TwoExNum;
            }
            else if (example.Contains('-'))
            {
                double OneExNum = Convert.ToDouble(example.Substring(0, example.IndexOf('-')).Trim());
                double TwoExNum = Convert.ToDouble(example.Substring(example.IndexOf('-') + 1).Trim());
                result = OneExNum - TwoExNum;
            } 
            else if (example.Contains('/'))
            {
                double OneExNum = Convert.ToDouble(example.Substring(0, example.IndexOf('/')).Trim());
                double TwoExNum = Convert.ToDouble(example.Substring(example.IndexOf('/') + 1).Trim());
                result = OneExNum / TwoExNum;
            }
            else if (example.Contains('*'))
            {
                double OneExNum = Convert.ToDouble(example.Substring(0, example.IndexOf('*')).Trim());
                double TwoExNum = Convert.ToDouble(example.Substring(example.IndexOf('*') + 1).Trim());
                result = OneExNum * TwoExNum;
            }

            return Convert.ToString(result);
        }
    }
}
