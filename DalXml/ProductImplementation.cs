using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools3;

namespace DalXml
{
    internal class ProductImplementation : IProduct
    {
        const string PATH = @"..\xml\products.xml";
        private List<Product> LoadList()
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "load list from xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamReader sw = new StreamReader(PATH))
            {
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "load list from xml");
                return serializer.Deserialize(sw) as List<Product>;
            }
        }
        private void Save(List<Product> products)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "save list in xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, products);
            }
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "save list in xml");

        }
        public int Create(Product item)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");
            int runId = Config.ProductId;
            List<Product> products=new List<Product>()    ;
            Product product=item with { id= runId };
            products=LoadList();
            products.Add(product);
            Save(products);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");
            return runId;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
            List<Product> products = new List<Product>();
            products = LoadList();
            Product p = Read(id);
            products.Remove(p);
            Save(products);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
        }

        public Product? Read(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            List<Product> products = new List<Product>();
            products = LoadList();
            Product p=products.FirstOrDefault(pro => id == pro.id);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            return p;
        }

        public Product? Read(Func<Product, bool> filter)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            List<Product> products = new List<Product>();
            products = LoadList();
            Product p = products.FirstOrDefault(filter) ?? throw new DALnotValidInputException("input was null");
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            return p;
        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readall product");
            List<Product> products = new List<Product>();
            products = LoadList();
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readall productl");
            return (filter == null) ? new List<Product?>(products) : products.Where(filter).ToList();
        }

        public void Update(Product item)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
            List<Product> products = new List<Product>();
            Delete(item.id);
            products = LoadList();
            products.Add(item);
            Save(products);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
        }
    }
}
