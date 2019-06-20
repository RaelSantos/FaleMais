using FaleMais.Dominio.User.Entities;
using System;
using System.Linq.Expressions;

namespace FaleMais.Dominio.User.Specs
{
    public static class PlanSpecs
    {
        public static Expression<Func<Plan, bool>> GetByUsername(string name)
        {
            return x => x.Name == name;
        }

        public static Expression<Func<Plan, bool>> GetById(int id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Plan, bool>> GetByMinute(int minute)
        {
            return x => x.Minute == minute;
        }
    }
}
