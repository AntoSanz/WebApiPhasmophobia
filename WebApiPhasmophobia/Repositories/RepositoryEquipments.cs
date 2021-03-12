using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Data;
using WebApiPhasmophobia.Models;

namespace WebApiPhasmophobia.Repositories
{
    public class RepositoryEquipments
    {
        EquipmentsContext context;
        public RepositoryEquipments(EquipmentsContext context)
        {
            this.context = context;
        }

        public List<Equipment_ES> GetAllEquipmentsES()
        {
            return this.context.Equipments.ToList();
        }
        public Equipment_ES GetEquipmentES(int id)
        {
            return this.context.Equipments.SingleOrDefault(e => e.Id == id);
        }
    }
}
