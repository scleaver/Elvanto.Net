using System;
using System.Collections.Generic;
using System.Text;

namespace Elvanto.Net.Interfaces
{
    /// <summary>
    /// The ElvantoManager interface.
    /// </summary>
    public interface IElvantoManager
    {
        long PageSize { get; }

        IGroupLogic Groups { get; }
        IPersonLogic People { get; }

        IElvantoManager Configure(Action<ElvantoOptions> options);
    }
}
