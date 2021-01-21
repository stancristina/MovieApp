using MovieApp.IServices;
using MovieApp.Models.Entities;
using MovieApp.Repositories;
using System.Collections.Generic;

namespace MovieApp.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _repository;
        public ProductionService(IProductionRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var production = _repository.FindById(id);
            _repository.Delete(production);
            return _repository.SaveChanges();
        }

        public List<Production> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Production GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Production production)
        {
            _repository.Create(production);
            return _repository.SaveChanges();
        }

        public bool Update(Production production)
        {
            _repository.Update(production);
            return _repository.SaveChanges();
        }
    }
}