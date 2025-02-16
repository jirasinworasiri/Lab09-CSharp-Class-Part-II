// See https://aka.ms/new-console-template for more information
Person.name = "jirasin"; 
System.Console.WriteLine(Person.GetName());  
var student = new Student();
Student.name = "66030029";
Console.WriteLine(Student.GetName());

class Person
{
    public static string? name;  
    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}