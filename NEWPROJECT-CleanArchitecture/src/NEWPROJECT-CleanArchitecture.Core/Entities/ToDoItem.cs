using NEWPROJECT_CleanArchitecture.Core.Events;
using NEWPROJECT_CleanArchitecture.Core.Interfaces;
using NEWPROJECT_CleanArchitecture.SharedKernel;

namespace NEWPROJECT_CleanArchitecture.Core.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public bool IsDone { get; private set; }

        public void MarkComplete()
        {
            IsDone = true;

            Events.Add(new ToDoItemCompletedEvent(this));
        }

        public override string ToString()
        {
            string status = IsDone ? "Done!" : "Not done.";
            return $"{Id}: Status: {status} - {Title} - {Description}";
        }
    }
}
