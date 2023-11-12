using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)// asinxiron
        {
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.ToString());

            //string path = @"C:\Users\shohb\OneDrive\Ishchi stol\C# codes\modul-4\ConsoleApp1\file2.json";

            // Faylga yozish
            // request bu
            //string BaseUrl = @"https://nbu.uz/uz/exchange-rates/json/";
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(BaseUrl);

            //// response
            //var response = await client.GetAsync(" ");
            //var StringResult = await response.Content.ReadAsStringAsync();

            //var resultDes = JsonSerializer.Deserialize<Baza[]>(StringResult);

            //--------------------------------------Person
            //string Url = "https://api.publicapis.org/entries";
            //HttpClient clint = new HttpClient();
            //clint.BaseAddress = new Uri(Url);

            //var result = await clint.GetAsync("");
            //var ResultJson = await result.Content.ReadAsStringAsync();

            //var DeJson = JsonSerializer.Deserialize<Person>(ResultJson);

            //foreach (var item in DeJson.entries)
            //{
            //    await Console.Out.WriteLineAsync(item.Cors);
            //}

            //--------------------------------- Cat fact

            //string pathUrl = "https://catfact.ninja/fact";
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(pathUrl);

            //string BazaLink = "C:\\Users\\shohb\\OneDrive\\Ishchi stol\\C# codes\\modul-4\\ConsoleApp1\\cat.json";
            ////File.Create(BazaLink).Close();

            //var response = await client.GetAsync("");
            //var result = await response.Content.ReadAsStringAsync();

            //using(StreamWriter sw = new StreamWriter(BazaLink,true))
            //{
            //    sw.WriteLine(result);
            //}
            //------------------------------------ CoinDesk
            //string Url = "https://api.coindesk.com/v1/bpi/currentprice.json";

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(Url);

            //var response = await client.GetAsync(" ");
            //var Result = await response.Content.ReadAsStringAsync(); 
            
            //var Dejson = JsonSerializer.Deserialize<CoinDesk>(Result);
            
            //Console.WriteLine(Dejson.bpi.USD.rate_float +" "+Dejson.time.updated);

            //---------------------------------------- 

        }
    }
}
