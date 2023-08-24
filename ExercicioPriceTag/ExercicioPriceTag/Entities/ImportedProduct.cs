using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPriceTag.Entities
{
    internal class ImportedProduct : Product
    {
        public double Customsfee { set; get; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double custonsFee)
        : base(name, price)
        {
            Customsfee = custonsFee;
        }

        protected double TotalPrice()
        {
            return Customsfee + Price;
        }
        public override string TagPrice()
        {
            return Name
                           + " $ "
                           + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                           + " (Customs fee: $ "
                           + Customsfee.ToString("F2", CultureInfo.InvariantCulture)
                           + ")";

        }


    }
}
