using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        // Properties
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        // Operations
        // Constructor
        public Amulet(string itemid, Level quality, string design) 
        { 
            this.ItemId = itemid;
            this.Design = design;
            this.Quality = quality;
        }
        //Chained-constructor
        public Amulet(string itemid, Level quality) : 
            this (itemid, quality, "")
        {}
        public Amulet(string itemid) :
            this (itemid, Level.medium, "")
        {}

        //Overridden method
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }





    }
}
