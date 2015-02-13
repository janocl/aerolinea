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
                list = (from p in db.Pasaje
                        join v in db.Vuelo on p.IdVuelo equals v.Id
                        join i in db.Itinerario on v.IdItinerario equals i.Id
                        join d in db.Destino on i.IdDestino equals d.Id
                        join c in db.Ciudad on d.IdCiudad equals c.Id
                        join a in db.Aeropuerto on c.IdAeropuerto equals a.Id
                        select new VueloView()
                        {
                            Valor = p.Valor,
                            Clase = p.Clase,
                            NumeroVuelo = v.NumeroVuelo,
                            FechaLlegada = d.FechaLlegada,
                            Destino = c.Nombre,
                            Aeropuerto = a.Nombre
                        }).ToList();

            }
            return list;
        }
    }
}