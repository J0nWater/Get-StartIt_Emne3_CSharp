namespace _2_Oppgave_Lag_8_variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3; //-2,147,483,648 to 2,147,483,647
            long longNumber = 365l; //	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 Suffix l
            float decimalNumber = 1.12f; //-3.402823e38 to 3.402823e38 Suffix f
            double decimalNumber2 = 2.6545; //-1.79769313486232e308 to 1.79769313486232e308
            decimal decimalNumber3 = 5.6546745m; //	(+ or -)1.0 x 10e-28 to 7.9 x 10e28 Suffix m
            string text = "Hello"; //text inside string
            char character = 'a'; //any character
            bool boolean = true; // true or false
        }
    }
}
