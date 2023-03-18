using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    // Tror ikke den skal nedarve fra Utility - men hvordan kalder jeg ellers på dens metode jeg skal bruge i GetTotalValue?
    public class AmuletRepository : Utility
    {
        // Attributes
        private List<Amulet> _amulets;

        // Methods

        // Tilføjer en amulet til vores liste "_amulets".
        public void AddAmulet(Amulet amulet)
        {
            _amulets.Add(amulet);
        }

        // Hvis amulet eksisterer med et itemId returneres itemId (er lidt i tvivl om det er itemid eller selve amulet der skal returneres
        // for nuværende.
        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in _amulets)
            {
                if (amulet.ItemId == itemId)
                    return amulet;
            }
            return null;
        }

        // Alle amuletters værdi samles i "total" og returneres når metoden kaldes.
        public double GetTotalValue()
        {
            foreach (Amulet amulet in _amulets)
            {
                double total =+ GetValueOfAmulet(amulet);
                return total;
            }
            return 0;
            
        }
        
        
    }
}
