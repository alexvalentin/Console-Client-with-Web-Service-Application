using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientForWSA
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleClientForWSA.ServiceReference1.WebService1SoapClient service = new ConsoleClientForWSA.ServiceReference1.WebService1SoapClient();

            Console.WriteLine("-----Loading Web Service-----\n");
            Console.ReadKey();

            // Convertor Celsius -> Fahrenheit
            double Fahrenheit = service.aFromCelsiustoFahrenheit(35);
            Console.WriteLine("35 Celsius degrees means " + Fahrenheit.ToString() + " Fahrenheit degrees.");

            // Convertor Fahrenheit -> Celsius
            double Celsius = service.aFromFahrenheittoCelsius(101);
            Console.WriteLine("\n101 Fahrenheit degrees means " + Celsius.ToString() + " Celsius degrees.");

            // Display Time
            string dateTimeDisplay = service.bDateTimeDisplay();
            Console.WriteLine("\nData actuala este:  " + dateTimeDisplay.ToString());

            // Convertor Euro -> Lei
            double Euro = service.dEuroToLei(35);
            Console.WriteLine("\n35 Euro means  " + Euro.ToString() + " Lei.");

            // Convertor Lei -> Euro
            double Lei = service.dLeiToEuro(450);
            Console.WriteLine("\n450 Lei means " + Lei.ToString() + " Euro.");

            
            // Five elements
            List <string> numbersStrLst = service.cfiveElements();

            Console.WriteLine("\nLista cu 5 elemente este: " + numbersStrLst[0] + ", " + numbersStrLst[1] + ", " + numbersStrLst[2] + ", " + numbersStrLst[3] + ", " + numbersStrLst[4]);

            Console.ReadKey();
        }
    }
}
