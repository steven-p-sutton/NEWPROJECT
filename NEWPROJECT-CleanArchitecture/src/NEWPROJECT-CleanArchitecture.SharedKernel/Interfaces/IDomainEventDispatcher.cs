using System.Threading.Tasks;
using NEWPROJECT_CleanArchitecture.SharedKernel;

namespace NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}