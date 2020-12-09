using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineBank.Models;

namespace OnlineBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly BankDBContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BankDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Payees()
        {
            var userdata = TempData.Peek("userdata");
            var name = TempData.Peek("name");
            List<Benficiarys> benficiarylist = new List<Benficiarys>();
            benficiarylist = (from Benficiarys in _db.Benficiarys where Benficiarys.Customer == name.ToString() select Benficiarys).ToList();
            return View(benficiarylist);
        }

        [HttpGet]
        public IActionResult PayeeAdd()
        {
            var name = TempData.Peek("name");
            Benficiarys item = new Benficiarys();
            item.Customer = name.ToString();
            return View(item);
        }

        [HttpPost]
        public IActionResult PayeeAdd(Benficiarys ben)
        {
            ben.CreatedDate = DateTime.Now;
            ben.Status = true;
            if (string.IsNullOrEmpty(ben.Payee_Name))
            {
                ModelState.AddModelError("Payee Name", "Payee Name field is required");
            }
            if (string.IsNullOrEmpty(ben.Payee_Contact))
            {
                ModelState.AddModelError("contact", "contact field is required");
            }
            if (string.IsNullOrEmpty(ben.Bnak_name))
            {
                ModelState.AddModelError("Bankname", "Bank name field is required");
            }

            if (ModelState.IsValid)
            {
                _db.Benficiarys.Add(ben);
                _db.SaveChanges();
                return RedirectToAction("Payees", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult PayeeUpdate(int? id)
        {
            var updateitem = (from ben in _db.Benficiarys where ben.ID == id select ben).SingleOrDefault();
            Benficiarys item = new Benficiarys();
            item.ID = updateitem.ID;
            item.Payee_Contact = updateitem.Payee_Contact;
            item.Payee_Name = updateitem.Payee_Name;
            item.Bnak_name = updateitem.Bnak_name;
            item.Customer = updateitem.Customer;
            return View(item);
        }

        [HttpPost]
        public IActionResult PayeeUpdate(Benficiarys ben)
        {
            if (string.IsNullOrEmpty(ben.Payee_Name))
            {
                ModelState.AddModelError("Payee Name", "Payee Name field is required");
            }
            if (string.IsNullOrEmpty(ben.Payee_Contact))
            {
                ModelState.AddModelError("contact", "contact field is required");
            }
            if (string.IsNullOrEmpty(ben.Bnak_name))
            {
                ModelState.AddModelError("Bankname", "Bank name field is required");
            }

            if (ModelState.IsValid)
            {
                var BenData = _db.Benficiarys.Where(x => x.ID == ben.ID).FirstOrDefault();
                if (BenData != null)
                {
                    BenData.Payee_Name = ben.Payee_Name;
                    BenData.Bnak_name = ben.Bnak_name;
                    BenData.Payee_Contact = ben.Payee_Contact;
                    _db.Entry(BenData).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Payees", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult customer()
        {
           
            List<Registration> customerlist = new List<Registration>();
            customerlist = _db.RegistrationTable.Where(x => x.Role == "1").ToList();
            return View(customerlist);
        }

        [HttpGet]
        public IActionResult customerDelete(int? id)
        {
            var itemToRemove = _db.RegistrationTable.SingleOrDefault(x => x.ID == id);
            if (itemToRemove != null)
            {
                _db.RegistrationTable.Remove(itemToRemove);
                _db.SaveChanges();
            }
            return View("Index", "Home");
        }

        [HttpGet]
        public IActionResult paymentPay(int? id)
        {
            var benData = _db.Benficiarys.SingleOrDefault(x => x.ID == id);
            PaymentHistory ph = new PaymentHistory();
            if (benData != null)
            {
                ph.Name = benData.Payee_Name;
                ph.Phone = benData.Payee_Contact;
                //ph.customerID = benData.ID;
            }
            return View(ph);
        }

        [HttpPost]
        public IActionResult payAmount(PaymentHistory Ph)
        {
            var loguser = TempData.Peek("name");
            var name =  _db.RegistrationTable.Where(x => x.Name == loguser.ToString()).FirstOrDefault();
            Ph.customerID = name.ID;
            Ph.Mode = "online";
            Ph.CreatedDate = DateTime.Now;
            if (string.IsNullOrEmpty(Ph.Name))
            {
                ModelState.AddModelError("Name", "Payee Name field is required");
            }
            if (string.IsNullOrEmpty(Ph.Phone))
            {
                ModelState.AddModelError("Phone", "contact field is required");
            }
            if (string.IsNullOrEmpty(Ph.Email))
            {
                ModelState.AddModelError("Email", "Email field is required");
            }

            if (ModelState.IsValid)
            {
                _db.PaymentTable.Add(Ph);
                _db.SaveChanges();
                return RedirectToAction("Payees", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult DepositWithdraw(int? id)
        {
            var reuser = _db.RegistrationTable.SingleOrDefault(x => x.ID == id);
            PaymentHistory ph = new PaymentHistory();
            if (reuser != null)
            {
                ph.Name = reuser.Name;
                ph.Phone = reuser.Contact_No;
                ph.customerID = reuser.ID;
            }
            return View(ph);
        }

        [HttpPost]
        public IActionResult DepositWithdrawSubmit(PaymentHistory Ph)
        {
            
            Ph.CreatedDate = DateTime.Now;
            if (string.IsNullOrEmpty(Ph.Name))
            {
                ModelState.AddModelError("Name", "Payee Name field is required");
            }
            if (string.IsNullOrEmpty(Ph.Phone))
            {
                ModelState.AddModelError("Phone", "contact field is required");
            }
            if (string.IsNullOrEmpty(Ph.Email))
            {
                ModelState.AddModelError("Email", "Email field is required");
            }

            if (ModelState.IsValid)
            {
                _db.PaymentTable.Add(Ph);
                _db.SaveChanges();
                return RedirectToAction("customer", "Home");
            }
            return View();
        }

        public IActionResult TellerList()
        {
            List<Registration> customerlist = new List<Registration>();
            customerlist = _db.RegistrationTable.Where(x => x.Role == "2").ToList();
            return View(customerlist);
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
