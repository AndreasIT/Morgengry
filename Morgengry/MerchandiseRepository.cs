//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morgengry
//{
//    public class MerchandiseRepository
//    {
//        private List<Merchandise> merchandises = new List<Merchandise>();
        
//        public void AddMerchandise (Merchandise merchandise)
//        {
//            merchandises.Add(merchandise);
//        }
//        public Merchandise GetMerchandise(string itemId)
//        {
//            foreach (Merchandise oneMerchandise in merchandises)
//            {
//                if (oneMerchandise.ItemId == itemId)
//                {
//                    return oneMerchandise;
//                }

//            }
//            return null;
//        }
//        public double GetTotalValue()
//        {
//            double totalValue = 0;
//            foreach (Merchandise oneMerchandise in merchandises)
//            {
//                if (oneMerchandise is Book)
//                {
//                    Book oneBook = oneMerchandise as Book;
//                    totalValue = totalValue + oneBook.Price;
//                }
//                else if (oneMerchandise is Amulet)
//                {
//                    Amulet oneAmulet = oneMerchandise as Amulet;
//                    totalValue += Amulet.GetValue(oneAmulet);
//                }
//            }
//            return totalValue;
//        }
//    }
//}
