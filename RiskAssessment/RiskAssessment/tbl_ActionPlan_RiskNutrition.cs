
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RiskAssessment
{

using System;
    using System.Collections.Generic;
    
public partial class tbl_ActionPlan_RiskNutrition
{

    public int ID { get; set; }

    public int QuestionID { get; set; }

    public string Risk { get; set; }

    public string Nutrient { get; set; }

    public int NutrientID { get; set; }

    public string SolutionDesc { get; set; }



    public virtual tbl_ActionPlan_NutrientKey tbl_ActionPlan_NutrientKey { get; set; }

    public virtual tbl_RiskAss_Questions tbl_RiskAss_Questions { get; set; }

}

}
