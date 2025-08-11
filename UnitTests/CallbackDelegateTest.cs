
using System.Reflection;
using InterviewPrograms;

namespace UnitTests
{
    public class CallbackDelegateTest
    {
        //check the existense of Execute method in the classses
        [Fact]
        public void TestExecute()
        {
            var methods = typeof(CallbackDelegate).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            var methodName = methods.Where(x => x.Name == "Execute").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("Execute", methodName);
        }

        //check the existense of DelegateMethod method in the classses
        [Fact]
        public void TestDelegateMethod()
        {
            var methods = typeof(CallbackDelegate).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var methodName = methods.Where(x => x.Name == "DelegateMethod").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("DelegateMethod", methodName);
        }

        //check the existense of MethodWithCallback method in the classses
        [Fact]
        public void TestMethodWithCallback()
        {
            var methods = typeof(CallbackDelegate).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var methodName = methods.Where(x => x.Name == "MethodWithCallback").Select(x => x.Name).FirstOrDefault();
            Assert.Equal("MethodWithCallback", methodName);
        }

        //test the delegatemethod as a callback
        private delegate void CallbackDel(string message);
        [Fact]
        public void TestDelegateMethodAsCallback()
        {
            CallbackDelegate obj = new CallbackDelegate();
            CallbackDelegate.CallbackDel delhandler = new CallbackDelegate.CallbackDel(obj.DelegateMethod);
            obj.MethodWithCallback(1, 2, delhandler);
        }
    }
}