//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPAC.Models
{
    using System;
    
    public partial class ILL_GET_OUT_RESPONSE_INFOR_Result
    {
        public int ID { get; set; }
        public string ReasonCode { get; set; }
        public string Reason_Viet { get; set; }
        public string Reason_Eng { get; set; }
        public Nullable<byte> CategoryID { get; set; }
        public Nullable<System.DateTime> ProvidedDate { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string ResponderSpecReason { get; set; }
        public int ResponderID { get; set; }
        public int LogID { get; set; }
        public Nullable<byte> ReasonID { get; set; }
    }
}