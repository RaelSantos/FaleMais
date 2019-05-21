using FaleMais.Infra.Persistence.Contexts;

namespace FaleMais.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FaleMaisDataContext _context;

        public UnitOfWork(FaleMaisDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Não faz nada :)
        }
    }
}
