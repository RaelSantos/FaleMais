using FaleMais.Dominio.User.Entities;
using System;
using System.Linq.Expressions;

namespace FaleMais.Dominio.User.Specs
{
    public static class AreaCodeDestinySpecs
    {
        public static Expression<Func<AreaCodeDestiny, bool>> GetById(int id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<AreaCodeDestiny, bool>> GetByCode(string code)
        {
            return x => x.Code.Equals(code);
        }
    }
}
