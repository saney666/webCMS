//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSMC14B.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_AlarmDealInfo
    {
        public int AlarmId { get; set; }
        public string AlarmWeek { get; set; }
        public Nullable<System.DateTime> AlarmTime_Begin { get; set; }
        public Nullable<System.DateTime> AlarmTime_AlarmAck { get; set; }
        public Nullable<System.DateTime> AlarmTime_SystemAck { get; set; }
        public Nullable<System.DateTime> AlarmTime_UnAckRtn { get; set; }
        public Nullable<System.DateTime> AlarmTime_Rtn { get; set; }
        public string EventType { get; set; }
        public string AlarmState { get; set; }
        public string UnAckDuration { get; set; }
        public string AlarmDuration { get; set; }
        public string TagName { get; set; }
        public string toolID { get; set; }
        public string location_id { get; set; }
        public string location { get; set; }
        public string location_side { get; set; }
        public string group_name { get; set; }
        public short type_id { get; set; }
        public string type_name { get; set; }
        public short vendor_id { get; set; }
        public string vendor_name { get; set; }
        public string ALMGroup { get; set; }
        public string AlarmMsg { get; set; }
        public string ValueString { get; set; }
        public string Value { get; set; }
        public string TriggerLimit { get; set; }
        public short AlarmLevel { get; set; }
        public string Operator { get; set; }
        public string AckOperator { get; set; }
        public string system { get; set; }
        public Nullable<bool> affect { get; set; }
        public string affTime { get; set; }
        public string dealWith { get; set; }
        public string almCause { get; set; }
        public string parts { get; set; }
        public string pmDate { get; set; }
        public string pmCycle { get; set; }
        public Nullable<bool> caseClose { get; set; }
        public string dealUser { get; set; }
    }
}