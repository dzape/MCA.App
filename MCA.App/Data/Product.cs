namespace MCA.App.Data
{
    using System.Text.Json.Serialization;
    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("domestic")]
        public bool Domestic { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
