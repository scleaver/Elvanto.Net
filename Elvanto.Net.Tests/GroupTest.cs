using Elvanto.Net.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System;
using Elvanto.Net.Models;

namespace Elvanto.Net.Tests
{
    public class GroupTest : ElvantoTest
    {

        /// <summary>
        /// Should return all groups.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task<Group> Should_Return_Groups()
        {
            var groups = await this.ElvantoManager.Groups.GetAllAsync();
            Assert.NotNull(groups);
            return groups.First();
        }

        [Fact]
        public async Task Should_Return_One_Group()
        {
            var singleGroup = await this.Should_Return_Groups().ConfigureAwait(false);

            var group = await this.ElvantoManager.Groups.GetInfoAsync(singleGroup.Id).ConfigureAwait(true);
            Assert.NotNull(group);
        }
    }
}
