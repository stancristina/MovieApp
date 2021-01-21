using MovieApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.IServices
{
    public interface IProductionService
    {
        List<Production> GetAll();
        Production GetById(int id);
        bool Insert(Production production);
        bool Update(Production production);
        bool Delete(int id);
    }
}
