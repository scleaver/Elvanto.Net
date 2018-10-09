using Elvanto.Net.Core;
using Elvanto.Net.Interfaces;
using Elvanto.Net.Logic;
using System;
using System.Collections.Generic;
using System.Text;

#if NET_CORE
using Microsoft.Extensions.Options;
#endif

namespace Elvanto.Net
{
    public class ElvantoManager : ElvantoManagerBase, IElvantoManager
    {
        public IElvantoManager Configure(Action<ElvantoOptions> options)
        {
            options(ElvantoOptions);
            return this;
        }

        public ElvantoManager(string apiKey) : base(apiKey)
        {
            this.Groups = new GroupLogic(ElvantoOptions);
            this.People = new PersonLogic(ElvantoOptions);

        }

#if NET_CORE

        public ElvantoManager(IOptions<ElvantoOptions> optionsAccessor) : base(optionsAccessor)
        {
            this.Groups = new GroupLogic(ElvantoOptions);
            this.People = new PersonLogic(ElvantoOptions);
        }

#else
        public ElvantoManager(ElvantoOptions optionsAccessor) : base(optionsAccessor)
        {
            this.Groups = new GroupLogic(ElvantoOptions);
            this.People = new PersonLogic(ElvantoOptions);
        }
#endif

        public IGroupLogic Groups { get; }
        public IPersonLogic People {get; }

        public long PageSize
        {
            get; private set;
        }
    }
}
