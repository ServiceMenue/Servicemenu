﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMenue.Commands;


namespace TestMenue
{
    class Utils
    {
        public static List<Command> initCommands() //All Commands have to be put into the Dictionarry 
        {
            List<Command> c = new List<Command>();
            //put into with c.Add(new "Command-Class*);
            #region Commands
            c.Add(new Cmd_Exit());
            c.Add(new Cmd_Clear());
            c.Add(new Cmd_Ping());

            
            
            #endregion
            return c;
        }

        internal static void generateCommandList(List< Command> commands)
        {

            int i = 0;
            foreach(Command s in commands){
                Console.WriteLine("[" + i + "]\t"+ s.name + "  " + getHelpForCommand(s));
                i++;
            }

        }
        public static bool Confirm()
        {
            bool ret = false;
            string c = "";
            do
            {
                Console.WriteLine("Type Yes(y)/No(y)");
                c = Console.ReadLine();

                ret = c.Equals( "y");
            } while (!c.Equals("y") && !c.Equals("n"));


            return ret;


                 

        }

        #region BatCommandExecuters

        public static void ExecuteCommand(string command)
        {
            ExecuteCommand(command, false, false);
        }

        public static void ExecuteCommand(string command, bool showConsole)
        {
            ExecuteCommand(command, showConsole, false);
        }
        

        public static void ExecuteCommand(string command, bool showConsole ,bool useAdminpermition)
        {
            int ExitCode;
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = showConsole;
            if (useAdminpermition)
                ProcessInfo.Verb = "runas";

            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();

            ExitCode = Process.ExitCode;
            Process.Close();


        }
#endregion
        #region helpgenerators
        public static string getHelpForCommand(Command c)
        {
            try
            {
                return !c.help.Equals("") ? c.help : ("!The help for " + c.name + " is not implemented yet");
            }
            catch
            {
                return "!The help for " + c.name + " is not implemented yet";
            }

        }
       
        #endregion
    }
}
