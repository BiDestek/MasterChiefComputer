﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;


namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int UserOcId { get; set; }
        public int UserId { get; set; }
        public int OcId { get; set; }
    }
}
