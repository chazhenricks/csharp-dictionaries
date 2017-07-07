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

            //loops over the purchase list
           foreach((string ticker, int shares, double price) purchase in purchases)
            {
            // will check to see if the stocks dictionary contains the purchase.ticker value. 
              if(stocks.ContainsKey(purchase.ticker)){
                  //checks to see if the totalStocks already has a key, which is the value of the purchase.ticker
                if(totalStocks.ContainsKey(stocks[purchase.ticker])){
                    //if it does, it will add the next (purchase.shares * purchase.price) to the existing value 
                    totalStocks[stocks[purchase.ticker]] += (purchase.shares * purchase.price);
                }else{
                    //if the dictionary does NOT already have the value, add it as well as a (purchase.shares * purchase.price) as a value;
                    totalStocks.Add(stocks[purchase.ticker], purchase.shares * purchase.price);
                }
              }
            }
                    //syntax for iterating over a dictionary
            foreach( KeyValuePair<string, double> totalStock in totalStocks){
                Console.WriteLine(totalStock);
            }
        }
    }
}
