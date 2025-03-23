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

    consumable[] consumableList;
    
    
    public static async Task GetAsync(string barcode)
    {
        using (var client = new HttpClient())
        {
            var endpoint =
                new Uri("https://world.openfoodfacts.net/api/v2/product/" + barcode + "?fields=product_name,categories");
            var result = client.GetAsync(endpoint).Result;
            var jsonString = result.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(jsonString);
            
            
            // Parse JSON using JObject
            JObject json = JObject.Parse(jsonString);

            
            string productName = json["product"]?["product_name"]?.ToString() ?? "No name";
            string categories = json["product"]?["categories"]?.ToString() ?? "No categories";
            
            Console.WriteLine("output " + productName, categories);
           
            
        }
    }
}