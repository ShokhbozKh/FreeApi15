using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Baza
    {
        public string title { get; set; }
        public string code { get; set; }
        public string cb_price { get; set; }
        public string nbu_buy_price { get; set; }
        public string nbu_cell_price { get; set; }
        public string date { get; set; }

        public override string ToString()
        {
            return $"{title} -- {nbu_cell_price}\n";
        }

    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    


}
