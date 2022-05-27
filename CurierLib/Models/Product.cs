using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurierLib.Models
{
    public class Product : Entity
    {

        public string NameTovar { get; set; }

        public int PriceOne { get; set; }
    }
}
