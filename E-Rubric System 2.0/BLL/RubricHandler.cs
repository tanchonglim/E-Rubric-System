///////////////////////////////////////////////////////////
//  RubricHandler.cs
//  Implementation of the Class RubricHandler
//  Generated by Enterprise Architect
//  Created on:      24-Dec-2020 5:34:49 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using System.Collections;
using E_Rubric_System.DLL.ERSDataSetTableAdapters;
using System.Data;

namespace E_Rubric_System.BLL
{
	public class RubricHandler {

		private RubricTableAdapter rta;

		public RubricHandler(){
			rta = new RubricTableAdapter();
		}

		~RubricHandler(){

		}


		/// 
		/// <param name="Rubric_name"></param>
		/// <param name="Criteria"></param>
		/// <param name="Poor"></param>
		/// <param name="Fair"></param>
		/// <param name="Satisfactory"></param>
		/// <param name="Good"></param>
		/// <param name="Excellent"></param>
		/// <param name="RubricID"></param>
		public void updateRubric(string Rubric_name, string Criteria, string Poor, string Fair, string Satisfactory, string Good, string Excellent, int RubricID){
			rta.updateRubric(Rubric_name, Criteria, Poor, Fair, Satisfactory, Good, Excellent, RubricID);
		}

		/// 
		/// <param name="RubricID"></param>
		public void deleteRubric(int RubricID){
			rta.deleteRubric(RubricID);
		}

		/// 
		/// <param name="RubricID"></param>
		public Rubric getRubric(int RubricID){
			var result = rta.selectRubric(RubricID);
			Rubric rubric = new Rubric();

			foreach (DataRow row in result)
			{
				var name = row["RubricName"].ToString();
				var criteria = row["Criteria"].ToString();
				var poor = row["Poor"].ToString();
				var good = row["Good"].ToString();
				var fair = row["Fair"].ToString();
				var excellent = row["Excellent"].ToString();
				var satisfactory = row["Satisfactory"].ToString();
				var rubricID = Int32.Parse(row["RubricID"].ToString());
				rubric = new Rubric(rubricID, name, criteria, poor, good, fair, excellent, satisfactory);
			}

			return rubric;
		}

		/// 
		/// <param name="Rubric_name"></param>
		/// <param name="Criteria"></param>
		/// <param name="Poor"></param>
		/// <param name="Fair"></param>
		/// <param name="Satisfactory"></param>
		/// <param name="Good"></param>
		/// <param name="Excellent"></param>
		/// <param name="RubricID"></param>
		public void createRubric(string Rubric_name, string Criteria, string Poor, string Fair, string Satisfactory, string Good, string Excellent){
			rta.createRubric(Rubric_name, Criteria, Poor, Fair, Satisfactory, Good, Excellent);
		}

		public RubricCollection getAllRubric(){
			var result = rta.selectAllRubric();

			RubricCollection rc = new RubricCollection();

			int counter = 0;
			foreach (DataRow row in result){

				var name = row["RubricName"].ToString();
				var criteria = row["Criteria"].ToString();
				var poor = row["Poor"].ToString();
				var good = row["Good"].ToString();
				var fair = row["Fair"].ToString();
				var excellent = row["Excellent"].ToString();
				var satisfactory = row["Satisfactory"].ToString();
				var rubricID = Int32.Parse(row["RubricID"].ToString());
				Rubric rubric = new Rubric(rubricID, name, criteria, poor, good, fair, excellent, satisfactory);
				rc[counter] = rubric;
				counter ++;

			}

			return rc;
		}

	}//end RubricHandler

}//end namespace Business