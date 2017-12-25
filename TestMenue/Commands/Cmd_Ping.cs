using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestMenue.Commands
{
    public class Cmd_Ping : Command
    {
        public string name { get; } = "Ping";

        public string help { get; } = "Sends a ping request";

        public void execNogui(string[] args)
        {
            Ping p = new Ping();
            String adress = "www.google.at";

            if(args.Length > 0)
            {
                adress = args[0];
            }
            var request = p.Send(adress);

            Console.WriteLine(request.RoundtripTime);

        }
    }
}
