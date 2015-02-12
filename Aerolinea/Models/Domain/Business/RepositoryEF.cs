using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;

namespace Aerolinea.Models.Domain.Business
{
    public class RepositoryEF : IRepository
    {

        
        public IEnumerable<VueloView> BusquedaDeVuelos()
        {
            var list = new List<VueloView>();
            using (var db = new AerolineaEntities())
            {
            }
            return list;
        }
    }
}