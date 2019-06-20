using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IAreaCodeSourceRepository
    {
        AreaCodeSource GetById(int id);
        AreaCodeSource GetByCode(string code);
        IEnumerable<AreaCodeSource> GetAll();
    }
}
