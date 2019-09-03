using Elvanto.Net.Core;
using Elvanto.Net.Interfaces;
using Elvanto.Net.Logic;
using Microsoft.Extensions.Options;
using System;

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

        public ElvantoManager(IOptions<ElvantoOptions> optionsAccessor) : base(optionsAccessor)
        {
            this.Groups = new GroupLogic(ElvantoOptions);
            this.People = new PersonLogic(ElvantoOptions);
        }

        public IGroupLogic Groups { get; }
        public IPersonLogic People {get; }

        public long PageSize
        {
            get; private set;
        }
    }
}
