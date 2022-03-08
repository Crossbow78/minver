using System;
using MinVerTests.Infra;
using Xunit;

namespace MinVerTests.Packages
{
    public sealed class Net6PlusFact : FactAttribute
    {
        public Net6PlusFact(string reason) => this.Reason = reason;

        public string Reason { get; }

        public override string Skip
        {
            get =>
                Sdk.Version.StartsWith("3.", StringComparison.Ordinal) ||
                Sdk.Version.StartsWith("5.", StringComparison.Ordinal)
                    ? this.Reason
                    : base.Skip;

            set => base.Skip = value;
        }
    }
}