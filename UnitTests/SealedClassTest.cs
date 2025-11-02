
using System.Reflection;
using InterviewPrograms;
using Microsoft.VisualBasic;

namespace UnitTests
{
    public class SealedClassTest
    {
        //test whether two variables x and y exist in sealed class
        [Fact]
        internal void TestVariablesExist()
        {
            var sc = new SealedClass();
            Assert.NotNull(sc.x);
            Assert.NotNull(sc.y);
        }
        //test to access these variables
        [Fact]
        internal void TestVariablesAccess()
        {
            var sc = new SealedClass();
            sc.x = 111;
            sc.y = 151;
            Assert.Equal(111,sc.x);
            Assert.Equal(151,sc.y);
        }





    }
}