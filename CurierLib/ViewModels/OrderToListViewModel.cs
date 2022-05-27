using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.ViewModels
{
   public  class OrderToListViewModel
    {
        public string Coirer { get; set; }

        public string Customer { get; set; }

        public string Tovar { get; set; }

        public string Price { get; set; }

        public DateTime Data { get; set; }
    }
}
