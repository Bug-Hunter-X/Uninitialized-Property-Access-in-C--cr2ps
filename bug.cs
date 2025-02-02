public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); //Accessing uninitialized property.

        //This fixes the error
        MyProperty = 10;
        Console.WriteLine(MyProperty); //Accessing initialized property.
    }
}