using BlazorAdvance.Data.Models;
using BlazorAdvance.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvance.Data.Service
{
    public class SidebarService :ISidebar
    {
        public List<Sidebar> GetLinks()
        {
            try
            {
                using (var context = new StudentDBContext())
                {
                    var list = context.Sidebar.ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Sidebar GetLinksById(int id)
        {
            try
            {
                using (var context = new StudentDBContext())
                {

                    Sidebar sidebar = context.Sidebar.FirstOrDefault(e => e.Id == id);
                    return sidebar;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Sidebar sidebar)
        {
            try
            {
                using (var context = new StudentDBContext())
                {

                    context.Sidebar.Add(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Sidebar sidebar)
        {
            try
            {

                using (var context = new StudentDBContext())
                {
                    context.Sidebar.Update(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(Sidebar sidebar)
        {
            try
            {

                using (var context = new StudentDBContext())
                {
                    context.Sidebar.Remove(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
