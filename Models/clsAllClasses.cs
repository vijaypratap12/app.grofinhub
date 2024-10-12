using Microsoft.AspNetCore.Http;
using Microsoft.Build.Construction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SportsBattle.Models
{
    public class clsAllClasses
    {
        public DataTable dt1 { get; set; }
        public DataTable dt2 { get; set; }
    }
    #region Maya Maurya

    #region Get App Version Details
    public class ResAppVersion
    {
        public string AppVersion { get; set; }
        public string AppCode { get; set; }
        public string AppURL { get; set; }
    }
    #endregion


    #region User Details
    public class ReqUserDetails
    {
        public string UserId { get; set; }

    }
    public class ReqmemberDetails
    {
        public string MobileNo { get; set; }

    }
    public class ResUserDetails
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string ReferralId { get; set; }
        public string DrivingLicence { get; set; }
        public string OwnerShips { get; set; }
        public string Status { get; set; }
        public string IGN { get; set; }
        public string FCM { get; set; }
    }
    #endregion
    #region User Login
    public class ReqUserLogin
    {
        public string MobileNo { get; set; }

    }
    public class ResUserLoginDetails
    {
        public string OTP { get; set; }
        public string UserType { get; set; }
        public string UserId { get; set; }
    }
    #endregion
    #region User Registration
    public class ReqUserRegistration
    {
        public string UserId { get; set; }
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string ReferralId { get; set; }
        public string DrivingLicence { get; set; }
        public string DLImage { get; set; }
        public string OwnerShips { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public string SideImage { get; set; }

    }

    #endregion

    #region Count user
    public class ResUserCount
    {

        public string ClickCount { get; set; }
        public string UserId { get; set; }
    }
    #endregion

    #region User Virtual Account
    public class VirtualAccount
    {

        public string customer_id { get; set; }

    }
    public class Datum
    {
        public string bank { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public string accountNumber { get; set; }
        public string ifsc { get; set; }
        public List<string> allowedMethods { get; set; }
        public string currency { get; set; }
        public double transactionLimit { get; set; }
        public double minimumBalance { get; set; }
        public string upiId { get; set; }
        public string upiQrCode { get; set; }
        public string upiOnboardingStatus { get; set; }
        public string upiOnboardingStatusDescription { get; set; }
        public string virtualAccountBalanceSettlement { get; set; }
    }

    public class Root
    {
        public string decentroTxnId { get; set; }
        public string status { get; set; }
        public string responseCode { get; set; }
        public string message { get; set; }
        public List<Datum> data { get; set; }
    }
    #endregion
    #region   Challenge List 
    public class ReqChallenge
    {
        public string UserId { get; set; }
    }
    public class ResChallenge
    {
        public string ChallengeId { get; set; }
        public string ChallengeStatus { get; set; }
        public string RivalName { get; set; }
        public string RivalId { get; set; }
        public string EntryFee { get; set; }
        public string PrizePool { get; set; }
        public string RoomCode { get; set; }
        public string ChallengeCreationTime { get; set; }
        public string GameType { get; set; }
        public string OpponentId { get; set; }
        public string OpponentName { get; set; }
        public string IGN { get; set; }
    }

    #endregion

    #region Create Challenge
    public class ReqCreateChallenge
    {
        public string UserId { get; set; }
        public string EntryFee { get; set; }
        public string GameType { get; set; }
        public string NoOfPlayers { get; set; }

    }

    #endregion

    #region  Player List
    public class ReqPlayerList
    {
        public string ChallengeId { get; set; }
    }
    public class ResPlayerList
    {
        public string PlayerId { get; set; }
        public string Player { get; set; }
    }
    #endregion

    #region   Update Challenge Status
    public class ReqUpdateChallengeStatus
    {
        public string Type { get; set; }
        public string UserId { get; set; }
        public string ChallengeId { get; set; }

    }

    #endregion
    #region  Challenge Details
    public class ReqChallengeDetails
    {
        public string ChallengeId { get; set; }
    }

    public class ResChallengeDetails
    {
        public string OpponentId { get; set; }
        public string OpponentName { get; set; }
        public string OpponentResultStatus { get; set; }
        public string ChallengeId { get; set; }
        public string ChallengeStatus { get; set; }
        public string RivalNameResultStatus { get; set; }
        public string RivalName { get; set; }
        public string RivalId { get; set; }
        public string EntryFee { get; set; }
        public string PrizePool { get; set; }
        public string RoomCode { get; set; }
        public string ChallengeCreationTime { get; set; }
        public string GameType { get; set; }
        public string IGN { get; set; }
    }
    #endregion



    #region Update Room Id
    public class ReqUpdateRoomId
    {
        public string ChallengeId { get; set; }
        public string RoomId { get; set; }
    }
    #endregion


    #region Update Challenge Result
    public class ReqUpdateChallengeResult
    {
        public string Status { get; set; }
        public string ChallengeId { get; set; }
        public string WinnerId { get; set; }
        public string UserId { get; set; }
        public string Image { get; set; }
    }
    #endregion
    public class ReqDeleteChallenge
    {
        public string ChallengeId { get; set; }
        public string UserId { get; set; }
    }
    #endregion


    #region WalletAmount
    public class ReqWalletAmount
    {
        public string UserId { get; set; }
    }
    public class ResWalletAmount
    {
        public string Amount { get; set; }
        public string TotalBonusAmount { get; set; }
        public string TotalWinningAmount { get; set; }
        public string TotalPlayed { get; set; }
        public string TotalWin { get; set; }
        public string TotalLoss { get; set; }
    }
    public class ReqDepositeAmount
    {
        public string UserId { get; set; }
        public string Amount { get; set; }
        public string Type { get; set; }
    }

    public class ReqCancelRequest
    {
        public string UserId { get; set; }
        public string Id { get; set; }

    }
    #endregion
    #region Get banner
    public class ResBanner
    {
        public string ImageURL { get; set; }

    }
    #endregion
    #region Get banner
    public class ResTop5User
    {
        public string Data { get; set; }

    }

    #endregion

    #region challengeCount
    public class ReschallengeCount
    {
        public string TotalCount { get; set; }
        public string TotalMyChallengeCount { get; set; }

    }

    #endregion 
    #region SaveFCM
    public class ResSaveFCM
    {
        public string UserId { get; set; }
        public string FCM { get; set; }

    }

    #endregion

    #region Send Notification
    public class ReqSendNotification
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
    #region  Transaction History
    public class ReqTransactionHistory
    {
        public string UserId { get; set; }
        public string Type { get; set; }
    }
    public class ResTransactionHistory
    {
        public string Amount { get; set; }
        public string Date { get; set; }
        public string transactionId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string BeforeAmount { get; set; }
        public string AfterAmount { get; set; }
    }
    public class ResWisthdrawTransactionHistory
    {
        public string Amount { get; set; }
        public string Date { get; set; }
        public string transactionId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string ProofId { get; set; }
        public string ApproveDate { get; set; }
        public string TransferId { get; set; }
        public string TransferRemark { get; set; }
    }
    #endregion

    public class ReqGetGameHistory
    {
        public string UserId { get; set; }
    }

    public class ResNotificationHistory
    {

        public string NotificationTitle { get; set; }
        public string NotificationDescription { get; set; }
        public string Date { get; set; }
        public string Img { get; set; }

    }
    public class ReqSendChat
    {
        public string userID { get; set; }
        public string challengeId { get; set; }
        public string opponentId { get; set; }
        public string msg { get; set; }
    }
    public class ReqChatList
    {
        public string challengeId { get; set; }
        public string userId { get; set; }

    }
    public class ResChatList
    {
        public string userRole { get; set; }
        public string message { get; set; }
        public string time { get; set; }

    }
    public class ResRefferalHistory
    {
        public string FromUserId { get; set; }
        public string FromUserName { get; set; }
        public string RefferalCommissionAmount { get; set; }
        public string Date { get; set; }

    }

    public class ResRankingHistory
    {
        public string Name { get; set; }
        public string Coin { get; set; }


    }
    #endregion

    #region Get App Version Details
    public class AdminDetails
    {
        public string WhatsappNo { get; set; }
        public string WhatsappLink { get; set; }
        public string YouTubeLink { get; set; }
        public string FacebookLink { get; set; }
        public string TelegramLink { get; set; }
        public string InstagramLink { get; set; }
    }
    #endregion
    #region GetPoppu
    public class GetPoppu
    {
        public string IsPopup { get; set; }
        public string ImageURL { get; set; }
    }
    #endregion

    #region IsAppUnderMaintance
    public class GetAppUnderMaintance
    {
        public string IsAppUnderMaintance { get; set; }
    }
    #endregion

    public class CommonMasterCls
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<CommonMasterCls> DataList { get; set; }
    }
     
    public class RegistrationCls
    {
        public string Action { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Block { get; set; }
        public string AadharCard { get; set; }
        public string PanCard { get; set; }
        public string Qualification { get; set; }
        public string AssociateCompany { get; set; }
        public string AssociateCompanyAgent { get; set; }
        public string EntryDate { get; set; }
        public string Status { get; set; }
        public string Agentid { get; set; }
        public string Password { get; set; }
        public string StateId { get; set; }
        public string DistrictId { get; set; }
        public string BlockId { get; set; }
        public string Dob { get; set; }
        public string Qualification1 { get; set; }
        public string AssociateMutual { get; set; }
        public string EntryBy { get; set; }

        public string BankId { get; set; }

        public string AccountNo { get; set; }
        public string IFSCCode { get; set; }
        public string AccountHolderName { get; set; }
        public string AadharNo { get; set; }
        public string PANNo { get; set; }

    }

    public class Responsemsgcls
    {
        public string strId { get; set; }
        public string msg { get; set; }
        public string OTP { get; set; }
        public string RefeID { get; set; }
        public string stateresp { get; set; }
        public DataTable dt { get; set; }

    }

    public class Data
    {
        public string client_id { get; set; }
        public string age_range { get; set; }
        public string aadhaar_number { get; set; }
        public string state { get; set; }
        public string gender { get; set; }
        public string last_digits { get; set; }
        public bool is_mobile { get; set; }
        public bool less_info { get; set; }
    }

    public class Rootaadhar
    {
        public bool status { get; set; }
        public string response_code { get; set; }
        public Data data { get; set; }
        public string msg { get; set; }

    }

    public class DataPAN
    {
        public string pan_number { get; set; }
        public object gender { get; set; }
        public string pan_returned_name { get; set; }
        public object title { get; set; }
        public string first_name { get; set; }
        public object middle_name { get; set; }
        public string last_name { get; set; }
    }

    public class RootPAN
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public int ackno { get; set; }
        public string refid { get; set; }
        public DataPAN data { get; set; }
    }
     
    public class DataAccount
    {
        public string client_id { get; set; }
        public bool account_exists { get; set; }
        public object upi_id { get; set; }
        public string full_name { get; set; }
        public object remarks { get; set; }
    }

    public class RootAccount
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public DataAccount data { get; set; }
    }
     
    public class Accountrequest
    {
        public string refid { get; set; }
        public string account_number { get; set; }
        public string ifsc { get; set; }
        public bool ifsc_details { get; set; }
    }
     
    public class AadharAPIcls
    {
        public string refid { get; set; }
        public string aadhar_number { get; set; }
    }

    public class PANNoAPICls
    {
        public string pannumber { get; set; }
        public string referenceid { get; set; }

    }
     
    public class RegisterRemitercls
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ammount { get; set; }
        public string dob { get; set; }
        public string Verified { get; set; }
        public string mobile { get; set; }
        public string Address { get; set; }
        public string OTP { get; set; }
        public string Pincode { get; set; }
        public string Action { get; set; }
        public string Stateresp { get; set; }

        public string Bank3_flag { get; set; }
        public string gst_state { get; set; }



    }

    public class RegisterRemiterApicls
    {
        public string mobile { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }
        public string address { get; set; }
        public string otp { get; set; }
        public string pincode { get; set; }
        public string stateresp { get; set; }
        public string bank3_flag { get; set; }
        public string dob { get; set; }

        public string gst_state { get; set; }
    }
     
    public class QueryParametercls
    {
        public string mobile { get; set; }
        public string bank3_flag { get; set; }
    }
     
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DataQueryremiter
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string mobile { get; set; }
        public string status { get; set; }
        public int bank3_limit { get; set; }
        public string bank3_status { get; set; }
        public int bank2_limit { get; set; }
        public int bank1_limit { get; set; }
    }

    //public class RootQueryremiter
    //{
    //    public bool status { get; set; }
    //    public int response_code { get; set; }
    //    public string message { get; set; }
    //    public DataQueryremiter data { get; set; }
    //}
     
    public class RootNewAddQueryremiter
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string stateresp { get; set; }
        public string message { get; set; }
    }
     
    #region Atul Singh 2023/03/01
    public class UserProfileModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Block { get; set; }
        public string Blockid { get; set; }
        //public string Adhar { get; set; }
        public string DistrictId { get; set; }
        public string StateId { get; set; }
        public string Dob { get; set; }
        public string Qualification { get; set; }
        public string AgentId { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
    }
    public class GetReferenceModel
    {
        public string UserId { get; set; }
        public string type { get; set; }
        public string amount { get; set; }

    }


    #endregion

    #region Atul Singh 2023/03/02

    public class BeneficiaryDetailsMdl
    {
        public string bene_id { get; set; }
        public string bankid { get; set; }
        public string bankname { get; set; }
        public string name { get; set; }
        public string accno { get; set; }
        public string ifsc { get; set; }
        public string verified { get; set; }
        public string banktype { get; set; }
        public string paytm { get; set; }
    }
    public class BeneficiaryParaMld
    {
        public string mobile { get; set; }

    }
    public class RootBeneficiaryDetailsMdl
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public List<object> data { get; set; }
        public string message { get; set; }
    }
    public class Responsemsgclsbenefi
    {
        public string strId { get; set; }
        public string msg { get; set; }
        public string stateresp { get; set; }
        public List<BeneficiaryDetailsMdl> dt { get; set; }
    }

    public class RootBeneficiaryMdlById
    {
        public string mobile { get; set; }
        public string beneid { get; set; }
    }
    public class BeneficiaryDelete
    {
        public string mobile { get; set; }
        public string bene_id { get; set; }
    }
    public class BeneficiaryDeleteret
    {
        public string strId { get; set; }
        public string msg { get; set; }
    }

    public class RootBeneficiaryRegister
    {
        public string mobile { get; set; }
        public string benename { get; set; }
        public string bankid { get; set; }
        public string accno { get; set; }
        public string ifsccode { get; set; }
        public string verified { get; set; }
        public string gst_state { get; set; }
        public string dob { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
    }

    #endregion

    #region Atul Singh 2023/03/04

    public class GetBeneficiaryDetails
    {
        public string Bene_code { get; set; }
        public string mobile { get; set; }
        public string benename { get; set; }
        public string bankid { get; set; }
        public string accno { get; set; }
        public string ifsccode { get; set; }
        public string verified { get; set; }
        public string gst_state { get; set; }
        public string dob { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
        public string RegDate { get; set; }

    }
    public class RemiterDetails
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string Ammount { get; set; }
        public string dob { get; set; }
        //   public string Verified { get; set; }
        // public string mobile { get; set; }
        public string Address { get; set; }
        public string OTP { get; set; }
        public string Pincode { get; set; }
        public string Stateresp { get; set; }

        public string Bank3_flag { get; set; }
        public string gst_state { get; set; }
        public string RegDate { get; set; }
        public string RemitterCode { get; set; }
    }

    #endregion

    #region 02/02/2023 
    public class GetOtpModel
    {
        public string OTP { get; set; }
    }
    public class BankDetailsModel
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
    }
    #endregion

    #region 02/03/2023
    public class Transactioncls
    {
        public string Mobile { get; set; }
        public string Pipe { get; set; }
        public string accno { get; set; }
        public int Bankid { get; set; }
        public string Benename { get; set; }
        public string Referenceid { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string Gst_state { get; set; }
        public int Bene_id { get; set; }
        public string TxnType { get; set; }
        public string Amount { get; set; }

        public string UserId { get; set; }
        public string Ackno { get; set; }
        public string OTP { get; set; }

    }
    public class TransactionApicls
    {
        public string mobile { get; set; }
        public string referenceid { get; set; }
        public string pipe { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
        public string txntype { get; set; }
        public string amount { get; set; }
    }

    public class Transactionstatus
    {
        public string referenceid { get; set; }
    }


    public class RefundOpt
    {
        public string referenceid { get; set; }
        public string ackno { get; set; }
        public string otp { get; set; }


    }

    public class Claim_refund
    {
        public string referenceid { get; set; }
        public string ackno { get; set; }
        public string otp { get; set; }


    }

    public class GenrateURLApi
    {
        public string merchantcid { get; set; }
        public string refid { get; set; }
        public string redirect_url { get; set; }
    }
    public class RootGenrateURL
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public GenrateURLdata data { get; set; }


    }

    public class GenrateURLdata
    {
        public string url { get; set; }
        public string encdata { get; set; }
    }


    //public class RootTransaction
    //{
    //    public bool status { get; set; }
    //    public int response_code { get; set; }
    //    public string message { get; set; }


    //    #region data
    //    public object utr { get; set; }
    //    public string amount { get; set; }
    //    public string ackno { get; set; }
    //    public string referenceid { get; set; }
    //    public string account { get; set; }
    //    public string txn_status { get; set; }
    //    // public object message { get; set; }
    //    public string customercharge { get; set; }
    //    public string gst { get; set; }
    //    public string discount { get; set; }
    //    public string tds { get; set; }
    //    public string netcommission { get; set; }
    //    public string daterefunded { get; set; }
    //    public string refundtxnid { get; set; }

    //    #endregion

    //    public TransactionstatusData data { get; set; }

    //}
    public class RootTransaction
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string ackno { get; set; }
        public string utr { get; set; }
        public int txn_status { get; set; }
        public string benename { get; set; }
        public string remarks { get; set; }
        public string message { get; set; }
        public string customercharge { get; set; }
        public string gst { get; set; }
        public string tds { get; set; }
        public string netcommission { get; set; }
        public string remitter { get; set; }
        public string account_number { get; set; }
        public string paysprint_share { get; set; }
        public string txn_amount { get; set; }
        public double balance { get; set; }
    }

    public class TransactionstatusData
    {

        public bool status { get; set; }
        public int response_code { get; set; }
        public object utr { get; set; }
        public string amount { get; set; }
        public string ackno { get; set; }
        public string referenceid { get; set; }
        public string account { get; set; }
        public string txn_status { get; set; }
        public object message { get; set; }
        public string customercharge { get; set; }
        public string gst { get; set; }
        public string discount { get; set; }
        public string tds { get; set; }
        public string netcommission { get; set; }
        public string daterefunded { get; set; }
        public string refundtxnid { get; set; }





    }



    #endregion
     
    public class TrnsRequst
    {

        public string MobileNo { get; set; }
        public string txttype { get; set; }
    }
     
    public class TrnsacResponse
    {
        public string ReferenceId { get; set; }
        public string MobileNo { get; set; }
        public string Pipe { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string Gst_State { get; set; }
        public string bene_id { get; set; }
        public string Txntype { get; set; }
        public string Amount { get; set; }
        public string bankid { get; set; }
        public string ackno { get; set; }
        public string txn_status { get; set; }
        public string benename { get; set; }
        public string customercharge { get; set; }
        public string gst { get; set; }
        public string tds { get; set; }
        public string account_number { get; set; }
        public string balance { get; set; }
        public string paysprint_share { get; set; }
        public string utr { get; set; }
    }

    #region Atul Singh 2023/03/06
    public class OperatorWatelBill
    {
        public string mode { get; set; }
    }
    public class OperatorListWaterBill
    {
        public string id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string viewbill { get; set; }
        public string regex { get; set; }
        public string displayname { get; set; }
        public object ad1_d_name { get; set; }
        public object ad1_name { get; set; }
        public object ad1_regex { get; set; }
    }
    public class OpeListWBillRes
    {
        public DataTable data { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public string response_code { get; set; }
    }
    public class ListOfOpeListWBillRes
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<OperatorListWaterBill> data { get; set; }
    }

    public class WaterDatailsInpt
    {
        public string canumber { get; set; }
        public string @operator { get; set; }
    }
    public class GetWaterDatails
    {
        public string response_code { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        public string name { get; set; }
        public string message { get; set; }
    }
    public class WaterBillPayInpt
    {
        public string canumber { get; set; }
        public string @operator { get; set; }
        public string amount { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
    public class WaterBillPayRes
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
    }
    public class WaterBillStatusInpt
    {
        public string referenceid { get; set; }
    }

    public class DataWaterBillDetails
    {
        public string txnid { get; set; }
        public string operatorname { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string comm { get; set; }
        public string tds { get; set; }
        public string status { get; set; }
        public string refid { get; set; }
        public string operatorid { get; set; }
        public string dateadded { get; set; }
        public string refunded { get; set; }
        public string refundtxnid { get; set; }
        public string daterefunded { get; set; }
    }

    public class WaterBillDetails
    {
        public string response_code { get; set; }
        public string status { get; set; }
        public DataWaterBillDetails data { get; set; }
        public string message { get; set; }
    }
    #endregion
     
    #region MATM 2023/03/13

    public class MATMPara
    {
        public string status { get; set; }
        public string reference { get; set; }
    }
    public class RootMATM
    {
        public string status { get; set; }
        public string message { get; set; }
        public string response_code { get; set; }
    }

    #endregion
     
    #region AEPS 2023/03/13

    public class AEPSEnquaryRes
    {
        public string status { get; set; }
        public string message { get; set; }
        public string ackno { get; set; }
        public string amount { get; set; }
        public string balanceamount { get; set; }
        public string bankrrn { get; set; }
        public string bankiin { get; set; }
        public string response_code { get; set; }
        public string errorcode { get; set; }
        public string clientrefno { get; set; }
    }

    public class RootAEPSinpt
    {
        public string body { get; set; }
    }
    public class AEPSEnqueriModel
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mobilenumber { get; set; }
        public string referenceno { get; set; }
        public string ipaddress { get; set; }
        public string adhaarnumber { get; set; }
        public string accessmodetype { get; set; }
        public int nationalbankidentification { get; set; }
        public string requestremarks { get; set; }
        public string data { get; set; }
        public string pipe { get; set; }
        public string timestamp { get; set; }
        public string transactiontype { get; set; }
        public string submerchantid { get; set; }
        public string is_iris { get; set; }

        //public DataWaterBillDetails data { get; set; }
        //public string message { get; set; }
    }

    public class AEPS2FARagistrationModel
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mobilenumber { get; set; }
        public string referenceno { get; set; }
        public string ipaddress { get; set; }
        public string adhaarnumber { get; set; }
        public string accessmodetype { get; set; }
        public string data { get; set; }
        public string timestamp { get; set; }
        public string submerchantid { get; set; }
    }
    public class AEPS2FARagistrationResponse
    {
        public int response_code { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
        public string errorcode { get; set; }
    }
    public class PDFData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string AcknowledgementNo { get; set; }
        public string Amount { get; set; }
        public string BalanceAmount { get; set; }
        public string BankRRN { get; set; }
        public string BankIIN { get; set; }
        public string ResponseCode { get; set; }
        public string ErrorCode { get; set; }
        public string ClientRefNo { get; set; }
        public string DateTime { get; set; }
        public string MiniBalanceAmount { get; set; }
        public string MiniErrorCode { get; set; }
    }


    public class MATMWithdrawStatusPara
    {
        public string reference { get; set; }
    }

    public class RootMATMWithdrawStatus
    {
        public string status { get; set; }
        public string txnstatus { get; set; }
        public string message { get; set; }
        public string ackno { get; set; }
        public string amount { get; set; }
        public string bankrrn { get; set; }
        public string cardnumber { get; set; }
        public string bankName { get; set; }
        public string response_code { get; set; }
        public string response { get; set; }
        public string txnrefrenceNo { get; set; }
        public string transactiontype { get; set; }
    }

    public class AEPSWithdrowRes
    {
        public string status { get; set; }
        public string txnstatus { get; set; }
        public string message { get; set; }
        public string ackno { get; set; }
        public string amount { get; set; }
        public string bankrrn { get; set; }
        public string response_code { get; set; }
    }

    public class Banklist
    {
        public string status { get; set; }
        public string message { get; set; }
        public DataTable data { get; set; }
    }
    public class BanklistData
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<DatumAEPSBankModel> data { get; set; }
    }

    public class DatumAEPSBankModel
    {
        public string id { get; set; }
        public string bankName { get; set; }
        public string iinno { get; set; }
        public string activeFlag { get; set; }
    }

    public class RootAEPSBankListRes
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public Banklist banklist { get; set; }
        public string message { get; set; }
    }
    public class RootAEPSBankListResList
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public BanklistData banklist { get; set; }
        public string message { get; set; }
    }

    public class DTHOperatorList
    {
        public string id { get; set; }
        public string name { get; set; }

    }
    #endregion
     
    #region HLR 2023/03/14
    public class RootHLR
    {
        public bool status { get; set; }
        public string message { get; set; }
        public DataTable response { get; set; }
    }

    public class RootHLRPara
    {
        public string canumber { get; set; }
        public string op { get; set; }
    }
    //public class Info
    //{
    //    public string Balance { get; set; }
    //    public string customerName { get; set; }
    //    public string NextRechargeDate { get; set; }
    //    public string status { get; set; }
    //    public string planname { get; set; }
    //    public string MonthlyRecharge { get; set; }
    //}

    //public class RootHLRDTHInfo
    //{
    //    public string status { get; set; }
    //    public string response_code { get; set; }
    //    public DataTable info { get; set; }
    //    public string message { get; set; }
    //}
    //public class RootHLRDTHInfoList
    //{
    //    public string status { get; set; }
    //    public string response_code { get; set; }
    //    public List<Info> info { get; set; }
    //    public string message { get; set; }
    //}

    public class Rootdthinfobodyapi
    {
        public string canumber { get; set; }
        public string op { get; set; }
    }
    public class Rootdthapires
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public List<DThapibody> info { get; set; }
        public string message { get; set; }
    }
    public class DThapibody
    {
        public double Balance { get; set; }
        public string customerName { get; set; }
        public string NextRechargeDate { get; set; }
        public string status { get; set; }
        public string planname { get; set; }
        public int MonthlyRecharge { get; set; }
    }
    public class RootDTHBrowsPlanPara
    {
        public string circle { get; set; }
        public string op { get; set; }
    }
    #region HLR 2023/03/15

    public class RootHLRdt
    {
        public int responsecode { get; set; }
        public bool status { get; set; }
        public DataTable data { get; set; }
        public string message { get; set; }
    }
    public class RootDoRecharge
    {
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string UserId { get; set; }
    }


    //    public class RootBrowesPlanData
    //    {
    //        public string status { get; set; }
    //        public string response_code { get; set; }
    //        public RootBrowesPlanDataddt info { get; set; }

    //        public string message { get; set; }
    //    }
    //    public class RootBrowesPlanDataddt
    //    {
    //    [Column("3G4G")]
    //    public DataTable _3G4G { get; set; }
    //    public DataTable COMBO { get; set; }
    //    public DataTable Romaing { get; set; }
    //    public DataTable TOPUP { get; set; }
    //}

    //    public class RootBrowesPlanData
    //    {
    //        public string status { get; set; }
    //        public string response_code { get; set; }
    //        public RootBrowesPlanDataddt info { get; set; }

    //        public string message { get; set; }
    //    }
    //    public class RootBrowesPlanDataddt
    //    {
    //    [Column("3G4G")]
    //    public DataTable _3G4G { get; set; }
    //    public DataTable COMBO { get; set; }
    //    public DataTable Romaing { get; set; }
    //    public DataTable TOPUP { get; set; }
    //}

    public class RootResMobRecharg
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
    }

    #endregion

    #endregion

    public class TranRe
    {
        public string strId { get; set; }
        public string msg { get; set; }
        public string stateresp { get; set; }

        public List<TransactionstatusData> dtlist { get; set; }
    }
     
    public class GetReqTranDetails
    {
        public string UserID { get; set; }
        public string Type { get; set; }
        public string FormDate { get; set; }
        public string ToDate { get; set; }


    }

    //public class ResponseTransDetails
    //{
    //    public string mobile { get; set; }
    //    public string referenceid { get; set; }
    //    public string pipe { get; set; }
    //    public string pincode { get; set; }
    //    public string address { get; set; }
    //    public string dob { get; set; }
    //    public string gst_state { get; set; }
    //    public string bene_id { get; set; }
    //    public string txntype { get; set; }
    //    public string amount { get; set; }
    //    public string type { get; set; }
    //    public bool status { get; set; }
    //    public int response_code { get; set; }
    //    public string ackno { get; set; }
    //    public string utr { get; set; }
    //    public string txn_status { get; set; }
    //    public string benename { get; set; }
    //    public string remarks { get; set; }
    //    public string message { get; set; }
    //    public string customercharge { get; set; }
    //    public string gst { get; set; }
    //    public string tds { get; set; }
    //    public string netcommission { get; set; }
    //    public string remitter { get; set; }
    //    public string account_number { get; set; }
    //    public string paysprint_share { get; set; }

    //    public string balance { get; set; }
    //}

    #region 20/03/2023 shani
    public class TransactionRequestApi
    {
        public string mobile { get; set; }
        public string UserID { get; set; }
        public string referenceid { get; set; }
        public string pipe { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
        public string txntype { get; set; }
        public string amount { get; set; }
        public string Message { get; set; }
    }

    public class TransactionResponseApi
    {
        public string bene_id { get; set; }
        public string txntype { get; set; }
        public string amount { get; set; }
    }

    #endregion

    #region shani 21/03/2023
    public class EPFOAPIMODEL
    {
        public string epfo_number { get; set; }
        public string refid { get; set; }
        // public string OTP { get; set; }
    }
    public class EPFOAPIMODELkyc
    {

        public string client_id { get; set; }
        public string otp { get; set; }
    }
    public class EPFOAPIMODELGetkycDetails
    {

        public string client_id { get; set; }
    }


    public class epfoapicls
    {
        public string epfo_number { get; set; }
        public string refid { get; set; }
        public string otp { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Dataepfo
    {
        public string client_id { get; set; }
        public bool otp_sent { get; set; }
        public string masked_mobile_number { get; set; }
        public bool is_async { get; set; }
    }

    public class Rootepfo
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public Dataepfo data { get; set; }
        public string message { get; set; }



    }
    public class DataRootEPFOSendOTP
    {
        public string client_id { get; set; }
        public string otp_sent { get; set; }
        public string masked_mobile_number { get; set; }
        public string is_async { get; set; }
    }

    public class RootEPFOSendOTP
    {
        public string statuscode { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public DataRootEPFOSendOTP data { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);




    public class KycDetails
    {
        public string pan_number { get; set; }
        public string aadhaar_number { get; set; }
        public string mobile_number { get; set; }
        public string email { get; set; }
        public string full_name { get; set; }
        public string relation_name { get; set; }
        public string relation_type { get; set; }
        public string dob { get; set; }
        public string doj_epf { get; set; }
        public string doj_eps { get; set; }
        public string account_number { get; set; }
        public string ifsc { get; set; }
        public string details { get; set; }
        public string client_id { get; set; }
        public string pf_uan { get; set; }


    }

    public class RootKycDetails
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public KycDetails data { get; set; }
    }


    public class BBPSReqModel
    {
        public string Mode { get; set; }

    }

    public class operatorListbyBBPS
    {
        public string mode { get; set; }
        public string refid { get; set; }
        public string otp { get; set; }
    }

    public class rootBBPS
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public DataTable data { get; set; }




    }


    //     clsAllClass

    #region transactions 2023/03/21

    public class TransactionclsForAPI
    {
        public string Mobile { get; set; }
        public string User_ID { get; set; }
        public string Pipe { get; set; }
        //public string accno { get; set; }
        public int Bankid { get; set; }
        //public string Benename { get; set; }
        public string Referenceid { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string Gst_state { get; set; }
        public int Bene_id { get; set; }
        public string TxnType { get; set; }
        public double Amount { get; set; }

        //public string UserId { get; set; }
        //public bool status { get; set; }
        // public int response_code { get; set; }
        public string ackno { get; set; }
        public string utr { get; set; }
        public int txn_status { get; set; }
        public string benename { get; set; }
        //public string remarks { get; set; }
        public string message { get; set; }
        public double customercharge { get; set; }
        public double gst { get; set; }
        public double tds { get; set; }
        // public string netcommission { get; set; }
        //public string remitter { get; set; }
        public string account_number { get; set; }
        public double paysprint_share { get; set; }
        // public string txn_amount { get; set; }
        public double balance { get; set; }

    }

    public class RootDoRechargeForAPI
    {
        //public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        //public string UserId { get; set; }
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
    }

    // for pan

    public class PanBody
    {
        public string refid { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string mode { get; set; }
        public string gender { get; set; }
        public string redirect_url { get; set; }
        public string email { get; set; }
        public string merchant_code { get; set; }


    }
    public class DataPan
    {
        public string url { get; set; }
        public string encdata { get; set; }
    }

    public class RootResPan
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public DataPan data { get; set; }
        public string message { get; set; }
    }
    public class BillFetchLic
    {
        public string billNumber { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string dueFrom { get; set; }
        public string dueTo { get; set; }
        public string validationId { get; set; }
        public string billId { get; set; }
    }

    public class RootBodyLic
    {
        public int id { get; set; }
        public string Operator { get; set; }
        public string category { get; set; }
        public string canumber { get; set; }
        public string mode { get; set; }
        public string amount { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public BillFetchLic bill_fetch { get; set; }
    }
    public class RootLicBillPayRes
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
    }
    #endregion





    #endregion



    #region 22/03/2023 shani FetchBilDetails

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BillFetch
    {
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string dueDate { get; set; }
        public bool acceptPayment { get; set; }
        public bool acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
    }

    public class RootresponseBilldetails
    {
        public int response_code { get; set; }
        public bool status { get; set; }
        public string amount { get; set; }
        public string name { get; set; }
        public string duedate { get; set; }
        public string message { get; set; }
    }

    public class fillfecthRequest
    {

        public string mode { get; set; }
        public string canumber { get; set; }
        public string @operator { get; set; }


    }

    public class FillFecthModel
    {
        public string Mode { get; set; }
        public string BillNo { get; set; }
        public string OP { get; set; }

    }



    #endregion

    //--------- clsAllClass ----------

    #region api 2023/03/22

    public class RootBodyLicForApi
    {
        public string canumber { get; set; }
        public string mode { get; set; }
        public string amount { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        //public BillFetchLic bill_fetch { get; set; }
        public string billNumber { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string dueFrom { get; set; }
        public string dueTo { get; set; }
        public string validationId { get; set; }
        public string billId { get; set; }

        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
        public string type { get; set; }
    }

    public class PanBodyForApi
    {
        public string refid { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string mode { get; set; }
        public string gender { get; set; }
        public string redirect_url { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string encdata { get; set; }
        public string type { get; set; }


    }

    public class ResponseTransDetails
    {
        public string mobile { get; set; }
        public string referenceid { get; set; }
        public string pipe { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
        public string txntype { get; set; }
        public string amount { get; set; }
        public string type { get; set; }
        public bool status { get; set; }
        public int response_code { get; set; }
        public string ackno { get; set; }
        public string utr { get; set; }
        public string txn_status { get; set; }
        public string benename { get; set; }
        public string remarks { get; set; }
        public string message { get; set; }
        public string customercharge { get; set; }
        public string gst { get; set; }
        public string tds { get; set; }
        public string netcommission { get; set; }
        public string remitter { get; set; }
        public string account_number { get; set; }
        public string paysprint_share { get; set; }
        public string balance { get; set; }
        public string operatorid { get; set; }
        public string EntryDate { get; set; }


    }


    #endregion



    public class BillLICFetchResponse
    {
        public string billNumber { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public bool acceptPayment { get; set; }
        public bool acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string dueFrom { get; set; }
        public string dueTo { get; set; }
        public string validationId { get; set; }
        public string billId { get; set; }
    }

    public class RootBillFetch
    {
        public int response_code { get; set; }
        public bool status { get; set; }
        public string amount { get; set; }
        public object name { get; set; }
        public object duedate { get; set; }
        public BillFetch bill_fetch { get; set; }
        public object ad2 { get; set; }
        public object ad3 { get; set; }
        public string message { get; set; }


    }

    public class BillReq
    {
        public string canumber { get; set; }
        public string ad1 { get; set; }
        public string mode { get; set; }
        //public string ad2 { get; set; }
        //public string ad3 { get; set; }
    }

    public class BillLicReqModel
    {
        public string Canumber { get; set; }
        public string Ad1 { get; set; }
        public string Mode { get; set; }
    }

    #region CheckPanStatus 2023/03/22

    public class CheckPanStatusBody
    {
        public string refid { get; set; }

    }

    #endregion

    #region 2023/02/23
    public class PanListAPiRes
    {
        public string id { get; set; }
        public string url { get; set; }
        public string encdata { get; set; }
        public string entrydate { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string mode { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string title { get; set; }
        public string refid { get; set; }



    }
    public class ReferelenceListRes
    {
        public string ReferenceId { get; set; }
        public string Amount { get; set; }
        public string Entrydate { get; set; }
    }
    #endregion
    public class RootQueryremiter
    {
        public bool status { get; set; }
        public string otp { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public DataQueryremiter data { get; set; }
    }

    #region Compliance 2023/03/24
    public class ConplainsApiReq
    {
        public string Aadharno { get; set; }
        public string AdharPicFront { get; set; }
        public string AdharPicBack { get; set; }
        public string Panno { get; set; }
        public string PanPicFront { get; set; }
        //public string PanPicBack { get; set; }
        public string Ad1 { get; set; }
        public string Ad1PicFront { get; set; }
        //public string Ad1PicBack { get; set; }
        public string Ad2 { get; set; }
        public string Ad2PicFront { get; set; }
        //public string Ad2PicBack { get; set; }
        public string Ad3 { get; set; }
        public string Ad3PicFront { get; set; }
        //public string Ad3PicBack { get; set; }
        public string Userid { get; set; }
        public string Mobileno { get; set; }
        public string Email { get; set; }
        public string Billno { get; set; }
        public string Doctype { get; set; }



        public string Ad4 { get; set; }
        public string Ad4PicFront { get; set; }
        //public string Ad4PicBack { get; set; }

        public string Ad5 { get; set; }
        public string Ad5PicFront { get; set; }
        //public string Ad5PicBack { get; set; }

        public string Ad6 { get; set; }
        public string Ad6PicFront { get; set; }
        //public string Ad6PicBack { get; set; }

        //public string Ad7 { get; set; }
        //public string Ad7PicFront { get; set; }
        //public string Ad7PicBack { get; set; }

        //public string Ad8 { get; set; }
        //public string Ad8PicFront { get; set; }
        //public string Ad8PicBack { get; set; }

        //public string Ad9 { get; set; }
        //public string Ad9PicFront { get; set; }
        //public string Ad9PicBack { get; set; }

        //public string Ad10 { get; set; }
        //public string Ad10PicFront { get; set; }
        //public string Ad10PicBack { get; set; }

    }
    public class DocDetailsApiRes
    {
        public string Id { get; set; }
        public string Aadharno { get; set; }
        public string AdharPicFront { get; set; }
        public string AdharPicBack { get; set; }
        public string Panno { get; set; }
        public string PanPicFront { get; set; }
        public string PanPicBack { get; set; }
        public string Ad1 { get; set; }
        public string Ad1PicFront { get; set; }
        public string Ad1PicBack { get; set; }
        public string Ad2 { get; set; }
        public string Ad2PicFront { get; set; }
        public string Ad2PicBack { get; set; }
        public string Ad3 { get; set; }
        public string Ad3PicFront { get; set; }
        public string Ad3PicBack { get; set; }
        public string Userid { get; set; }
        public string Mobileno { get; set; }
        public string Email { get; set; }
        public string Billno { get; set; }
        public string Doctype { get; set; }

        public string Entrydate { get; set; }
        public string Entrytype { get; set; }


        public string Ad4 { get; set; }
        public string Ad4PicFront { get; set; }
        public string Ad4PicBack { get; set; }


        public string Ad5 { get; set; }
        public string Ad5PicFront { get; set; }
        public string Ad5PicBack { get; set; }


        public string Ad6 { get; set; }
        public string Ad6PicFront { get; set; }
        public string Ad6PicBack { get; set; }


        public string Ad7 { get; set; }
        public string Ad7PicFront { get; set; }
        public string Ad7PicBack { get; set; }


        public string Ad8 { get; set; }
        public string Ad8PicFront { get; set; }
        public string Ad8PicBack { get; set; }


        public string Ad9 { get; set; }
        public string Ad9PicFront { get; set; }
        public string Ad9PicBack { get; set; }

        public string Ad10 { get; set; }
        public string Ad10PicFront { get; set; }
        public string Ad10PicBack { get; set; }

        public string Name { get; set; }
        public string Income { get; set; }
        public string Address { get; set; }



    }
    public class DocDetailsReq
    {
        public string id { get; set; }
    }

    #endregion

    #region 2023/03/25

    public class SaveComplianceAllDetailsPara
    {

        public string Adharno { get; set; }
        public IFormFile AdharPicFront { get; set; }
        public string AdharPicFrontfilename { get; set; }
        public IFormFile AdharPicBack { get; set; }
        public string AdharPicBackfilename { get; set; }
        public string Panno { get; set; }
        public IFormFile PanPicFront { get; set; }
        public string PanPicFrontfilename { get; set; }
        public IFormFile PanPicBack { get; set; }
        public string PanPicBackfilename { get; set; }
        public string Ad1 { get; set; }
        public IFormFile Ad1PicFront { get; set; }
        public string Ad1PicFrontfilename { get; set; }
        public IFormFile Ad1PicBack { get; set; }
        public string Ad1PicBackfilename { get; set; }
        public string Ad2 { get; set; }
        public IFormFile Ad2PicFront { get; set; }
        public string Ad2PicFrontfilename { get; set; }
        public IFormFile Ad2PicBack { get; set; }
        public string Ad2PicBackfilename { get; set; }
        public string Ad3 { get; set; }
        public IFormFile Ad3PicFront { get; set; }
        public string Ad3PicFrontfilename { get; set; }
        public IFormFile Ad3PicBack { get; set; }
        public string Ad3PicBackfilename { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string BillNo { get; set; }
        public string DocType { get; set; }
        public string UserId { get; set; }


        public string Ad4 { get; set; }
        public IFormFile Ad4PicFront { get; set; }
        public string Ad4PicFrontfilename { get; set; }
        public IFormFile Ad4PicBack { get; set; }
        public string Ad4PicBackfilename { get; set; }


        public string Ad5 { get; set; }
        public IFormFile Ad5PicFront { get; set; }
        public string Ad5PicFrontfilename { get; set; }
        public IFormFile Ad5PicBack { get; set; }
        public string Ad5PicBackfilename { get; set; }


        public string Ad6 { get; set; }
        public IFormFile Ad6PicFront { get; set; }
        public string Ad6PicFrontfilename { get; set; }
        public IFormFile Ad6PicBack { get; set; }
        public string Ad6PicBackfilename { get; set; }


        public string Ad7 { get; set; }
        public IFormFile Ad7PicFront { get; set; }
        public string Ad7PicFrontfilename { get; set; }
        public IFormFile Ad7PicBack { get; set; }
        public string Ad7PicBackfilename { get; set; }


        public string Ad8 { get; set; }
        public IFormFile Ad8PicFront { get; set; }
        public string Ad8PicFrontfilename { get; set; }
        public IFormFile Ad8PicBack { get; set; }
        public string Ad8PicBackfilename { get; set; }


        public string Ad9 { get; set; }
        public IFormFile Ad9PicFront { get; set; }
        public string Ad9PicFrontfilename { get; set; }
        public IFormFile Ad9PicBack { get; set; }
        public string Ad9PicBackfilename { get; set; }


        public string Ad10 { get; set; }
        public IFormFile Ad10PicFront { get; set; }
        public string Ad10PicFrontfilename { get; set; }
        public IFormFile Ad10PicBack { get; set; }
        public string Ad10PicBackfilename { get; set; }

        public string name { get; set; }
        public string address { get; set; }
        public string income { get; set; }

    }

    public class Commission
    {
        public decimal commissonPer { get; set; }
        public string EntryBy { get; set; }
    }

    #endregion

    #region 27/03/2023

    public class PartnerRecharge
    {
        public decimal WalletAmt { get; set; }
        public decimal APESAmt { get; set; }
        public int Id { get; set; }
        public string EntryBy { get; set; }
        public string Flag { get; set; }
        public string Message { get; set; }
    }


    public class PayBillModel
    {
        public string OperatorID { get; set; }
        public string Canumber { get; set; }
        public string Amount { get; set; }
        public string Referenceid { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Mode { get; set; }
        public string UserName { get; set; }
        public string DueDate { get; set; }

        public BillFetch bill_fetch { get; set; }
        public string Ad1 { get; set; }
        public string Ad2 { get; set; }
        public string Ad3 { get; set; }
    }
    public class PayBillApicls
    {
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mode { get; set; }

        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string dueDate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
        //public string bill_fetch { get; set; }
        public string Ad1 { get; set; }
        public string Ad2 { get; set; }
        public string Ad3 { get; set; }

    }
    #endregion

    #region [UserMenuPermission] 2023/03/28

    public class UserMenuPermission
    {
        public bool Dmt { get; set; }
        public bool AEPS { get; set; }
        public bool MATM { get; set; }
        public bool BBPS { get; set; }
        public bool RECHARGE { get; set; }
        public bool DTH { get; set; }
        public bool ELECTRICITY { get; set; }
        public bool FASTAG { get; set; }
        public bool WATER_BILL { get; set; }
        public bool MUNCIPALITY { get; set; }
        public bool LIC { get; set; }
        public bool PAN { get; set; }
        public bool EPFO { get; set; }
        public bool LPG { get; set; }
        public bool IRCTC { get; set; }
        public bool FLIGHT { get; set; }
        public bool BUS { get; set; }
        public bool HOTEL { get; set; }
        public bool HOLIDAYS_BOOKING { get; set; }
    }
    public class DocDetailBody
    {
        public string UserId { get; set; }
        public string Type { get; set; }

    }
    #endregion

    public class BillPayResponse
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public string operatorid { get; set; }
        public int ackno { get; set; }
        public string opening { get; set; }
        public string closing { get; set; }
        public string message { get; set; }
    }
    #region [UserMenuPermission] 2023/03/28

    public class UserCommissionBody
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string Dmt { get; set; }
        public string Aeps { get; set; }
        public string Matm { get; set; }
        public string Bbps { get; set; }
        public string Recharge { get; set; }
        public string Dth { get; set; }
        public string Electricity { get; set; }
        public string Fastag { get; set; }
        public string Waterbill { get; set; }
        public string Muncipality { get; set; }
        public string Lic { get; set; }
        public string Pan { get; set; }
        public string Epfo { get; set; }
        public string Lpg { get; set; }
        public string Irctc { get; set; }
        public string Flight { get; set; }
        public string Bus { get; set; }
        public string Hotel { get; set; }
        public string Holidaysbooking { get; set; }
    }
    #endregion
     
    public class usercomplain
    {

        public string Message { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string serviceId { get; set; }
        public string UseriID { get; set; }
        public string TransactionId { get; set; }
        public string Transactiondate { get; set; }

    }

    public class uploadvideoCls
    {

        public string Message { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UseriID { get; set; }
        public string ServiceType { get; set; }
    }

    public class PaysprintRecharge
    {
        public int Amount { get; set; }
    }

    public class MemberDetails
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Action { get; set; }

    }
    #region [MemberKYC] 2023/04/10

    public class KYCDetailsBody
    {
        public string Partnerid { get; set; }
        public string AadhaarNo { get; set; }
        public string PanNo { get; set; }
        public string Bankname { get; set; }
        public string Bankholdername { get; set; }
        public string Bankaccountno { get; set; }
        public string Ifsccode { get; set; }
        public IFormFile Aadharpicfront { get; set; }
        public IFormFile Aadharpicback { get; set; }
        public IFormFile Panpicfront { get; set; }
        public IFormFile Panpicback { get; set; }

        public string Aadharpicfrontname { get; set; }
        public string Aadharpicbackname { get; set; }
        public string Panpicfrontname { get; set; }
        public string Panpicbackname { get; set; }
        public string Action { get; set; }

    }


    #endregion

    #region [MemberKYC] 2023/04/12
    public class EnquiryData
    {
        public string txnid { get; set; }
        public string operatorname { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string comm { get; set; }
        public string tds { get; set; }
        public string status { get; set; }
        public string refid { get; set; }
        public object operatorid { get; set; }
        public string dateadded { get; set; }
        public string refunded { get; set; }
        public string refundtxnid { get; set; }
        public string daterefunded { get; set; }
    }

    public class DoRechargeEnqueryres
    {
        public int response_code { get; set; }
        public bool status { get; set; }
        public EnquiryData data { get; set; }
        public string message { get; set; }
        public string action { get; set; }
    }


    #endregion

    #region [CHeckHLR] 2023/04/21
    public class CheckHLRBody
    {
        public string number { get; set; }
        public string type { get; set; }
    }

    #endregion
    public class Geturlencdata
    {
        public string Url { get; set; }
        public string Encdata { get; set; }
        public string Msg { get; set; }
        public string rescode { get; set; }
    }

    #region wallet 2023/04/26

    public class WalletResponce
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string wallet { get; set; }
        public string message { get; set; }
    }
    public class CashWalletResponce
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string cdwallet { get; set; }
        public string message { get; set; }
    }

    #endregion

    #region tansaction body
    public class TansactionBody
    {
        public string mobile { get; set; }
        public string referenceid { get; set; }
        public string pipe { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
        public string txntype { get; set; }
        public string amount { get; set; }
    }
    #endregion
    public class GetRemitterDetails
    {
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string Dob { get; set; }
    }
    #region Paysprint
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponse
    {

        public string Access_Token { get; set; }
    }
    #endregion
    #region CallBack Decentro
    public class ReqCallBack
    {
        public string bankReferenceNumber { get; set; }
        public string payerMobileNumber { get; set; }
        public string payerName { get; set; }
    }


    public class ParamCallBack
    {
        public string merchant_id { get; set; }
        public string partner_id { get; set; }
        public string request_id { get; set; }
        public string amount { get; set; }
    }

    //public class CallBackAPIRequest
    //{
    //    public string @event { get; set; }
    //    public ParamCallBack param { get; set; }
    //    public string param_inc { get; set; }
    //}
    #endregion
     
    #region getkycdetails 2023/04/29

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BankDetails
    {
        public string account_number { get; set; }
        public string ifsc { get; set; }
        public string details { get; set; }
    }

    public class DataKYCDetails
    {
        public string client_id { get; set; }
        public string pf_uan { get; set; }
        public KycDetailsGEtRes kyc_details { get; set; }
    }

    public class KycDetailsGEtRes
    {
        public string pan_number { get; set; }
        public string aadhaar_number { get; set; }
        public string mobile_number { get; set; }
        public string email { get; set; }
        public string full_name { get; set; }
        public string relation_name { get; set; }
        public string relation_type { get; set; }
        public string dob { get; set; }
        public string doj_epf { get; set; }
        public string doj_eps { get; set; }
        public BankDetails bank_details { get; set; }
    }

    public class RootGetKYCDetailsRes
    {
        public string status { get; set; }
        public int response_code { get; set; }
        public string message { get; set; }
        public DataKYCDetails data { get; set; }
    }
    public class RootResGetKycRes
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string message { get; set; }
    }

    #endregion
    public class GetTransactionResponse
    {
        public string mobile { get; set; }
        public string pipe { get; set; }
        public string bankid { get; set; }
        public string referenceid { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
        public string txnType { get; set; }
        public string amount { get; set; }
        public string ackno { get; set; }
        public string utr { get; set; }
        public string txn_status { get; set; }
        public string benename { get; set; }
        public string message { get; set; }
        public string customercharge { get; set; }
        public string gst { get; set; }
        public string tds { get; set; }
        public string account_number { get; set; }
        public string paysprint_share { get; set; }
        public string balance { get; set; }
        public string EntryDate { get; set; }
    }

    public class MobileRechargeResponseApiCls
    {
        public string MobileNo { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
        public string EntryDate { get; set; }
        public string refunddate { get; set; }
    }

    public class LicBillPayResponseApiCls
    {

        public string EntryDate { get; set; }
        public string cannumber { get; set; }
        public string mode { get; set; }
        public string amount { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string billNumber { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string dueFrom { get; set; }
        public string dueTo { get; set; }
        public string validationId { get; set; }
        public string billId { get; set; }

        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }

    }
     
    public class GetPanDetailsResponseApiCls
    {

        public string firstname { get; set; }
        public string title { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string mode { get; set; }
        public string gender { get; set; }
        public string email { get; set; }


        public string url { get; set; }
        public string refid { get; set; }
        public string encdata { get; set; }
        public string type { get; set; }
        public string EntryDate { get; set; }
    }
    public class BBPSListAPiRes
    {
        public string CaNumber { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Mode { get; set; }
        public string operatorId { get; set; }
        public string ReferenceID { get; set; }
        public string opening { get; set; }
        public string closing { get; set; }
        public string ackno { get; set; }
        public string Msg { get; set; }
        public string status { get; set; }
        public string ENTRYDATE { get; set; }
        public string DueDate { get; set; }

    }

    public class LicListApiResponse
    {
        public string canumber { get; set; }
        public string mode { get; set; }
        public string amount { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string billnumber { get; set; }
        public string billamount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string acceptpayment { get; set; }
        public string acceptpartpay { get; set; }
        public string cellnumber { get; set; }
        public string duefrom { get; set; }
        public string dueto { get; set; }
        public string validationId { get; set; }
        public string billid { get; set; }
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string message { get; set; }
        public string entrydate { get; set; }
        public string type { get; set; }

    }
    public class PennyDropRequest
    {
        public string mobile { get; set; }
        public string accno { get; set; }
        public string bankid { get; set; }
        public string benename { get; set; }
        public string referenceid { get; set; }
        public string pincode { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string gst_state { get; set; }
        public string bene_id { get; set; }
    }
     
    public class BBPSInsertApiCls
    {
        public string @operator { get; set; }
        public string UserId { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mode { get; set; }
        public decimal billAmount { get; set; }
        public decimal billnetamount { get; set; }
        public string billdate { get; set; }
        public string dueDate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
        public string status { get; set; }
        public int response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string opening { get; set; }
        public string closing { get; set; }
        public string message { get; set; }

    }
     
    public class ListBillPay_BELResponse
    {
        public string Type { get; set; }

        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mode { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string dueDate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
        public string status { get; set; }
        public string response_code { get; set; }
        public string operatorid { get; set; }
        public string ackno { get; set; }
        public string opening { get; set; }
        public string closing { get; set; }
        public string message { get; set; }
        public string EntryDate { get; set; }

    }
    public class StatusBBPSEnquiryRequest
    {
        public string referenceid { get; set; }

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class FetchConsumerDetailsResponse
    {
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string dueDate { get; set; }
        public string maxBillAmount { get; set; }
        public bool acceptPayment { get; set; }
        public bool acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
    }

    public class FetchConsumerDetailsRoot
    {
        public int response_code { get; set; }
        public bool status { get; set; }
        public string amount { get; set; }
        public string name { get; set; }
        public string duedate { get; set; }
        public FetchConsumerDetailsResponse bill_fetch { get; set; }
        public string message { get; set; }
    }
     
    public class FetchConsumerRequestApi
    {
        public int @operator { get; set; }
        public string canumber { get; set; }
    }
    //public class FetchConsumerCls
    //{
    //    public string OperatorId { get; set; }
    //    public string Canumber { get; set; }
    //}




    //public class FasTagRechargeRequestApi
    //{
    //    public int @operator { get; set; }
    //    public string canumber { get; set; }
    //    public string amount { get; set; }
    //    public string referenceid { get; set; }
    //    public string latitude { get; set; }
    //    public string longitude { get; set; }
    //    public string dueDate { get; set; }
    //    public string userName { get; set; }
    //    public string bill_fetch { get; set; }
    //}
    //public class FasTagRechargeRequestModel
    //{
    //    public int operatorId { get; set; }
    //    public string Canumber { get; set; }
    //    public string Amount { get; set; }
    //    public string Referenceid { get; set; }
    //    public string Latitude { get; set; }
    //    public string Longitude { get; set; }
    //    public string DueDate { get; set; }
    //    public string UserName { get; set; }
    //    public FetchConsumerDetailsResponse FetchconsumerD { get; set; }
    //}

    //public class FasTagRechargeResponseroot
    //{
    //    public bool status { get; set; }
    //    public int response_code { get; set; }
    //    public string message { get; set; }
    //}

    public class FastTagRechargeRequest_BillFetch
    {
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string dueDate { get; set; }
        public string maxBillAmount { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
    }

    public class FastTagRechargeRequest
    {
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public FastTagRechargeRequest_BillFetch bill_fetch { get; set; }
    }
     
    public class CallBackAPIRequest
    {
        public string @event { get; set; }
        public string param { get; set; }
        public string param_inc { get; set; }
    }
    #region onboarding 2023/05/05
    public class OnboardingBody
    {
        public string merchantcode { get; set; }
        public string mobile { get; set; }
        public string is_new { get; set; }
        public string email { get; set; }
        public string firm { get; set; }
        public string callback { get; set; }
    }
    public class OnboardingRes
    {
        public string status { get; set; }
        public string response_code { get; set; }
        public string redirecturl { get; set; }
        public string onboard_pending { get; set; }
        public string message { get; set; }
        public string msgbody { get; set; }
    }
    #endregion
     
    public class BillFetch_BBPS
    {
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string billdate { get; set; }
        public string dueDate { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
    }

    public class BBPS_Body
    {
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string mode { get; set; }
        public BillFetch_BBPS bill_fetch { get; set; }
        public string ad1 { get; set; }
        public string ad2 { get; set; }
        public string ad3 { get; set; }
    }
    public class DataRootEPFOKycVerifyOPT
    {
        public string client_id { get; set; }
        public string otp_sent { get; set; }
        public string masked_mobile_number { get; set; }
        public string is_async { get; set; }
    }
    public class Bank
    {
        public int Bank1 { get; set; }
        public int Bank2 { get; set; }
    }

    public class OnboardingResponse
    {
        public string refno { get; set; }
        public string txnid { get; set; }
        public string status { get; set; }
        public string statusbank2 { get; set; }
        public string mobile { get; set; }
        public string partnerid { get; set; }
        public string merchantcode { get; set; }
        public Bank bank { get; set; }
    }
    public class RootEPFOKycVerifyOPT
    {
        public string statuscode { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public DataRootEPFOKycVerifyOPT data { get; set; }
    }
    public class CheckHLRRequestBody
    {
        public string number { get; set; }
        public string type { get; set; }
    }

    public class AEPSWithdraw : AEPSEnqueriModel
    {
        public int? amount { get; set; }
    }
    public class BanklistAEPS
    {
        public bool status { get; set; }
        public string message { get; set; }
        public List<DatumAEPS> data { get; set; }
    }

    public class DatumAEPS
    {
        public string id { get; set; }
        public string bankName { get; set; }
        public string iinno { get; set; }
        public string activeFlag { get; set; }
    }

    public class RootAEPS
    {
        public bool status { get; set; }
        public int response_code { get; set; }
        public BanklistAEPS banklist { get; set; }
        public string message { get; set; }
    }
    #region Onloarding
    public class OnboardParam
    {
        public string merchant_id { get; set; }
        public string partner_id { get; set; }
        public string request_id { get; set; }
        public float amount { get; set; }
    }
    public class OnboardRequesBody
    {
        public string @event { get; set; }
        public OnboardParam param { get; set; }
        public string param_enc { get; set; }
    }
    public class AEPSTreeWay
    {
        public string reference { get; set; }
        public string status { get; set; }
    }
    public class AEPSWithdrowlRes
    {
        public bool status { get; set; }
        public string txnstatus { get; set; }
        public string message { get; set; }
        public string ackno { get; set; }
        public string amount { get; set; }
        public string bankrrn { get; set; }
        public int response_code { get; set; }
    }
    #endregion
    public class OnBoardingforAEPS
        {
        public OnboardRequesBody param { get; set; }
    }
    public class fastagapi1
    {
        public string userid { get; set; }
        public bool status { get; set; }
        public int response_code { get; set; }
        public string stateresp { get; set; }
        public string message { get; set; }
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string referenceid { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string dueDate { get; set; }
        public string maxBillAmount { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
    }
    public class FastagApiResponce
    {
        public string id { get; set; }
        public string aPI_status { get; set; }
        public string response_code { get; set; }
        public string message { get; set; }
        public string reference_id { get; set; }
        public string @operator { get; set; }
        public string canumber { get; set; }
        public string amount { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string billAmount { get; set; }
        public string billnetamount { get; set; }
        public string dueDate { get; set; }
        public string maxBillAmount { get; set; }
        public string acceptPayment { get; set; }
        public string acceptPartPay { get; set; }
        public string cellNumber { get; set; }
        public string userName { get; set; }
        public string entryDate { get; set; }
        public string entry_by { get; set; }
        public string iS_mobile_entry { get; set; }
    }


	public class ViewMemberDocDetailsCls
	{
		public string ID { get; set; }
		public string PartnerID { get; set; }
		public string Name { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string DocType { get; set; }
		public string BillNo { get; set; }
		public string Aadharno { get; set; }
		public string AadharFimage { get; set; }
		public string AadharBimage { get; set; }
		public string PanNo { get; set; }
		public string PanFimage { get; set; }
		public string Ad1 { get; set; }
		public string Ad1PicFront { get; set; }
		public string Ad1PicBack { get; set; }

		public string Ad2 { get; set; }

		public string Ad2PicFront { get; set; }
		public string Ad2PicBack { get; set; }

		public string Ad3 { get; set; }
		public string Ad3PicFront { get; set; }
		public string Ad3PicBack { get; set; }
		public string Ad4 { get; set; }

		public string Ad4PicFront { get; set; }
		public string Ad4PicBack { get; set; }
		public string Ad5 { get; set; }

		public string Ad5PicFront { get; set; }
		public string Ad5PicBack { get; set; }
		public string Ad6 { get; set; }

		public string Ad6PicFront { get; set; }
		public string Ad6PicBack { get; set; }
		public string Ad7 { get; set; }
		public string Ad7PicFront { get; set; }
		public string Ad7PicBack { get; set; }
		public string Ad8 { get; set; }
		public string Ad8PicFront { get; set; }
		public string Ad8PicBack { get; set; }
		public string Ad9 { get; set; }

		public string Ad9PicFront { get; set; }
		public string Ad9PicBack { get; set; }
		public string Ad10 { get; set; }

		public string Ad10PicFront { get; set; }
		public string Ad10PicBack { get; set; }
		public string PanBimage { get; set; }
        public string CloseStatus { get; set; }
    }
    public class profile
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Pincode { get; set; }
        public string mobile { get; set; }
        public string Dob { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Block { get; set; }
        public string Address { get; set; }
        public string BankName { get; set; }
        public string BankHolderName { get; set; }
        public string BankAccountNo { get; set; }
        public string IFSCCode { get; set; }
        public DataTable dt { get; set; }
        public int Action { get; set; }
    }

}