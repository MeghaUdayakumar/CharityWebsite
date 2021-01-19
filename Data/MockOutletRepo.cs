using System.Collections.Generic;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    public class MockOutletRepo : IOutletRepo
    {
        public IEnumerable<Outlet> GetAllOutlets()
        {
            var Outlets= new List<Outlet>
            {
                new Outlet{id=1, OutletName="NNN"},
                new Outlet{id=2, OutletName="MMM"}

            };
            return Outlets;
        }

        public Outlet GetOutletById(int id)
        {
            return new Outlet{id=1, OutletName="NNN"};

        }
    }
}