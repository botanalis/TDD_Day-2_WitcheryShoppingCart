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
            //取得書籍數量
            int count = this._Books.Count;
            //取得折扣
            double off = getDiscount(count);

            int result = 0;
                        

            foreach (Book item in this._Books)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (i == 0)
                    {
                        //有折扣
                        result = result + (int)(item.Amount * off);
                    }
                    else
                    {
                        //沒折扣
                        result = result + (item.Amount * (item.Count - 1 ));
                    }
                    
                }
                
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