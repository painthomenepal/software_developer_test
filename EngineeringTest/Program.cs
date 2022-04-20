// See https://aka.ms/new-console-template for more information
using EngineeringTest;
using System.Collections.Generic;

List<Receipt> lis = new List<Receipt>();
string ans ="Y";
do
{
    Console.Write("Enter Quantity: ");
    var quantity = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Product: ");
    var product = Console.ReadLine();
    Console.Write("Enter Price: ");
    var price = Convert.ToDecimal(Console.ReadLine());
    lis.Add(new Receipt(quantity,product,price));
    Console.WriteLine();
    Console.WriteLine("Do you want to add another item? Enter Y for yes or other alphabet to finish input");
    ans = Console.ReadLine();
}

while (ans == "Y" || ans == "y");

Console.WriteLine("*********Input*********");
Console.WriteLine();
foreach (var i in lis)
{
    Console.Write(i.Quantity); Console.Write(",");
    Console.Write(i.Product); Console.Write(",");
    Console.Write(i.Price);
    Console.WriteLine("");
}
Console.WriteLine(""); 
Console.WriteLine("");
Console.WriteLine("***********Output**************");
Console.WriteLine();



Total getTotal = new Total();
OutputParams output = new OutputParams();
output = getTotal.FindTotal(lis);
foreach (var i in output.outputList)
{
    Console.Write(i.Quantity); Console.Write(",");
    Console.Write(i.Product); Console.Write(",");
    Console.Write(i.Price);
    Console.WriteLine("");
}

Console.WriteLine("Sales Taxes: {0}", output.SalesTaxes);
Console.WriteLine("Total: {0}", output.Total);
