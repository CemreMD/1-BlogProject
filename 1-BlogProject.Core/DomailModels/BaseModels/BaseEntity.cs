﻿using _1_BlogProject.Core.DomailModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BlogProject.Core.DomailModels.BaseModels
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime ?UpdatedDate { get; set; }
        public DateTime ?DeletedDate { get; set; }
        public Status Status { get; set; }=Status.Created; 

    }
}
