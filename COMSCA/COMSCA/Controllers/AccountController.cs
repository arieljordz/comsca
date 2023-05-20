using COMSCA.Models;
using COMSCA.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Controllers
{
    public class AccountController : Controller
    {
        private readonly COMSCADBContext db;

        public AccountController(COMSCADBContext context)
        {
            db = context;
        }

        public IActionResult Account()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var qry = db.tbl_userAccounts.Where(x => x.Username == username && x.Password == password).Any();

            if (qry)
            {
                //return RedirectToAction("Dashboard", "Home");
                //return RedirectToAction("Contribution", "Home");
                //return RedirectToAction("SetActiveDate", "Home");
                return RedirectToAction("MembershipDetails", "Home");
                //return RedirectToAction("Ledger", "Home");
                //return RedirectToAction("LoanApproval", "Home");
                //return RedirectToAction("LoanDetails", "Home");
                //return RedirectToAction("Fees", "FileMaintenance");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View("Account");
            }
        }

        [HttpPost]
        public IActionResult SaveUser(tbl_userAccounts user)
        {
            try
            {
                if (user.UserID != 0)
                {
                    var qry = db.tbl_userAccounts.Where(x => x.UserID == user.UserID).SingleOrDefault();
                    qry.FirstName = user.FirstName;
                    qry.LastName = user.LastName;
                    qry.FullName = user.FirstName + " " + user.LastName;
                    qry.Username = user.Username;
                    qry.Password = user.Password;
                    db.SaveChanges();
                }
                else
                {
                    user.DateAdded = DateTime.Now;
                    user.FullName = user.FirstName + " " + user.LastName;
                    db.tbl_userAccounts.Add(user);
                    db.SaveChanges();
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        public IActionResult LoadUsers()
        {
            var list = db.tbl_userAccounts.ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    UserID = item.UserID,
                    FullName = item.FullName,
                    Username = item.Username,
                    Password = item.Password,
                    DateAdded = item.DateAdded.ToShortDateString(),
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult UpdateUser(int UserID)
        {
            try
            {
                var data = db.tbl_userAccounts.Where(x => x.UserID == UserID).SingleOrDefault();
                return Json(new { data = data });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message });
            }
        }

        public IActionResult RemoveUser(int UserID)
        {
            try
            {
                var data = db.tbl_userAccounts.Where(x => x.UserID == UserID).SingleOrDefault();
                db.tbl_userAccounts.Remove(data);
                db.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


    }
}
