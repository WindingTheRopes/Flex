
using Flex.CORE.App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Flex.CORE.Cmd
{
    class cmdHandler
    {
        Vars vars = new Vars();
        private Dictionary<string, string> FlexCommands = new Dictionary<string, string> { };
        flexFunctions flexFunctions = new flexFunctions();

        private Dictionary<string, Action> FlexFunctions = new Dictionary<string, Action> { };
     
       
        public void initDictionaries()
        {

       
            string flexHelpPath = System.IO.Path.Combine(vars.appData, "flexHelp.exe");
            
            FlexCommands.Add("help", flexHelpPath);
            FlexFunctions.Add("exit", flexFunctions.exit);
            FlexFunctions.Add("quit", flexFunctions.exit);
        }
    
      
        public int Execute(string input)
        {
           
            try
            {
                if (FlexCommands.Keys.Contains(input))
                {
                    var process = new Process();
                    process.StartInfo = new ProcessStartInfo(FlexCommands[input])
                    {
                        UseShellExecute = false
                    };

                    process.Start();
                    process.WaitForExit();

                    return 0;
                }
                else if (FlexFunctions.Keys.Contains(input))
                {
                    FlexFunctions[input]();
                    return 0;
                }
                Console.WriteLine($"ERROR: COMMAND {input} NOT FOUND");
                return 1;
            }
            catch
            {
                return 1;
            }
            
        }
    }
}