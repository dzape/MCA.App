namespace MCA.App
{
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;
    using MCA.App.Data;
    using MCA.App.Services;
    class Program
    {
        static void Main()
        {
            IProductService productService = new ProductService();

            string json = new WebClient().DownloadString("https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1");
            var data = JsonConvert.DeserializeObject<List<Product>>(json);

            productService.GetStats(data);

        }
    }
}
