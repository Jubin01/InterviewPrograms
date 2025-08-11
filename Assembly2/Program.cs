using System.Runtime.CompilerServices;
using InterviewPrograms;
[assembly: InternalsVisibleToAttribute("UnitTests")]
namespace Assembly2
{
    internal class Program
    {
        private static void Main()
        {
            DerivedClass obj = new DerivedClass();
            obj.Execute();
        }
    }
}
