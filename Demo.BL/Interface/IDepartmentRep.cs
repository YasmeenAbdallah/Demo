using Demo.BL.Models;
using Demo.DAL.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Interface
{
    public interface IDepartmentRep
    {
        /// <summary>
        /// get lis of departments
        /// </summary>
        /// <returns></returns>
        IEnumerable<Department> Get();
        /// <summary>
        /// get departmant obj by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Department GetById(int id);
        /// <summary>
        /// create new department
        /// </summary>
        /// <param name="obj"></param>
        void Create(Department obj);
        /// <summary>
        /// delete a department
        /// </summary>
        /// <param name="id"></param>
        void Delete(Department obj);
        /// <summary>
        /// edit on existance department
        /// </summary>
        /// <param name="obj"></param>
        void Edit(Department obj);
    }
}
