using System;
using System.Net;
using System.Collections.Generic;
using System.Web.Http;
using System.Xml;
using PDSBService.Models;
using System.Web.Script.Serialization;
using System.DirectoryServices.AccountManagement;
using System.Web.Hosting;
using System.ServiceModel.Activation;
using System.Linq;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.UserProfiles;
using System.Security;



namespace PDSBService.Controllers
{
    [RoutePrefix("api/OracleDB")]
    public class OracleDBController : ApiController
    {
        private string siteUrl = "http://peelapps.peelschools.org/wcf/CustomService.svc/";

        //GetCouresStatus       
        //[Route("courseStatus/{EmpId}/{CourseName}")]
        [Route("GetCourseStatus")]
        [HttpGet]
        public EmpODData GetCourseStatus(string EmpId, string CourseName)
        {
          if (string.IsNullOrEmpty(EmpId))
             {
              EmpId = "p0038911";
           }
            //EmpId=p0083253&CourseName=OD2016
            //empid=p0038911&coursename=ir2019
            if (string.IsNullOrEmpty(CourseName))
            {
                CourseName = "ir2019";
            }
            
            string url = String.Format(siteUrl + "Course/FilterItem?CourseName={0}&EmpId={1}", CourseName, EmpId);

            WebClient serviceRequest = new WebClient();


            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;

            EmpODData odData = new EmpODData();

            odData.odStatus = ValueToDB1;

            return odData;
        }

