
namespace InterviewPrograms
{
    internal class CallbackDelegate
    {
        private delegate void CallbackDel(string message);
        internal void Execute()
        {
            // instantiate the delegate.
            CallbackDel delhandler = new CallbackDel(DelegateMethod);

            // pass the deleagte to a method as callback
            MethodWithCallback(1, 2, delhandler);
        }
        // create a method for a delegate.
        private static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        private static void MethodWithCallback(int param1, int param2, CallbackDel callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}