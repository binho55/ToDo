using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMvc.Models;

namespace ToDoMvc.Services
{
    public class FakeToDoService : IToDoItemService
    {
        public Task<IEnumerable<IToDoItemService>> GetIncompleteItemAsync()
        {

            var Items = new[]
            {
                    new Models.ToDoItem
                    {
                        Id = Guid.NewGuid(),
                        Title = "Item 1",
                        DueAt = DateTime.Now.AddDays(1)
                    },

                    new Models.ToDoItem{
                        Id = Guid.NewGuid(),
                        Title = "Item 2",
                        DueAt = DateTime.Now.AddDays(2)
                    },

                    new Models.ToDoItem{
                        Id = Guid.NewGuid(),
                        Title = "Item 3",
                        DueAt = DateTime.Now.AddDays(3)
                    }
            };
            return Task.FromResult(Items as IEnumerable<IToDoItemService>);
        }
    }
}
    
