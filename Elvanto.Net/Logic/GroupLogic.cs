using Elvanto.Net.Core;
using Elvanto.Net.Core.Requests;
using Elvanto.Net.Core.Responses;
using Elvanto.Net.Interfaces;
using Elvanto.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable 1584, 1711, 1572, 1581, 1580

namespace Elvanto.Net.Logic
{
    internal class GroupLogic : BaseLogic, IGroupLogic
    {
        public GroupLogic(ElvantoOptions elvantoConfiguration) : base(elvantoConfiguration)
        {
        }

        public Task<Group> AddAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid groupId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Group>> GetAllAsync(GroupsRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.GroupsData.Groups;
        }

        public async Task<Group> GetInfoAsync(Guid groupId)
        {
            var request = new SingleItemRequest
            {
                Id = groupId
            };

            return (await GetSingleResponseAsync(request).ConfigureAwait(false))?.Groups.FirstOrDefault();
        }

        public async Task<Group> GetInfoAsync(SingleItemRequest request)
        {
            return (await GetSingleResponseAsync(request).ConfigureAwait(false))?.Groups.FirstOrDefault();
        }

        public async Task<GroupResponse> GetSingleResponseAsync(SingleItemRequest request)
        {
            using (var client = CreateElvantoClient("groups/getInfo"))
            {
                var response = await client.PostAsync("", new StringContent(JsonConvert.SerializeObject(request, Formatting.None), Encoding.UTF8, "application/json")).ConfigureAwait(false);
                await response.EnsureSuccessElvantoAsync().ConfigureAwait(false);

                return await response.Content.ReadAsJsonAsync<GroupResponse>().ConfigureAwait(false);
            }
        }

        public async Task<GroupsResponse> GetResponseAsync(GroupsRequest request = null)
        {
            request = request ?? new GroupsRequest
            {
                PageSize = _pageSize
            };

            using (var client = CreateElvantoClient("groups/getAll"))
            {
                var response = await client.PostAsync("", new StringContent(JsonConvert.SerializeObject(request, Formatting.None), Encoding.UTF8, "application/json")).ConfigureAwait(false);
                await response.EnsureSuccessElvantoAsync().ConfigureAwait(false);

                return await response.Content.ReadAsJsonAsync<GroupsResponse>().ConfigureAwait(false);
            }
        }

        public Task<Group> UpdateAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task AddPersonAsync(Guid groupId, Guid personId, string position)
        {
            throw new NotImplementedException();
        }

        public Task RemovePersonAsync(Guid groupId, Guid personId)
        {
            throw new NotImplementedException();
        }
    }
}
