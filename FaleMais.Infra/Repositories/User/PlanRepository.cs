using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Dominio.User.Specs;
using FaleMais.Infra.Persistence.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace FaleMais.Infra.Repositories.User
{
    public class PlanRepository : IPlanRepository
    {
        private readonly FaleMaisDataContext _context;

        public PlanRepository(FaleMaisDataContext context)
        {
            _context = context;
        }

        public Plan GetById(int id)
        {
            return _context.Plans.Where(PlanSpecs.GetById(id)).FirstOrDefault();
        }

        public IEnumerable<Plan> GetAll()
        {
            return _context.Plans.ToList();
        }                 
    }
}
