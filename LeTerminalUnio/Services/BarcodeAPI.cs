using System.Runtime.InteropServices.JavaScript;
using LeTerminalUnio.Models.Consumable;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeTerminalUnio;

using System;
using System.Net.Http;
using System.Threading.Tasks;


public class BarcodeAPI
{

    Dictionary<string, consumable> items = new Dictionary<string, consumable>();
    
    
    public static async Task GetAsync(string barcode)
    {
        using (var client = new HttpClient())
        {
            var endpoint =
                new Uri("https://world.openfoodfacts.org/api/v0/product/" + barcode + ".json?fields=code,product,categories");
            var result = client.GetAsync(endpoint).Result;
            var jsonString = result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(jsonString);
            
            
            // Parse JSON using JObject
            JObject json = JObject.Parse(jsonString);
            
            // TODO: complete the parser part, so that the response is transferred to a consumable object
            string consumableBarcode = json["code"].ToString();
            string productName = json["product"]?["product_name"]?.ToString() ?? "No name";
            string categories = json["product"]?["categories"]?.ToString() ?? "No categories";
            
            
            consumable itemConsumable = new consumable(consumableBarcode, productName, categories);

            
            
            
        }
    }
}