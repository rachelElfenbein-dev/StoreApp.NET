using BlApi;
using DalApi;
using DalTest;
using DO;
using System;
using BO;

class Program
{
    static readonly BlApi.IBl s_bl = (BlApi.IBl)DalApi.Factory.Get;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to my console application!");
        // הוסף כאן קוד נוסף
       // Initialization.Iitialize();
        int select = printMainMenu();
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    productMenu();
                    break;
                case 2:
                    saleMenu();
                    break;
                case 3:
                    customerMenu();
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again");
                    break;
            }
            select = printMainMenu();
        }
    }
    private static void productMenu()
    {
        int select = printSubMenu("product");
        while (select != 0)
        {
            switch (select)
            {
                case 0:
                    printMainMenu();
                    break;
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    Read(s_bl.Product);
                    break;
                case 3:
                    ReadAll(s_bl.Product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Delete(s_bl.Product);
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again");
                    break;
            }
            select = printSubMenu("product");
        }
    }
    private static void saleMenu()
    {
        int select = printSubMenu("sale");
        while (select != 0)
        {
            switch (select)
            {
                case 0:
                    printMainMenu();
                    break;
                case 1:
                    CreateSale();
                    break;
                case 2:
                    //Read(s_bl.Sale);
                    break;
                case 3:
                    //ReadAll(s_bl.Sale);
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    //Delete(s_bl.Sale);
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again");
                    break;
            }
            select = printSubMenu("sale");
        }
    }
    private static void customerMenu()
    {
        int select = printSubMenu("customer");
        while (select != 0)
        {
            switch (select)
            {
                case 0:
                    printMainMenu();
                    break;
                case 1:
                    CreateCustomer();
                    break;
                case 2:
                    Read(s_bl.Customer);
                    break;
                case 3:
                    ReadAll(s_bl.Customer);
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    Delete(s_bl.Customer);
                    break;
                default:
                    Console.WriteLine("Wrong selection, please select again");
                    break;
            }
            select = printSubMenu("customer");
        }
    }
    private static int printMainMenu()
    {
        Console.WriteLine("For product press 1");
        Console.WriteLine("For sale press 2");
        Console.WriteLine("For customer press 3");
        Console.WriteLine("To exit press 0");
        int select;

        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;

        return select;
    }
    private static int printSubMenu(string item)
    {
        Console.WriteLine($"To add {item} press 1");
        Console.WriteLine($"To read {item} press 2");
        Console.WriteLine($"To readall {item}s press 3");
        Console.WriteLine($"To update {item}s press 4");
        Console.WriteLine($"To delate {item} press 5");
        Console.WriteLine($"To go back press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;

        return select;
    }
    private static void ReadAll(BlApi.IProduct p)
    {
        foreach (var item in p.ReadAll())
        {
            Console.WriteLine(item);
        }
    }
    private static void ReadAll(BlApi.ICustomer c)
    {
        foreach (var item in c.ReadAll())
        {
            Console.WriteLine(item);
        }
    }
    private static void ReadAll(BlApi.ISale s)
    {
        foreach (var item in s.ReadAll())
        {
            Console.WriteLine(item);
        }
    }
    private static void Read(BlApi.ICustomer c)
    {
        int id = 0;
        Console.WriteLine("insert ID...");
        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            Console.WriteLine(c.Read(id));
        }
        catch
        {
            throw new DALidNotExistException("read fail!, id not exist ");
        }
    }
    private static void Read(BlApi.ISale s)
    {
        int id = 0;
        Console.WriteLine("insert ID...");
        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            Console.WriteLine(s.Read(id));
        }
        catch
        {
            throw new DALidNotExistException("read fail!, id not exist ");
        }
    }
    private static void Read(BlApi.IProduct p)
    {
        int id = 0;
        Console.WriteLine("insert ID...");
        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            Console.WriteLine(p.Read(id));
        }
        catch
        {
            throw new DALidNotExistException("read fail!, id not exist ");
        }
    }
    private static void Delete(BlApi.IProduct p)
    {
        int id;

        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            p.Delete(id);
        }
        catch
        {
            throw new DALidNotExistException("delete fail!, id not exist ");
        }
    }
    private static void Delete(BlApi.ICustomer c)
    {
        int id;

        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            c.Delete(id);
        }
        catch
        {
            throw new DALidNotExistException("delete fail!, id not exist ");
        }
    }
    private static void Delete(BlApi.ISale s)
    {
        int id;

        try
        {
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id supposed to be only numbers!!! ");
        }
        try
        {
            s.Delete(id);
        }
        catch
        {
            throw new DALidNotExistException("delete fail!, id not exist ");
        }
    }
    private static void CreateProduct()
    {
        BO.Product p = createProductFromInput();
        s_bl.Product.Create(p);
    }
    private static BO.Product createProductFromInput(int id = 0)
    {
        string? name;
        BO.Categories? category;
        double price;
        int quantity;

        Console.WriteLine("press name");
        name = Console.ReadLine();
        category = (BO.Categories)PrintCategoryMenu();

        try
        {
            Console.WriteLine("press price");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("press quantity");
            quantity = int.Parse(Console.ReadLine());
            return new BO.Product(id, name, category, price, quantity);
        }
        catch
        {
            throw new DALnotValidInputException(" input not valid! in price/quantity ");
        }
    }
    private static void CreateSale()
    {
        //s_bl.Sale.Create(CreateSaleFromInput());
    }
    private static BO.Sale CreateSaleFromInput(int id = 0)
    {
        int productId, amountForSale;
        double totalPrice;
        bool isForClubCustomers;
        DateTime startDate, endDate;
        try
        {
            Console.WriteLine("insert productId");
            productId = int.Parse(Console.ReadLine());
            Console.WriteLine("insert amount for sale");
            amountForSale = int.Parse(Console.ReadLine());
            Console.WriteLine("insert total price  ");
            totalPrice = double.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("input not valid! in productId/amountForSale/totalPrice ");
        }
        try
        {
            Console.WriteLine("insert bool isForClubCustomers ");
            isForClubCustomers = bool.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("input not valid! must be true/false ");
        }
        try
        {
            startDate = DateTime.Parse(Console.ReadLine());
            endDate = DateTime.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("input not valid! in start date/ end date");

        }

        return new BO.Sale(id, productId, amountForSale, totalPrice, isForClubCustomers, startDate, endDate);
    }
    private static void CreateCustomer()
    {
        int id = 0;
        try
        {
            Console.WriteLine("inert ID");
            id = int.Parse(Console.ReadLine());
        }
        catch
        {
            throw new DALnotValidInputException("id must be number");
        }
        s_bl.Customer.Create(CreateCustomerFromInput(id));
    }
    private static BO.Customer CreateCustomerFromInput(int id)
    {
        string name, address, phone;
        Console.WriteLine("insert name");
        name = Console.ReadLine();
        Console.WriteLine("insert addres");
        address = Console.ReadLine();
        Console.WriteLine("insert phone");
        phone = Console.ReadLine();
        return new BO.Customer(id, name, address, phone);
    }
    private static void UpdateCustomer()
    {
        int id;
        try
        {
            id = int.Parse(Console.ReadLine());
            s_bl.Customer.Update(CreateCustomerFromInput(id));

        }
        catch
        {
            throw new DALnotValidInputException("input not valid! must be number");
        }
    }
    private static void UpdateProduct()
    {
        int id;
        try
        {
            id = int.Parse(Console.ReadLine());
            BO.Product product = createProductFromInput(id);
            s_bl.Product.Update(product);


        }
        catch
        {
            throw new DALnotValidInputException("input not valid! must be number");
        }

;
    }
    private static void UpdateSale()
    {
        int id;

        try
        {
            id = int.Parse(Console.ReadLine());
            //s_bl.Sale.Update(CreateSaleFromInput());


        }
        catch
        {
            throw new DALnotValidInputException("input not valid! must be number");
        }
    }
    private static int PrintCategoryMenu()
    {

        Console.WriteLine("for Kitchenware press 0");
        Console.WriteLine("for ElectricProducts press 1");
        Console.WriteLine("for BedroomFurniture press 2");
        Console.WriteLine("for LivingRoomFurniture press 3");
        Console.WriteLine("for Garden press 4");
        int select;
        try
        {
            select = int.Parse(Console.ReadLine());
            return select;
        }
        catch
        {
            throw new DALnotValidInputException("category can be only options 0-4");
        }

    }

}