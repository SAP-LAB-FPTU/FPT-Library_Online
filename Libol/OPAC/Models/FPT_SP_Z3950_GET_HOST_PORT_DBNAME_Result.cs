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
    
    public partial class FPT_SP_Z3950_GET_HOST_PORT_DBNAME_Result
    {
        public int ID { get; set; }
        public int DatabaseID { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public Nullable<int> Port { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool PreferredLender { get; set; }
        public string DBName { get; set; }
        public string Description { get; set; }
    }
}