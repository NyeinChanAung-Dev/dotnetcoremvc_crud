using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcoremvc_crud.Models;
using dotnetcoremvc_crud.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoremvc_crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly dotnetcoremvc_crudContext _db;

        public HomeController(dotnetcoremvc_crudContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> _CustomerList()
        {
            List<Customer> _customerList = new List<Customer>();
            _customerList = await _db.Customer.AsNoTracking().OrderBy(c => c.Id).ToListAsync();

            return PartialView("_CustomerList", _customerList);
        }

        [HttpGet]
        public async Task<IActionResult> _CustomerForm(string FormType, int Id)
        {
            Customer _customer = new Customer();
            if (FormType == "Add")
            {
                return PartialView("_CustomerForm", _customer);
            }
            else
            {
                _customer = await _db.Customer.FirstOrDefaultAsync(m => m.Id == Id);
                return PartialView("_CustomerForm", _customer);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpSertCustomerForm(Customer _customer)
        {
            if (ModelState.IsValid)
            {
                if (_customer.Id == 0)
                {
                    _db.Customer.Add(_customer);
                    await _db.SaveChangesAsync();
                }
                else
                {
                    _db.Update(_customer);
                    await _db.SaveChangesAsync();
                }
                return Json("Success");
            }
            else
            {
                return Json("Fail");
            }
        }

        public async Task<IActionResult> _DeleteCustomer(int Id = 0)
        {
            var _customer = await _db.Customer.FindAsync(Id);

            if (_customer == null)
            {
                return Json("Fail");
            }
            else
            {
                _db.Remove(_customer);
                await _db.SaveChangesAsync();

                return Json("Success");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
