// Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.

using System.Runtime.InteropServices;

Console.WriteLine("Введите выражение для вычисления вида a + b или a - b, или a / b, или a * b:");
string? mathExpression = Console.ReadLine();

Console.WriteLine($"Результат вычисления: {Calculate(mathExpression)}");
 
static int Calculate(string? mathExpression)
{
    int number1 = 0;
    int number2 = 0;
    char op = ' ';
    if (mathExpression != null)
    {
        if (mathExpression.Length == 5)
        {
            number1 = Convert.ToInt32(mathExpression.Substring(0,1));
            number2 = Convert.ToInt32(mathExpression.Substring(4,1));
            op = Convert.ToChar(mathExpression[2]);
        }
        if (mathExpression.Length == 3)
        {
            number1 = Convert.ToInt32(mathExpression.Substring(0,1));
            number2 = Convert.ToInt32(mathExpression.Substring(2,1));
            op = Convert.ToChar(mathExpression[1]);
        }
        return op switch
        {
            '+' => number1 + number2,
            '-' => number1 - number2,
            '*' => number1 * number2,
            '/' => number1 / number2,
            _ => throw new Exception($"Ошибка. Введите математическое выражение вида a + b или a - b, или a / b, или a * b")
        };
    }
    else throw new Exception($"Ошибка. Введите математическое выражение вида a + b или a - b, или a / b, или a * b");
}