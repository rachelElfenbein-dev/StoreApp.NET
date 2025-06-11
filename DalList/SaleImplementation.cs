using DalApi;
using DO;
using System.Linq;
using System.Reflection;
using Tools3;

namespace Dal;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        Sale sale = item with { id = DataSource.Config.GetRunning_num_sale };
        DataSource.sales.Add(sale);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");

        return sale.id;
    }
    public Sale? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read sale");
        var s = DataSource.sales.FirstOrDefault(sal => id == sal.id);
        if (s == null) { throw new DALidNotExistException("there is no such sale"); }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read sale");
        return s;
    }
  
    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll sale");
        List<Sale?> s = (filter == null) ? new List<Sale?>(DataSource.sales) : DataSource.sales.Where(filter).ToList();
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll sale");
        return s;
    }
    public void Update(Sale item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        Delete(item.id);
        DataSource.sales.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");

    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        Sale s = Read(id);
        DataSource.sales.Remove(s);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");

    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.sales.FirstOrDefault(filter) ?? throw new DALnotValidInputException("input was null");
    }
}
