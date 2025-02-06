using CarCharging.Core.Model;
using CarCharging.Core.Repositories;
using CarCharging.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Service
{
    public class StopService: Core.Service.IStop
    {
        private readonly Core.Repositories.IStop _pageRepository;
        public StopService(Core.Repositories.IStop pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public List<Page> GetAll()
        {
            return _pageRepository.GetPages();
        }
        public Page AddPage(Page page)
        {
            return _pageRepository.AddPage(page);
        }
        public Page UpdatePage(int id, Page page)
        {
            return _pageRepository.UpdatePage(id, page);
        }
        public void DeletePage(int id)
        {
            _pageRepository.DeletePage(id);
        }
    }
}
