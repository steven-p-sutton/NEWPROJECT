using NEWPROJECT_CleanArchitecture.Core.Entities;
using NEWPROJECT_CleanArchitecture.SharedKernel;

namespace NEWPROJECT_CleanArchitecture.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}