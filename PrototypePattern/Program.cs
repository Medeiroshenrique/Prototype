using System;

namespace PrototypePattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.Name = "Misael Paulo";
            permanentEmployee.Age = 25;
            permanentEmployee.Type = "Permanent";

            PermanentEmployee clonePermanentEmployee = (PermanentEmployee)permanentEmployee.Clone();
            clonePermanentEmployee.Name = "Noah Coulson";
            clonePermanentEmployee.Age = 32;

            Console.WriteLine("Permanent Employee details:");
            Console.WriteLine($"Name {permanentEmployee.Name}");
            Console.WriteLine($"Age {permanentEmployee.Age}");
            Console.WriteLine($"Kind: {permanentEmployee.Type}");

            Console.WriteLine();
            
            Console.WriteLine("Cloned Employee details:");
            Console.WriteLine($"Name {clonePermanentEmployee.Name}");
            Console.WriteLine($"Age {clonePermanentEmployee.Age}");
            Console.WriteLine($"Kind: {clonePermanentEmployee.Type}");

            Console.ReadKey();
        }
    }
}