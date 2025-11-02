using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace InterviewPrograms
{
    internal class X
    {
        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }

    internal class Y : X
    {
        protected sealed override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }
    }

    internal class Z : Y
    {
        // Attempting to override F causes compiler error CS0239.
        // protected override void F() { Console.WriteLine("Z.F"); }
        protected override void F2() { Console.WriteLine("Z.F2"); }

        internal void Execute()
        {
            var z = new Z();
            z.F();
        }
    }

    internal class SealedMemberTest
    {
        internal void Execute()
        {
            var z = new Z();
            z.Execute();
            // z.F();
        }
    }

}

