using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            //stocks[keyname] will give you that keys value;
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APL", "Apple");
            stocks.Add("CR", "Chaz Rules");
            stocks.Add("TR", "Tiny Rick");
            stocks.Add("LOL", "LOL");


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 10, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 34, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 8, price: 19.02));

            purchases.Add((ticker: "APL", shares: 820, price: 19.02));
            purchases.Add((ticker: "APL", shares: 867, price: 19.02));
            purchases.Add((ticker: "APL", shares: 9000, price: 19.02));

            purchases.Add((ticker: "CR", shares: 100, price: 19.02));
            purchases.Add((ticker: "CR", shares: 200, price: 19.02));
            purchases.Add((ticker: "CR", shares: 440, price: 19.02));

            purchases.Add((ticker: "TR", shares: 2, price: 19.02));
            purchases.Add((ticker: "TR", shares: 8, price: 19.02));
            purchases.Add((ticker: "TR", shares: 890, price: 19.02));

            purchases.Add((ticker: "LOL", shares: 840, price: 19.02));
            purchases.Add((ticker: "LOL", shares: 32, price: 19.02));
            purchases.Add((ticker: "LOL", shares: 67, price: 19.02));
   
            
            Dictionary<string, double> totalStocks = new Dictionary<string, double>();


           foreach((string ticker, int shares, double price) purchase in purchases)
            {
            // Does the company name key already exist in the report dictionary?
              Console.WriteLine($"{purchase.ticker}");
              if(stocks.ContainsKey(purchase.ticker)){
                if(totalStocks.ContainsKey(stocks[purchase.ticker])){
                    totalStocks[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                }else{
                    totalStocks.Add(stocks[purchase.ticker], purchase.shares * purchase.price);
                }
              }
            }
            
            foreach( KeyValuePair<string, double> totalStock in totalStocks){
                Console.WriteLine(totalStock);
            }
        }
    }
}
