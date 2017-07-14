using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JO.Core.Models;
using JO.Core.Repositorys.Interfaces;
using JO.Core.Services.Interfaces;

namespace JO.Core.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public bool AddNewToDo(string newDescription)
        {
            if (string.IsNullOrEmpty(newDescription)) return false;
            var newToDo = new ToDo();
            newToDo.Description = newDescription;
            _toDoRepository.Insert(newToDo);

            return true;
        }

        public void CompleteToDo(int id, bool complete)
        {
            var toDo = _toDoRepository.GetById(id);
            if(toDo != null)
            {
                toDo.Complete = complete;
            }
        }

        public List<ToDo> GetAll()
        {
            return _toDoRepository.GetAll();
        }

        public void RemoveToDo(int id)
        {
            var toDo = _toDoRepository.GetById(id);
            if(toDo != null)
            {
                _toDoRepository.Delete(toDo);
            }
        }
    }
}
