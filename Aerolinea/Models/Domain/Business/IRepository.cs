﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models.Domain.Business
{
    public interface IRepository
    {
        IEnumerable<VueloView> BusquedaDeVuelos();

    }
}