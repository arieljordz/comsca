using COMSCA.DTO;
using COMSCA.Interface;
using COMSCA.Models;
using COMSCA.Models.DBContext;
using COMSCA.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace COMSCA.Controllers
{

    public class FileMaintenanceController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;

        public FileMaintenanceController(COMSCADBContext context, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
        }

        public IActionResult UserAccounts()
        {
            ViewBag.Username = db.tbl_userAccounts.FirstOrDefault().FullName;
            return View();
        }

        public IActionResult SetActiveDate()
        {
            ViewBag.Username = db.tbl_userAccounts.FirstOrDefault().FullName;
            return View();
        }

        public IActionResult Fees()
        {
            ViewBag.Username = db.tbl_userAccounts.FirstOrDefault().FullName;
            var fees = db.tbl_fee.OrderBy(x => x.FeeID);
            ViewBag.cmbfees = new SelectList(fees, "FeeID", "Description");

            return View();
        }

        [HttpPost]
        public IActionResult SaveActiveDates(ActiveDateDTO obj)
        {
            try
            {
                var qry = db.tbl_activeDate.ToList();
                if (qry.Count() == 0)
                {

                    DateTime DateofWeek = obj.StartDate;
                    DateTime DateofWeekAbsent = obj.StartDate;

                    int WeeksCount = global.GetWeeksInYear(obj.StartDate);

                    int WeekNumber = 1;
                    for (int i = 0; i < WeeksCount; i++)
                    {
                        tbl_activeDate dates = new tbl_activeDate();
                        dates.ActiveDate = DateofWeek;
                        dates.IsActive = WeekNumber == 1 ? true : false;
                        dates.WeekNumber = WeekNumber;
                        db.tbl_activeDate.Add(dates);
                        db.SaveChanges();

                        WeekNumber++;
                        DateofWeek = DateofWeek.AddDays(7);
                    }
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "The Dates are already generated." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public IActionResult LoadActiveDates()
        {
            var list = db.tbl_activeDate.OrderBy(x => x.WeekNumber).ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    ActiveDateID = item.ActiveDateID,
                    ActiveDate = item.ActiveDate.ToLongDateString(),
                    IsActive = item.IsActive,
                    WeekNumber = item.WeekNumber,
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult SetAsActive(int ActiveDateID)
        {
            try
            {
                var qry = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault();
                qry.IsActive = false;
                db.SaveChanges();

                var data = db.tbl_activeDate.Where(x => x.ActiveDateID == ActiveDateID).SingleOrDefault();
                data.IsActive = true;
                db.SaveChanges();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public IActionResult RemoveActiveDate(int ActiveDateID)
        {
            try
            {
                var data = db.tbl_activeDate.Where(x => x.ActiveDateID == ActiveDateID).SingleOrDefault();
                db.tbl_activeDate.Remove(data);
                db.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult SaveFee(tbl_feeDtls feeDtls)
        {
            try
            {
                if (feeDtls.FeeDtlsID != 0)
                {
                    var qry = db.tbl_feeDtls.Where(x => x.FeeDtlsID == feeDtls.FeeDtlsID).SingleOrDefault();
                    qry.FeeID = feeDtls.FeeID;
                    qry.Description = db.tbl_fee.Where(x => x.FeeID == feeDtls.FeeID).SingleOrDefault().Description;
                    qry.Amount = feeDtls.Amount;
                    qry.IsActive = feeDtls.IsActive == true ? true : false;
                    db.SaveChanges();
                    return Json(new { success = true });
                }
                else
                {
                    var qry = db.tbl_feeDtls.Where(x => x.FeeID == feeDtls.FeeID).Any();
                    if (!qry)
                    {
                        feeDtls.Description = db.tbl_fee.Where(x => x.FeeID == feeDtls.FeeID).SingleOrDefault().Description;
                        feeDtls.IsActive = feeDtls.IsActive == true ? true : false;
                        db.tbl_feeDtls.Add(feeDtls);
                        db.SaveChanges();
                        return Json(new { success = true });
                    }
                    else
                    {
                        return Json(new { success = false, message = "There is an existing fee details for this record." });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }

        }

        public IActionResult LoadFees()
        {
            var list = db.tbl_feeDtls.ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    FeeDtlsID = item.FeeDtlsID,
                    FeeID = item.FeeID,
                    Description = item.Description,
                    Amount = item.Amount,
                    IsActive = item.IsActive == true ? true : false,
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult UpdateFee(int FeeDtlsID)
        {
            try
            {
                var data = db.tbl_feeDtls.Where(x => x.FeeDtlsID == FeeDtlsID).SingleOrDefault();
                return Json(new { data = data });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message });
            }
        }

        public IActionResult RemoveFee(int FeeDtlsID)
        {
            try
            {
                var data = db.tbl_feeDtls.Where(x => x.FeeDtlsID == FeeDtlsID).SingleOrDefault();
                db.tbl_feeDtls.Remove(data);
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
