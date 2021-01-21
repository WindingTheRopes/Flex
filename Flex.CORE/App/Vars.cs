using System;
using System.Collections.Generic;
using System.Text;

namespace Flex.CORE.App
{
    class Vars
    {
        //appdata path
        public string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public void init()
        {
            appData = System.IO.Path.Combine(appData, "Alacriware" + "Flex");
        }
        //program path
        public string programPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
