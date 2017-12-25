using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue
{
    class StartupConfig
    {

        public bool gui { get; private set; }

       
        public StartupConfig (String[] args)
        {
            gui = Array.IndexOf(args, "gui") > -1;

            
        }
        
    }
}
