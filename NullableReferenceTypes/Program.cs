using System;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            greeter.SayHello(null, "De Carufel");
        }
    }

}
