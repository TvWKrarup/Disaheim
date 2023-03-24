using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        // Attributter
        private static double _lowQualityValue = 12.5;
        private static double _mediumQualityValue = 20;
        private static double _highQualityValue = 27.5;

        // Properties
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; }
        public static double MediumQualityValue { get; set; }
        public static double HighQualityValue { get; set; }
        



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

        // Method fra Interface "IValuable" - skrevet som abstrakt i Merchandise som denne klasse nedarver fra.
        // Vi overskriver den abstrakte metode med denne.
        public override double GetValue()
        {
                if (this.Quality == Level.low)
                {
                    return LowQualityValue;
                }
                if (this.Quality == Level.medium)
                {
                    return MediumQualityValue;
                }
                if (this.Quality == Level.high)
                {
                    return HighQualityValue;
                }
            return 0;
        }

    }
}
