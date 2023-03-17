using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        //Properties
        public string Title { get; set; }
        public double Price { get; set; }

        // Operations
        // Constructor
        // itemId from baseclass "Merchandise" 
        public Book(string itemId, string title, double price)
        {
            base.ItemId = itemId;
            this.Title = title;
            this.Price = price; 
        }

        // Overloaded constructor  
        public Book(string itemId, string title)
        {
            base.ItemId = itemId;
            this.Title = title;
            this.Price = 0.0;
        
        }
        public Book(string itemId)
        {
            base.ItemId= itemId;
            this.Title = "";
            this.Price = 0.0;
        }

        // Overridden methid
        public override string ToString()
        {
            return $"ItemId: {base.ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
