using SR78.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SR78.Services
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetBrands();
        Task<Brand> GetBrand(Guid id);
        Task<bool> Save(Brand brand);
        Task<bool> Update(Brand brand);
        Task<bool> Delete(Guid id);
    }
}
