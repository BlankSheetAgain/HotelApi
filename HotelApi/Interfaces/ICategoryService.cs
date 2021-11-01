using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Interfaces
{
    public interface ICategoryService
    {
        public Task Create(Category category);
        public Task<Category> Get(Guid Id);
        public Task<List<Category>> GetAll();
        public Task Update(Category category);

        public Task Delete(Guid Id);
    }
}
