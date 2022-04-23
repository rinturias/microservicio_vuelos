﻿using Aerolinea.Vuelos.Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Application.UseCases.Command.Vuelos
{
    public class CrearVuelosCommand : IRequest<Guid>
    {
        private CrearVuelosCommand() { }

        public CrearVuelosCommand(List<TripulacionDto> detalle)
        {
            Detalle = detalle;
        }

        public List<TripulacionDto> Detalle { get; set; }

        
    
    }
}
