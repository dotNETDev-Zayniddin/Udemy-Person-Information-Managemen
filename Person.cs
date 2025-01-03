using System;
namespace Udemy
{
    class Person
    {
        public int PersonID { get; set; }
        public string Name = "";
        public int Age { get; set; }
        public string Adress = "";

        public void Display()
        {
            System.Console.WriteLine($"PersonID: {PersonID}, Name: {Name}, Age: {Age}, Adress: {Adress}");
        }
        public void Update()
        {
            System.Console.WriteLine();
        }
    }
}