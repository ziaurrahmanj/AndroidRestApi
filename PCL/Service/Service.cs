using PCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Service
{
    public class Service
    {
        PCL.Repository.Repository repo = new PCL.Repository.Repository();
        public List<HotDog> GetAllHotdogs()
        {
          return  repo.GetAllHotdogs();
        }
    }
}
