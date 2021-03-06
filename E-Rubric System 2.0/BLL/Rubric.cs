///////////////////////////////////////////////////////////
//  Rubric.cs
//  Implementation of the Class Rubric
//  Generated by Enterprise Architect
//  Created on:      26-Dec-2020 12:09:28 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Rubric_System.BLL
{
	public abstract class Rubric : Item
	{
        public int rubricID { get; set; }
        public String  rubricName { get; set; }
		public String Criteria { get; set; }
		public String Poor { get; set; }
		public String Fair { get; set; }
		public String Satisfactory { get; set; }
		public String Good { get; set; }
		public String Excellent { get; set; }
		public String RubricType { get; set; }

		public Rubric() { }

		public abstract Table getRubricTable();

		public abstract void updateRubric(Table table);

		public abstract Table getMarkingRubric();
		public abstract int getMarks(Table table);

	}//end Rubric

}