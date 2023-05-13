using AspNetCore.Reporting;
using COMSCA.DTO;
using COMSCA.Interface;
using COMSCA.Models.DBContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Controllers
{
    public class ReportsController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;
        private readonly IWebHostEnvironment webHostEnvirnoment;

        public ReportsController(COMSCADBContext context, IWebHostEnvironment webHostEnvironment, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
            webHostEnvirnoment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoadLoanDetails(int LoanID)
        {
            string mimtype = "";
            int extension = 1;
            var path = $"{webHostEnvirnoment.WebRootPath}\\Reports\\LoanDetails.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //parameters.Add("FullName", db.tbl_member.Where(x=>x.MemberID == 1).FirstOrDefault().FullName);

            var qry = db.tbl_loanSchedule.ToList();

            var list = global.GetLoanLedger(LoanID);

            List<WeeksDTO> objList = new List<WeeksDTO>();

            foreach (var week in list.FirstOrDefault().Weeks.ToList())
            {
                var obj = new WeeksDTO
                {
                    Week = week,
                    FullName = list.FirstOrDefault().FullName,
                    Amount = list.FirstOrDefault().Amount,
                    Interest = GetInterest(list.FirstOrDefault().Amount),
                    IsPaid = false,
                };
                objList.Add(obj);
            }

            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("LoanDetails", objList);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/pdf");
        }

        public decimal GetInterest(decimal Amount)
        {
            decimal Interest = 0.0M;
            decimal percent = 0.02M;
            Interest = Amount * percent;
            return Interest;
        }
    }
}
