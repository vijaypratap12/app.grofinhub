using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBattle.Models
{
    public class VenderModel
    {
        public string id { get; set; }
        public string vendor_Name { get; set; }
        public string Mobile_No { get; set; }
        public string Password { get; set; }
        public string vendor_DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public int IsActive { get; set; }
        public string EntryBy { get; set; }
        public string EntryDate { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string ifsc { get; set; }
        public string accountNumber { get; set; }
        public string UPIId { get; set; }
        public string RefferId { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public string decentroTxnId { get; set; }
        public string status { get; set; }
        public string bankstatus { get; set; }
        public string responseCode { get; set; }
        public string bankmessage { get; set; }
        public string allowedMethods { get; set; }
        public string currency { get; set; }
        public string transactionLimit { get; set; }
        public string minimumBalance { get; set; }
        public string upiQrCode { get; set; }
        public string upiOnboardingStatus { get; set; }
        public string upiOnboardingStatusDescription { get; set; }
        public string virtualAccountBalanceSettlement { get; set; }
        public string VEntryDate { get; set; }
        
    }
}
