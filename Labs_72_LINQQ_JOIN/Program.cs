using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_72_LINQQ_JOIN
{
        class Program
        {
            static void Main(string[] args)
            {
                using (var db = new NorthwindEntities())
                {
                    Console.WriteLine("Orders By Customer Using LINQ Join\n\n");
                    var custorders =
                        from cust in db.Customers
                        join order in db.Orders
                        on cust.CustomerID equals order.CustomerID
                        orderby cust.ContactName, order.OrderDate
                        select new
                        {
                            ID = cust.CustomerID,
                            Name = cust.ContactName,
                            order.OrderID,
                            order.OrderDate
                        };

                    foreach (var item in custorders)
                    {
                        Console.WriteLine($"{item.ID,-20} {item.Name,-30} {item.OrderID,-20} {item.OrderDate:d}");
                    }

                    Console.WriteLine("\n\nLINQ Group Products By Category\n");

                    var productsByCategory =
                        (from c in db.Categories
                         join product in db.Products
                         on c.CategoryID equals product.CategoryID
                         select new
                         {
                             id = c.CategoryID,
                             category = c.CategoryName,
                             productID = product.ProductID,
                             name = product.ProductName
                         }).ToList();
                    foreach (var p in productsByCategory)
                    {
                        Console.WriteLine($"Category {p.category,-20} with id {p.id,-5} has product called {p.name,-30} with id {p.productID}");
                    }


                    Console.WriteLine("\n\nNow try grouping\n\n");

                    var productsByCategory2 =
                        (from c in db.Categories
                         join product in db.Products on c.CategoryID equals product.CategoryID
                         select new
                         {
                             id = c.CategoryID,
                             category = c.CategoryName,
                             productID = product.ProductID,
                             name = product.ProductName
                         }).GroupBy(category => category.category)
                            .Select(category => new
                            {
                                name = category.Key,
                                count = category.Count()
                            }).ToList();

                    foreach (var p in productsByCategory2)
                    {
                        Console.WriteLine($"Category {p.name,-20} has {p.count} items");
                    }









                    Console.WriteLine("\n\nSMART LINQ QUERIES\n\n");
                    Console.WriteLine("\n\nLooking at Product Categories and all products per category\n\n");

                    var Category =
                        from c in db.Categories
                        select c;
                    foreach (var c in Category)
                    {
                        Console.WriteLine($"\n\n{c.CategoryID,-2} {c.CategoryName,-9} eg. {c.Description}\n");

                        //SUB LOOP
                        var Product =
                            from p in db.Products
                            where c.CategoryID == p.CategoryID
                            select p;
                        foreach (var item2 in Product)
                        {
                            Console.WriteLine("             " + item2.ProductName);
                        }
                    }
                    //better way to do a subloop!  
                    Console.WriteLine("\n\nLet's upgrade this to include all products");

                    foreach (var cp in Category)
                    {
                        Console.WriteLine($"{cp.CategoryID,-2} {cp.CategoryName,-15} has {cp.Products.Count}");

                        Console.WriteLine("\t\t===========Products===============");
                        foreach (var product in cp.Products)
                        {
                            Console.WriteLine($"\t\t{product.ProductID,-10}{product.ProductName}");
                        }
                    }

                }
            }
        }
    }
