using Elvanto.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Elvanto.Net.Tests
{
    public class PersonTest : ElvantoTest
    {
        [Fact]
        public async Task<CustomField> Should_Return_CustomFields()
        {
            var fields = await this.ElvantoManager.People.GetAllCustomFieldsAsync();
            Assert.NotNull(fields);
            return fields.First();
        }

        [Fact]
        public async Task Should_Return_One_CustomField()
        {
            var expected = "Course Complete";
            var fieldId = new Guid("6ef280ca-ac9f-11e2-9d32-1cdaf3332316");

            var actual = await this.ElvantoManager.People.GetCustomFieldAsync(fieldId);
            Assert.NotNull(actual);
            Assert.Equal(expected, actual.Name);
        }
    }
}
