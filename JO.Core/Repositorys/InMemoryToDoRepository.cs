using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JO.Core.Models;
using JO.Core.Repositorys.Interfaces;

namespace JO.Core.Repositorys
{
    public class InMemoryToDoRepository : IToDoRepository
    {
        private int _id = 0;
        private List<ToDo> _toDoCollection = new List<ToDo>();

        public void Delete(ToDo toDo)
        {
            _toDoCollection.Remove(toDo);
        }

        public List<ToDo> GetAll()
        {
            return _toDoCollection;
        }

        public ToDo GetById(int id)
        {
            return _toDoCollection.FirstOrDefault(m => m.Id == id);
        }

        public void Insert(ToDo toDo)
        {
            toDo.Id = _id++;
            _toDoCollection.Add(toDo);
        }

        public void Update(ToDo toDo)
        {
            var original = _toDoCollection.FirstOrDefault(m => m.Id == toDo.Id);
            if(original != null)
            {
                original.Complete = toDo.Complete;
                original.Description = toDo.Description;
            }
        }
    }
}
