using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        // Properties
        public string ItemId { get; set; }


        // Operations
        // Methods
        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

        // GetValue() fra IValuable interface skrives som abstract så SKAL der laves en version af den i Book og Amulet
        // da de nedarver fra Merchandise
        abstract public double GetValue();
        


    }
}
