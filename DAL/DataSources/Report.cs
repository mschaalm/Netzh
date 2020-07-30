//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DataSources
{
    using System;
    using System.Collections.Generic;
    /***
     * this class represent the entity report
     ***/
    public partial class Report
    {
        public int ReportID { get; set; }
        public System.DateTime TimeFalling { get; set; }//time of the falling
        public string Address { get; set; }//the address of falling
        public int ReporterID { get; set; }
        public string AddressCoordinates { get; set; }//the cordinates of the address falling
        public int NumberOfBooms { get; set; }
        public Nullable<int> Updated { get; set; }
    
        public virtual Reporter Reporter { get; set; }
        public virtual UpdatedReport UpdatedReport { get; set; }
    }
}