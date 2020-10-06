﻿using NEWPROJECT_CleanArchitecture.Core.Entities;
using NEWPROJECT_CleanArchitecture.UnitTests;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NEWPROJECT_CleanArchitecture.IntegrationTests.Data
{
    public class EfRepositoryAdd : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task AddsItemAndSetsId()
        {
            var repository = GetRepository();
            var item = new ToDoItemBuilder().Build();

            await repository.AddAsync(item);

            var newItem = (await repository.ListAsync<ToDoItem>())
                            .FirstOrDefault();

            Assert.Equal(item, newItem);
            Assert.True(newItem?.Id > 0);
        }
    }
}
