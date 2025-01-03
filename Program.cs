using System;
namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
             PersonManager manager = new PersonManager();
           bool isWorking = true;
            while(isWorking)
            {
                
            System.Console.WriteLine("1. Add a Person");
            System.Console.WriteLine("2. Display All Persons");
            System.Console.WriteLine("3. Search for a Person");
            System.Console.WriteLine("4. Update Adress");
            System.Console.WriteLine("5. Exit");
            System.Console.WriteLine();
            System.Console.Write("Enter your choice: ");
           
            string choose = Console.ReadLine();
           
                switch (choose)
            {
                case "1":
                {
                    manager.Add();
                    break;
                }
                case "2":
                {
                    manager.DisplayAll();
                    break;
                }
                case "3":
                {
                    manager.Search();
                    break;  
                }
                case "4":
                {
                    manager.Update();
                    break;
                }
                case "5":
                {
                    System.Console.WriteLine("Exiting...");
                    isWorking = false;
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Input was wrong. Try Again!");
                    break;
                }
            }
             }
           }
           catch (FormatException ex)
           {
            System.Console.WriteLine("Input was invalid. Please try Again.");
           }
           catch(Exception ex)
           {
            System.Console.WriteLine("Unhandled error occured.");
            System.Console.WriteLine("Error: " + ex.Message);
           }
           }
    }
}