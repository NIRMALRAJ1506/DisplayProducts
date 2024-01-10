// See https://aka.ms/new-console-template for more information
using DisplayProducts;

List<Products> products = new List<Products>()
{
    new Products(){PName="Laptop",PPrice=52000.50,PBrand="Dell",MfgDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:10,month:10,year:2026)},
    new Products(){PName="Mobile",PPrice=25000.54,PBrand="Vivo",MfgDate=new DateTime(day:4,month:6,year:2020),ExpDate=new DateTime(day:7,month:11,year:2025)},
    new Products(){PName="Mobile",PPrice=18000.75,PBrand="One Plus",MfgDate=new DateTime(day:10,month:11,year:2021),ExpDate=new DateTime(day:12,month:11,year:2025)},
    new Products(){PName="Headphones",PPrice=5000.80,PBrand="BOAT",MfgDate=new DateTime(day:20,month:12,year:2024),ExpDate=new DateTime(day:11,month:11,year:2027)},
    new Products(){PName="TV",PPrice=62000.90,PBrand="Sony",MfgDate=new DateTime(day:10,month:12,year:2020),ExpDate=new DateTime(day:11,month:12,year:2025)},
};
Console.WriteLine("PName\t PPrice \t PBrand \t MfgDate \t ExpDate");
foreach (Products pro in products)
{
    Console.Write(pro.PName + "\t \t");
    Console.Write(pro.PPrice + "\t \t");
    Console.Write(pro.PBrand + "\t \t");
    Console.Write(pro.MfgDate.ToLongDateString());
    Console.Write(pro.ExpDate.ToLongDateString());
    Console.WriteLine("\n");
}
