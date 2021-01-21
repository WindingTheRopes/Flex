using System;
using Flex.CORE;
using Flex.CORE.App;
using Flex.CORE.Cmd;

namespace Flex
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            CORE.App.Version Version = new Flex.CORE.App.Version();
            cmdMain cmdMain = new cmdMain();
            AppMain appMain = new AppMain();
            appMain.init();

            

     
        
            Console.WriteLine("FLEX " + Version.version + " Revision " + Version.revision + " (" + Version.versionDate + ")");
            Console.WriteLine("2020 Alacriware Software, created by windingtheropes");
            Console.WriteLine("");
            Console.WriteLine("https://github.com/alacriware/flex");
            Console.WriteLine("Type 'help' for help");
            Console.WriteLine("");
            cmdMain.start();
            
            
        }
    }
}
