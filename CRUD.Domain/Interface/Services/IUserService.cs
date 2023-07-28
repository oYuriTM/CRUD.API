using CRUD.Domain.Dto.Users;
using CRUD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Interface.Services
{
    public interface IUserService
    {
        public Task<UserResponseDto> Create(UserRegisterDto user);
        public Task<UserResponseDto> GetById(int id);
        public Task<List<UserResponseDto>> GetAll();
        public Task<UserResponseDto> Update(UserUpdateDto userIn);
        public Task<UserResponseDto> Delete(int id);
    }
}
