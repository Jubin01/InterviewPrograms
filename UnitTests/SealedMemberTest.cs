
using System.Reflection;
using InterviewPrograms;
using Microsoft.VisualBasic;

namespace UnitTests
{
    public class SealedMemberTest
    {
        //test whether sealed method exists
        [Fact]
        internal void TestSealedMethodExist()
        {
            MethodInfo method = typeof(Z).GetMethod("F", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.NotNull(method);
        }
        //test to access sealed method
        [Fact]
        internal void TestSealedMethodAccess()
        {
            var z = new Z();
            z.Execute();
        }





    }
}