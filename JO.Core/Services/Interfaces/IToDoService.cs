using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JO.Core.Models;

namespace JO.Core.Services.Interfaces
{
    public interface IToDoService
    {
        List<ToDo> GetAll();
        bool AddNewToDo(string newDescription);
        void CompleteToDo(int id, bool complete);
        void RemoveToDo(int id);
    }
}
