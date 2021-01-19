using System.Collections.Generic;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    public interface IOutletRepo
    {
         IEnumerable<Outlet> GetAllOutlets();
         Outlet GetOutletById(int id);
    }
}