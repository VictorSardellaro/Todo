using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "victorgonzalez"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "victorgonzalez"));
        }

        [TestMethod]
        public void Data_a_consulta_deve_retornar_tarefas_apenas_do_usuario_victorgonzalez()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("victorgonzalez"));
            Assert.AreEqual(2, result.Count());
        }
    }
}