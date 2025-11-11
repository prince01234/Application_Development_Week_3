
//Create the following methods inside the Operators class:
//Add(int a, int b) — prints the sum of two numbers
//Subtract(int a, int b) — prints the difference
//Multiply(int a, int b) — prints the product
//Divide(int a, int b) — prints the result of division

class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine(a / b);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
/* 
Create another method inside the same class:
OddEvenFinder(int number) — determines whether the given number 
is Odd or Even using the Ternary Operator (? :) and prints the message "Even Number" or "Odd Number".
*/
public void OddOrEven(int c)
    {
        string result = (c % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }


    //In Program.cs: Call all the methods of the Operators class.  
    static void Main()
    {
        var ops = new Operators();

        int a = 12;
        int b = 7;

        ops.Add(a, b);
        ops.Subtract(a, b);
        ops.Multiply(a, b);
        ops.Divide(a, b);
        ops.OddOrEven(a);
        ops.OddOrEven(b);

    }
}

