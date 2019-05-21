using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IAreaCodeRepository
    {
        void Save(AreaCode plan);
        void Update(AreaCode plan);
        Plan GetAreaCodeByUsername(string username);
        IEnumerable<AreaCode> GetAllAreaCode();
    }
}
