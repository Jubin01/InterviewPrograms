using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace InterviewPrograms
{
    internal abstract class AbstractBaseClass
    {
        protected int _x = 100;
        protected int _y = 150;

        //abstract method
        internal abstract void AbstractMethod();

        //abstract properties
        internal abstract int X { get; }
        internal abstract int Y { get; }
    }

    internal class DerivedFromAbstractClass : AbstractBaseClass
    {
        internal override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        internal override int X
        {
            get
            {
                return _x + 10;
            }
        }
        internal override int Y
        {
            get
            {
                return _y + 10;
            }
        }

    }
    internal class AbstractTest
    {
        internal void Execute()
        {
            var o = new DerivedFromAbstractClass();
            o.AbstractMethod();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");
        }
    }
}
