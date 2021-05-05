using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_03___ENUM_M._09.Entities {
    //------------------------------- START -------------------------------//
    class HourContract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue() {
            return Hours * ValuePerHour;
        }

    }
    //-------------------------------- END -------------------------------//
}
