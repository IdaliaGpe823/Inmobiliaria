using ProyectoInmobiliaria.Data;
using ProyectoInmobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Services
{
    public class DepartmentService
    {
        public void AddDepartment(Department department)
        {
            using (var context = new MyDbContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public List<Department> GetAllDepartments()
        {
            using (var context = new MyDbContext())
            {
                return context.Departments.Include(d => d.Rentals).ToList();
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (var context = new MyDbContext())
            {
                context.Entry(department).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var context = new MyDbContext())
            {
                var department = context.Departments.Find(id);
                if (department != null)
                {
                    context.Departments.Remove(department);
                    context.SaveChanges();
                }
            }
        }
    }
}
