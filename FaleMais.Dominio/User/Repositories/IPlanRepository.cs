using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IPlanRepository
    {      
        Plan GetById(int id);
        IEnumerable<Plan> GetAll();
    }
}
