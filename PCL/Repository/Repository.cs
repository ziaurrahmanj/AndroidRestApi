using PCL.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCL.Repository
{
    public class Repository
    {
        public List<HotDog> GetAllHotdogs()
        {
            return new List<HotDog>()
           {
            new HotDog { Name="hot dog 1" }    ,
            new HotDog { Name="hot dog 2" }
           };
            
        }
    }
}
