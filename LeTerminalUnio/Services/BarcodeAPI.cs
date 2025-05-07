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

    static Dictionary<string, consumable> items = new Dictionary<string, consumable>();
    
    // Use this barcode when testing: 5053990127740
    
    
    public static async Task addItem(string barcode)
    {
        using (var client = new HttpClient())
        {
            var endpoint =
                new Uri("https://world.openfoodfacts.org/api/v0/product/" + barcode + ".json?fields=code,product,categories,product_name");
            var result = client.GetAsync(endpoint).Result;
            var jsonString = result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(jsonString);
            
            
            // Parse JSON using JObject
            JObject json = JObject.Parse(jsonString);
            
           
            string consumableBarcode = json["code"].ToString();
            string productName = json["product"]?["product_name"]?.ToString() ?? "No name";
            string categories = json["product"]?["categories"]?.ToString() ?? "No categories";
            
            
          
            items.Add(consumableBarcode, new consumable{barcode = consumableBarcode, name = productName, category = categories});
            
            Console.WriteLine("Item count: " + items.Count);
            Console.WriteLine("The items have been added to the list: " + items[consumableBarcode].name);
            // TODO: In the furture, A database will have to be added and connected to
            
            
        }
    }

    public static void deleteItem(string barcode)
    {
        items.Remove(barcode);
    }

    public static void listAllItems()
    {
        foreach (KeyValuePair<string, consumable> entry in items)
        {
            Console.WriteLine($"Barcode: {entry.Key}, Name: {entry.Value.name}");
        }

    }
    
    
}