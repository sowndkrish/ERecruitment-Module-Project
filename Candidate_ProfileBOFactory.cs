using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Erecruitment_BO;
namespace ERecruitmentFactoryBO 
{
    public class Candidate_ProfileBOFactory 
    {
        public static ICandidateProfileBO createCandidateProfileBO()
        {
            ICandidateProfileBO objcandidateprofbo = new Candidate_ProfileBO();
            return objcandidateprofbo;
        }
        public static ICandidateProfileBO createCandidateProfileBO(int candidate_profile_id, int vacancy_id, string candidate_name, DateTime dob, string location, string gender, float percentage_10, float percentage_12, string gap_in_education, string gap_in_experience, string resume_file, int test_id)
        {
            ICandidateProfileBO objcandidateprofbo = new Candidate_ProfileBO(candidate_profile_id,vacancy_id,candidate_name,dob,location,gender,percentage_10,percentage_12,gap_in_education,gap_in_experience,resume_file,test_id);
            return objcandidateprofbo;
        }
    }
}
