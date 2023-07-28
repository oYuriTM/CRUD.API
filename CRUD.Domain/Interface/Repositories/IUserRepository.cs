using CRUD.Domain.Dto.Users;
using CRUD.Domain.Models;
using System;

namespace CRUD.Domain.Interface.Repositories
{
    public interface IUserRepository
    {
        public Task<Users> Create(Users user);
        public Task<Users> GetById(int id);
        public Task<List<Users>> GetAll();
        public Task<Users> Update(Users userIn);
        public Task<Users> Delete(int id);
    }
}
