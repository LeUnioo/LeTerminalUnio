namespace LeTerminalUnio;

public class TestRequest
{
    
   



    public static async Task GetAsync(string barcode)
    {
        using (var client = new HttpClient())
        {
            var endpoint = new Uri("https://world.openfoodfacts.net/api/v2/product/"+barcode+"?fields=product_name");
            var result = client.GetAsync(endpoint).Result;
            var json = result.Content.ReadAsStringAsync().Result;
        }
        
    }
    
    
}