using System;
namespace Udemy
{
    class PersonManager
    {
        List<Person> persons = new List<Person>();
       
        //Add new Person
        public void Add()
        {
            Person newPerson = new Person();
            System.Console.Write("Enter Person ID: ");
            newPerson.PersonID = int.Parse(System.Console.ReadLine());
            
            System.Console.Write("Enter Name: ");
            newPerson.Name = Console.ReadLine();
            
            System.Console.Write("Enter Age: ");
            newPerson.Age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter Adress: ");
            newPerson.Adress = Console.ReadLine();
            
            persons.Add(newPerson); // Adding person info into persons List
            System.Console.WriteLine("Person added succesfully.");

        }

        public void DisplayAll()
        {
            foreach(Person person in persons)
            {
                person.Display();
            }
        }

        public void Search()
        {
            System.Console.Write("Enter Name to search: ");
            string NameForSearch = Console.ReadLine();
            bool isFound = false;
            foreach(Person person in persons)
            {
               
               if(person.Name == NameForSearch)
               {
                person.Display();
                isFound = true;
               }
            }
              if(!isFound)
                {
                    System.Console.WriteLine("Person Not Found!");
                }

        }

        public void Update()
        {
            bool isFound = false;
            System.Console.Write("Enter Person ID to update address: ");
            int PersonIDForUpdate = int.Parse(System.Console.ReadLine());
            foreach (Person person in persons)
            {
                if(person.PersonID == PersonIDForUpdate)
                {
                    isFound = true;
                    person.Display();
                    Console.Write($"Enter new Adress: ");
                    string newAdress = Console.ReadLine();
                    person.Adress = newAdress;
                    System.Console.WriteLine("Successfuly updated.");
                }
            }
            if(!isFound)
            {
                System.Console.WriteLine("This ID is not found!");
            }
        }
        
    }
}