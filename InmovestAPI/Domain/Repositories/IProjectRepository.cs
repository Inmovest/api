﻿using InmovestAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmovestAPI.Domain.Repositories
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> ListAsync();
        Task AddAsync(Project project);
        Task<Project> FindByIdAsync(int id);
        Task<Project> FindByNameAsync(string name);
        Task<IEnumerable<Project>> FindByManagerId(int managerId);
        void Update(Project project);
        void Remove(Project project);
        // Agregar las relaciones del FindByEnitityId
    }
}
