using System.Threading.Tasks;
using NEWPROJECT_CleanArchitecture.SharedKernel;

namespace NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}