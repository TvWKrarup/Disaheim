using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {
        // Properties
        public string ItemId { get; set; }


        // Operations

        // En del af opgaven er at indføre og senere udkommentere denne constructor
        // Constructor
        //public Merchandise(string itemId) 
        //{ 
        //    this.ItemId = itemId;
        //}

        // Methods
        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }


    }
}
