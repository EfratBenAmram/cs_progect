using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Model
{
    public enum Esize
    {
        EIGHTH = 1, 
        QUARTER = 2,
        HALF = 4,
        FULL = 8
    }
    public class Advertisement
    {
        public int Id { get; set; }
        public User User { get; set; }  
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public Page Page { get; set; }
        public Esize Size { get; set; }


    }
}
