using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using myProjectApi.Interfases;
using myProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi.Repository
{
  
    public class AutoRepository : IAutoRepository
    {
        private readonly AutoRepository _context = null;

        public AutoRepository(IOptions<SqlConnectionSettings> settings) => _context = new AutoRepository(settings);


        public Task<bool> AddNewAuto(Auto auto)
        {

            return null;
        }

        public Task<List<Auto>> GetAllAuto()
        {
             
            return null;
        }
    }
}
