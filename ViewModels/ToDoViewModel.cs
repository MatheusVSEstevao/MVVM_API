﻿using MVVM_API_SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.ViewModels
{
    public class ToDoViewModel
    {
        public ToDo ToDo { get; set; }

        public ToDoViewModel()
        {
            ToDo = new ToDo()
            {
                Id = 2,
                TaskID = 2,
                Title = "Tarefa",
                Status = true
            };

        }
    }
}
