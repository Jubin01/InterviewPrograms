//test protected internal member myValue access from another assembly
using InterviewPrograms;

namespace Assembly2
{
    internal class DerivedClass : BaseClass
    {
        internal void Execute()
        {
            var baseObject = new BaseClass();
            var derivedObject = new DerivedClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 10;

            // OK, because this class derives from BaseClass.
            derivedObject.myValue = 10;
            Console.WriteLine("myValue accessed by instance of Derived Class in another assembly: " + derivedObject.myValue);
        }
    }
}
