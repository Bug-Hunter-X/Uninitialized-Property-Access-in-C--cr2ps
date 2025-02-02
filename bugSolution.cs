public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        MyProperty = 10; // Initialize the property before accessing it
        Console.WriteLine(MyProperty); // Accessing the initialized property
    }
}