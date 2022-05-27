using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class Customer : Entity
    {
        public string Adress { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
