using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FlowerShop
{
    static class Json
    {
        public static void PostInJson(Order order)
        {
            string JsonObject = JsonConvert.SerializeObject(order.FormDescription()) + "\n";

            File.AppendAllText("Orders.json", JsonObject);
        }

        public static string FromJson()
        {
            string path = @"Orders.json";
            StreamReader file = new StreamReader(path);

            string lines = "";
            string line;
            while ((line = file.ReadLine()) != null)
            {
                lines += line;
            }
            return lines;
        }
    }
}
