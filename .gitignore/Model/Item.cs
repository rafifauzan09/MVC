using System;
using System.Collections.Generic;
using System.Text;

namespace promoMVC.Model
{
    public class Item
    {
        public string title { get; set; }
        public string price { get; set; }

        public Item(string title, string price)
        {
            this.title = title;
            this.price = price;
        }
    }
}
