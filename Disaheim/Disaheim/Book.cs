using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        //Properties
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        // Operations
        // Constructor
        public Book(string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }

        // Chained constructor 

        public Book(string itemId, string title) :
            this(itemId, title, 0.0)
        {}
        public Book(string itemId) :
            this(itemId, "", 0.0)
        {}

        // Overridden methid
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
