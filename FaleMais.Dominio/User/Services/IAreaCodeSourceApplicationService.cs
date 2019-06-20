using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Services
{
    public interface IAreaCodeSourceApplicationService
    {
        AreaCodeSource Get();
        IEnumerable<AreaCodeSource> GetAll();
    }
}
