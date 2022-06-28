using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual int No { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Surname { get; set; }
        public virtual string? Address { get; set; }
    }
}
