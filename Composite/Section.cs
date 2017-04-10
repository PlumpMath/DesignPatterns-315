using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Section : Component
    {
        private List<Component> pages = new List<Component>();
        public Section(string name, string description) : base(name, description)
        {
        }
       public override void Add(Component component)
        {
            pages.Add(component);
        }

        public override void Remove(Component component)
        {
            pages.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("-Section {0}, description: {1} ", name, description);
            Console.WriteLine();
            Console.WriteLine("----Pages:");
            for (int i = 0; i < pages.Count; i++)
            {
                pages[i].Print();
            }
        }
    }
}
