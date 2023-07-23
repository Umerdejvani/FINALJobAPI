using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class CandidateResultStatusModel
    {
        String response;
        public String Response
        {
            get { return response; }
            set { response = value; }
        }

        String errorDescription;
        public String ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        List<CandidateResultStatusDetail> Detail;
        public List<CandidateResultStatusDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class CandidateResultStatusDetail
        {
            public string CandidateID { get; set; }
            public string JObID { get; set; }
            public string CandidateName { get; set; }
            public string CandidateContact { get; set; }
            public string CandidateCNIC { get; set; }
            public string CandidateEmail { get; set; }
            public string ResultStatus { get; set; }
            public string JobTitle { get; set; }
            public string PositionName { get; set; }
            public string JobType { get; set; }
            public string DepartmentName { get; set; }
            public string Experience { get; set; }
            public string City { get; set; }



        }
    }
}