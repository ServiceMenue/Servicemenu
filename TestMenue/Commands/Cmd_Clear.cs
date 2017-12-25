using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue.Commands {
    class Cmd_Clear : Command {
        public string help { get; } = "";

        public string name { get; } = "Reset";

        public void execNogui(string[] args) {
            Console.Clear();
            Utils.generateCommandList(Program.commands);
        }
    }
}
