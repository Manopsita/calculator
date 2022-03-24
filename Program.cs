// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("**********************************************");
System.Console.WriteLine("Enter two numbers seperated by a `new line`: ");
System.Console.WriteLine(
@"For e.g.
XX
YY"
);
System.Console.WriteLine("**********************************************");
float.TryParse(Console.ReadLine(), out var num1);
float.TryParse(Console.ReadLine(), out var num2);
System.Console.WriteLine();
Console.WriteLine($"You entered: {num1} and {num2}");
System.Console.WriteLine();
System.Console.WriteLine(@"Enter the option number for the desired operation:
1. For adding both the numbers
2. For subtracting `second` from `first`
3. For multiplying both the numbers
4. For dividing `first` by `second`");
int.TryParse(Console.ReadLine(), out var op);
System.Console.WriteLine();
if (op == default)
{
    System.Console.WriteLine("You have chosen the wrong option");
}
else
{
    string expression;
    float result;
    switch (op)
    {
        case 1:
            expression = $"{num1} + {num2}";
            result = num1 + num2;
            break;
        case 2:
            expression = $"{num1} - {num2}";
            result = num1 + num2;
            break;
        case 3:
            expression = $"{num1} X {num2}";
            result = num1 * num2;
            break;
        case 4:
            expression = $"{num1} / {num2}";
            result = num1 / num2;
            break;
        default:
            expression = string.Empty;
            result = default;
            break;
    }
    if (expression == string.Empty)
    {
        System.Console.WriteLine("You have chosen the wrong option");
    }
    else
    {
        System.Console.WriteLine();

        System.Console.WriteLine($"Result: {expression} = {result}");
        System.Console.WriteLine();

    }
}
