//Oppgave 1: Lag en metode som tar imot to tall og returnerer true dersom tallene er like.

Console.WriteLine("Check if the numbers are equal.");
Console.WriteLine("Enter the first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number1} = {number2} is {CheckNumbers()}");
bool isEqual;

bool CheckNumbers()
{
    if (number1 == number2)
    {
        return isEqual = true;
    }
    else
    {
        return isEqual = false;
    }
}