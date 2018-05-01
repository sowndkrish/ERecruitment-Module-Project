using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Erecruitment_BO
{
   public class Candidate_ProfileBO:ICandidateProfileBO
    {
        int candidate_profile_id;
        int vacancy_id;
        string candidate_name;
        DateTime dob;
        string location;
        string gender;
        float percentage_10;
        float percentage_12;
        string gap_in_education;
        string gap_in_experience;
        string resume_file;
        int test_id;
        int test_status;
        int written_test_status;
        int technical_interview_status;
        int hr_interview_status;
        string medical_report;
        bool medical_test_status;
        int bgc_test_id;
        bool bgc_test_status;
        string remarks;
        public int Candidate_Profile_Id 
        {
            get
            {
                return candidate_profile_id;
            }
            set
            {
                candidate_profile_id = value;
            }
        }
        public int Vacancy_Id
        {
            get
            {
                return vacancy_id;
            }
            set
            {
                vacancy_id = value;
            }
        }
        public string Candidate_Name
        {
            get
            {
                return candidate_name;
            }
            set
            {
                candidate_name = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public float Percentage_10
        {
            get
            {
                return percentage_10;
            }
            set
            {
                percentage_10 = value;
            }
        }
        public float Percentage_12
        {
            get
            {
                return percentage_12;
            }
            set
            {
                percentage_12 = value;
            }
        }
        public string Gap_In_Education
        {
            get
            {
                return gap_in_education;
            }
            set
            {
                gap_in_education = value;
            }
        }
        public string Gap_In_Experience
        {
            get
            {
                return gap_in_experience;
            }
            set
            {
                gap_in_experience = value;
            }
        }
        public string Resume_File
        {
            get
            {
                return resume_file;
            }
            set
            {
                resume_file = value;
            }
        }
        public int Test_Id
        {
            get
            {
                return test_id;
            }
            set
            {
                test_id = value;
            }
        }
        public int Test_Status
        {
            get
            {
                return test_status;
            }
            set
            {
                test_status = value;
            }
        }
        public int Written_Test_Status
        {
            get
            {
                return written_test_status;
            }
            set
            {
                written_test_status = value;
            }
        }
        public int Technical_Interview_Status
        {
            get
            {
                return technical_interview_status;
            }
            set
            {
                technical_interview_status = value;
            }
        }
        public int HR_Interview_Status
        {
            get
            {
                return hr_interview_status;
            }
            set
            {
                hr_interview_status = value;
            }
        }
        public string Medical_Report
        {
            get
            {
                return medical_report;
            }
            set
            {
                medical_report = value;
            }
        }
        public bool Medical_Test_Status
        {
            get
            {
                return medical_test_status;
            }
            set
            {
                medical_test_status = value;
            }
        }
        public int BGC_Test_Id
        {
            get
            {
                return bgc_test_id;
            }
            set
            {
                bgc_test_id = value;
            }
        }
        public bool BGC_Test_Status
        {
            get
            {
                return bgc_test_status;
            }
            set
            {
                bgc_test_status = value;
            }
        }
        public string Remarks
        {
            get
            {
                return remarks;
            }
            set
            {
                remarks = value;
            }
        }
        public Candidate_ProfileBO()
        {}
        public Candidate_ProfileBO(int candidate_profile_id,int vacancy_id,string candidate_name,DateTime dob,string location,string gender,float percentage_10,float percentage_12,string gap_in_education,string gap_in_experience,string resume_file,int test_id)
        {
            this.candidate_profile_id = candidate_profile_id;
            this.vacancy_id = vacancy_id;
            this.candidate_name = candidate_name;
            this.dob = dob;
            this.location = location;
            this.gender = gender;
            this.percentage_10 = percentage_10;
            this.percentage_12 = percentage_12;
            this.gap_in_education = gap_in_education;
            this.gap_in_experience = gap_in_experience;
            this.resume_file = resume_file;
            this.test_id = test_id;
        }

    }
}
