using System;

namespace classes;

class Program
{
    static void Main(string[] args)
    {
        // Classes are reference types
        // Access Modifiers : public, private, protected, internal, protected internal
        // public : Accessible from anywhere
        // private : Accessible only from the same class
        // protected : Accessible only from the same class or any derived class
        // internal : Accessible only from the same assembly
        // protected internal : Accessible only from the same assembly or any derived class
        // Default access modifier is internal

        // Creating an object of Employee class
        Employee employee1 = new Employee();
        employee1.Id = 1;
        employee1.Name = "Faruk";
        employee1.Department = "IT";
        employee1.EmployeeDetails();

        Employee employee2 = new Employee();
        employee2.Id = 2;
        employee2.Name = "Enes";
        employee2.Department = "Manager";
        employee2.EmployeeDetails();

        Console.ReadKey();

    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public void EmployeeDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("Id : {0}", Id);
        Console.WriteLine("Name : {0}", Name);
        Console.WriteLine("Department : {0}", Department + "\n");
    }
}