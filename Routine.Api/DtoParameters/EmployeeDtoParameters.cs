﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routine.Api.DtoParameters
{
    public class EmployeeDtoParameters
    {
        private const int MaxPageSize = 20;
        public string Gender { get; set; }
        public string Q { get; set; }
        public int PageNumber { get; set; }

        private int _pageSize = 5;
        public int PageSize 
        {
            get => _pageSize;
            set => _pageSize = Math.Min(MaxPageSize, value);
        }

        public string OrderBy { get; set; } = "Name";
    }
}
