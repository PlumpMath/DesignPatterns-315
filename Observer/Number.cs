using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Number:IObserver
    {
        public int Value { get; set; }
        
        public void Update(object ob)
        {
            
        }
        public Number(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            string result = String.Format("{0}", Value);
            return result;
        }
    }
}
