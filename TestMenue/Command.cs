using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue
{
    interface Command
    {
        //Summary: Executes a Command in Nogui Mode
        void execNogui(String[] args);
        
        String help { get; }
        String name { get; }
    }
}
