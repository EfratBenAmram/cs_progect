using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Service
{
    public interface IPageService
    {
        List<Page> GetAll();
        public Page AddPage(Page page);
        public Page UpdatePage(int id, Page page);
        public void DeletePage(int id);
    }
}
