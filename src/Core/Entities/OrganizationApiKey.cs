using System;
using Bit.Core.Utilities;

namespace Bit.Core.Entities
{
    public class OrganizationApiKey : ITableObject<Guid>
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public string ApiKey { get; set; }

        public void SetNewId()
        {
            Id = CoreHelpers.GenerateComb();
        }
    }
}
