using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gierka.Interfaces;

namespace Gierka.Interfaces
{
    public interface IBuy
    {
        string Name { get; }
        int Cost { get; }

        void Buy(Player p);
    }
}
