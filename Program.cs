using System;

namespace HelloWorld
{
  class Person
  {
    private string Name;
    private ulong Age;

    public Person()
    {
      Name = "Unknown";
      Age = 0;
    }

    public Person(string name, ulong age)
    {
      Name = name;
      Age = age;
    }

    public void Greet()
    {
      Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
    }
  }

  class Program
  {
    static ulong factorial(ulong number)
    {
      if (number <= 1)
      {
        return 1;
      }

      return number * factorial(number - 1);
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello world!");

      for (ulong number = 0; number <= 10; number++)
      {
        Console.WriteLine($"{number}! = {factorial(number)}");
      }

      string[] fruits = { "Apple", "Banana", "Cherry" };

      foreach (string fruit in fruits)
      {
        Console.WriteLine(fruit);
      }

      Person person = new Person("John", 43);
      person.Greet();
    }
  }
}
