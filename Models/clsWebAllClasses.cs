using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBattle.Models
{
    public class clsWebAllClasses
    {

    }
    public class clsPlayer
    {

        public string FirstPlayerStatus { get; set; }
        public string SecPlayerStatus { get; set; }

        public string FromUserId { get; set; }
        public string ToUserId { get; set; }

        public string amount_type { get; set; }
        public string Amount { get; set; }
        public string type { get; set; }
        public string msg { get; set; }  
        public string ChallengeId { get; set; }  

        public string Status { get; set; }
        public string UserID { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public DataTable dtDetails { get; set; }
        public DataTable dtDetails1 { get; set; }

        public DataTable dtTransactionHistory { get; set; }
        public DataTable dtPendingTable { get; set; }
        public DataTable dtRunningTable { get; set; }
        public DataTable dtComplatedTable { get; set; }
        public DataTable dtCancelledTable { get; set; }
        public DataTable dtPayment { get; set; }
        public DataTable dtReferrals { get; set; }
        public byte[] Data { get; set; }
    }
    public class clsBindPendingCount
    {
        public int TotalWithdraPending { get; set; }
        public int TotalGamePending { get; set; }
    }
    public class clsWithdraw
    {
        public string Action { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public string ProofId { get; set; }
        public string TransferId { get; set; }
        public string TransferRemark { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public DataTable dtDetails { get; set; }
    }
    public class clsBanner
    {
        public DataTable dt { get; set; }
        public string Action { get; set; }
        public string msg { get; set; }
        public string Id { get; set; }
        public string ImageURL { get; set; }

    }
    public class clsCommission
    {
        public string Action { get; set; }
        public string Commission { get; set; }
        public string RefferalCommission { get; set; } 
        public string ImageURL { get; set; } 
        public Boolean IsPopup { get; set; } 
        public Boolean IsAppUnderMaintance { get; set; } 
    }
    public class clsNotification
    {
        public DataTable dt { get; set; }
        public string Action { get; set; } 
        [Required(ErrorMessage = "Please Notification Title")]
        public string NotificationTitle { get; set; }
        public string NotificationDescription { get; set; }
        public string ImageURL { get; set; }
        public Boolean IsSave { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public string Id { get; set; }


    }
    public class clsHomePageDetails
    { 
        public string WhatsappNo { get; set; }
        public string WhatsappLink { get; set; }
        public string YouTubeLink { get; set; }
        public string FacebookLink { get; set; }
        public string TelegramLink { get; set; }
        public string InstagramLink { get; set; } 
        public string Action { get; set; }
        public DataTable dt { get; set; }
        public string Id { get; set; }
    }
    public class clsRefferalDetails
    {
        public string FromProfilePic { get; set; }
        public string FromUserId { get; set; }
        public string FromUserName { get; set; }
        public string RefferalCommissionAmount { get; set; }
        public string ToProfilePic { get; set; }
        public string ToUserId { get; set; }
        public string ToUserName { get; set; }
        public string  Date { get; set; }

    }
    public class clsAdminCommissionReport
    {
        public string Action { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }
        public string NewPassword { get; set; }

        public string OldPassword { get; set; }

        public DataTable dt { get; set; }
    }


    public class WalletRequestApiCls
    {
        public string TransactionType { get; set; }

        public string images { get; set; }
        public string Amount { get; set; }
        public string DepositedDate { get; set; }
        public string BankName { get; set; }
        public string UserId { get; set; }

        public string TransactionID { get; set; }
    }

    public class BalanceReq
    {
        public string TransactionType { get; set; }
        public IFormFile FileName { get; set; }
        public string images { get; set; }
        public string TransferTo { get; set; }
        public string Amount { get; set; }
        public decimal transferamt { get; set; }
        public string DepositedDate { get; set; }
        public string BankName { get; set; }
        public string UserID { get; set; }
        public string TransactionID { get; set; }
    }


    public class GetuserBalanceReq
    {

        public string UserId { get; set; }

    }

    public class GetuserBalanceResponse
    {
        public string Credit { get; set; }
        public string Debit { get; set; }

    }



    public class GetuserWalletHistoryResponse
    {
        public string Status { get; set; }
        public string Entrydate { get; set; }
        public string TransactionType { get; set; }
        public string BankName { get; set; }
        public string Amount { get; set; }
        public string DepositedDate { get; set; }
        public string TransactionID { get; set; }

    }


    public class ChangePasswordModel
    {
        
        

        public string Flag { get; set; }
        public string NewPassword { get; set; }
        public string UserID { get; set; }

        public string OldPassword { get; set; }
        public string confirmPassword { get; set; }
        public string Message { get; set; }

        public DataTable dt { get; set; }
    }

}
