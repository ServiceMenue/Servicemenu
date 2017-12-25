using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue.Commands
{
    class Cmd_Exit : Command
    {
        public string help { get; } = "Exits Menue";

        public string name { get; } = "Exit";

        public void execNogui(string[] args)
        {
            Environment.Exit(0);
        }
    }
}
