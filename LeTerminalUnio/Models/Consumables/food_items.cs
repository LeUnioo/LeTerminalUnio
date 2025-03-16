namespace LeTerminalUnio.Models.Consumables
{
    public class food_items
    {
        private string barcode;
        private string name;
        private string category;
        
        
        public food_items(string barcode, string name, string category)
        {
            this.barcode = barcode;
            this.name = name;
            this.category = category;
        }


        public string getFoodBarcode()
        {
            return barcode;
        }

      
        
    }
}