﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    internal interface IEmployeeService
    {
        int GetCountByAge(int age);
    }
}
