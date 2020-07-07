using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFarm.BLL
{
    class SalaryBLL
    {
        public int id { get; set; }
        public string amount_paid { get; set; }
        public string paid_to { get; set; }
        public string paid_by { get; set; }
        public string month { get; set; }
        public DateTime date { get; set; }
        public string comments { get; set; }
        public int montho { get; set; }
        public int year { get; set; }
    }
}
