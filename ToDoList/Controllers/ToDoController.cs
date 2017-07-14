using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JO.Core.Models;
using JO.Core.Services.Interfaces;
using JO.ToDoList.Models;

namespace JO.ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public ActionResult Index(string newDescription)
        {             
            var toDoViewModel = new ToDoCollectionViewModel();  

            if (!string.IsNullOrEmpty(newDescription))
            {
                toDoViewModel.Added = _toDoService.AddNewToDo(newDescription);
            }

            toDoViewModel.ToDoCollection = _toDoService.GetAll();
            
            return View(toDoViewModel);
        }

        [HttpPost]
        public ActionResult Remove(int? id)
        {
            var toDoViewModel = new ToDoCollectionViewModel();

            if (id != null)
            {
                _toDoService.RemoveToDo(id.Value);
            }

            toDoViewModel.ToDoCollection = _toDoService.GetAll();

            return View("Index", toDoViewModel);
        }

        [HttpPost]
        public ActionResult Complete(int? id, bool complete)
        {
            var toDoViewModel = new ToDoCollectionViewModel();

            if (id != null)
            {
                _toDoService.CompleteToDo(id.Value, complete);
            }

            toDoViewModel.ToDoCollection = _toDoService.GetAll();

            return View("Index", toDoViewModel);
        }
    }
}