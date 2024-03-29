﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KS.Entities;
using KS.Interfaces.DataAccess.Repositories;
using KS.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace KS.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<CategoryIndexViewModel>> GetCategory()
        {
            return await _context.Categories.Select(x => new CategoryIndexViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug
            }).ToListAsync();
        }

    }
}