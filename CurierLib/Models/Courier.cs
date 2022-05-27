using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
     public class Courier : Entity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
    }
}
