using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
        public class Rental
        {
            public int Id { get; set; }
            public int DepartmentId { get; set; }
            public string ClientName { get; set; }
            public DateTime RentalDate { get; set; }

            // Relación con Department
            public virtual Department Department { get; set; }
        }
}
