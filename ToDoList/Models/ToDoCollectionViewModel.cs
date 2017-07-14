using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JO.Core.Models;

namespace JO.ToDoList.Models
{
    public class ToDoCollectionViewModel
    {
        public bool Added { get; set; }
        public List<ToDo> ToDoCollection { get; set; }
    }
}