using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using HotelApi.Context;
using HotelApi.Interfaces;
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly HotelContext _context;

        public CategoryService(HotelContext context)
        {
            _context = context;
        }
        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

       
        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> Get(Guid Id)
        {
            return await _context.Categories.FindAsync(Id);
        }

        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
                await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            var category = await Get(Id);
            if (category != null) _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
