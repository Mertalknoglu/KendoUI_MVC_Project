using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIProject.Models
{
    public class MenuModel
    {
        public int id { get; set; }
        public int parentid { get; set; }
        public string title { get; set; }
        public string link { get; set; }
    }
}