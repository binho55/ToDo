﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoMvc.Models.View;
using ToDoMvc.Services;
using ToDoMvc.Models;


namespace ToDoMvc.Controllers
{
    public class ToDoController : Controller
    {

        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService service)
        {
            _toDoItemService = service;
        }
        public async Task<IActionResult> Index()
        {
            //busca items de algum lugar
            //se necessario criar uma view model
            //encaminha para view
            var vm = new ToDoViewModel
            {
                Items = await _toDoItemService.GetIncompleteItemAsync()
            };
            return View(vm);
        }
    }
}