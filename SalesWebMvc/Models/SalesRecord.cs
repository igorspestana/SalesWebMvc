using SalesWebMvc.Models.Enums;
using System;
using System.Xml.Linq;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        //Atributos básicos
        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        //Associação
        public SaleStatus status { get; set; }
        public Seller Seller { get; set; }

        //Constructor default
        public SalesRecord()
        {

        }

        //Constructor with arguments
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
