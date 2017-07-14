using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JO.Core.Models;

namespace JO.Core.Repositorys.Interfaces
{
    public interface IToDoRepository
    {
        void Insert(ToDo task);
        void Update(ToDo task);
        void Delete(ToDo task);
        ToDo GetById(int id);
        List<ToDo> GetAll();
    }
}
