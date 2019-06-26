//to use classes in other classes, you have to use inheritance. it is a pain but when you have to use multiple classes for little or no purpose it has to be used. peace out.
using System;

public class Person {

  //No arugment constuctor
  public Person() 
  {
    Name = "unknown";
  }
  //One argument constructor
  public Person(string name) 
  {
    Name = name;
  }
  //Auto implemented read only property?
  public string Name { get; }

  //Method that overrides the base class system.object implementation
  public override string ToString()
  {
    return Name;
  }
}
//new class aw yeah
class TestPerson 
{
    static void Main()
    {
      //call constructor that has no parameters from the first class! wow look at that
      var person1 = new Person();
      Console.WriteLine(person1.Name);

      //now call one parameter constructor
      var person2 = new Person("Bobby.");
      Console.WriteLine(person2.Name);
      //get string representation of the person2 instance??
      Console.WriteLine(person2);
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }
}