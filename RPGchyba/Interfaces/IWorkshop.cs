using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Interfaces
{
    public interface IWorkshop
    {
        string Place {  get; }
        string Name { get; }  
        string Cost { get; }

        public void BuildChceck();

        public void UpgradeCheck();
    }
}
