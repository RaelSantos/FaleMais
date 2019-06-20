using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IAreaCodeDestinyRepository
    {
        AreaCodeDestiny GetById(int id);
        AreaCodeDestiny GetByCode(string code);
        IEnumerable<AreaCodeDestiny> GetAll();   
    }
}
