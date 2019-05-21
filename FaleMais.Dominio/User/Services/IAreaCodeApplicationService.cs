using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Services
{
    public interface IAreaCodeApplicationService
    {
        AreaCode Get();
        List<AreaCode> GetAll();
    }
}
