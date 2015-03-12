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
        private List<DestinoView> listDes = null;
        private List<OrigenView> listOrg = null;

        public IEnumerable<VueloView> BusquedaVuelos() 
        {

            //var lista = new List<VueloView>();


            //var query = from o in BusquedaVuelosOrigen()
            //            join d in BusquedaVuelosDestino() on o.
            //            where o != null
            //            group o by new VueloView
            //            {
            //                AeropuertoOrigen = o.Aeropuerto,
            //                FechaSalida = o.FechaSalida,
            //                HoraSalida = o.HoraSalida,
            //                Origen = o.Origen,
                            

            //            } into g1
            //            select new VueloView { 
            //                                    AeropuertoOrigen = g1.Key.AeropuertoOrigen,
            //                                    AeropuertoDestino = g1.Key.
            //            };


            //BusquedaVuelosOrigen().ToList().ForEach(model => lista.Add(new VueloView
            //    {

            //        FechaSalida = model.FechaSalida,
            //        HoraSalida = model.HoraSalida,
            //        Origen = model.Origen,
            //        AeropuertoOrigen  = model.Aeropuerto,
            //        FechaLlegada = Convert.ToDateTime(BusquedaVuelosDestino().Select(item => item.FechaDestino.ToString())),
            //        HoraLlegada = Convert.ToDateTime(BusquedaVuelosDestino().Select(item=>item.HoraDestino.ToString())),
            //        Destino = Convert.ToString(BusquedaVuelosDestino().Select(item=>item.Destino.ToString())),
            //        AeropuertoDestino = Convert.ToString(BusquedaVuelosDestino().Select(item=>item.Aeropuerto.ToString()))
            //    }
            //    ));



            using (var db = new AerolineaEntities())
            {
                list = new List<VueloView>();
                list = (from o in db.Origen
                        join c in db.Ciudad on o.IdCiudad equals c.Id
                        join a in db.Aeropuerto on c.IdAeropuerto equals a.Id
                        select new VueloView()
                        {
                            FechaSalida = o.FechaSalida,
                            Origen = c.Nombre,
                            AeropuertoOrigen = a.Nombre
                        }).ToList();

            }
            return list;


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