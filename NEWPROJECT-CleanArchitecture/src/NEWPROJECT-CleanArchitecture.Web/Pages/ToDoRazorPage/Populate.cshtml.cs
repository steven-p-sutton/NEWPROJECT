using NEWPROJECT_CleanArchitecture.Core;
using NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NEWPROJECT_CleanArchitecture.Web.Pages.ToDoRazorPage
{
    public class PopulateModel : PageModel
    {
        private readonly IRepository _repository;

        public PopulateModel(IRepository repository)
        {
            _repository = repository;
        }

        public int RecordsAdded { get; set; }

        public void OnGet()
        {
            RecordsAdded = DatabasePopulator.PopulateDatabase(_repository);
        }
    }
}
