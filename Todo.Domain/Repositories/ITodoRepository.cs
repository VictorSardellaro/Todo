using System;
using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Domain.Respositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid id, string user);

    }
}