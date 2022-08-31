using System;
namespace NestedLoopOperations
{
    class program
    {
        static bool programQuit = false;
        static void Main(string[] args)
        {
            while (programQuit == false)
            {
                MainMenuText();
                UserChoise(UserInput());
            }
        }

        static void MainMenuText()
        {
            Console.WriteLine("Gör ditt Val:");
            Console.WriteLine("1: Skriv ut 5 Table.");
            Console.WriteLine("2: Skriv ut tree.");
            Console.WriteLine("3: Avsluta Program");
        }
        static int UserInput()
        {
            string? inputString = Console.ReadLine();
            int inputNum;
            Int32.TryParse(inputString, out inputNum);
            return inputNum;
        }
        static void UserChoise(int UserInput)
        {
            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Du har gjort Val 1:");
                    Counter(true);
                    break;
                case 2:
                    Console.WriteLine("Du har gjort Val 2:");
                    Counter(false);
                    break;
                case 3:
                    Console.WriteLine("Program Avslutas:");
                    programQuit = true;
                    break;
                default:
                    Console.WriteLine("Dit val är ej giltigt, prova igen.");
                    UserChoise(UserInput);
                    break;

            }
            static void Counter(bool countUp)
            {
                if (countUp == true)
                {
                    int i = 1, n = 5, table;

                    do
                    {
                        table = n * i;
                        Console.WriteLine("{0} * {1} = {2}", n, i, table);
                        i++;
                    } while (i <= 10);
                }
                else
                {
                    for (int i = 1; i <= 25; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j + " ");
                        }
                        Console.WriteLine();
                    }

                }

            }
        }

    }
}


