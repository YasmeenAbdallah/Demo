using AutoMapper;
using Demo.BL.Interface;
using Demo.BL.Models;
using Demo.BL.Repository;
using Demo.DAL.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class DepartmentsController : Controller
    {
       
        private readonly IDepartmentRep departmentRep;
        private readonly IMapper mapper;

        public DepartmentsController(IDepartmentRep departmentRep ,IMapper mapper)
        {
            this.departmentRep = departmentRep;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var data = departmentRep.Get();
           var model = mapper.Map<IEnumerable<DepartmentVM>>(data);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create() {

            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            if (ModelState.IsValid)
            {
                var data = mapper.Map<Department>(model);
                departmentRep.Create(data);
             return  RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var data =departmentRep.GetById(id);
                var model = mapper.Map<DepartmentVM>(data);
                return View(model);

            }
            catch (Exception)
            {

                throw;
            }            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = departmentRep.GetById(id);
            var model = mapper.Map<DepartmentVM>(data);
            if(model != null)
            return View(model);
            else 
                return RedirectToAction("Index");


        }
        [HttpPost]
        public IActionResult Edit(DepartmentVM model)
        {
            if (ModelState.IsValid)
            {
                var data = mapper.Map<Department>(model);
               
                departmentRep.Edit(data);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    
        [HttpGet]
        public IActionResult Delete(DepartmentVM model)
        {
            var data = mapper.Map<Department>(model);
            departmentRep.Delete(data);
            return RedirectToAction("Index");

        }


    }
}
