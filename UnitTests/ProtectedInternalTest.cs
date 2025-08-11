
using System.Reflection;
using InterviewPrograms;
using Assembly2;
namespace UnitTests
{
    public class ProtectedInternalTest
    {
        //check the existence of Execute method in the classses
        [Fact]
        public void TestExecuteExists()
        {
            var methods = typeof(ProtectedInternalTestAccess).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var methodName = methods.Where(x => x.Name == "Execute").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("Execute", methodName);
        }

        //test the basecalss access
        [Fact]
        public void TestBaseClassAccess()
        {
            BaseClass baseObject = new BaseClass();
            baseObject.myValue = 5;
        }

        //test the derived class access
        [Fact]
        public void TestDerivedClassAccess()
        {
            DerivedClass derivedObject = new DerivedClass();
            derivedObject.myValue = 10;
        }

    }
}