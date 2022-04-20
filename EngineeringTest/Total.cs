using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringTest
{
    internal class Total
    {
        public OutputParams FindTotal(List<Receipt> receipts)
        {
            OutputParams output = new OutputParams();
            List<Receipt> newlis = new List<Receipt>();
            decimal total = 0;
            decimal basicTax = 0;
            foreach (Receipt rec in receipts)
            {
                
                if(rec.Product.Contains("book") == false && rec.Product.Contains("chocolate") == false && rec.Product.Contains("pills") == false)
                {
                    var itemTotal = rec.Quantity * rec.Price;
                    decimal itemTax = 0;
                    if(rec.Product.Length > 8 && rec.Product.Contains("imported") == true)
                    {
                        itemTax = itemTotal * 15 / 100;
                        basicTax = basicTax + itemTax;
                    }
                    else
                    {
                        itemTax = (rec.Quantity * rec.Price) * 1 / 10;
                        basicTax = basicTax + itemTax;
                    }
                    total = total + itemTotal;
                    //newlis.Add(new Receipt(rec.Quantity, rec.Product, Math.Round((rec.Price + itemTax)*20,MidpointRounding.AwayFromZero)/20));
                    newlis.Add(new Receipt(rec.Quantity, rec.Product, rec.Price + Math.Round(itemTax*20,MidpointRounding.AwayFromZero)/20));

                }
                else
                {
                    var itemTotal = rec.Quantity * rec.Price;
                    
                    decimal itemTax = 0;
                    if (rec.Product.Length > 8 && rec.Product.Contains("imported") == true)
                    {
                        itemTax = itemTotal * 5 / 100;
                        basicTax = basicTax + itemTax;
                    }
                    else
                    {
                        basicTax = basicTax + itemTax;
                    }
                    total = total + itemTotal;
                    //newlis.Add(new Receipt(rec.Quantity, rec.Product, Math.Round((rec.Price + itemTax)*20,MidpointRounding.AwayFromZero)/20));
                    newlis.Add(new Receipt(rec.Quantity, rec.Product, rec.Price + Math.Round(itemTax * 20, MidpointRounding.AwayFromZero) / 20));


                }

            }
            output.SalesTaxes = Math.Round(basicTax * 20,MidpointRounding.AwayFromZero)/20;

            output.Total = total + output.SalesTaxes;
            output.outputList = newlis;
            return output;
        }
    }
}
