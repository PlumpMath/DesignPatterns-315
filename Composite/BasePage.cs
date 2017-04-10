using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class BasePage : Component
    {
     
        private List<Component> sections = new List<Component>();
        public BasePage(string name, string description) : base(name, description)
        {
        }
       
        public override void Add(Component component)
        {
            sections.Add(component);
        }

        public override void Remove(Component component)
        {
            sections.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Base Page " + name);
            Console.WriteLine();
            Console.WriteLine("-Sections:");
            for (int i = 0; i < sections.Count; i++)
            {
                sections[i].Print();
            }
        }
    }
}
