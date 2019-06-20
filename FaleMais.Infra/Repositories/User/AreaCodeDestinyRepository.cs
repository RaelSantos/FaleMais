using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Dominio.User.Specs;
using FaleMais.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaleMais.Infra.Repositories.User
{
    public class AreaCodeDestinyRepository : IAreaCodeDestinyRepository
    {
        private readonly FaleMaisDataContext _context;

        public AreaCodeDestinyRepository(FaleMaisDataContext context)
        {
            _context = context;
        }

        public AreaCodeDestiny Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AreaCodeDestiny> GetAll()
        {
            return _context.AreaCodeDestinys.ToList();
        }

        public AreaCodeDestiny GetByCode(string code)
        {
            return _context.AreaCodeDestinys.Where(AreaCodeDestinySpecs.GetByCode(code)).FirstOrDefault();
        }

        public AreaCodeDestiny GetById(int id)
        {
            return _context.AreaCodeDestinys.Where(AreaCodeDestinySpecs.GetById(id)).FirstOrDefault();
        }
    }
}
