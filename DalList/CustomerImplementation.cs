using DO;
using DalApi;
using System.Numerics;
using System.Xml.Linq;
using Tools3;
using System.Reflection;
namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
        var c = DataSource.customers.Where(cus => item.id == cus.id);
        if ((c.Any()))
            throw new DALidalreadyExistException("this code already exists");
        DataSource.customers.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer");
        return item.id;
    }
    public Customer? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read customer");
        var c = DataSource.customers.FirstOrDefault(cus => id == cus.id);
        if (c == null) { throw new DALidNotExistException("there is no such customer"); }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read customer");
        return c;
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readall customer");
        List<Customer?> c = (filter == null) ? new List<Customer?>(DataSource.customers) : DataSource.customers.Where(filter).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall customer");
        return c;
    }
    public void Update(Customer item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
        Delete(item.id);
        DataSource.customers.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customer");
    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");
        Customer c = Read(id);
        DataSource.customers.Remove(c);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
        return DataSource.customers.FirstOrDefault(filter) ?? throw new DALnotValidInputException("input was null");
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");

    }
}

   