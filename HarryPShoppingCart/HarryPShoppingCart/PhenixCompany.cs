using System;
using System.Collections.Generic;

namespace HarryPShoppingCart
{
    public class PhenixCompany
    {
        private List<Book> _Books;

        public PhenixCompany()
        {
            this._Books = new List<Book>();
        }
        public void Buy(Book book)
        {
            this._Books.Add(book);
        }

        public int Settle()
        {
            int count = 0;
            int result = 0;

            foreach (Book item in this._Books)
            {
                count = count + 1;
                result = result + (item.Amount * item.Count);
            }

            if (count == 2)
            {
                result = (int)(result * 0.95);
            }
            else if (count == 3)
            {
                result = (int)(result * 0.9);
            }
            else if (count == 4)
            {
                result = (int)(result * 0.8);
            }
            

            return result;
        }
    }
}