using AutoMapper;
using Demo.BL.Interface;
using Demo.BL.Models;
using Demo.BL.Repository;
using Demo.DAL.Entitiy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRep employeeRep;
        private readonly IDepartmentRep departmentRep;
        private readonly IMapper mapper;

        public EmployeeController(IEmployeeRep employeeRep,IDepartmentRep departmentRep, IMapper mapper)
        {
            this.employeeRep = employeeRep;
            this.departmentRep = departmentRep;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var data = employeeRep.Get();
            var model = mapper.Map<IEnumerable<EmployeeVM>>(data);
          

            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DepartmentList = new SelectList(departmentRep.Get(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = mapper.Map<Employee>(model);
                employeeRep.Create(data);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var data = employeeRep.GetById(id);
                var model = mapper.Map<EmployeeVM>(data);
                ViewBag.DepartmentList = new SelectList(departmentRep.Get(), "Id", "Name",model.DepartmentId);
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
            var data = employeeRep.GetById(id);
            var model = mapper.Map<EmployeeVM>(data);
            ViewBag.DepartmentList = new SelectList(departmentRep.Get(), "Id", "Name",model.DepartmentId);

            if (model != null)
                return View(model);
            else
                return RedirectToAction("Index");


        }
        [HttpPost]
        public IActionResult Edit(EmployeeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = mapper.Map<Employee>(model);

                employeeRep.Edit(data);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            var data = employeeRep.GetById(id);
            var model = mapper.Map<EmployeeVM>(data);
            ViewBag.DepartmentList = new SelectList(departmentRep.Get(), "Id", "Name", model.DepartmentId);
            return View(model);

        }

        [HttpPost]
        public IActionResult Delete(EmployeeVM model)
        {

            try
            {
                var data = mapper.Map<Employee>(model);
                employeeRep.Delete(data);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.DepartmentList = new SelectList(departmentRep.Get(), "Id", "Name", model.DepartmentId);
                return View(model);
            }
        }


    }
}
