using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDSBService.Models
{
    public class EmpODData
    {
        public string odStatus { get; set; }
    }

    #region 
    public class EmpGLData
    {
        public string empNo { get; set; }
        public string locCode { get; set; }
        public string glCode { get; set; }
        public string vendorNo { get; set; }
    }

    public class EmpGLDataList : List<EmpGLData>
    {

        public EmpGLDataList() { }

        public EmpGLDataList(List<EmpGLData> EmpGLDataList) : base(EmpGLDataList) { }

    }

    public class EmpLOCData
    {

        public string locCode { get; set; }
        public string locDesc { get; set; }
    }

    public class EmpLOCDataList : List<EmpLOCData>
    {

        public EmpLOCDataList() { }

        public EmpLOCDataList(List<EmpLOCData> EmpLOCDataList) : base(EmpLOCDataList) { }

    }

    public class EmplODDetails
    {

        public string empID { get; set; }
        public string jobTitle { get; set; }
        public string odStatus { get; set; }
        public string name { get; set; }

    }

    public class EmplODList : List<EmplODDetails>
    {

        public EmplODList() { }
        public EmplODList(List<EmplODDetails> EmplODList) : base(EmplODList) { }
    }

    #endregion
}