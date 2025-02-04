using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Model
{
    public class Page
    {
      public int Id { get; set; }
      public int PageNumber { get; set; }
        public List<Advertisement> Advertisements { get; set; }

    }
}
