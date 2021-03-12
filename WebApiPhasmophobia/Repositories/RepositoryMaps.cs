using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Data;
using WebApiPhasmophobia.Models;

namespace WebApiPhasmophobia.Repositories
{
    public class RepositoryMaps
    {
        MapsContext context;
        public RepositoryMaps(MapsContext context)
        {
            this.context = context;
        }

        public List<Map_ES> GetAllMapsES()
        {
            return this.context.Maps.ToList();
        }
        public Map_ES GetMapES(int id)
        {
            return this.context.Maps.SingleOrDefault(m => m.Id == id);
        }
    }
}
