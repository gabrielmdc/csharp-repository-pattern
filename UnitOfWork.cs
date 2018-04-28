using RepositoryPattern.repositories;

namespace RepositoryPattern
{
    class UnitOfWork
    {
        private readonly MyContext _context;

        public UnitOfWork(MyContext context)
        {
            this._context = context;
            Persons = new TreatmentRepository(context);
        }

        public ITreatmentRepository Persons { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
