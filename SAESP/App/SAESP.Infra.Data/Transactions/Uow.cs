using SAESP.Infra.Data.Context;

namespace SAESP.Infra.Data.Transactions
{
    public class Uow : IUow
    {
        private readonly SaespContext _context;

        public Uow(SaespContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Com Entity, não implementar, o rollback é feito pelo mesmo ao final do escopo (requisição).
        }
    }
}