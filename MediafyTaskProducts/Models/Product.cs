using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MediafyTaskProducts.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string FromPrice { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
