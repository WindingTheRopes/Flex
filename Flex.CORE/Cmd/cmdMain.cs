
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using Flex.CORE;


namespace Flex.CORE.Cmd
{
    public class cmdMain
    {

       
        public void start()
        {
            string input;

            do
            {
                Console.Write("FLEX> ");
                input = Console.ReadLine();
                cmdHandler cmdHandler = new cmdHandler();
                cmdHandler.readCmd(input);

            }
            while (true);
            

        }
       
    }
 
}
