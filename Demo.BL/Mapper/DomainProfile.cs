using AutoMapper;
using Demo.BL.Models;
using Demo.DAL.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Department, DepartmentVM>();
            CreateMap<DepartmentVM, Department>();
            CreateMap<Employee, EmployeeVM>();
            CreateMap<EmployeeVM, Employee>();
        }
    }
}
