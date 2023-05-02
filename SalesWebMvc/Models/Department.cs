using System.Collections;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        //Atributos básicos
        public int Id { get; set; }
        public string Name { get; set; }
        //Associação
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //Constructor default
        public Department()
        {

        }

        //Constructor with arguments
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}


