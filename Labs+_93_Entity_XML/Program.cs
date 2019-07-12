using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Labs__93_Entity_XML
{
    class Program
    {
        static Product product = new Product();
        static List<Product> productSimpleList;



        static void Main(string[] args)
        {

            using (var db = new Northwind())
            {
                var products = db.Products.ToList();
                products.ForEach(p => Console.WriteLine(p.ProductName));


                Console.WriteLine("\n\nAdding an individual item to XML\n----------------------------------------------");

                //just get first product
                product = products.FirstOrDefault();
                var productXML = new XElement("Product",
                    new XElement("ProductID", product.ProductID),
                    new XElement("ProductName", product.ProductName),
                    new XElement("SupplierID", product.SupplierID),
                    new XElement("CategoryID", product.CategoryID),
                    new XElement("QuantityPerUnit", product.QuantityPerUnit),
                    new XElement("UnitPrice", product.UnitPrice),
                    new XElement("UnitsInStock", product.UnitsInStock),
                    new XElement("UnitsOnOrder", product.UnitsOnOrder),
                    new XElement("ReorderLevel", product.ReorderLevel),
                    new XElement("Discontinued", product.Discontinued)
                    );

                Console.WriteLine(productXML);

                Console.WriteLine("\n\nAdding multiple items to XML\n----------------------------------------------");

                var productXMLMultiple = new XElement("Products",
                    from p in products
                    select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("SupplierID", p.SupplierID),
                    new XElement("CategoryID", p.CategoryID),
                    new XElement("QuantityPerUnit", p.QuantityPerUnit),
                    new XElement("UnitPrice", p.UnitPrice),
                    new XElement("UnitsInStock", p.UnitsInStock),
                    new XElement("UnitsOnOrder", p.UnitsOnOrder),
                    new XElement("ReorderLevel", p.ReorderLevel),
                    new XElement("Discontinued", p.Discontinued)
                    ));

                Console.WriteLine(productXMLMultiple);

                Console.WriteLine("\n\nUsing UNION to join a column from another table\n----------------------------------------------");


                var productsss = db.Products.Include("Category").ToList();

                var productXMLMultipleWithCategory = new XElement("Products",
                    from p in productsss
                    select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("SupplierID", p.SupplierID),
                    new XElement("CategoryID", p.CategoryID),
                    new XElement("QuantityPerUnit", p.QuantityPerUnit),
                    new XElement("UnitPrice", p.UnitPrice),
                    new XElement("UnitsInStock", p.UnitsInStock),
                    new XElement("UnitsOnOrder", p.UnitsOnOrder),
                    new XElement("ReorderLevel", p.ReorderLevel),
                    new XElement("Discontinued", p.Discontinued)
                    //new XElement("Category", p.Category.CategoryName)
                    ));

                Console.WriteLine(productXMLMultipleWithCategory);


                //To save a document
                productXMLMultiple.Save("productXMLMultiple");

                //write new file to XML then de-serialize it back

                //write new file

                products = db.Products.ToList();

                var xmlProductsOutput = new XElement(
                    "Products",
                    from Product in productSimpleList
                    select new XElement(
                        "products",
                        new XElement("productID", product.ProductID),
                        new XElement("ProductName", product.ProductName),
                        new XElement("CategoryID", product.CategoryID)
                    ));

                xmlProductsOutput.Save("xmlProductsOutput.xml");

                Console.WriteLine("\n\nDeserialization\n----------------------------------------------");

                var productsDeserialized = new Products();

                using (var reader = new StreamReader("xmlProductsOutput.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Products));
                    productsDeserialized = (Products)serializer.Deserialize(reader);
                }
                //at this point, productDeserialized should hold our Product list

                productsDeserialized.ProductList.ForEach(p =>
                {
                    Console.WriteLine($"{p.ProductID,-10}{p.ProductName,-25}{p.CategoryID}");
                });

            }
        }
    }

    //annotation to let system know part of deserialization
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }
}