﻿using BlazorApp.Shared;

namespace BlazorApp.MinimalAPI.Services
{
    public interface IEmployee
    {
        Task<List<EmployeeDTO>> GetEmployees();

        Task<bool> AddEmployee(EmployeeDTO employee);

        Task<bool> UpdateEmployee(EmployeeDTO employee);

        Task<bool> DeleteEmployee(int id);

        Task<EmployeeDTO> GetEmployee(int id);
    }
}
