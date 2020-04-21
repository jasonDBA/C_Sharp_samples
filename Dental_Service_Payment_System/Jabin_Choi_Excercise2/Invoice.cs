using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabin_Choi_Excercise2
{
    public class Invoice
    {
        //Property
        private int quantityValue;
        private decimal priceValue;
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }

        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public int Quantity
        {
            get { return quantityValue; }
            set
            {
                if (value > 0)
                {
                    quantityValue = value;
                }
            }
        }
        public decimal Price
        {
            get { return priceValue; }
            set
            {
                if(value >= 0M)
                {
                    priceValue = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
            PartNumber, PartDescription, Quantity, Price);
        } 
    }
}
