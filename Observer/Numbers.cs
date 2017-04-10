using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Numbers: IObservable
    {
        public Sort sort { get; set; }
        
        
        List<IObserver> observers;
        public Numbers()
        {
            observers = new List<IObserver>();
            sort = new Sort(observers);
        }
        public void RegisterObserver(IObserver o)
        {
           observers=sort.MySort(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(sort);
            }
        
        }
        public Number ConfigurationOfNumbers()
        {
            Random rnd = new Random();
            
            var number =new Number(rnd.Next(1, 10000));
           
            NotifyObservers();
            return number;
        }
        public IEnumerator GetEnumerator()
        {
            return observers.GetEnumerator();
        }

    
    }
}
