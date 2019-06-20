using FaleMais.Dominio.User.Entities;
using System;
using System.Linq.Expressions;

namespace FaleMais.Dominio.User.Specs
{
    public static class AreaCodeValueMinuteSpecs
    {
        public static Expression<Func<AreaCodeValueMinute, bool>> GetBySourceIdAndDestinyId(int sourceId, int destinyId)
        {
            return x => x.AreaCodeSourceId == sourceId && x.AreaCodeDestinyId == destinyId;
        }

        public static Expression<Func<AreaCodeValueMinute, bool>> GetByValueMinute(decimal valueMinute)
        {
            return x => x.ValueMin == valueMinute;
        }       
    }
}
