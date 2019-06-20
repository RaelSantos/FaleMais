using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Dominio.User.Specs;
using FaleMais.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaleMais.Infra.Repositories.User
{
    public class AreaCodeSourceRepository : IAreaCodeSourceRepository
    {
        private readonly FaleMaisDataContext _context;

        public AreaCodeSourceRepository(FaleMaisDataContext context)
        {
            _context = context;
        }

        public AreaCodeSource Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AreaCodeSource> GetAll()
        {
            return _context.AreaCodeSources.ToList();
        }

        public AreaCodeSource GetByCode(string code)
        {
            return _context.AreaCodeSources.Where(AreaCodeSourceSpecs.GetByCode(code)).FirstOrDefault();
        }

        public AreaCodeSource GetById(int id)
        {
            return _context.AreaCodeSources.Where(AreaCodeSourceSpecs.GetById(id)).FirstOrDefault();
        }
    }
}
