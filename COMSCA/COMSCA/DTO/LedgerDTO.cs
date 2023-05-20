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
        public string Full_Name { get; set; }
        public bool Week_1 { get; set; }
        public bool Week_2 { get; set; }
        public bool Week_3 { get; set; }
        public bool Week_4 { get; set; }
        public bool Week_5 { get; set; }
        public bool Week_6 { get; set; }
        public bool Week_7 { get; set; }
        public bool Week_8 { get; set; }
        public bool Week_9 { get; set; }
        public bool Week_10 { get; set; }
        public bool Week_11 { get; set; }
        public bool Week_12 { get; set; }
        public bool Week_13 { get; set; }
        public bool Week_14 { get; set; }
        public bool Week_15 { get; set; }
        public bool Week_16 { get; set; }
        public bool Week_17 { get; set; }
        public bool Week_18 { get; set; }
        public bool Week_19 { get; set; }
        public bool Week_20 { get; set; }
        public bool Week_21 { get; set; }
        public bool Week_22 { get; set; }
        public bool Week_23 { get; set; }
        public bool Week_24 { get; set; }
        public bool Week_25 { get; set; }
        public bool Week_26 { get; set; }
        public bool Week_27 { get; set; }
        public bool Week_28 { get; set; }
        public bool Week_29 { get; set; }
        public bool Week_30 { get; set; }
        public bool Week_31 { get; set; }
        public bool Week_32 { get; set; }
        public bool Week_33 { get; set; }
        public bool Week_34 { get; set; }
        public bool Week_35 { get; set; }
        public bool Week_36 { get; set; }
        public bool Week_37 { get; set; }
        public bool Week_38 { get; set; }
        public bool Week_39 { get; set; }
        public bool Week_40 { get; set; }
        public bool Week_41 { get; set; }
        public bool Week_42 { get; set; }
        public bool Week_43 { get; set; }
        public bool Week_44 { get; set; }
        public bool Week_45 { get; set; }
        public bool Week_46 { get; set; }
        public bool Week_47 { get; set; }
        public bool Week_48 { get; set; }
        public bool Week_49 { get; set; }
        public bool Week_50 { get; set; }
        public bool Week_51 { get; set; }
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
        public decimal Amount{ get; set; }
        public string TotalAmount{ get; set; }
    }
}
