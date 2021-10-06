using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace timesheetdemo.CRUD.Model
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string GoowidId { get; set; }
        public string ClientCompanyName { get; set; }
        public string CandidateName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Units { get; set; }
        public decimal RatePerUnit { get; set; }
        public decimal TotalAmount { get; set; }
        public string Timestamp { get; set; }
    }
}
