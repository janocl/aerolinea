using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;

namespace Aerolinea.Models.Domain.Business
{
    public class RepositoryEF : IRepository
    {
        private List<VueloView> list = null;
        public IEnumerable<VueloView> BusquedaVueloOrigen() 
        {
            using (var db = new AerolineaEntities())
            {
                list = (from o in db.Origen
                        join c in db.Ciudad on o.IdCiudad equals c.Id
                        join a in db.Aeropuerto on c.IdAeropuerto equals a.Id
                        select new VueloView()
                        {
                            FechaSalida = o.FechaSalida,
                            Origen = c.Nombre,
                            Aeropuerto = a.Nombre
                        }).ToList();

            }
            return list;
        }


    }
}