using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new DecimalToRomanConverter();

            while (true)
            {
                Console.WriteLine("Saisir une valeur entière positive :");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out var inputInt))
                    break;

                var output = converter.Convert(inputInt);

                Console.WriteLine($"En chiffres romains : {output}");
            }
        }
    }
}
