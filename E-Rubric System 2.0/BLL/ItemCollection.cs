﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public interface ItemCollection
    {
        ItemIterator createIterator();
    }
}