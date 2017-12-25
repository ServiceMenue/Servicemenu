using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue {
    class CommandHandler {
        private List<Command> commands;

        public CommandHandler(List<Command> cms) {
            commands = cms;
        }

        public bool handleCommand(String cmd) {

            string[] arr = cmd.Split(' ');
            int index = -1;
            try { index = Convert.ToInt32(arr[0]); } catch { return false; }


            String[] arg = arr.Skip(1).ToArray<String>();

            if (index.Equals("exit"))
                System.Environment.Exit(0);


            if (index >= commands.Count || index < 0)
                return false;

            if (arg.Length >= 1 && arg[0].Equals("help")) {
                Console.WriteLine(Utils.getHelpForCommand(commands[index]));
                return true;
            }

            if (!Program.conf.gui) {
                commands[index].execNogui(arg);
            } else {
                //Later for gui Implementation
            }


            return true;
        }


    }
}
