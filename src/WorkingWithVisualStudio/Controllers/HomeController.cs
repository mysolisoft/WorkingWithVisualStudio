﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio.Models;
using System.Linq;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
            => View(SimpleRepository.SharedRepository.Products
                .Where(i=>i?.Price<50));
    }
}
