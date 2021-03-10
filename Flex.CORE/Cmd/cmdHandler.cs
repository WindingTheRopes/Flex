
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
       
      public int readCmd(string input)
        {
          

            
            try
            {
              
                return 0;
            }
            catch
            {
                Console.WriteLine("Unexpected error");
                return 1;
            }
        }
    }
}