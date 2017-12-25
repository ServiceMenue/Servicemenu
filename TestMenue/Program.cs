using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMenue.Commands;

namespace TestMenue
{
    class Program
    {
        public static List<Command> commands = Utils.initCommands();
        public static StartupConfig conf;
        static void Main(string[] args)
        {
 
            conf = new StartupConfig(args);
            Utils.generateCommandList(commands);  

            CommandHandler cm = new CommandHandler(commands);

            while (true)
            {
                try
                {
                    if (!cm.handleCommand(Console.ReadLine()))
                    {
                        Console.WriteLine("An Error Announced"); //TODO: Better Execption Handeling !!!!
                    }


                }
                catch(Exception e) //To completely avoid any Crashes of the Programm
                {
                    Console.WriteLine(e.ToString());
                }

            }
            Console.ReadKey();
        }
    }
}
