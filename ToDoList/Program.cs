using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static List<string> toDoList = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nTo-do liste");
                Console.WriteLine("1. Tilføj opgave");
                Console.WriteLine("2. Fjern opgave");
                Console.WriteLine("3. Vis opgaver");
                Console.WriteLine("4. Afslut");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        DisplayTasks();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Indtast en opgave: ");
            var task = Console.ReadLine();
            toDoList.Add(task);
        }

        static void RemoveTask()
        {
            DisplayTasks();
            Console.Write("Indtast opgavens nummer for at fjerne: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= toDoList.Count)
            {
                toDoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Opgave fjernet.");
            }
            else
            {
                Console.WriteLine("Ugyldigt nummer, prøv igen.");
            }
        }

        static void DisplayTasks()
        {
            Console.WriteLine("\nDine opgaver:");
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
        }
    }
}
