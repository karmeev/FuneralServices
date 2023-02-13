using Funeral.Application.Common.Interfaces.Persistance;
using Funeral.Domain.Entities;

namespace Funeral.Infrastructure.Persistance.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private static readonly List<Worker> _workers = new();
        public void Add(Worker worker)
        {
            _workers.Add(worker);
        }

        public Worker? GetWorkerById(int id)
        {
            return _workers.SingleOrDefault(w => w.Id == id );
        }
    }
}