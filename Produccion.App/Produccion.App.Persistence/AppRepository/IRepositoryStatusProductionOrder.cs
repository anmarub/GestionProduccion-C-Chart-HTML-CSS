using System;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryStatusProductionOrder
    {
         StatusProductionOrder AddStatusProductionOrder(StatusProductionOrder StatusProductionOrder);
         IEnumerable<StatusProductionOrder> GetAllStatusProduction();
         StatusProductionOrder GetStatusProduction(int idStatusProduction);
         StatusProductionOrder UpdateStatusProduction(StatusProductionOrder StatusProduction);
         void DeleteStatusProduction(int idStatusProduction);

    }
}