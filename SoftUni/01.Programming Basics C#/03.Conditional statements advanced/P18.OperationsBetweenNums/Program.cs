namespace P18.OperationsBetweenNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double result = 0;
            string textResult = string.Empty;

            switch (@operator)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = (double)firstNum * secondNum;
                    break;
                case '/':
                    if (secondNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNum} by zero");
                        return;
                    }
                    result = (double)firstNum / secondNum;
                    Console.WriteLine($"{firstNum} {@operator} {secondNum} = {result:F2}");
                    return;
                case '%':
                    if (secondNum == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNum} by zero");
                        return;
                    }
                    result = (double)firstNum % secondNum;
                    Console.WriteLine($"{firstNum} {@operator} {secondNum} = {result}");
                    return;
            }

            string numberType = result % 2 == 0 ? "even" : "odd";

            Console.WriteLine($"{firstNum} {@operator} {secondNum} = {result} - {numberType}");
        }
    }
}