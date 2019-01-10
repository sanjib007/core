﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Globomantic.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace Globomantic.Controllers
{
    public class ConferenceController : Controller
    {
        private IConferenceService service;

        public ConferenceController(IConferenceService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Conference Overview";
            return View(await service.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Conference";
            return View(new ConferenceModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConferenceModel model)
        {
            if (ModelState.IsValid)
                await service.Add(model);
            return RedirectToAction("Index");
        }
    }
}