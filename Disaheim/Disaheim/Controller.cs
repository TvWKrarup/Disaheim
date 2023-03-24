using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    
    {
        
        public ValuableRepository ValuableRepository { get; set; }

        public Controller()
        {
            this.ValuableRepository = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            this.ValuableRepository.AddValuable(valuable);
        }
    }
}
