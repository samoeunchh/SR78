using Microsoft.EntityFrameworkCore;
using SR78.Data;
using SR78.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SR78.Services
{
    public class BrandRepository : IBrandRepository
    {
        private ApplicationDbContext _context;
        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> GetBrand(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Brand>> GetBrands()
        {
           return await _context.Brand.ToListAsync() ;
        }

        public async Task<bool> Save(Brand brand)
        {
            try
            {
                brand.BrandId = Guid.NewGuid();
                _context.Brand.Add(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
