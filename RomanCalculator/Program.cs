// See https://aka.ms/new-console-template for more information
using Calculator;

var running = true;
var calc = new RomanCalculator();
OnInfo();

while (running)
{
    var input = Console.ReadLine();
    switch (input)
    {
        case "q":
            running = false;
            break;

        case "?":
            OnInfo();
            break;

        case "cls":
            Console.Clear();
            break;
        default:
            try
            {
                if (double.TryParse(input, out var result))
                {
                    Console.WriteLine(calc.DecimalToRoman(result));
                }
                else
                {
                    Console.WriteLine(calc.RomanToInt(input));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
}

void OnInfo()
{
    Console.WriteLine("Send a decimal or whole to convert it to a roman numeral");
    Console.WriteLine("    *The number most be greater than zero and less than 4000");
    Console.WriteLine("    **Decimal numbers are rounded up if the number is >= 5, and down if < 5");
    Console.WriteLine("Send a roman numeral to convert it to a whole number");
    Console.WriteLine("    *Any numeral may only be repeated three times. V, L and D can never repeat");
    Console.WriteLine("Send 'q' to quit the program.");
    Console.WriteLine("Send '?' to get this info prompt again.");
    Console.WriteLine("send 'cls' to clear the screen.");
}


