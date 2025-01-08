using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuneHive.Domain.Common;

namespace TuneHive.Domain.Entity
{
    public class ApplicationUser : IEntity, IHasCreationTime, IHasModificationTime, IActive, ISoftDelete
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

    }
}
