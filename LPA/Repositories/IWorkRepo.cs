﻿using LPA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPA.Repositories
{
    public interface IPartijRepo
    {
        List<Partij> getPartij();
    }
}