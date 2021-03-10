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

            CORE.App.coolio coolio = new CORE.App.coolio();




            coolio.print("FLEX " + Version.version + " Revision " + Version.revision + " (" + Version.versionDate + ")", 0);
            coolio.print("2020 windingtheropes", 0);
            coolio.print("", 0);
            coolio.print("https://github.com/windingtheropes/flex", 0);
            coolio.print("Type 'help' for help", 0);
            coolio.print("", 0);
            cmdMain.start();
            
            
        }
    }
}
