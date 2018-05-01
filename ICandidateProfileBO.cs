using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateProfileBO
    {
        int Candidate_Profile_Id { get; set; }
        int Vacancy_Id { get; set; }
        string Candidate_Name { get; set; }
        DateTime DOB { get; set; }
        string Location { get; set; }
        string Gender { get; set; }
        float Percentage_10 { get; set; }
        float Percentage_12 { get; set; }
        string Gap_In_Education { get; set; }
        string Gap_In_Experience { get; set; }
        string Resume_File { get; set; }
        int Test_Id { get; set; }
        int Test_Status { get; set; }
        int Written_Test_Status { get; set; }
        int Technical_Interview_Status { get; set; }
        int HR_Interview_Status { get; set; }
        string Medical_Report { get; set; }
        bool Medical_Test_Status { get; set; }
        int BGC_Test_Id { get; set; }
        bool BGC_Test_Status { get; set; }
        string Remarks { get; set; }
    }
}
