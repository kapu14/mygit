
using System;
using System.Collections.Generic;
using System.Text;

namespace anotherNameSpace
{
    class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(int code, string name,int price )
        {
            Code = code;
            Name = name;
            Price = price;
        }

        //消費税を求める
        public int GetTax()
        {
            return (int)(Price * 0.1);
        }

        //税込み価格を求める
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}
