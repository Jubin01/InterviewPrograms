
using System.Reflection;
using Delegate = InterviewPrograms.Delegate;
namespace UnitTests
{
    public class DelegateTests
    {
        //check the existense of Execute method in the classses
        [Fact]
        public void TestExecute()
        {
            Delegate obj = new Delegate();
            var methods = typeof(Delegate).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var methodName = methods.Where(x => x.Name == "Execute").Select(x => x.Name).FirstOrDefault();            
            Assert.Equal("Execute",methodName);
        }
    }
}