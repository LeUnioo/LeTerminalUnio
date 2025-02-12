namespace LeTerminalUnio;

public class Terminalmanager
{
     

    
    
    public void operationHandler()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "add_item":
                Console.WriteLine("The item have been added to the list");
                break;
            default:
                Console.WriteLine("The input is invalid");
                break;
                
        }
        
    }
}