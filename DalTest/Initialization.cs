
using DO;
using DalApi;
using System.Runtime.InteropServices;
namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    private static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(6548,"יהודית","shagat arye","0556733201"));
        s_dal.Customer.Create(new Customer(8596, "רחל", "rabi akiva", "0583211344"));
        s_dal.Customer.Create(new Customer(3214, "Ester", "avi ezri", "0583296331"));
        s_dal.Customer.Create(new Customer(1475, "Rivka", "netivot amishpat", "0548485932"));
        s_dal.Customer.Create(new Customer(2580, "Moshe", "rashbi", "0548485931"));
    }
    private static void CreateProduct()
    {
        s_dal.Product.Create(new Product(0, "תנור", Categories.ElectricProducts, 5000, 50));
        s_dal.Product.Create(new Product(0, "מקרר", Categories.ElectricProducts, 5000, 50));
        s_dal.Product.Create(new Product(0, "רחל החמודה", Categories.ElectricProducts, 5000, 50));
        s_dal.Product.Create(new Product(0, "מיטת תינוק", Categories.BedroomFurniture, 700, 100));
        s_dal.Product.Create(new Product(0, "סיר", Categories.Kitchenware, 500, 500));
        s_dal.Product.Create(new Product(0, "ערסל ביצה", Categories.Garden, 700, 25));
        s_dal.Product.Create(new Product(0, "ספה פינתית", Categories.LivingRoomFurniture, 7000, 30));
    }
    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(0,1000,100,500,true, DateTime.Now,new DateTime(2025,1,1)));
        s_dal.Sale.Create(new Sale(0, 1001,200, 750, false, DateTime.Now, new DateTime(2025, 1, 1)));
        s_dal.Sale.Create(new Sale(0, 1002, 300, 5000, true, DateTime.Now, new DateTime(2025, 2, 1)));
        s_dal.Sale.Create(new Sale(0, 1003, 250, 200, false, DateTime.Now, new DateTime(2025, 3, 2)));
        s_dal.Sale.Create(new Sale(0, 1004, 400, 520, false, DateTime.Now, new DateTime(2025, 5, 4)));

    }
    public static void Iitialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateCustomer();
        CreateProduct();

        CreateSale();
    }
}

