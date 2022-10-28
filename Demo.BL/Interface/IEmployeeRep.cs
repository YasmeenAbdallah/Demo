using Demo.DAL.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Interface
{
  public interface IEmployeeRep
    {
        /// <summary>
        /// get lis of Employees
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> Get();
        /// <summary>
        /// Search By Name
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> SearchByName(string name);
        /// <summary>
        /// get departmant obj by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee GetById(int id);
        /// <summary>
        /// create new Employee
        /// </summary>
        /// <param name="obj"></param>
        void Create(Employee obj);
        /// <summary>
        /// delete a Employee
        /// </summary>
        /// <param name="id"></param>
        void Delete(Employee obj);
        /// <summary>
        /// edit on existance Employee
        /// </summary>
        /// <param name="obj"></param>
        void Edit(Employee obj);
    }
}
