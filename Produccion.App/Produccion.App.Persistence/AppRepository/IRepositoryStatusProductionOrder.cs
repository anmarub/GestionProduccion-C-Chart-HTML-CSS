using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

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