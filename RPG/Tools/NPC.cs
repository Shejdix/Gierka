using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Tools
{
    public class NPC
    {
        //Private values, public methods
        private string name;
        private string dialogue;

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Dialogue
        {
            get { return dialogue; }
            set { dialogue = value; }
        }

        public NPC(string name, string dialogue)
        {
            this.name = name;
            this.dialogue = dialogue;
        }
    }
}
