using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Services
{
    interface IAreaCodeDestinyApplicationService
    {
        AreaCodeDestiny Get();
        IEnumerable<AreaCodeDestiny> GetAll();
    }
}
