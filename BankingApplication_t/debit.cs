//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingApplication_t
{
    using System;
    using System.Collections.Generic;
    
    public partial class debit
    {
        public int sno { get; set; }
        public string Date { get; set; }
        public Nullable<decimal> AccountNo { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> OldBalance { get; set; }
        public string Mode { get; set; }
        public Nullable<decimal> DebAmount { get; set; }
    }
}
