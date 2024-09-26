using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Colony { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsRented { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
