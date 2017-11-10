using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            foreach (IValuable oneValuable in valuables)
            {
                if (oneValuable is Book)
                {
                    Book b = (Book)oneValuable;
                    if (b.ItemId == id)
                    {
                        return oneValuable;
                    }
                }
                if (oneValuable is Amulet)
                {
                    Amulet a = (Amulet)oneValuable;
                    if (a.ItemId == id)
                    {
                        return oneValuable;
                    }
                }
                if (oneValuable is Course)
                {
                    Course c = (Course)oneValuable;
                    if (c.Name == id)
                    {
                        return oneValuable;
                    }
                }

            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (IValuable oneValuable in valuables)
            {
                if (oneValuable is Book)
                {
                    Book oneBook = oneValuable as Book;
                    totalValue += totalValue + oneBook.Price;
                }
                if (oneValuable is Amulet)
                {
                    Amulet oneAmulet = oneValuable as Amulet;
                    totalValue += oneAmulet.GetValue ();
                }
                if (oneValuable is Course)
                {
                    Course oneCourse = oneValuable as Course;
                    totalValue += oneCourse.GetValue();
                }
            }
            return totalValue;
        }
        public int Count()
        {
            int Value = 0;
            foreach (IValuable oneValuable in valuables)
            {
                Value = Value + 1;
            }
            return Value;
        }
    }
}
