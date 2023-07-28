using CRUD.Domain.Interface.Repositories;
using CRUD.Domain.Models;
using CRUD.Infra.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _userRepository;
        public UserRepository(DataContext userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Users> Create(Users user)
        {
            var userDb =  _userRepository.Users
                .SingleOrDefault(u => u.FirstName == user.FirstName);

            if (userDb is not null)
                throw new Exception($"UserName {user.FirstName} already exist!");

            _userRepository.Users.Add(user);
            await _userRepository.SaveChangesAsync();

            return user;
        }

        public async Task<Users> Delete(int id)
        {
            var userDb = await _userRepository.Users
                .SingleOrDefaultAsync(u => u.Id == id);

            if (userDb is null)
                throw new Exception($"User {id} not found");

            _userRepository.Users.Remove(userDb);
            await _userRepository.SaveChangesAsync();
            return userDb;
        }

        public async Task<List<Users>> GetAll()
        {
           var getAll = await _userRepository.Users.ToListAsync();
           return getAll;
        }

        public async Task<Users> GetById(int id)
        {
            var getId = await _userRepository.Users
                .SingleOrDefaultAsync(u => u.Id == id);

            if (getId is null)
                throw new Exception($"User {id} not found");

            return getId;
        }

        public async Task<Users> Update(Users userIn)
        {
            var update = await _userRepository.Users
                .SingleOrDefaultAsync(u => u.Id == userIn.Id);

            if (update is null)
                throw new Exception($"User {userIn.Id} not found");
            
            _userRepository.Entry(update).CurrentValues.SetValues(userIn);
            await _userRepository.SaveChangesAsync();
            return update;
        }
    }
}
