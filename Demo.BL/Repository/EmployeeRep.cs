using Demo.BL.Interface;
using Demo.DAL.Database;
using Demo.DAL.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BL.Repository
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly DemoContext db;

        public EmployeeRep(DemoContext db)
        {
            this.db = db;
        }
        public void Create(Employee obj)
        {

            db.Employee.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Employee obj)
        {

            db.Remove(obj);
            db.SaveChanges();
        }

        public void Edit(Employee obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Employee> Get()
        {
            var data = db.Employee.Include("Department").Select(a => a);
            return data;
        }

        public Employee GetById(int id)
        {
            Employee data = GetDepById(id);
            return data;
        }


        //==================Refactory================================
        private Employee GetDepById(int id)
        {
            return db.Employee.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
