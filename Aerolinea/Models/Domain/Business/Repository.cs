using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aerolinea.Models.Domain.Data;
using System.Web.Mvc;

namespace Aerolinea.Models.Domain.Business
{
    public class Repository : IRepository
    {
        private List<VueloView> lista = null;
        private List<DestinoView> listDes = null;
        private List<OrigenView> listOrg = null;

        public IEnumerable<VueloView> BusquedaVuelos() 
        {

            lista = new List<VueloView>();
            lista.Add(new VueloView()
            {
                ListaVuelosOrigen = BusquedaVuelosOrigen().ToList(),
                ListaVuelosDestino = BusquedaVuelosDestino().ToList(),
                ListaItemsOrigen = BusquedaVuelosOrigen().Select(x => new SelectListItem { Text = x.Origen }),
                ListaItemsDestino = BusquedaVuelosDestino().Select(x => new SelectListItem { Text = x.Destino })
            });

            return lista;


        }

        public IEnumerable<VueloView> FiltrosBusqueda()
        {
            lista = new List<VueloView>();
            lista.Add(new VueloView()
            {
                ListaItemsOrigen = BusquedaVuelosOrigen().Select(x => new SelectListItem { Text = x.Origen }),
                ListaItemsDestino = BusquedaVuelosDestino().Select(x => new SelectListItem { Text = x.Destino })
            });

            return lista;
        
        }

        public IEnumerable<OrigenView> BusquedaVuelosOrigen()
        {
            using (var db = new AerolineaEntities())
            {
                listOrg = new List<OrigenView>();
                listOrg = (from o in db.Origen
                           join c in db.Ciudad on o.IdCiudad equals c.Id
                           join a in db.Aeropuerto on c.IdAeropuerto equals a.Id
                           select new OrigenView()
                           {
                               FechaSalida = o.FechaSalida,
                               HoraSalida = o.HoraSalida,
                               Origen = c.Nombre,
                               Aeropuerto = a.Nombre
                           }).ToList();

            }
            return listOrg;

        }


        public IEnumerable<DestinoView> BusquedaVuelosDestino()
        {
            using (var db = new AerolineaEntities())
            {
                listDes = new List<DestinoView>();
                listDes = (from d in db.Destino
                            join c in db.Ciudad on d.IdCiudad equals c.Id
                            join a in db.Aeropuerto on c.IdAeropuerto equals a.Id
                            select new DestinoView()
                            {
                                FechaDestino = d.FechaLlegada,
                                HoraDestino = d.HoraLlegada,
                                Destino = c.Nombre,
                                Aeropuerto = a.Nombre
                            }).ToList();

            }
            return listDes;
        
        }




    }
}