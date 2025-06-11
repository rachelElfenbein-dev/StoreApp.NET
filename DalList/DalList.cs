
using DalApi;
namespace Dal;

internal sealed class DalList : IDal
{
    public ISale Sale => new SaleImplementation();
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
    private static DalList instance;
	public static DalList Instance
    {
		get { return instance; }
	}
    static DalList()
    {
        instance = new DalList();
    }

    private DalList() { }
}
