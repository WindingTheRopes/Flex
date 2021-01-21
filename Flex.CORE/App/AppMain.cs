using Flex.CORE.Cmd;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flex.CORE.App
{
    public class AppMain
    {
        public void init()
        {
            cmdHandler cmdHandler = new cmdHandler();
            cmdHandler.initDictionaries();
            Vars vars = new Vars();
            vars.init();
        }
    }
}
