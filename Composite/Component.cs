using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    abstract class Component
    {
       
            protected string name;
        protected string description;

        public Component(string name, string description)
            {
                this.name = name;
            this.description = description;
            }

            public virtual void Add(Component component) { }

            public virtual void Remove(Component component) { }

            public virtual void Print()
            {
                Console.WriteLine(name);
            }
      }
}
