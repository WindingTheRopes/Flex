using System;

namespace FlexUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Version Version = new Version();
            Console.WriteLine("FLEXUPDATE " + Version.version + " Revision " + Version.revision + " (" + Version.versionDate + ")");
        }
    }
}
