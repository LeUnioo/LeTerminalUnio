// See https://aka.ms/new-console-template for more information

namespace LeTerminalUnio
{
    class Program
    {
        private static Terminalmanager terminalmanager;
        
        public static void Main(string[] args)
        {
            terminalmanager = new Terminalmanager();
            terminalmanager.operationHandler();
            
            



        }


    }
}
