
namespace InterviewPrograms
{
    internal class CallbackDelegate
    {
        internal delegate void CallbackDel(string message);
        internal void Execute()
        {
            // instantiate the delegate.
            CallbackDel delhandler = new CallbackDel(DelegateMethod);

            // pass the deleagte to a method as callback
            MethodWithCallback(1, 2, delhandler);
        }
        // create a method for a delegate.
        internal void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        internal void MethodWithCallback(int param1, int param2, CallbackDel callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}