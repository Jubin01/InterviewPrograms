using System.Runtime.CompilerServices;

namespace InterviewPrograms
{
    internal class Delegate
    {
        private delegate void CallbackDelegate(string message);
        internal void Execute()
        {
            // instantiate the delegate.
            CallbackDelegate delhandler = new CallbackDelegate(DelegateMethod);

            // call the delegate.
            delhandler.Invoke("Hello Delegate");
        }
        // create a method for a delegate.
        internal void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
