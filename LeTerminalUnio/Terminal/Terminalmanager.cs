namespace LeTerminalUnio.Terminalmanager;

public class Terminalmanager
{
    public async void operationHandler()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "barcode":
                Console.WriteLine("Please enter the barcode of the item: ");
                string barcode = Console.ReadLine();
                BarcodeAPI.GetAsync(barcode);
                
                break;
            default:   
                Console.WriteLine("The input is invalid");
                break;
                
        }
        
    }
}