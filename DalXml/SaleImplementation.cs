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
    internal class SaleImplementation : ISale
    {
        const string PATH = @"..\xml\sales.xml";
        private List<Sale> LoadList()
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "load list from xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> sales;
            using (StreamReader sw = new StreamReader(PATH))
            {
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "load list from xml");
                sales = serializer.Deserialize(sw) as List<Sale>;
            }
            return sales;
        }
        private void Save(List<Sale> sales)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "save list in xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (StreamWriter sw = new StreamWriter(PATH))
            {
                serializer.Serialize(sw, sales);
            }
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "save list in xml");

        }
        public int Create(Sale item)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
            int runId = Config.SaleId;
            List<Sale> sales;
            Sale sale = item with { id = runId };
            sales = LoadList();
            sales.Add(sale);
            Save(sales);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
            return runId;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
            List<Sale> sales = new List<Sale>();
            sales = LoadList();
            Sale? p = Read(id);
            sales.Remove(p);
            Save(sales);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        }

        public Sale? Read(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            List<Sale> sales = new List<Sale>();
            sales = LoadList();
            Sale p = sales.FirstOrDefault(pro => id == pro.id);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            return p;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            List<Sale> sales = new List<Sale>();
            sales = LoadList();
            Sale p = sales.FirstOrDefault(filter) ?? throw new DALnotValidInputException("input was null");
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            return p;
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readall sale");
            List<Sale> sales = new List<Sale>();
            sales = LoadList();
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readall salel");
            return (filter == null) ? new List<Sale?>(sales) : sales.Where(filter).ToList();
        }

        public void Update(Sale item)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
            List<Sale> sales = new List<Sale>();
            sales = LoadList();
            Delete(item.id);
            sales.Add(item);
            Save(sales);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        }
    }
}
