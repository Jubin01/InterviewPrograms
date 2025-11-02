using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace InterviewPrograms
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    //below gives error
    // class DerivedClass : SealedClass
    // {
    // }

    class SealedTest
    {
        internal void Execute()
        {
            var sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine($"x = {sc.x}, y = {sc.y}");
        }
    }

}

