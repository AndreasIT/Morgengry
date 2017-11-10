using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise 
    {
     
        public string Title;
        public double Price;

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;
        }
        public Book(string inItemId, string inTitle, double inPrice) : base (inItemId)
        {
            //ItemId = inItemId;
            Title = inTitle;
            Price = inPrice;
        }
        public Book(string inItemId, string inTitle) :
        this(inItemId, inTitle, 0)
        {
            //itemid = inItemid;
            //title = inTitle;
            //price = 0;
        }
        public Book(string inItemId) :
        this(inItemId, "", 0)
        {
            //itemid = inItemid;
            //title = "";
            //price = 0;
        }
        public override double GetValue()
        {
            return Price;
        }
    }

}
