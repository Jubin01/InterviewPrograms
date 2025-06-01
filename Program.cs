namespace InterviewPrograms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Delegate obj = new Delegate();
            CallbackDelegate obj = new CallbackDelegate();
            obj.Execute();
        }
    }
}