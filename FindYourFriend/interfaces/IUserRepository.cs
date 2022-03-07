using FindYourFriend.DTOs;
using FindYourFriend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourFriend.interfaces
{
  public interface IUserRepository
  {
    void Update(AppUser user);
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByUsernameAsync(string username);
    Task<bool> SaveAllAsync();
    Task<MemberDTO> GetMemberAsync(string username);
    Task<IEnumerable<MemberDTO>> GetMembersAsync();
  }
}
