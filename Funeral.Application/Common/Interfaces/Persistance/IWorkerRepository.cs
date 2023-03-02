using Funeral.Domain.Entities;

namespace Funeral.Application.Common.Interfaces.Persistance
{
    public interface IWorkerRepository
    {
        Worker? GetWorkerById(int id);
        void Add(Worker worker);
    }
}