        // Get an employee's seniority day 1628
        //[Route("GetCupe1628JobAppliedSen/{EmpId}/{PostNumber}")]
        [Route("GetCupe1628JobAppliedSen")]
        [HttpGet]
        public string GetCupe1628JobAppliedSen(string EmpId, string PostNumber)
        {
            // string url = String.Format(siteUrl + "GetCupe1628AppJobSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "GetCupe1628JobAppliedSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);
            string url = String.Format(siteUrl + "GetCupe1628AppJobSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        //  Get an employee's seniority day 2544
        //[Route("GetCupe2544JobAppliedSen/{EmpId}/{PostNumber}")]
        [Route("GetCupe2544JobAppliedSen")]
        [HttpGet]
        public string GetCupe2544JobAppliedSen(string EmpId, string PostNumber)
        {
            // string url = String.Format(siteUrl + "GetCupe2544AppJobSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);

            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "GetCupe2544AppJobSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);
            string url = String.Format(siteUrl + "GetCupe2544AppJobSen/FilterItem?EmpId={0}&PostNumber={1}", EmpId, PostNumber);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // Get the jobs that an employee has applied for 1268
        //[Route("GetCupe1628JobApplied/{EmpId}")]
        [Route("GetCupe1628JobApplied")]
        [HttpGet]
        public string GetCupe1628JobApplied(string EmpId)
        {
            // string url = String.Format(siteUrl + "GetCupe1628JobApplied/FilterItem?EmpId={0}", EmpId);

            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "GetCupe1628JobApplied/FilterItem?EmpId={0}", EmpId);
            string url = String.Format(siteUrl + "GetCupe1628JobApplied/FilterItem?EmpId={0}", EmpId);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // Get the jobs that an employee has applied for 2544
        //[Route("GetCupe2544JobApplied/{EmpId}")]
        [Route("GetCupe2544JobApplied")]
        [HttpGet]
        public string GetCupe2544JobApplied(string EmpId)
        {
            // string url = String.Format(siteUrl + "GetCupe2544JobApplied/FilterItem?EmpId={0}", EmpId);
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "GetCupe2544JobApplied/FilterItem?EmpId={0}", EmpId);
            string url = String.Format(siteUrl + "GetCupe2544JobApplied/FilterItem?EmpId={0}", EmpId);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // Get the lunchrooms supervisors
        //[Route("GetLunchRoomSupByLocation/{LocationId}")]
        [Route("GetLunchRoomSupByLocation")]
        [HttpGet]
        public string GetLunchRoomSupByLocation(string LocationId)
        {
            //  string url = String.Format(siteUrl + "GetLunchRoomSupByLocation/FilterItem?LocationId={0}", LocationId);
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "GetLunchRoomSupByLocation/FilterItem?LocationId={0}", LocationId);
            string url = String.Format(siteUrl + "GetLunchRoomSupByLocation/FilterItem?LocationId={0}", LocationId);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // Insert a job 1628   
        [Route("InsertJobCupe1628")]
        [HttpGet]
        public string InsertJobCupe1628(string EmpId, string PostNumber, string Note)
        {
            // string url = String.Format(siteUrl + "InsertJobCupe1628/FilterItem?EmpId={0}&PostNumber={1}&Note={2}", EmpId, PostNumber, Note);
            string appliedDate = DateTime.Now.ToShortDateString();
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "PostCupe1628Job/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "InsertJobCupe1628/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);
            string url = String.Format(siteUrl + "PostCupe1628Job/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);

            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // Insert a job 2544
        [Route("InsertJobCupe2544")]
        [HttpGet]
        public string InsertJobCupe2544(string EmpId, string PostNumber, string Note)
        {
            // string url = String.Format(siteUrl + "InsertJobCupe2544/FilterItem?EmpId={0}&PostNumber={1}&Note={2}", EmpId, PostNumber, Note);
            string appliedDate = DateTime.Now.ToShortDateString();
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "PostCupe2544Job/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);
            //string url = String.Format("http://testportal.peelschools.org:6005/CustomService.svc/" + "InsertJobCupe2544/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);
            string url = String.Format(siteUrl + "PostCupe2544Job/FilterItem?EmpId={0}&PostNumber={1}&AppliedDate={2}&Note={3}", EmpId, PostNumber, appliedDate, Note);
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));

            // Parse XML value
            XmlDocument doc1 = new XmlDocument();
            doc1.InnerXml = response;
            XmlElement root1 = doc1.DocumentElement;
            string ValueToDB1 = root1.InnerText;
            return ValueToDB1;
        }
        // GetEmpLOC. No SQL this in only on SharePoint service1.svc and in not on wcf.svc.This is using the SharePoint profile services
        //[Route("GetEmpLOC/{empLOCDataList}")]
        [Route("GetEmpLOC")]
        [HttpGet]
        public EmpLOCData GetEmpLOC()
        {
            EmpLOCData empLOCData = new EmpLOCData();
            // EmpLOCDataList empLOCDataList = new EmpLOCDataList();
            //string siteUrl = "https://pdsb1.sharepoint.com/sites/PDSBhubsite";
            var userAccountName = "i:0#.f|membership|jack.liang@peelsb.com";
            string siteUrl = "https://pdsb1-admin.sharepoint.com";

            //global admin
            string tenantAdminLoginName = "jack.liang@peelsb.com";
            string tenantAdminPassword = "Pass@word2019";
            var clientContext = new ClientContext(siteUrl);
            PeopleManager peopleManager = new PeopleManager(clientContext);
            var personProperties = peopleManager.GetPropertiesFor(userAccountName);
            using (clientContext)
            {
                SecureString passWord = new SecureString();
                foreach (char c in tenantAdminPassword.ToCharArray()) passWord.AppendChar(c);

                clientContext.Credentials = new SharePointOnlineCredentials(tenantAdminLoginName, passWord);

                // Get the people manager instance for tenant context


                clientContext.Load(personProperties, p => p.AccountName, p => p.UserProfileProperties);

                clientContext.ExecuteQuery();



                //empLOCData.locDesc = UserProfileProperties["Office"].tostring();
                //  empLOCData.locCode = UserProfileProperties["Office"].tostring();


            }

            foreach (var property in personProperties.UserProfileProperties)
            {
                if (property.Key.ToString() == "Office")
                    empLOCData.locDesc = property.Value.ToString();
                if (property.Key.ToString() == "Department")
                    empLOCData.locCode = property.Value.ToString();
            }

            return empLOCData;
        }


    }
}
