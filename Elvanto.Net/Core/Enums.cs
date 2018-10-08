using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Elvanto.Net.Core
{
    public class Enums
    {
        public enum SuspendedStatus
        {
            [Description("All")]
            all = 1,

            [Description("Yes")]
            yes = 2,

            [Description("No")]
            no = 3
        }

        public enum ContactStatus
        {
            [Description("All")]
            all = 1,

            [Description("Yes")]
            yes = 2,

            [Description("No")]
            no = 3
        }

        public enum ArchivedStatus
        {
            [Description("All")]
            all = 1,

            [Description("Yes")]
            yes = 2,

            [Description("No")]
            no = 3
        }
    }
}
