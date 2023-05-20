using COMSCA.Interface;
using COMSCA.Models;
using COMSCA.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Controllers
{
    public class HomeController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;

        public HomeController(COMSCADBContext context, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
        }

        public IActionResult LoadViews()
        {
            ViewBag.Username = db.tbl_userAccounts.FirstOrDefault().FullName;
            ViewBag.DateNow = DateTime.Now;
            var gender = db.tbl_gender.OrderBy(x => x.GenderID);
            ViewBag.cmbgender = new SelectList(gender, "GenderID", "Description");
            ViewBag.CurrentCollection = global.MoneyFormat(global.GetCurrentCollection());
            ViewBag.TotalLoans = global.MoneyFormat(global.GetTotalLoans());
            ViewBag.ContributionFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Contribution Fee").FirstOrDefault().Amount;
            ViewBag.AbsentFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Absent Fee").FirstOrDefault().Amount;
            ViewBag.ServiceChargeFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Service Charge Fee").FirstOrDefault().Amount;
            ViewBag.cmbloandates = new SelectList(global.GetLoanDates(), "ActiveDateID", "ActiveDate");

            return View();
        }

        public IActionResult Dashboard()
        {
            return LoadViews();
        }

        public IActionResult MembershipDetails()
        {
            return LoadViews();
        }
        public IActionResult NewMembership()
        {
            return LoadViews();
        }
        public IActionResult Contribution()
        {
            return LoadViews();
        }

        public IActionResult Ledger()
        {
            return LoadViews();
        }

        public IActionResult LoanSchedule()
        {
            return LoadViews();
        }

        public IActionResult LoanApproval()
        {
       
            return LoadViews();
        }

        public IActionResult LoanDetails()
        {
            return LoadViews();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
