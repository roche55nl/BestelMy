using System;
using System.Collections.Generic;
using System.Text;

namespace BestelMy.Models
{
   public class Gerecht
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int SelectedQuantity { get; set; }
    }
}
