using System;

namespace classes;

//Main Class
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

        Employee employee2 = new Employee(2, "Enes", "Manager");
        employee2.EmployeeDetails();


        employee2.EmployeeCountDetails();

        Console.WriteLine("Add 1 + 2 :" + Operations.Add(1, 2));
        Console.WriteLine("Subtract 3 - 2 :" + Operations.Subtract(3, 2));
        Console.WriteLine("Multiply 4 * 2 :" + Operations.Multiply(4, 2));
        Console.WriteLine("Divide 10 / 2 :" + Operations.Divide(10, 2) + "\n");

        Rectangle rectangle = new Rectangle(10, 20);
        Console.WriteLine("Area of Rectangle : " + rectangle.GetArea() + "\n");

        Console.WriteLine("Monday is the " + (int)(Days.Monday) + "st day.\n");

        Console.ReadKey();
    }
}

// Class
class Employee
{
    //Constructor : Special method that is called when an object of a class is created
    public Employee()
    {
        Console.WriteLine("Main Constructor Called");
        _employeeCount++;
    }
    static Employee()
    {
        Console.WriteLine("Static Constructor Called");
        _employeeCount = 0;
    }
    // Overloading Constructor
    public Employee(int id, string name, string department)
    {
        Console.WriteLine("Overloading Constructor Called");
        Id = id;
        Name = name;
        Department = department;
        _employeeCount++;
    }

    // Properties (getters and setters), Encapsulation : Binding data with methods
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    private static int _employeeCount;
    public static int EmployeeCount
    {
        get
        {
            return _employeeCount;
        }
    }

    // Methods (functions)
    public void EmployeeDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("Id : {0}", Id);
        Console.WriteLine("Name : {0}", Name);
        Console.WriteLine("Department : {0}", Department + "\n");
    }
    public void EmployeeCountDetails()
    {
        Console.WriteLine("Employee Count : {0}", _employeeCount + "\n");
    }
}

public class Rectangle
{
    private int length { get; set; }
    private int width { get; set; }
    public Rectangle()
    {

    }

    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public int GetArea()
    {
        return Operations.Multiply(length, width);
    }

}

// Static class
static class Operations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

// Enum
enum Days
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}