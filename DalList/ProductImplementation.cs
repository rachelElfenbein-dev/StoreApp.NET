using DO;
using DalApi;
using System.Diagnostics;
using System.Xml.Linq;
using Tools3;
using System.Reflection;
using System.Linq;
namespace Dal;

internal class ProductImplementation: IProduct
{

    public int Create(Product item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");

        Product product = item with { id = DataSource.Config.GetRunning_num_product};
        DataSource.products.Add(product);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product");
        return product.id;
    }
    public Product? Read(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
        Product product=null;
        var p = DataSource.products.FirstOrDefault(pro => id == pro.id);
        if (p == null) { throw new DALidalreadyExistException("there is no such product"); }
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
        return p;
    }
    ///???????????????????????????????????????????????????????????????????????????
    public List<Product> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll product");
        List<Product?> p = (filter == null) ? new List<Product?>(DataSource.products) : DataSource.products.Where(filter).ToList();
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll product");
        return p;
    }
    public void Update(Product item)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
        Delete(item.id);
        DataSource.products.Add(item);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product");
    }
    public void Delete(int id)
    {
        LogManager.WriteToLogStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
        Product p = Read(id);
        DataSource.products.Remove(p);
        LogManager.WriteToLogEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        return DataSource.products.FirstOrDefault(filter) ?? throw new DALnotValidInputException("input was null");
    }
}
