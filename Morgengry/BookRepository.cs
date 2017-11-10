using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);  
        }
        public Book GetBook(string itemId)
        {
            foreach (Book oneBook in books)
            {
                if (oneBook.ItemId == itemId)
                {
                    return oneBook;
                }

            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Book oneBook in books)
            {
                totalValue = totalValue + oneBook.Price;
            }
            return totalValue;
        }
    }
}
