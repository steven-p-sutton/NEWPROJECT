using System.Threading.Tasks;
using NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces;
using NEWPROJECT_CleanArchitecture.SharedKernel;

namespace NEWPROJECT_CleanArchitecture.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
