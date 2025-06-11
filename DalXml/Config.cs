using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DalXml
{
    static internal class Config
    {
        const string filePath = @"..\xml\data-config.xml";
        static XElement dataConfig = XElement.Load(filePath);
        public static int ProductId
        {
            get
            {
                XElement dataConfig = XElement.Load(filePath);
                int ID;
                if (!int.TryParse(dataConfig.Element("NextProductId").Value, out ID))
                    ID = 1000;
                dataConfig.Element("NextProductId").SetValue(ID + 100);
                dataConfig.Save(filePath);
                return ID;
            }
        }
        public static int SaleId
        {
            get
            {
                XElement dataConfig = XElement.Load(filePath);
                int ID;
                if (!int.TryParse(dataConfig.Element("NextSaleId").Value, out ID))
                    ID = 200;
                dataConfig.Element("NextSaleId").SetValue(ID + 10);
                dataConfig.Save(filePath);
                return ID;

            }
        }


    }
}
