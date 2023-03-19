using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        // Properties
        public string Design { get; set; }
        public Level Quality { get; set; }

        // Operations
        // Constructor
        // Default - itemid from baseclass "Merchandise"
        public Amulet(string itemid, Level quality, string design)
        {  
            base.ItemId = itemid;
            this.Design = design;
            this.Quality = quality;
        }
        // Overloaded constructor
        // 2 parametre
        public Amulet(string itemid, Level quality)
        {
            base.ItemId = itemid;
            this.Quality =(Level)quality;
            this.Design = "";
        }
        // 1 parameter
        public Amulet(string itemid)
        {
            base.ItemId=itemid;
            this.Quality=Level.medium;
            this.Design = "";
        }

        //Overridden method
        public override string ToString()
        {
            return $"ItemId: {base.ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
