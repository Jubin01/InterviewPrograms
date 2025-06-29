//test protected internal member myValue access from same assembly
namespace InterviewPrograms
{
    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    internal class ProtectedInternalTestAccess
    {
        internal void Execute()
        {
            var baseObject = new BaseClass();
            baseObject.myValue = 5;
            Console.WriteLine("myValue accessed by instance of Base Class within containing assembly: " + baseObject.myValue);
        }
    }
}