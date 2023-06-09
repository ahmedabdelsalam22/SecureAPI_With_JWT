﻿using MagicVilla_web.Models.Dtos;
using NuGet.Common;

namespace MagicVilla_web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id,string token);
        Task<T> CreateAsync<T>(VillaCreateDto dto, string token);
        Task<T> UpdateAsync<T>(VillaUpdateDto dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);

    }
}
