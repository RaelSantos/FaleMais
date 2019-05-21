using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using System;
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

        public IEnumerable<Plan> GetAllPlan()
        {
           return _context.Plans.ToList();
        }

        public Plan GetPlanByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Save(Plan plan)
        {
            throw new NotImplementedException();
        }

        public void Update(Plan plan)
        {
            throw new NotImplementedException();
        }
    }
}
