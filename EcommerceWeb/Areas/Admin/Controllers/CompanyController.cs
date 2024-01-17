using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProject.DataAccess.Repository.IRepository;
using WebProject.Models;
using WebProject.Models.ViewModels;
using WebProject.WebProject.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using WebProject.Utility;

namespace EcommerceWeb.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class CompanyController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return View(objCompanyList);
        }


        //Get
        public IActionResult Upsert(int? id)
        {

            if (id == null || id == 0)
            {
                //for create
                return View(new Company());
            }
            else
            {
                //for update
                Company companyObj = _unitOfWork.Company.Get(u => u.Id == id);
                return View(companyObj);
            }


        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company CompanyObj)
        {


            if (ModelState.IsValid)
            {

                if (CompanyObj.Id == 0)
                {
                    _unitOfWork.Company.Add(CompanyObj);

                }
                else
                {
                    _unitOfWork.Company.Update(CompanyObj);

                }

                _unitOfWork.Save();

                if (CompanyObj.Id == 0)
                {
                    TempData["success"] = "Company created successfully";
                }
                else
                {
                    TempData["success"] = "Company updated successfully";
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(CompanyObj);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = objCompanyList });

        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {

            var CompanyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
            if (CompanyToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }           

            _unitOfWork.Company.Remove(CompanyToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Deleted Successfuly" });


        }

        #endregion

    }
}
