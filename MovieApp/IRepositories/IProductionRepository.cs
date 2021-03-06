﻿using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Repositories
{
    public interface IProductionRepository : IGenericRepository<Production>
    {
        Production GetByIdJoined(int id);
    }
}
