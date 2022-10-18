using Demo.BL.Interface;
using Demo.BL.Models;
using Demo.DAL.Database;
using Demo.DAL.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        private readonly DemoContext db;

        public DepartmentRep(DemoContext db)
        {
            this.db = db;
        }
        public void Create(Department obj)
        {
          
            db.Department.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Department obj)
        {
            
            db.Remove(obj);
            db.SaveChanges();
        }

        public void Edit(Department obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Department> Get()
        {
            var data = db.Department.Select(a => a );
            return data;
        }

        public Department GetById(int id)
        {
            Department data = GetDepById(id);
            return data;
        }


        //==================Refactory================================
        private Department GetDepById(int id)
        {
            return db.Department.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
