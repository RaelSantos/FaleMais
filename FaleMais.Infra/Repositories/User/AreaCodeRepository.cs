using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaleMais.Infra.Repositories.User
{
    public class AreaCodeRepository : IAreaCodeRepository
    {
        private readonly FaleMaisDataContext _context;

        public AreaCodeRepository(FaleMaisDataContext context)
        {
            _context = context;
        }

        public IEnumerable<AreaCode> GetAllAreaCode()
        {
           return _context.AreaCodes.ToList();
        }

        public Plan GetAreaCodeByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Save(AreaCode plan)
        {
            throw new NotImplementedException();
        }

        public void Update(AreaCode plan)
        {
            throw new NotImplementedException();
        }
    }
}
