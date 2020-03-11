using myProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi.Interfases
{
    interface IAutoRepository
    {
        Task<List<Auto>> GetAllAuto();
        Task<bool> AddNewAuto(Auto auto);
    }
}
