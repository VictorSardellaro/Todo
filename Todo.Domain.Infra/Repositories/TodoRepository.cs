using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;
using Todo.Domain.Infra.Contexts;
using Todo.Domain.Respositories;

namespace Todo.Domain.Infra.Repositories
{
    public class TodoRepository : ITodoRepository
    {

        private readonly DataContext _context;

        public TodoRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(TodoItem todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(Guid id, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem todo)
        {
            _context.Entry(todo).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}