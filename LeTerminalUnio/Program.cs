// See https://aka.ms/new-console-template for more information

namespace LeTerminalUnio
{
    class Program
    {
        private static Terminalmanager.Terminalmanager terminalmanager;
        
        public static void Main(string[] args)
        {
            terminalmanager = new Terminalmanager.Terminalmanager();
            terminalmanager.operationHandler();
            

        }


    }
}
