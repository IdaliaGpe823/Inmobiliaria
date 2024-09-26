using ProyectoInmobiliaria.Models;
using ProyectoInmobiliaria.Services;

namespace ProyectoInmobiliaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentService = new DepartmentService();

            // Crear un nuevo departamento
            var newDepartment = new Department
            {
                Street = "Main St",
                Number = 123,
                Colony = "Centro",
                City = "Ciudad",
                Description = "Departamento céntrico",
                RentPrice = 1000.00m,
                IsRented = false
            };
            departmentService.AddDepartment(newDepartment);

            // Leer departamentos
            var departments = departmentService.GetAllDepartments();
            foreach (var department in departments)
            {
                Console.WriteLine($"ID: {department.Id}, Dirección: {department.Street}, Precio: {department.RentPrice}");
            }
        }
    }

}