using Elvanto.Net.Core;
using Elvanto.Net.Core.Requests;
using Elvanto.Net.Core.Responses;
using Elvanto.Net.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elvanto.Net.Interfaces
{
    public interface IPersonLogic
    {
        Task<IEnumerable<Person>> GetAllAsync(PeopleRequest request = null);

        Task<IEnumerable<Person>> SearchAsync(SearchRequest request = null);

        Task<Person> GetInfoAsync(Guid personId);

        Task<Person> GetInfoAsync(SingleItemRequest request);

        Task<Person> AddAsync(Person person);
        Task<Person> UpdateAsync(Person person);

        Task DeleteAsync(Guid personId);

        Task<Person> CurrentUser();

        Task<IEnumerable<PeopleCategory>> GetAllCategoriesAsync();

        Task<IEnumerable<CustomField>> GetAllCustomFieldsAsync();

        Task<CustomField> GetCustomFieldAsync(Guid fieldId);

        Task<PeopleResponse> GetResponseAsync(PeopleRequest request = null);

        Task<PersonResponse> GetSingleResponseAsync(SingleItemRequest request);
    }
}
