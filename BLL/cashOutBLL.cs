﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFarm.BLL
{
    class cashOutBLL
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string activity { get; set; }
        public string amount { get; set; }
        public string comment { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
}
