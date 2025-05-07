namespace LeTerminalUnio.Terminalmanager;

public class Terminalmanager
{
    public async void operationHandler()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "barcode": 
                Console.WriteLine("Add item(1), Delete item(2), List all items(3)");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Please enter the barcode of the item: ");
                        string barcode = Console.ReadLine();
                        BarcodeAPI.addItem(barcode);
                        break;
                    case "2":
                        Console.WriteLine("Please enter the barcode of the item: ");
                        BarcodeAPI.deleteItem(Console.ReadLine());
                        Console.WriteLine("Item have been removed");
                        break;
                    case "3":
                        Console.WriteLine("Here is a list of all items: ");
                        BarcodeAPI.listAllItems();
                        break;
                }
                
                break;
            default:   
                Console.WriteLine("The input is invalid");
                break;
                
        }
        
    }
}