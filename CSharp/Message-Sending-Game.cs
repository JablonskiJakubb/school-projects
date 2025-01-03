using System;
using System.Collections.Generic;

public class MessageSendingGame
{
    // List of recipients
    static string[] recipients = new string[] { "Kasia", "Basia", "Asia", "Joasia" };
    static bool eligible = false; // Flag for eligibility

    public static void Main(string[] args)
    {
        ConsoleKey key;
        DisplayMainMenu();

        do
        {
            key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    DisplayMessageForm();
                    break;
                case ConsoleKey.D2:
                    if (eligible)
                    {
                        break;
                    }
                    else
                    {
                        DisplayEligibilityTask();
                    }
                    DisplayMainMenu();
                    break;
                case ConsoleKey.Escape:
                    break;
                default:
                    Console.WriteLine("Please read the menu.");
                    break;
            }
        }
        while (key != ConsoleKey.Escape);
    }

    // Display the main menu
    static void DisplayMainMenu()
    {
        Console.WriteLine("Write - choose 1");
        Console.WriteLine("Solve - choose 2");
        Console.WriteLine("Exit - Escape");
    }

    // Show task to become eligible for sending message
    static void DisplayEligibilityTask()
    {
        Random rand = new Random();
        int a = rand.Next(1, 10);
        int b = rand.Next(1, 10);
        int c = rand.Next(1, 10);
        string operation = string.Format("{0} + {1} * {2}", a, b, c);
        Console.WriteLine(operation);
        Console.WriteLine("Enter the result: ");
        int userAnswer = int.Parse(Console.ReadLine());
        int result = a + b * c;
        if (result == userAnswer)
        {
            eligible = true;
        }
        else
        {
            eligible = false;
        }
    }

    // Display the message form (recipient selection)
    static void DisplayMessageForm()
    {
        Console.WriteLine("Choose a recipient: ");
        int index = 1;
        foreach (var item in recipients)
        {
            Console.WriteLine(index + " - " + item);
            index++;
        }
    }
}
