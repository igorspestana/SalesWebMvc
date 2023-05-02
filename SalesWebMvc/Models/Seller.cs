using SalesWebMvc.Models.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        //Atributos básicos
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        //Associação
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        //Constructor default
        public Seller()
        {

        }

        //Constructor with arguments
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord record)
        {
            Sales.Add(record);
        }

        public void RemoveSales(SalesRecord record)
        {
            Sales.Remove(record);
        }

        public double TotalSales(DateTime inicial, DateTime final) { 
            Sales
        }
    }
}
