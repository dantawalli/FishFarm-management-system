using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFarm.BLL
{
    class StockingBLL
    {
        public int id { get; set; }
        public DateTime added_date { get; set; }
        public int pond_id { get; set; }
        public string species { get; set; }
        public string average_weight { get; set; }
        public string total_weight { get; set; }
        public decimal unit_cost { get; set; }
        public decimal total_cost { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
}
