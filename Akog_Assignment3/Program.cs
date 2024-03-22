using Akog_Assignment3;

class MainProgram
{
    static void Main(string[] args)
    {
        Person bob = new Person();
        Console.WriteLine(bob.IsValidated());

        Person kim = new Person("kim", "smith");
        Console.WriteLine(kim.IsValidated());
    }
}

