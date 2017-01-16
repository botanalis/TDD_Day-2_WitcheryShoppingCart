using System;
using System.Collections.Generic;

namespace HarryPShoppingCart
{
    public class PhenixCompany
    {
        private Book _Books;

        public void Buy(Book book)
        {
            this._Books = book;
        }

        public int Settle()
        {
            int result = 0;

            result = this._Books.Count * this._Books.Amount;

            return result;
        }
    }
}