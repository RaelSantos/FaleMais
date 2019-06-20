using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Dominio.User.Specs;
using FaleMais.Infra.Persistence.Contexts;
using System.Linq;

namespace FaleMais.Infra.Repositories.User
{
    public class AreaCodeValueMinuteRepository : IAreaCodeValueMinuteRepository
    {
        private readonly FaleMaisDataContext _context;

        public AreaCodeValueMinuteRepository(FaleMaisDataContext context)
        {
            _context = context;
        }

        public AreaCodeValueMinute ValueMin(int sourceId, int destinyId)
        {
            return _context.AreaCodeValueMinutes.Where(AreaCodeValueMinuteSpecs.GetBySourceIdAndDestinyId(sourceId, destinyId)).FirstOrDefault();
        }
    }
}
