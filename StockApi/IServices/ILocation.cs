﻿using StockApi.BO;
using StockApi.Entities;
using StockApi.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApi.IServices
{
    public interface ILocation
    {
        LocationBO Create(LocationBO location);

        List<LocationBO> Create(List<LocationBO> locations);

        LocationBO Delete(long Id);

        List<LocationBO> Delete(List<long> Ids);

        List<LocationBO> Get(List<long> Ids);

        List<LocationBO> Get();

        LocationBO Get(long Id);
        IQueryable<LocationBO> GetQuery(QueryParameters parameters);
        LocationBO Update(LocationBO location);


    }
}
