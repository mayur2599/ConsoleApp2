using System;
public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre a 1 Nummber :");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entre a 2 Number");
        int j = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        Console.WriteLine("Entre a Operation to Perform ? +,-,/,*");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = i + j;
                break;
            case '-':
                result = i - j;
                break;
            case '/':
                result = i / j;
                break;
            case '*':
                result = i * j;
                break;

        }
        Console.WriteLine("Result is : " + result);
        Console.ReadLine();
    }
}
