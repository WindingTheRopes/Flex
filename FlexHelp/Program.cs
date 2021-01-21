using System;

namespace FlexHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Version Version = new Version();
            Console.WriteLine("FLEXHELP " + Version.version + " Revision " + Version.revision + " (" + Version.versionDate + ")");
            
        }
    }
}
