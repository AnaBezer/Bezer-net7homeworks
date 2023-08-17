using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public static void GetProduct()
        {
            Product product = new Product
            {
                ProductName = "Notebook",
                ProductPrice = 10
            };

            // error at most of the code in the static method when there is no version of the Newtonsoft.Json package installed - missing using a directive or an assembly reference

            var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings 
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new KebabCaseNamingStrategy() // Newtonsoft.Json package version to 10.0.1, error at KebabCaseNamingStrategy() - could not be found, missing using a directive or an assembly reference 
                }
            });

            Console.WriteLine(json);
        }
    }
}
