
using System.Reflection;
using InterviewPrograms;
using Microsoft.VisualBasic;

namespace UnitTests
{
    public class AbstractTest
    {
        //check if Abstract Method is implemented
        [Fact]
        internal void TestAbstractMethodImplemented()
        {
            var o = new DerivedFromAbstractClass();
            o.AbstractMethod();
        }

        //check if Abstract properties are overridden
        [Fact]
        internal void TestAbstractPropertiesImplemented()
        {
            var o = new DerivedFromAbstractClass();
            int x = o.X;
            int y = o.Y;
        }





    }
}