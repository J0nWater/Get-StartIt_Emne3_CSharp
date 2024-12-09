//Oppgave 2: Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike,
//og returnerer tallene multiplisert med hverandre dersom de er like

Console.WriteLine("If the numbers are not equal then both numbers will be summed, \n" +
    "or if the numbers are equal then the numbers will be multiplied.\n");

Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());

int result;

CheckEqual();
void CheckEqual()
{
    if (number1 == number2)
    {
        result = number1 * number2;
        Console.WriteLine($"\n{number1} is equal to {number2}");
        Console.WriteLine($"Numbers are multiplied {number1} * {number2} = {result} ");
    }
    else
    {
        result = number1 + number2;
        Console.WriteLine($"\n{number1} is equal to {number2}");
        Console.WriteLine($"Numbers are summed {number1} + {number2} = {result} ");
    }
}