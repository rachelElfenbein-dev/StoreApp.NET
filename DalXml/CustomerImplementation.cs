using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tools3;


namespace DalXml
{
    internal class CustomerImplementation : ICustomer
    {
        const string PATH = @"..\xml\customers.xml";
        const string CUSTOMERS = "Customers";
        const string CUSTOMER = "Customer";
        const string CUSTOMERID = "CustomerId";
        const string CUSTOMERNAME = "CustomerName";
        const string CUSTOMERADDRESS = "CustomerAddress";
        const string CUSTOMERPHONE = "CustomerPhone";
        public int Create(Customer item)
        {
            XElement customerXml = XElement.Load(PATH);
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
            XElement x = customerXml.Elements(CUSTOMERID).FirstOrDefault(c => (int)c == item.id);
            if (x != null)
                throw new Exception("this customer code already exists");

            customerXml.Add(new XElement(CUSTOMER, new XElement(CUSTOMERID, item.id),
                                            new XElement(CUSTOMERNAME, item.name),
                                            new XElement(CUSTOMERADDRESS, item.address),
                                            new XElement(CUSTOMERPHONE, item.phone)));
            customerXml.Save(PATH);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");

            return item.id;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");
            XElement customersXml = XElement.Load(PATH);
            customersXml.Descendants(CUSTOMERID).First(pId => pId.Value == id.ToString()).Parent.Remove();
            customersXml.Save(PATH);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");
        }

        public Customer? Read(int id)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
           XElement customerXml = XElement.Load(PATH);
           XElement c = customerXml.Descendants(CUSTOMERID).FirstOrDefault(cId => cId.Value == id.ToString()).Parent;
           if (c == null)
            {
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product" + id);
                throw new DALidNotExistException("not found this customer");
            }
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
            Customer customer =new Customer((int)c.Element(CUSTOMERID), (string)c.Element(CUSTOMERNAME), (string)c.Element(CUSTOMERADDRESS), (string)c.Element(CUSTOMERPHONE));
            c.Save(CUSTOMERID);
            return customer;

        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read customer");
           XElement customersXml = XElement.Load(PATH);
            XElement? customers = XElement.Load(PATH).Descendants(CUSTOMERS)
                .FirstOrDefault(c => filter != null && filter(new Customer((int)c.Element(CUSTOMERID), (string)c.Element(CUSTOMERNAME), (string)c.Element(CUSTOMERADDRESS),(string)c.Element(CUSTOMERPHONE))));
            Customer customer = new Customer((int)customers.Element(CUSTOMERID), (string)customers.Element(CUSTOMERNAME), (string)customers.Element(CUSTOMERADDRESS), (string)customers.Element(CUSTOMERPHONE));
           customersXml.Save(PATH);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read customer");
            customersXml.Save(CUSTOMERID);
            return customer;
        }
        public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll customer");
            XElement customersXml = XElement.Load(PATH);
            if (filter == null)
            {
                List<Customer> list = new List<Customer>(customersXml.Descendants(CUSTOMER)
                    .Select(c => new Customer((int)c.Element(CUSTOMERID), (string)c.Element(CUSTOMERNAME), (string)c.Element(CUSTOMERADDRESS), (string)c.Element(CUSTOMERPHONE)))).ToList();
                LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll product");
                customersXml.Save(PATH);
                return list;
            }
            List<Customer> list1 = new List<Customer>(customersXml.Descendants(CUSTOMER)
                .Select(c => new Customer((int)c.Element(CUSTOMERID), (string)c.Element(CUSTOMERNAME), (string)c.Element(CUSTOMERADDRESS), (string)c.Element(CUSTOMERPHONE))).Where(c => filter(c)).ToList());
            customersXml.Save(PATH);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readAll customer");
            return list1;
        }

        public void Update(Customer item)
        {
            LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
            XElement customersXml = XElement.Load(PATH);
            Delete(item.id);
            Create(item);
            LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
        }
    }
}
