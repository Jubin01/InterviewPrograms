
using System.Reflection;
using InterviewPrograms;
using Delegate = InterviewPrograms.Delegate;
namespace UnitTests
{
    public class DelegateTest
    {
        //check the existense of Execute method in the classses
        [Fact]
        public void TestExecute()
        {
            Delegate obj = new Delegate();
            var methods = typeof(Delegate).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var methodName = methods.Where(x => x.Name == "Execute").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("Execute", methodName);
        }

        //check the existense of DelegateMethod method in the classses
        [Fact]
        public void TestDelegateMethodExists()
        {
            Delegate obj = new Delegate();
            var methods = typeof(Delegate).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var methodName = methods.Where(x => x.Name == "DelegateMethod").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("DelegateMethod", methodName);
        }
        private delegate void CallbackDelegate(string message);
        //test the delegatemethod
        [Fact]
        public void TestDelegateMethod()
        {
            Delegate obj = new Delegate();
            CallbackDelegate delhandler = new CallbackDelegate(obj.DelegateMethod);
            // call the delegate.
            delhandler.Invoke("Hello Delegate");
        }

    }
}