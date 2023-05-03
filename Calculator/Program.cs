using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            { 
                Console.WriteLine("Podaj 1. liczbę");
                var number1 = GetInPut();
                
                Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+;, '-', '/', '*';");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj 2. liczbę");
                var number2 = GetInPut();

                var result = Calculate(number1, number2, action);

                Console.WriteLine("Wynik Twojego działania to: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    
        private static int GetInPut()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość jest nieprawidłowa");

            return input;
        }
    private static int Calculate(int number1, int number2, string action) 
        {
            switch (action)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "/":
                    return number1 / number2;
                case "*":
                    return number1 * number2;
                default:
                    throw new Exception("Wybrałeś złą operację");
            }
        }
    }
}


    