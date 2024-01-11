using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WaterIntakeManagement.Models
{
    public class WaterIntake
    {
        [Key]
        public int WaterIntakeEntryId { get; set; }
        public DateTime Date { get; set; }
        public int AmountInMilliliters { get; set; }
        public TimeSpan TimeOfDay { get; set; }
        public string Notes { get; set; }
        public int DailyGoalInMilliliters { get; set; }
    }

}