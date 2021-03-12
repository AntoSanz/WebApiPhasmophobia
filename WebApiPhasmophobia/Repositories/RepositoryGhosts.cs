using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Data;
using WebApiPhasmophobia.Models;

namespace WebApiPhasmophobia.Repositories
{
    public class RepositoryGhosts
    {
        GhostsContext context;
        public RepositoryGhosts(GhostsContext context)
        {
            this.context = context;
        }

        public List<Ghost_ES> GetAllGhostsES()
        {
            return this.context.Ghosts.ToList();
        }
        public Ghost_ES GetGhostES(int id)
        {
            return this.context.Ghosts.SingleOrDefault(g => g.Id == id);
        }
    }
}
