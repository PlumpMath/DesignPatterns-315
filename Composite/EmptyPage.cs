using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class EmptyPage : Component
    {
        public EmptyPage(string name, string description) : base(name, description)
        {
        }
        public override void Print()
        {
            Console.WriteLine("----Page {0}, description: {1} ", name, description);
            Console.WriteLine();
        }
    }
}
