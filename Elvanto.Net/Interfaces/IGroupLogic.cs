using Elvanto.Net.Core;
using Elvanto.Net.Core.Requests;
using Elvanto.Net.Core.Responses;
using Elvanto.Net.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elvanto.Net.Interfaces
{
    public interface IGroupLogic
    {

        Task<IEnumerable<Group>> GetAllAsync(GroupsRequest request = null);

        Task<Group> GetInfoAsync(Guid groupId);

        Task<Group> GetInfoAsync(SingleItemRequest request);

        Task<Group> AddAsync(Group group);

        Task<Group> UpdateAsync(Group group);

        Task DeleteAsync(Guid groupId);

        Task AddPersonAsync(Guid groupId, Guid personId, String position);

        Task RemovePersonAsync(Guid groupId, Guid personId);

        Task<GroupsResponse> GetResponseAsync(GroupsRequest request = null);

        Task<GroupResponse> GetSingleResponseAsync(SingleItemRequest request);

    }
}