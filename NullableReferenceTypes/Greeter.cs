using System;
using System.Collections.Generic;
using System.Text;

namespace NullableReferenceTypes
{
    class Greeter
    {
        public void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName[0]}. {lastName}!");
        }
    }
}
