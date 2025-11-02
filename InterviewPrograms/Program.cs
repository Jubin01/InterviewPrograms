using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("UnitTests")]
namespace InterviewPrograms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Delegate obj = new Delegate();
            // CallbackDelegate obj = new CallbackDelegate();
            //ProtectedInternalTestAccess obj = new ProtectedInternalTestAccess();
            // AbstractTest obj = new AbstractTest();
            //SealedTest obj = new SealedTest();
            SealedMemberTest obj = new SealedMemberTest();
            obj.Execute();
        }
    }
}