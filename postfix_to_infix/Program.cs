using System;
using System.Collections.Generic;

class Program
{
    // Yardımcı fonksiyon: Operatör öncelik seviyesini döndürür.
    static int GetOperatorPrecedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            case '^':
                return 3;
            default:
                return 0; // Geçersiz operatör veya operatör yoksa
        }
    }

    // Postfix ifadeyi infix ifadeye dönüştüren fonksiyon
    static string PostfixToInfix(string postfix)
    {
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < postfix.Length; i++)
        {
            char symbol = postfix[i];

            if (Char.IsLetterOrDigit(symbol))
            {
                stack.Push(symbol.ToString());
            }
            else
            {
                string operand2 = stack.Pop();
                string operand1 = stack.Pop();
                string result = operand1 + symbol + operand2;
                stack.Push(result);
            }
        }

        return stack.Pop();
    }

    static void Main()
    {
        string postfixExpression = "ab*cab*c/d-/-g+";
        string infixExpression = PostfixToInfix(postfixExpression);

        Console.WriteLine("Postfix ifade: " + postfixExpression);
        Console.WriteLine("Infix ifade: " + infixExpression);
    }
}
