using System.Collections.Generic;
using System.IO;
using System.Linq;
using InventoryApi.Models;

namespace InventoryApi.Services
{
    public class InventoryService
    {

        private static string GetJsonData()
        {
            string path = Directory.GetCurrentDirectory();
            var dataStore = new FileStream(System.IO.Path.Join(path, "data.json"), FileMode.Open);
            using var reader = new StreamReader(dataStore);
            return  reader.ReadToEnd();
        }

        public IEnumerable<Product> GetProducts()
        {
            var data= GetJsonData();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Product>>(data);
        }

    }
}
