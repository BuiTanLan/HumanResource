using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HumanResource.ApplicationCore.Entities
{
    public class DayWork
    {
        public int DayWorkId { set; get; }
        public DateTime DateOfWork { get; set; }
        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
        public string DayInfo { get; set; }
        public bool? Status { set; get; }
        public int TimeSheetId { get; set; }
        public TimeSheet TimeSheet { get; set; }
    }
}
