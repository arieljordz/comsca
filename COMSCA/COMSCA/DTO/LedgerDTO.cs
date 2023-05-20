using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.DTO
{
    public class LedgerDTO
    {
        public int LedgerID { get; set; }
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public string TotalString { get; set; }
        public bool Week1 { get; set; }
        public bool Week2 { get; set; }
        public bool Week3 { get; set; }
        public bool Week4 { get; set; }
        public bool Week5 { get; set; }
        public bool Week6 { get; set; }
        public bool Week7 { get; set; }
        public bool Week8 { get; set; }
        public bool Week9 { get; set; }
        public bool Week10 { get; set; }
        public bool Week11 { get; set; }
        public bool Week12 { get; set; }
        public bool Week13 { get; set; }
        public bool Week14 { get; set; }
        public bool Week15 { get; set; }
        public bool Week16 { get; set; }
        public bool Week17 { get; set; }
        public bool Week18 { get; set; }
        public bool Week19 { get; set; }
        public bool Week20 { get; set; }
        public bool Week21 { get; set; }
        public bool Week22 { get; set; }
        public bool Week23 { get; set; }
        public bool Week24 { get; set; }
        public bool Week25 { get; set; }
        public bool Week26 { get; set; }
        public bool Week27 { get; set; }
        public bool Week28 { get; set; }
        public bool Week29 { get; set; }
        public bool Week30 { get; set; }
        public bool Week31 { get; set; }
        public bool Week32 { get; set; }
        public bool Week33 { get; set; }
        public bool Week34 { get; set; }
        public bool Week35 { get; set; }
        public bool Week36 { get; set; }
        public bool Week37 { get; set; }
        public bool Week38 { get; set; }
        public bool Week39 { get; set; }
        public bool Week40 { get; set; }
        public bool Week41 { get; set; }
        public bool Week42 { get; set; }
        public bool Week43 { get; set; }
        public bool Week44 { get; set; }
        public bool Week45 { get; set; }
        public bool Week46 { get; set; }
        public bool Week47 { get; set; }
        public bool Week48 { get; set; }
        public bool Week49 { get; set; }
        public bool Week50 { get; set; }
        public bool Week51 { get; set; }
        public decimal Total { get; set; }

    }
    public class LedgersDTO
    {
        public string FullName { get; set; }
        public bool Week1 { get; set; }
        public bool Week2 { get; set; }
        public bool Week3 { get; set; }
        public bool Week4 { get; set; }
        public bool Week5 { get; set; }
        public bool Week6 { get; set; }
        public bool Week7 { get; set; }
        public bool Week8 { get; set; }
        public bool Week9 { get; set; }
        public bool Week10 { get; set; }
        public bool Week11 { get; set; }
        public bool Week12 { get; set; }
        public bool Week13 { get; set; }
        public bool Week14 { get; set; }
        public bool Week15 { get; set; }
        public bool Week16 { get; set; }
        public bool Week17 { get; set; }
        public bool Week18 { get; set; }
        public bool Week19 { get; set; }
        public bool Week20 { get; set; }
        public bool Week21 { get; set; }
        public bool Week22 { get; set; }
        public bool Week23 { get; set; }
        public bool Week24 { get; set; }
        public bool Week25 { get; set; }
        public bool Week26 { get; set; }
        public bool Week27 { get; set; }
        public bool Week28 { get; set; }
        public bool Week29 { get; set; }
        public bool Week30 { get; set; }
        public bool Week31 { get; set; }
        public bool Week32 { get; set; }
        public bool Week33 { get; set; }
        public bool Week34 { get; set; }
        public bool Week35 { get; set; }
        public bool Week36 { get; set; }
        public bool Week37 { get; set; }
        public bool Week38 { get; set; }
        public bool Week39 { get; set; }
        public bool Week40 { get; set; }
        public bool Week41 { get; set; }
        public bool Week42 { get; set; }
        public bool Week43 { get; set; }
        public bool Week44 { get; set; }
        public bool Week45 { get; set; }
        public bool Week46 { get; set; }
        public bool Week47 { get; set; }
        public bool Week48 { get; set; }
        public bool Week49 { get; set; }
        public bool Week50 { get; set; }
        public bool Week51 { get; set; }
        public string Total { get; set; }
        //public decimal Total { get; set; }

    }

    public class LedgerDtlsDTO
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public string ActiveDateIDs { get; set; }
        public string[] arr_DateIDs { get; set; }
    }


    public class MemberLedgerDTO
    {
        public string FullName { get; set; }
        public string WeekNumber { get; set; }
        public bool IsPaid { get; set; }
        public string TotalAmount{ get; set; }
    }
}
