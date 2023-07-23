using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.CandidateResultStatusModel;

namespace JobAPI.Controllers
{
    public class GetCandidateResultStatusController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public CandidateResultStatusModel GetCandidateResultStatus()
        {
            CandidateResultStatusModel rply = new CandidateResultStatusModel();
            try
            {
                List<CandidateResultStatusDetail> lst = new List<CandidateResultStatusDetail>();

                var query = (dx.sp_GetCandidateResultStatus()).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new CandidateResultStatusDetail
                        {
                            CandidateID = x.CandidateID.ToString(),
                            JObID = x.JObID.ToString(),
                            CandidateName = x.CandidateName,
                            CandidateContact = x.CandidateContact,
                            CandidateCNIC = x.CnadidateCNIC,
                            CandidateEmail = x.CandidateEmail,
                            ResultStatus = x.ResultStatus,
                            JobTitle = x.JobTitle,
                            PositionName = x.PositionName,
                            JobType = x.JobType,
                            DepartmentName = x.DepartmentName,
                            Experience = x.Experience.ToString(),
                            City = x.City,
                        });

                    }

                    rply.Response = "success";
                    rply.ErrorDescription = "";
                    rply.detail = lst;
                }
                else
                {
                    rply.Response = "failure";
                    rply.ErrorDescription = "No Record Found";
                }

                return rply;

            }
            catch (Exception ex)
            {
                rply.Response = "failure";
                rply.ErrorDescription = ex.Message;
                return rply;

            }

        }
    }
}
