using Elvanto.Net.Models;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

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
            var groups = await ElvantoManager.Groups.GetAllAsync();
            Assert.NotNull(groups);
            return groups.First();
        }

        [Fact]
        public async Task Should_Return_One_Group()
        {
            var singleGroup = await Should_Return_Groups().ConfigureAwait(false);

            var group = await ElvantoManager.Groups.GetInfoAsync(singleGroup.Id).ConfigureAwait(true);
            Assert.NotNull(group);
        }
    }
}
