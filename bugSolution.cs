public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public ExampleClass()
    {
        MyProperty = 10; // Initialize in the constructor
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now this will print the initialized value.
    }
}