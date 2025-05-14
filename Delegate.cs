class Delegate
{
    public delegate void CallbackDelegate(string message);
    public void Execute()
    {
        // Instantiate the delegate.
        CallbackDelegate delhandler = new CallbackDelegate(DelegateMethod);

        // Call the delegate.
        delhandler.Invoke("Hello Delegate");
    }
    // Create a method for a delegate.
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
}