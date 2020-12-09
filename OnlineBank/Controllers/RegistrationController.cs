using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineBank.Models;

namespace OnlineBank.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly BankDBContext _db;
        private readonly ILogger<RegistrationController> _logger;
        public RegistrationController(ILogger<RegistrationController> logger, BankDBContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            List<Roles> Rolelist = new List<Roles>();
            Rolelist = (from Roles in _db.RolesTable select Roles).ToList();
            ViewBag.role = Rolelist;
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Registration re)
        {
            if (ModelState.IsValid)
            {
                _db.RegistrationTable.Add(re);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Add All Fields");
            }
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.Message = "Login page";
            return View();
        }

        [HttpPost]
        public IActionResult Login(Registration re)
        {
            ViewBag.Message = "Login page";
            if (string.IsNullOrEmpty(re.Contact_No))
            {
                ModelState.AddModelError("Contact_No", "Contact field is required");
            }
            if (string.IsNullOrEmpty(re.Password))
            {
                ModelState.AddModelError("Password", "Password field is required");
            }
            if (ModelState.IsValid)
            {
                var userdata = (from p in _db.RegistrationTable
                                where p.Contact_No == re.Contact_No
                                && p.Password == re.Password
                                select p).SingleOrDefault();
                TempData["userdata"] = JsonConvert.SerializeObject(userdata);
                TempData["role"] = userdata.Role;
                TempData["name"] = userdata.Name;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            TempData.Remove("userdata");
            TempData.Remove("role");
            TempData.Remove("name");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult updateProfile()
        {
            ViewBag.Message = "Profile Update";
            var name = TempData.Peek("name");
            var reuser = _db.RegistrationTable.Where(x => x.Name == name.ToString()).FirstOrDefault();
            Registration re = new Registration();
            re.ID = reuser.ID;
            re.Name = reuser.Name;
            re.Contact_No = reuser.Contact_No;
            re.Email = reuser.Email;
            re.Password = reuser.Password;
            return View(re);
        }
        [HttpPost]
        public IActionResult updateProfile(Registration re)
        {
            ViewBag.Message = "Profile Update";
            if (string.IsNullOrEmpty(re.Contact_No))
            {
                ModelState.AddModelError("Contact No", "Contact field is required");
            }
            if (string.IsNullOrEmpty(re.Email))
            {
                ModelState.AddModelError("Email", "Email field is required");
            }
            if (string.IsNullOrEmpty(re.Name))
            {
                ModelState.AddModelError("Name", "Name field is required");
            }
            if (string.IsNullOrEmpty(re.Password))
            {
                ModelState.AddModelError("Password", "Password field is required");
            }
            if (ModelState.IsValid)
            {
                var reData = _db.RegistrationTable.Where(x => x.ID == re.ID).FirstOrDefault();
                if (reData != null)
                {
                    reData.Name = re.Name;
                    reData.Contact_No = re.Contact_No;
                    reData.Email = re.Email;
                    reData.Password = re.Password;
                    _db.Entry(reData).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Logout", "Registration");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult PaymentHistory()
        {
            var name = TempData.Peek("name");
            List<PaymentHistory> paymentlist = new List<PaymentHistory>();
            var reuser = _db.RegistrationTable.Where(x => x.Name == name.ToString()).FirstOrDefault();
            paymentlist = (from p in _db.PaymentTable where p.customerID == reuser.ID select p).ToList();
            return View(paymentlist);
        }
    }
}
