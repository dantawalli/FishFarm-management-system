using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFarm.BLL
{
    class SalesBLL
    {
        public int id { get; set; }
        public DateTime added_date { get; set; }
        public string species { get; set; }
        public string pond_id { get; set; }
        public string quantity { get; set; }
        public string total_cost { get; set; }
        public string remarks { get; set; }
        public int  month { get; set; }
        public int year { get; set; }
    }
}
