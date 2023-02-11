﻿using Employee.API.DataAccess.Repositories.Contracts;
using Employee.DataAccessLayer.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee.DataAccessLayer.Repositories
{
    public class CoffeeRepository : ICoffeeRepository, IDisposable
    {
        private readonly EmployeeContext _context;

        public CoffeeRepository(EmployeeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Coffee> GetCoffee()
        {
            return _context.Coffees;
        }

        public Coffee GetCoffee(string coffeeId)
        {
            return _context.Coffees.SingleOrDefault(a => a.Id == coffeeId);
        }



        public void AddCoffee(Coffee coffee)
        {
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee));
            }

            _context.Coffees.Add(coffee);
            Save();
        }


        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public void UpdateCoffee(Coffee coffee, string Id)
        {
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee));
            }
            if (Id == null)
            {
                throw new ArgumentNullException(nameof(coffee));
            }
            if(Id != coffee.Id)
            {
                //return BadRequest();
            }
            //_context.Coffees.Update(coffee, Id);
            _context.Entry(coffee).State = EntryState.Modified;

            try
            {
                Save();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!coffeeExists())
                {
                    // 
                }
            }
        }

        public bool CoffeeExists(string Id)
        {
            return _context.Coffees.Any(c => c.Id == Id);
        }


    }
}