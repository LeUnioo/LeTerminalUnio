namespace LeTerminalUnio.Models.Consumables
{
    public class drinkables
    {
        private string barcode;
        private string name;
        private string category;
        
        public drinkables(string barcode, string name, string category) 
        {
            this.barcode = barcode;
            this.name = name;
            this.category = category;
            
        }
    }    
}
