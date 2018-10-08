using Elvanto.Net.Core;
using Elvanto.Net.Core.Requests;
using Elvanto.Net.Core.Responses;
using Elvanto.Net.Interfaces;
using Elvanto.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elvanto.Net.Logic
{
    internal class PersonLogic : BaseLogic, IPersonLogic
    {
        public PersonLogic(ElvantoOptions elvantoConfiguration) : base(elvantoConfiguration)
        {
        }

        public Task<Person> AddAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> CurrentUser()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid personId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAllAsync(PeopleRequest request = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PeopleCategory>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomField>> GetAllCustomFieldsAsync()
        {
            using (var client = CreateElvantoClient("people/customFields/getAll"))
            {
                var response = await client.GetAsync("").ConfigureAwait(false);
                await response.EnsureSuccessElvantoAsync().ConfigureAwait(false);

                return (await response.Content.ReadAsJsonAsync<CustomFieldsResponse>().ConfigureAwait(false))?.CustomFieldsData.CustomFields;
            }
        }

        public async Task<CustomField> GetCustomFieldAsync(Guid fieldId)
        {
            var fields = await GetAllCustomFieldsAsync().ConfigureAwait(false);

            if(fields != null)
            {
                var field = fields.Where(x => x.Id == fieldId).FirstOrDefault();

                return field;
            }
            return null;
        }

        public Task<Person> GetInfoAsync(Guid personId)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetInfoAsync(SingleItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PeopleResponse> GetResponseAsync(PeopleRequest request = null)
        {
            throw new NotImplementedException();
        }

        public Task<PersonResponse> GetSingleResponseAsync(SingleItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> SearchAsync(SearchRequest request = null)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdateAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
