using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }

        }

        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia ogólne do całości.
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Ta metoda wypisuje komunikat zależny od wieku.
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz, ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Brawo, jesteś pełnoletni, możesz wypić piwo");

            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś niepoprawny wiek. Wymagana jest liczba.");

            }
            else
            {
                Console.WriteLine("Możemy Ci zaoferować mleko.");
            }
        }
        /// <summary>
        /// Ta metoda wypisuje powitanie do użytkownika.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
