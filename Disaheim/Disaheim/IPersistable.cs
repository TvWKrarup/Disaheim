using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public interface IPersistable
    {
        public void Save(string fileName);
        public void Load(string fileName);
    }
}
