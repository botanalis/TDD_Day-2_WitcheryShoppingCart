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

            return CalculateDiscount(this._Books);
        }

        private int CalculateDiscount(List<Book> books)
        {
            List<Book> DiscountBooks = new List<Book>();
            //取得書籍數量
            int count = books.Count;
            //取得折扣
            double off = getDiscount(count);

            int result = 0;

            if (count != 0) {

                foreach (Book item in books)
                {
                    result = result + (int)(item.Amount * off);

                    item.Count = item.Count - 1;

                    if (item.Count != 0)
                    {
                        DiscountBooks.Add(item);
                    }
                }

                result = result + CalculateDiscount(DiscountBooks);
            }

            return result;
        }

        private double getDiscount(int count)
        {
            double off = 1;

            if (count == 2)
            {
                off = 0.95;
            }
            else if (count == 3)
            {
                off = 0.9;
            }
            else if (count == 4)
            {
                off = 0.8;
            }
            else if (count == 5)
            {
                off = 0.75;
            }

            return off;
        }
    }
}