﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Rubric_System.BLL
{
    public class AnalyticRubricCreator : IRubricCreator
    {
        public Rubric getRubric()
        {
            return new AnalyticRubric();
        }
    }
}