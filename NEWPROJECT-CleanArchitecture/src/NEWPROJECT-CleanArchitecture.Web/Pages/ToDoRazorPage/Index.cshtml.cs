﻿using NEWPROJECT_CleanArchitecture.Core.Entities;
using NEWPROJECT_CleanArchitecture.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NEWPROJECT_CleanArchitecture.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            ToDoItems = await _repository.ListAsync<ToDoItem>();
        }
    }
}
