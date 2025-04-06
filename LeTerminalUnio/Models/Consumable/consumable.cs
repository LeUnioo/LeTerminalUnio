namespace LeTerminalUnio.Models.Consumable;

public class consumable
{
    private string barcode;
    private string name;
    private string category;


    public consumable(string barcode, string name, string category)
    {
        this.barcode = barcode;
        this.name = name;
        this.category = category;
    }
     
    
   
}