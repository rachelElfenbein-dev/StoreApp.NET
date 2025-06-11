using DalApi;
using DO;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;


namespace DalTest
{
    internal class Program
    {
        private static readonly IDal s_dal=DalApi.Factory.Get;
        static void Main(string[] args)
        {
            Initialization.Iitialize();
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
                        Read<Product>(s_dal.Product);
                        break;
                    case 3:
                        ReadAll<Product>(s_dal.Product);
                        break;
                    case 4:
                        UpdateProduct();
                        break;
                    case 5:
                        Delete<Product>(s_dal.Product);
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
                        Read<Sale>(s_dal.Sale);
                        break;
                    case 3:
                        ReadAll<Sale>(s_dal.Sale);
                        break;
                    case 4:
                        UpdateSale();
                        break;
                    case 5:
                        Delete<Sale>(s_dal.Sale);
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
                        Read<Customer>(s_dal.Customer);
                        break;
                    case 3:
                        ReadAll<Customer>(s_dal.Customer);
                        break;
                    case 4:
                        UpdateCustomer();
                        break;
                    case 5:
                        Delete<Customer>(s_dal.Customer);
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
        private static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        private static void Read<T>(ICrud<T> crud)
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
                Console.WriteLine(crud.Read(id));
            }
            catch
            {
                throw new DALidNotExistException("read fail!, id not exist ");
            }
        }
        private static void Delete<T>(ICrud<T> crud)
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
                crud.Delete(id);
            }
            catch
            {
                throw new DALidNotExistException("delete fail!, id not exist ");
            }
        }
        private static void CreateProduct()
        {
            Product p = createProductFromInput();
            s_dal.Product.Create(p);
        }
        private static Product createProductFromInput(int id = 0)
        {
            string? name;
            Categories? category;
            double price;
            int quantity;

            Console.WriteLine("press name");
            name = Console.ReadLine();
            category = (Categories)PrintCategoryMenu();

            try
            {
                Console.WriteLine("press price");
                price = double.Parse(Console.ReadLine());
                Console.WriteLine("press quantity");
                quantity = int.Parse(Console.ReadLine());
                return new Product(id, name, category, price, quantity);
            }
            catch
            {
                throw new DALnotValidInputException(" input not valid! in price/quantity ");
            }
        }
        private static void CreateSale()
        {
            s_dal.Sale.Create(CreateSaleFromInput());
        }
        private static Sale CreateSaleFromInput(int id = 0)
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
                isForClubCustomers =bool.Parse(Console.ReadLine());
            }
            catch
            {
                throw new DALnotValidInputException("input not valid! must be true/false ");
            }
            try
            {
                startDate= DateTime.Parse(Console.ReadLine());
                endDate=DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                throw new DALnotValidInputException("input not valid! in start date/ end date");

            }
           
            return new Sale(id, productId, amountForSale, totalPrice, isForClubCustomers, startDate, endDate);
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
            s_dal.Customer.Create(CreateCustomerFromInput(id));
        }
        private static Customer CreateCustomerFromInput(int id)
        {
            string name, address, phone;
            Console.WriteLine("insert name");
            name = Console.ReadLine();
            Console.WriteLine("insert addres");
            address = Console.ReadLine();
            Console.WriteLine("insert phone");
            phone = Console.ReadLine();
            return new Customer(id, name, address, phone);
        }
        private static void UpdateCustomer()
        {
            int id;
            try
            {
                id=int.Parse(Console.ReadLine());
                s_dal.Customer.Update(CreateCustomerFromInput(id));

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
                Product product = createProductFromInput(id);
                s_dal.Product.Update(product);
        

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
                s_dal.Sale.Update(CreateSaleFromInput());


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
}