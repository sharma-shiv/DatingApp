using API.DTOs;
using API.Entities;
using AutoMapper.Execution;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string user);
        Task<IEnumerable<MemberDto>> GetMembersAsync ();
        Task<MemberDto> GetMemberAsync(string username);            
    }
}