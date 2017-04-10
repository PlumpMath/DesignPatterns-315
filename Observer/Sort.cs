using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Sort
    {
        List<IObserver> numbers;
        public Sort(List<IObserver> numbers)
        {
            this.numbers = numbers;
        }
        public List<IObserver> MySort(IObserver number)
        {
            int count = numbers.Count;
            if (count==0)
            {
                numbers.Add(number);
            }
            else if (count == 1)
            {
                if (number.Value<= numbers[0].Value)
                {
                    numbers.Insert(0, number);
                }
                else
                {
                    numbers.Add(number);
                }

            }
            else
            {
                for (int i = count - 1; i >= 0;)
                {
                    if (number.Value < numbers[i].Value)
                    {
                        i--;
                    }
                    else if (number.Value >= numbers[i].Value)
                    {
                        numbers.Insert((i + 1), number);
                        return numbers;
                    }
                }
            }
            return numbers;

        }
    }
}
