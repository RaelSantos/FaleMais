using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Services
{
    public interface IPlanApplicationService
    {
        Plan Get();
        IEnumerable<Plan> GetAll();
    }
}
