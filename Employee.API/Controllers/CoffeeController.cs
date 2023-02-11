﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Employee.API.Provider.Contracts;

namespace Employee.API.Controllers
{
   
    [ApiController]
    [Route("api/coffee")]
    public class CoffeeController: ControllerBase
    {
        private readonly ICoffeeProvider coffeeProvider;

        public CoffeeController(ICoffeeProvider coffeeProvider)
        {
            this.coffeeProvider = coffeeProvider;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<DataAccessLayer.Coffee>> GetCoffee()
        {
            return coffeeProvider.GetCoffee().ToList();
        }

        [HttpGet("{coffeeId}")]
        public ActionResult<DataAccessLayer.Coffee> GetCoffee(string coffeeId)
        {
            return coffeeProvider.GetCoffee(coffeeId);
        }

        [HttpPost]
        public void AddCoffee(DataAccessLayer.Coffee coffee)
        {
            coffeeProvider.AddCoffee(coffee);
        }

        [HttpPut("{coffeeId}")]
        public void UpdateCoffee(string coffeeId, DataAccessLayer.Coffee coffee)
        {
            coffeeProvider.UpdateCoffee(coffee, coffeeId);
        }
    }
}
