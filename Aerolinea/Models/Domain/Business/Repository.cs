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

        public IEnumerable<VueloView> BusquedaVuelos(string Origen, string Destino) 
        {

            lista = new List<VueloView>();
            lista.Add(new VueloView()
            {
                IdVuelo = lista.Count() + 1,
                ListaVuelosOrigen = BusquedaVuelosOrigen().ToList().Where(x=>x.Origen == Origen).ToList(),
                ListaVuelosDestino = BusquedaVuelosDestino().ToList().Where(x => x.Destino == Destino).ToList(),
                // Elimina la duplicidad agrupandolos por una propiedad especifica
                ItemsOrigen = BusquedaVuelosOrigen().GroupBy(x => x.Origen).Select(y => new SelectListItem { Text = y.First().Origen }).OrderBy(x=>x.Text),
                ItemsDestino = BusquedaVuelosDestino().GroupBy(x => x.Destino).Select(y => new SelectListItem { Text = y.First().Destino }).OrderBy(x=>x.Text)
            });

            return lista;


        }

        public IEnumerable<VueloView> FiltrosBusqueda()
        {
            lista = new List<VueloView>();
            lista.Add(new VueloView()
            {
                IdVuelo = lista.Count() + 1,
                FechaSalida = BusquedaVuelosOrigen().Select(x => x.FechaSalida).First(),
                FechaLlegada = BusquedaVuelosDestino().Select(x => x.FechaDestino).First(),
                // Elimina la duplicidad agrupandolos por una propiedad especifica
                ItemsOrigen = BusquedaVuelosOrigen().GroupBy(x => x.Origen).Select(y => new SelectListItem { Text = y.First().Origen }).OrderBy(x=>x.Text),
                ItemsDestino = BusquedaVuelosDestino().GroupBy(x => x.Destino).Select(y => new SelectListItem { Text = y.First().Destino }).OrderBy(x=>x.Text)
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
                               IdOrigen = o.Id,
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
                                IdDestino = d.Id,
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