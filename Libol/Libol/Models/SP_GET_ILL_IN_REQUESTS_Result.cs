//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    
    public partial class SP_GET_ILL_IN_REQUESTS_Result
    {
        public string rdoRequest { get; set; }
        public int ID { get; set; }
        public string RequestID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public Nullable<System.DateTime> RespondDate { get; set; }
        public string Title { get; set; }
        public string PatronName { get; set; }
        public string PatronID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ods { get; set; }
        public Nullable<System.DateTime> eds { get; set; }
        public Nullable<byte> Priority { get; set; }
        public byte ServiceType { get; set; }
        public string LibrarySymbol { get; set; }
        public Nullable<int> Nom { get; set; }
    }
}
