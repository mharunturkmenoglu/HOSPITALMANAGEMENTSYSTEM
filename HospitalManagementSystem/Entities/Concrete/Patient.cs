﻿using HospitalManagementSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities.Concrete
{
    public class Patient : EntityBase, IEntity
    {
        public List<Appointment>? Appointments { get; set; }
        public int InsuranceNo { get; set; }
    }
}
