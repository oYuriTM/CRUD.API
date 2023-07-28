using AutoMapper;
using CRUD.Domain.Dto.Users;
using CRUD.Domain.Interface.Repositories;
using CRUD.Domain.Interface.Services;
using CRUD.Domain.Models;

namespace CRUD.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserResponseDto> Create(UserRegisterDto user)
        {
            var rs = await _userRepository.Create(_mapper.Map<Users>(user));
            return _mapper.Map<UserResponseDto>(rs);
        }

        public async Task<UserResponseDto> Delete(int id)
        {
            var rs = await _userRepository.Delete(id);
            return _mapper.Map<UserResponseDto>(rs);
        }

        public async Task<List<UserResponseDto>> GetAll()
        {
            var rs = await _userRepository.GetAll();
            return _mapper.Map<List<UserResponseDto>>(rs);
        }

        public async Task<UserResponseDto> GetById(int id)
        {
            var rs = await _userRepository.GetById(id);
            return _mapper.Map<UserResponseDto>(rs);
        }

        public async Task<UserResponseDto> Update(UserUpdateDto userIn)
        {
            var rs = await _userRepository.Update(_mapper.Map<Users>(userIn));
            return _mapper.Map<UserResponseDto>(rs);
        }
    }
}
