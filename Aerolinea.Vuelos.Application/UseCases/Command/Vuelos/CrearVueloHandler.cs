using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.Services;

using Aerolinea.Vuelos.Domain.Entities;
using Aerolinea.Vuelos.Domain.Interfaces;
using AAerolinea.Vuelos.Domain.Interfaces;
using Aerolinea.Vuelos.Domain.Factories;


namespace Aerolinea.Vuelos.Application.UseCases.Command.Vuelos
{
    public class CrearVueloHandler
    {

        public readonly IVueloServices _vueloServices;
        public readonly IVuelosFactory _vuelosFactory;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IVueloRepository _vueloRepository;
        public CrearVueloHandler(IVueloServices vueloServices, IVuelosFactory vuelosFactory, IUnitOfWork unitOfWork, IVueloRepository vueloRepository)
        {
            _vueloServices=vueloServices;
            _vuelosFactory=vuelosFactory;
            _unitOfWork = unitOfWork;
            _vueloRepository=vueloRepository;
        }

        public async Task<Guid> Handle(CrearVuelosCommand request, CancellationToken cancellationToken)
        {
          
               // string nroPedido = await _pedidoService.GenerarNroPedidoAsync();
                Vuelo objVuelo= _vuelosFactory.Create(1);

                foreach (var item in request.Detalle)
                {
                    objVuelo.AgregarItem(objVuelo.codVuelo, 
                        
                        objVuelo.horaSalida,
                        objVuelo.horaLLegada,
                        objVuelo.estado,
                        objVuelo.precio,
                        objVuelo.fecha,
                        objVuelo.codDestino,
                        objVuelo.codOrigen,
                        objVuelo.codAeronave,
                        objVuelo.activo,
                        item.codTripulacion,
                        item.codEmpleado,
                        item.estado,
                        item.activo);
                }

                objVuelo.ConsolidarEventVueloHabilitado();

                await _vueloRepository.CreateAsync(objVuelo);

                await _unitOfWork.Commit();

                return objVuelo.Id;
          
        }
    }
}
