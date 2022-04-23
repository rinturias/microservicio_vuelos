using Aerolinea.Vuelos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Vuelos.Infrastructure.Context
{
    public class UnitOfWork: IUnitOfWork
    {
        public Task Commit()
        {
            return Task.CompletedTask;
        }
    }
}
