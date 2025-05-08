// See https://aka.ms/new-console-template for more information

namespace LeTerminalUnio
{
    class Program
    {
        private static Terminalmanager.Terminalmanager terminalmanager;
        
        public static void Main(string[] args)
        {
            terminalmanager = new Terminalmanager.Terminalmanager();

            while (true)
            {   
                Console.WriteLine("Welcome to the LeTerminalUnio Console, available commands are listed in the provided README file");
                
                terminalmanager.operationHandler();
            }

        }


    }
}
