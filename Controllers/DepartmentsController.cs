using Demo.BL.Models;
using Demo.BL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentRep obj = new DepartmentRep();
        public IActionResult Index()
        {
            var data = obj.Get();
           return View(data);
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
                obj.Create(model);
             return  RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var data =obj.GetById(id);
                return View(data);

            }
            catch (Exception)
            {

                throw;
            }            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = obj.GetById(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentVM model)
        {
            if (ModelState.IsValid)
            {
                obj.Edit(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    
        [HttpGet]
        public IActionResult Delete(int id)
        {
            obj.Delete(id);
            return RedirectToAction("Index");

        }


    }
}
