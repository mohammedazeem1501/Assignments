using BlazorAdvance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Repository
{
    interface ISidebar
    {
        List<Sidebar> GetLinks();
        public Sidebar GetLinksById(int id);
        public bool Insert(Sidebar sidebar);
        public bool Update(Sidebar sidebar);
        public bool Delete(Sidebar sidebar);
    }
}
