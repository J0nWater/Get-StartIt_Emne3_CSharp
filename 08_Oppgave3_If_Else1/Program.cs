//Oppgave 3: Lag en metode som tar inn to int verdier.
//Dersom en av de, eller summen til int verdiene blir 30,
//skal metoden returnere true. Ellers returnerer metoden false

Console.WriteLine("Checking if one of the numbers or the sum is equal to 30\n");

Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = number1 + number2;
bool answer = false;

CheckNumbers();
void CheckNumbers()
{
    if (number1 == 30 || number2 == 30 || sum == 30)
    {
        answer = true;
        Console.WriteLine($"\nThe answer is: {answer} - Number 30 was found");
    }
    else
    {
        answer = false;
        Console.WriteLine($"\nThe answer is: {answer} - Number 30 is not found");
    }
}