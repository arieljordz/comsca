using COMSCA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using COMSCA.Models.DBContext;
using COMSCA.Repository;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using COMSCA.Interface;

namespace COMSCA.Controllers
{

    public class MembershipController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;

        public MembershipController(COMSCADBContext context, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
        }

        [HttpPost]
        public IActionResult SaveMember(tbl_member member)
        {
            try
            {
                var chk = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault();
                if (chk != null)
                {
                    if (member.MemberID != 0)
                    {
                        var qry = db.tbl_member.Where(x => x.MemberID == member.MemberID).SingleOrDefault();
                        qry.FirstName = member.FirstName;
                        qry.LastName = member.LastName;
                        qry.FullName = member.FirstName + " " + member.LastName;
                        qry.Address = member.Address;
                        db.SaveChanges();
                    }
                    else
                    {
                        member.DateRegistered = DateTime.Now;
                        member.FullName = member.FirstName + " " + member.LastName;
                        db.tbl_member.Add(member);
                        db.SaveChanges();

                        SaveCollectionDtls(member.MemberID);
                    }
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Set the active date first." });
                }
        
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }

        }

        public void SaveCollectionDtls(int MemberID)
        {
            DateTime StartDate = Convert.ToDateTime(db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDate);
            DateTime DateofWeek = StartDate;
            DateTime DateofWeekAbsent = StartDate;

            int WeeksCount = global.GetWeeksInYear(StartDate);

            for (int i = 0; i < WeeksCount; i++)
            {
                int ActiveDateID = db.tbl_activeDate.Where(x => x.ActiveDate.Date == DateofWeek.Date).SingleOrDefault().ActiveDateID;

                tbl_collectionDtls dtls = new tbl_collectionDtls();
                dtls.MemberID = MemberID;
                dtls.ActiveDateID = ActiveDateID;
                db.tbl_collectionDtls.Add(dtls);
                db.SaveChanges();

                DateofWeek = DateofWeek.AddDays(7);
                DateofWeekAbsent = DateofWeekAbsent.AddDays(7);

            }
        }

        //public int GetWeeksInYear(DateTime StartDate)
        //{
        //    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        //    Calendar cal = dfi.Calendar;
        //    return cal.GetWeekOfYear(StartDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        //}

        public IActionResult LoadMembers()
        {
            var list = db.tbl_member.ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    MemberID = item.MemberID,
                    FullName = item.FullName,
                    Address = item.Address,
                    Gender = db.tbl_gender.Where(x => x.GenderID == item.GenderID).FirstOrDefault().Description,
                    DateRegistered = item.DateRegistered.ToShortDateString(),
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult UpdateMember(int MemberID)
        {
            try
            {
                var data = db.tbl_member.Where(x => x.MemberID == MemberID).SingleOrDefault();
                return Json(new { data = data });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message });
            }
        }

        public IActionResult RemoveMember(int MemberID)
        {
            try
            {
                var data = db.tbl_member.Where(x => x.MemberID == MemberID).SingleOrDefault();
                db.tbl_member.Remove(data);
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
