using FaleMais.Dominio.User.Entities;
using System.Collections.Generic;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IPlanRepository
    {
        void Save(Plan plan);
        void Update(Plan plan);
        Plan GetPlanByUsername(string username);
        IEnumerable<Plan> GetAllPlan();
    }
}
