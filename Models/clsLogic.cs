using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using System.Drawing;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using Microsoft.SqlServer.Server;


namespace SportsBattle.Models
{
	public class clsLogic
	{
		DBHelper db = new DBHelper();
		public DataTable GetAppVersion()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetAppVersion"),
			};
			dt = db.ExecProcDataTable("USP_AppVersion", parm);
			return dt;
		}
		public DataTable GetUserDetails(ReqmemberDetails objP)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetUserDetails"),
				new SqlParameter("@MobileNo",objP.MobileNo),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable GetMobileNoExists(string MobileNo)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetMobileNoExists"),
				new SqlParameter("@MobileNo",MobileNo),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable UserRegisteration(ReqUserRegistration Req)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","UserRegisteration"),
				new SqlParameter("@MobileNo",Req.MobileNo),
				new SqlParameter("@Member_Name",Req.Name),
				new SqlParameter("@Address",Req.Address),
				new SqlParameter("@Pincode",Req.Pincode),
				new SqlParameter("@Member_DOB",Req.DOB),
				new SqlParameter("@Gender",Req.Gender),
				new SqlParameter("@ReferralId",Req.ReferralId),
				new SqlParameter("@DrivingLicence",Req.DrivingLicence),
				new SqlParameter("@OwnerShips",Req.OwnerShips),
				new SqlParameter("@FrontImage",Req.FrontImage),
				new SqlParameter("@BackImage",Req.BackImage),
				new SqlParameter("@SideImage",Req.SideImage),
				new SqlParameter("@DLImage", Req.DLImage)
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			Req.UserId = dt.Rows[0]["UserID"].ToString();
			return dt;
		}

		public DataTable UserCountUpdate(int ERCount, int ChCount, int batteryCount, int AdCount, ResUserCount objCount)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				 new SqlParameter("@Action","UpdateCount"),
				new SqlParameter("@ErCount",ERCount),
				new SqlParameter("@ChCount",ChCount),
				new SqlParameter("@BatCount",batteryCount),
				new SqlParameter("@AdCount",AdCount),
				new SqlParameter("@UserId", objCount.UserId)
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable GetChallenge(ReqChallenge Request, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",Request.UserId),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable CreateChallenge(ReqCreateChallenge Req)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","CreateChallenge"),
				new SqlParameter("@NoOfPlayers",Req.NoOfPlayers),
				new SqlParameter("@UserId",Req.UserId),
				new SqlParameter("@EntryFee",Req.EntryFee),

				new SqlParameter("@GameType",Req.GameType),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable GetPlayerDetails(ReqPlayerList objP)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetPlayerDetails"),
				new SqlParameter("@ChallengeId",objP.ChallengeId),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable UpdateChallengeStatus(ReqUpdateChallengeStatus Req)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","UpdateChallengeStatus"),
				new SqlParameter("@UserId",Req.UserId),
				new SqlParameter("@ChallengeId",Req.ChallengeId),
				new SqlParameter("@Type",Req.Type),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable GetChallengeDetailsById(ReqChallengeDetails Request)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetChallengeById"),
				new SqlParameter("@ChallengeId",Request.ChallengeId),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable UpdateRoomId(ReqUpdateRoomId Request)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","UpdateRoomId"),
				new SqlParameter("@ChallengeId",Request.ChallengeId),
				new SqlParameter("@RoomId",Request.RoomId),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable UpdateChallengeResult(ReqUpdateChallengeResult Request)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","UpdateChallengeResult"),
				new SqlParameter("@ChallengeId",Request.ChallengeId),
				new SqlParameter("@ImageURL",Request.Image),
				new SqlParameter("@UserId",Request.UserId),
				new SqlParameter("@WinnerId",Request.WinnerId),
				new SqlParameter("@Status",Request.Status),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable DeleteChallenge(ReqDeleteChallenge Request)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","DeleteChallenge"),
				new SqlParameter("@ChallengeId",Request.ChallengeId),
				new SqlParameter("@UserId",Request.UserId),
			};
			dt = db.ExecProcDataTable("USP_Challenge", parm);
			return dt;
		}
		public DataTable GetWalletBalance(ReqWalletAmount ObjP)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetUserWalletAmount"),
				new SqlParameter("@UserId",ObjP.UserId),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable AmountTransfer(ReqDepositeAmount ObjP)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","AmountTransfer"),
				new SqlParameter("@Amount",ObjP.Amount),
				new SqlParameter("@UserId",ObjP.UserId),
				new SqlParameter("@Type",ObjP.Type),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable GetBanner()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","Details"),
			};
			dt = db.ExecProcDataTable("USP_BannerDetails", parm);
			return dt;
		}
		public DataTable GetTop5User()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetTop5User"),
			};
			dt = db.ExecProcDataTable("USP_BannerDetails", parm);
			return dt;
		}
		public DataTable GetBankInfo(ReqWalletAmount ObjP, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",ObjP.UserId),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable SaveFCM(ResSaveFCM ObjP, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",ObjP.UserId),
				new SqlParameter("@FCM",ObjP.FCM),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable TransactionHistory(ReqTransactionHistory ObjP, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",ObjP.UserId),
				new SqlParameter("@Type",ObjP.Type),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable GetUserCommonDetails(ReqGetGameHistory ObjP, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",ObjP.UserId),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}
		public DataTable SendChat(ReqSendChat ObjP, string Action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action",Action),
				new SqlParameter("@UserId",ObjP.userID),
				new SqlParameter("@opponentId",ObjP.opponentId),
				new SqlParameter("@msg",ObjP.msg),
				new SqlParameter("@challengeId",ObjP.challengeId),

			};
			dt = db.ExecProcDataTable("USP_SendChat", parm);
			return dt;
		}
		public DataTable AdminDetails()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetAdminDetails"),
			};
			dt = db.ExecProcDataTable("USP_AdminDetails", parm);
			return dt;
		}
		public DataTable GetPopUp()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetPopUp"),
			};
			dt = db.ExecProcDataTable("USP_AdminDetails", parm);
			return dt;
		}

		public DataTable CancelRequest(ReqCancelRequest ObjP)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","CancelRequest"),
				new SqlParameter("@UserId",ObjP.UserId),
				new SqlParameter("@Id",ObjP.Id),
			};
			dt = db.ExecProcDataTable("USP_UserDetails", parm);
			return dt;
		}

		public DataTable GetAppUnderMaintance()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","AppUnderMaintance"),
			};
			dt = db.ExecProcDataTable("USP_AdminDetails", parm);
			return dt;
		}
		public DataTable GetTotalDetails()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@Action","GetTotalDetails"),
			};
			dt = db.ExecProcDataTable("USP_AdminDetails", parm);
			return dt;
		}

		#region 01/03/2023 UserLogin 
		public DataTable GetMobileNoforOtp(string MobileNo)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@MobileNo",MobileNo),
			};
			dt = db.ExecProcDataTable("sp_userDetails", parm);
			return dt;
		}
		#endregion

		#region  02/02/2023 GetbankList
		public DataTable BindGetBankList()
		{
			try
			{
				DataTable dt = new DataTable();
				SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@MobileNo",MobileNo)
            };

				dt = db.ExecProcDataTable("sp_bankList", parm);
				return dt;
			}
			catch (Exception ex)
			{

				throw;
			}
		}




		#endregion

		#region 
		public DataTable GetTransactionDetailsApi(TrnsRequst obj)
		{
			try
			{
				DataTable dt = new DataTable();
				SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@MobileNo",obj.MobileNo),
				new SqlParameter("@TxtType",obj.txttype)
			};
				dt = db.ExecProcDataTable("sp_getTransactionDetails", parm);
				return dt;
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		#endregion


		#region Atul Singh 2023/03/01
		public DataTable GetUserProfile(string MobileNo)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@MobileNo",MobileNo),
			};
			dt = db.ExecProcDataTable("sp_userDetails", parm);
			return dt;
		}
		public DataTable GetReferenceId(string referencecode, GetReferenceModel obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@ReferaceID",referencecode),
				new SqlParameter("@Type",obj.type),
				new SqlParameter("@amount",obj.amount),
				new SqlParameter("@userid",obj.UserId),
			};
			dt = db.ExecProcDataTable("sp_GenratetransactionID", parm);
			return dt;
		}
		public DataTable GetReferenceId(string referencecode, string type)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@ReferaceID",referencecode),
				new SqlParameter("@Type",type),
                //new SqlParameter("@amount",obj.amount),
                //new SqlParameter("@userid",obj.UserId),
            };
			dt = db.ExecProcDataTable("sp_GenratetransactionID", parm);
			return dt;
		}

		#endregion

		#region Atul Singh 2023/03/04

		public DataTable GetBeneficiaryDetails(string userid)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@action",1),
				new SqlParameter("@agentid",userid),
			};
			dt = db.ExecProcDataTable("sp_getDetailsBeneficiary", parm);
			return dt;
		}
		public DataTable GetRemitterDetails(string userid)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@action",1),
				 new SqlParameter("@agentid",userid),
			};
			dt = db.ExecProcDataTable("sp_getRemitterDetials", parm);
			return dt;
		}

		public DataTable GetDTHOperatorList(string action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@action",action),

			};
			dt = db.ExecProcDataTable("sp_operatorlist", parm);
			return dt;
		}
		#endregion



		#region GetTransaction Details 16/03/2023
		public DataTable GetTransaction(GetReqTranDetails obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@userid",obj.UserID),

				  new SqlParameter("@FromDate",obj.FormDate=="" ? null: obj.FormDate),
				  new SqlParameter("@Todate",obj.ToDate=="" ? null: obj.ToDate),

				new SqlParameter("@type",obj.Type),

			};
			dt = db.ExecProcDataTable("sp_GetTransDetails", parm);
			return dt;
		}
		#endregion



		#region  shani 20/03/2023
		public DataTable InsertTransaction(TransactionRequestApi obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@ReferenceId",obj.referenceid),
				new SqlParameter("@Pincode",obj.pincode),
				 new SqlParameter("@MobileNo",obj.mobile),
				 new SqlParameter("@Pipe",obj.pipe),
				 new SqlParameter("@Address",obj.address),
				 new SqlParameter("@Gst_State",obj.gst_state),
				 new SqlParameter("@bene_id",obj.bene_id),
				  new SqlParameter("@Txntype",obj.txntype),
				  new SqlParameter("@Amount",obj.amount),
				  new SqlParameter("@Dob",obj.dob),
				  new SqlParameter("@Dob",obj.UserID),

			};
			dt = db.ExecProcDataTable("sp_transaction", parm);
			return dt;
		}

		#endregion



		#region InsertTransactions 2023/03/21

		public DataTable InsertDMTTransaction(TransactionclsForAPI obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@ReferenceId",obj.Referenceid),
				new SqlParameter("@Pincode",obj.Pincode),
				 new SqlParameter("@MobileNo",obj.Mobile),
				 new SqlParameter("@Pipe",obj.Pipe),
				 new SqlParameter("@Address",obj.Address),
				 new SqlParameter("@Gst_State",obj.Gst_state),
				 new SqlParameter("@bene_id",obj.Bene_id),
				  new SqlParameter("@Txntype",obj.TxnType),
				 new SqlParameter("@Amount",obj.Amount),
				 new SqlParameter("@bankid",obj.Bankid),
				 new SqlParameter("@Dob",obj.Dob),

                 //response data
                 new SqlParameter("@tnx_status",obj.txn_status),
				 new SqlParameter("@utr",obj.utr),
				 new SqlParameter("@paysprint_share",obj.paysprint_share),
				 new SqlParameter("@balance",obj.balance),
				 new SqlParameter("@account_number",obj.account_number),
				 new SqlParameter("@tds",obj.tds),
				 new SqlParameter("@gst",obj.gst),
				 new SqlParameter("@customercharge",obj.customercharge),
				 new SqlParameter("@benename",obj.benename),
				 new SqlParameter("@ackno",obj.ackno),
				 new SqlParameter("@message",obj.message),
				 new SqlParameter("@type",obj.Mobile)



			};
			dt = db.ExecProcDataTable("sp_transaction", parm);
			return dt;
		}

		public DataTable DoRecharge(RootDoRechargeForAPI p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@MobileNo",p.canumber),
				new SqlParameter("@ReferenceID",p.referenceid),
				new SqlParameter("@Amount",p.amount),
				new SqlParameter("@ackno",p.ackno),
				new SqlParameter("@ResponseCode",p.response_code),
				new SqlParameter("@Status",p.status),
				new SqlParameter("@OperatorID",p.operatorid),
				 new SqlParameter("@Message",p.message),
				 new SqlParameter("@type",p.canumber)


			};
			dt = db.ExecProcDataTable("sp_customerRecharge", parm);
			return dt;
		}

		#endregion


		//-------- clslogic ---------

		#region LIcBilPay 2023/03/22

		public DataTable LicBillPayDetails(RootBodyLicForApi p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@canumber",p.canumber),
				new SqlParameter("@mode",p.mode),

				new SqlParameter("@amount",p.amount),
				new SqlParameter("@ad1",p.ad1),
				new SqlParameter("@ad2",p.ad2),
				new SqlParameter("@ad3",p.ad3),
				new SqlParameter("@referenceid",p.referenceid),
				new SqlParameter("@latitude",p.latitude),
				new SqlParameter("@longitude",p.longitude),
				new SqlParameter("@billnumber",p.billNumber),
				new SqlParameter("@billamount",p.billAmount),
				new SqlParameter("@billnetamount",p.billnetamount),
				new SqlParameter("@billdate",p.billdate),
				new SqlParameter("@acceptpayment",p.acceptPayment),
				new SqlParameter("@acceptpartpay",p.acceptPartPay),
				new SqlParameter("@cellnumber",p.cellNumber),
				new SqlParameter("@duefrom",p.dueFrom),
				new SqlParameter("@dueto",p.dueTo),
				new SqlParameter("@validationId",p.validationId),
				new SqlParameter("@billid",p.billId),
				new SqlParameter("@status",p.status),
				new SqlParameter("@operatorid",p.operatorid),
				new SqlParameter("@ackno",p.ackno),
				new SqlParameter("@message",p.message),
				new SqlParameter("@response_code",p.response_code),
				new SqlParameter("@type",p.type)

			};
			dt = db.ExecProcDataTable("sp_LicBillPayDetails", parm);
			return dt;
		}

		public DataTable PanUrlEncdata(PanBodyForApi p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@url",p.url),
				new SqlParameter("@encdata",p.encdata),

				new SqlParameter("@refid",p.refid),
				new SqlParameter("@title",p.title),
				new SqlParameter("@email",p.email),
				new SqlParameter("@gender",p.gender),
				new SqlParameter("@mode",p.mode),
				new SqlParameter("@lname",p.lastname),
				new SqlParameter("@mname",p.middlename),
				new SqlParameter("@fname",p.firstname),
				new SqlParameter("@type",p.type)

			};
			dt = db.ExecProcDataTable("PanUrlEncdata", parm);
			return dt;
		}
		#endregion

		#region get referenceids by userid 2023/03/23

		public DataTable GetReferenceIdsByUserID(GetReqTranDetails p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@userid",p.UserID),
				new SqlParameter("@type",p.Type),
				new SqlParameter("@action","1")
			};
			dt = db.ExecProcDataTable("sp_GetReferenceId", parm);
			return dt;
		}
		#endregion
		#region savedocdetails 2023/03/24

		public DataTable SaveDocDetails(ConplainsApiReq p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","1"),
				new SqlParameter("@Aadharno",p.Aadharno),
				new SqlParameter("@AadharPicFront",p.AdharPicFront),
				new SqlParameter("@AadharPicBack",p.AdharPicBack),
				new SqlParameter("@Panno",p.Panno),
				new SqlParameter("@PanPicFront",p.PanPicFront),
				//new SqlParameter("@PanPicBack",p.PanPicBack),
				new SqlParameter("@Ad1",p.Ad1),
				new SqlParameter("@Ad1PicFront",p.Ad1PicFront),
				//new SqlParameter("@Ad1PicBack",p.Ad1PicBack),
				new SqlParameter("@Ad2",p.Ad2),
				new SqlParameter("@Ad2PicFront",p.Ad2PicFront),
				//new SqlParameter("@Ad2PicBack",p.Ad2PicBack),
				new SqlParameter("@Ad3",p.Ad3),
				new SqlParameter("@Ad3PicFront",p.Ad3PicFront),
				//new SqlParameter("@Ad3PicBack",p.Ad3PicBack),
				new SqlParameter("@Userid",p.Userid),
				new SqlParameter("@Mobile",p.Mobileno),
				new SqlParameter("@Email",p.Email),
				new SqlParameter("@Billno",p.Billno),
				new SqlParameter("@DocType",p.Doctype),
				new SqlParameter("@EntryType","MOBILE"),

				 new SqlParameter("@Ad4",p.Ad4),
				new SqlParameter("@Ad4PicFront",p.Ad4PicFront),
				//new SqlParameter("@Ad4PicBack",p.Ad4PicBack),

				 new SqlParameter("@Ad5",p.Ad5),
				new SqlParameter("@Ad5PicFront",p.Ad5PicFront),
				//new SqlParameter("@Ad5PicBack",p.Ad5PicBack),


				 new SqlParameter("@Ad6",p.Ad6),
				new SqlParameter("@Ad6PicFront",p.Ad6PicFront),
				//new SqlParameter("@Ad6PicBack",p.Ad6PicBack),

				// new SqlParameter("@Ad7",p.Ad7),
				//new SqlParameter("@Ad7PicFront",p.Ad7PicFront),
				//new SqlParameter("@Ad7PicBack",p.Ad7PicBack),

				// new SqlParameter("@Ad8",p.Ad8),
				//new SqlParameter("@Ad8PicFront",p.Ad8PicFront),
				//new SqlParameter("@Ad8PicBack",p.Ad8PicBack),

				// new SqlParameter("@Ad9",p.Ad9),
				//new SqlParameter("@Ad9PicFront",p.Ad9PicFront),
				//new SqlParameter("@Ad9PicBack",p.Ad9PicBack),

				// new SqlParameter("@Ad10",p.Ad10),
				//new SqlParameter("@Ad10PicFront",p.Ad10PicFront),
				//new SqlParameter("@Ad10PicBack",p.Ad10PicBack),


			};
			dt = db.ExecProcDataTable("sp_DocDetails", parm);
			return dt;
		}

		public DataTable SaveDocDetails(string id, string action)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action",action),
				new SqlParameter("@Id",id),
			};
			dt = db.ExecProcDataTable("sp_DocDetails", parm);
			return dt;
		}
		public DataTable SaveDocDetails(string id)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action",'2'),
				new SqlParameter("@Userid",id),
			};
			dt = db.ExecProcDataTable("sp_DocDetails", parm);
			return dt;
		}
		public Image Change64toImage(string img64)
		{

			byte[] bytes = Convert.FromBase64String(img64);

			using (MemoryStream ms = new MemoryStream(bytes))
			{
				Image pic = Image.FromStream(ms);
				return pic;
			}

		}
		#endregion
		#region [User Menu Permission details] 2023/03/28

		public DataTable UserMenuPermission(string userid)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@action","3"),
				new SqlParameter("@userid",userid)
			};
			dt = db.ExecProcDataTable("sp_menupermission", parm);
			return dt;
		}
		public DataTable SaveDocDetails(DocDetailBody p)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","4"),
				new SqlParameter("@Userid",p.UserId),
				new SqlParameter("@DocType",p.Type)
			};
			dt = db.ExecProcDataTable("sp_DocDetails", parm);
			return dt;
		}

		#endregion
		#region for paysprint 
		//public DataTable UserCallbackDetails(CallBackAPIRequest p)
		//{
		//    DataTable dt = new DataTable();
		//    SqlParameter[] parm = new SqlParameter[] {
		//        new SqlParameter("@event",p.@event),
		//        new SqlParameter("@merchant_id",p.param.merchant_id),
		//        new SqlParameter("@partner_id",p.param.partner_id),
		//        new SqlParameter("@request_id",p.param.request_id),
		//        new SqlParameter("@amount",p.param.amount),
		//        new SqlParameter("@param_inc",p.param_inc)
		//    };
		//    dt = db.ExecProcDataTable("PS_SP_CallBackAPIRequest", parm);
		//    return dt;
		//}
		#region for paysprint 
		public DataTable UserCallbackDetails(OnboardRequesBody p)
		{
			DataTable dt = new DataTable();
			if (p.@event == "MERCHANT_ONBOARDING")
			{
				SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@event",p.@event),
				new SqlParameter("@merchant_id", p.param.merchant_id),
				new SqlParameter("@partner_id", p.param.partner_id),
				new SqlParameter("@request_id", p.param.request_id),
				new SqlParameter("@amount", p.param.amount),
				new SqlParameter("@param_inc",p.param_enc)
			};
				dt = db.ExecProcDataTable("PS_SP_CallBackAPIRequest", parm);
			}
			return dt;
		}

		#endregion

		#endregion


		#region walletRequest 28/04/2023

		public DataTable WalletRequest(WalletRequestApiCls obj)
		{
			DataTable dt = new DataTable();


			SqlParameter[] Param = new SqlParameter[]{
				  new SqlParameter("@TransactionType",obj.TransactionType),
				  new SqlParameter("@TransactionID",obj.TransactionID),
				  new SqlParameter("@BankName",obj.BankName),
				  new SqlParameter("@Amount",obj.Amount),
				  new SqlParameter("@DepositedDate",obj.DepositedDate),
				  new SqlParameter("@images",obj.images),
				  new SqlParameter("@UserID",obj.UserId)
				};

			dt = db.ExecProcDataTable("Usp_InsertUserbalanceReq", Param);
			return dt;
		}


		#endregion

		public DataTable GetUserBalanceDetails(GetuserBalanceReq obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@UserID",obj.UserId),
				new SqlParameter("@Action","WDetails"),

			};
			dt = db.ExecProcDataTable("Usp_GetUserBalanceDetails", parm);
			return dt;
		}


		public DataTable GetUserWalletHistory(GetuserBalanceReq obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {
				new SqlParameter("@UserID",obj.UserId),
				new SqlParameter("@Action","WalletHistory"),

			};
			dt = db.ExecProcDataTable("Usp_GetUserBalanceDetails", parm);
			return dt;
		}




		public DataTable GetTransactionReport()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","TransactionDetails"),

			};
			dt = db.ExecProcDataTable("Usp_GetallDetailsForApi", parm);
			return dt;
		}
		public DataTable MobileRechargeReport()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","MobileRechageDetails"),

			};
			dt = db.ExecProcDataTable("Usp_GetallDetailsForApi", parm);
			return dt;
		}
		public DataTable LicGetDetailsPayBill()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","LicPayBillDetails"),

			};
			dt = db.ExecProcDataTable("Usp_GetallDetailsForApi", parm);
			return dt;
		}
		public DataTable GetPanNsdlDetails()
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

				new SqlParameter("@Action","PanDetails"),

			};
			dt = db.ExecProcDataTable("Usp_GetallDetailsForApi", parm);
			return dt;
		}




		#region 02/05/2023

		public DataTable InsertBBPSDetailsForApi(BBPSInsertApiCls obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {


			   new SqlParameter("@Action" , "B" )   ,
			   new SqlParameter("@UserId" ,  obj.UserId)   ,
			   new SqlParameter("@operator" , obj.@operator )   ,
			   new SqlParameter("@canumber" , obj.canumber )   ,
			   new SqlParameter("@amount " , obj.amount )   ,
			   new SqlParameter("@referenceid", obj.referenceid )   ,
			   new SqlParameter("@latitude" , obj.latitude)   ,
			   new SqlParameter("@longitude" , obj.longitude)   ,
			   new SqlParameter("@mode" , obj.mode )   ,
			   new SqlParameter("@billAmount " , obj.billAmount )   ,
			   new SqlParameter("@billnetamount " , obj.billnetamount )   ,
			   new SqlParameter("@billdate" , obj.billdate )   ,
			   new SqlParameter("@dueDate" , obj.dueDate )   ,
			   new SqlParameter("@acceptPayment" , obj.acceptPayment )   ,
			   new SqlParameter("@acceptPartPay" , obj.acceptPartPay )   ,
			   new SqlParameter("@cellNumber" , obj.cellNumber )   ,
			   new SqlParameter("@userName " , obj.userName )   ,
			   new SqlParameter("@status " , obj.status )   ,
			   new SqlParameter("@response_code" , obj.response_code )   ,
			   new SqlParameter("@operatorid " , obj.operatorid )   ,
			   new SqlParameter("@ackno " , obj.ackno )   ,
			   new SqlParameter("@opening " , obj.opening )   ,
			   new SqlParameter("@closing " , obj.closing )   ,
			   new SqlParameter("@message " , obj.message )

			};
			dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
			return dt;
		}
		public DataTable InsertLPGForApi(BBPSInsertApiCls obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {


			   new SqlParameter("@Action" , "L" ),
			   new SqlParameter("@UserId" ,  obj.UserId)   ,
			   new SqlParameter("@operator" , obj.@operator )   ,
			   new SqlParameter("@canumber" , obj.canumber )   ,
			   new SqlParameter("@amount " , obj.amount )   ,
			   new SqlParameter("@referenceid", obj.referenceid )   ,
			   new SqlParameter("@latitude" , obj.latitude)   ,
			   new SqlParameter("@longitude" , obj.longitude)   ,
			   new SqlParameter("@mode" , obj.mode )   ,
			   new SqlParameter("@billAmount " , obj.billAmount )   ,
			   new SqlParameter("@billnetamount " , obj.billnetamount )   ,
			   new SqlParameter("@billdate" , obj.billdate )   ,
			   new SqlParameter("@dueDate" , obj.dueDate )   ,
			   new SqlParameter("@acceptPayment" , obj.acceptPayment )   ,
			   new SqlParameter("@acceptPartPay" , obj.acceptPartPay )   ,
			   new SqlParameter("@cellNumber" , obj.cellNumber )   ,
			   new SqlParameter("@userName " , obj.userName )   ,
			   new SqlParameter("@status " , obj.status )   ,
			   new SqlParameter("@response_code" , obj.response_code )   ,
			   new SqlParameter("@operatorid " , obj.operatorid )   ,
			   new SqlParameter("@ackno " , obj.ackno )   ,
			   new SqlParameter("@opening " , obj.opening )   ,
			   new SqlParameter("@closing " , obj.closing )   ,
			   new SqlParameter("@message " , obj.message )



			};
			dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
			return dt;
		}
		public DataTable InsertElectricityDetailsForApi(BBPSInsertApiCls obj)
		{
			DataTable dt = new DataTable();
			SqlParameter[] parm = new SqlParameter[] {

			   new SqlParameter("@Action" , "E" )   ,
			   new SqlParameter("@operator" , obj.@operator )   ,
			   new SqlParameter("@UserId" ,  obj.UserId)   ,
			   new SqlParameter("@canumber" , obj.canumber )   ,
			   new SqlParameter("@amount " , obj.amount )   ,
			   new SqlParameter("@referenceid", obj.referenceid )   ,
			   new SqlParameter("@latitude" , obj.latitude)   ,
			   new SqlParameter("@longitude" , obj.longitude)   ,
			   new SqlParameter("@mode" , obj.mode )   ,
			   new SqlParameter("@billAmount " , obj.billAmount )   ,
			   new SqlParameter("@billnetamount " , obj.billnetamount )   ,
			   new SqlParameter("@billdate" , obj.billdate )   ,
			   new SqlParameter("@dueDate" , obj.dueDate )   ,
			   new SqlParameter("@acceptPayment" , obj.acceptPayment )   ,
			   new SqlParameter("@acceptPartPay" , obj.acceptPartPay )   ,
			   new SqlParameter("@cellNumber" , obj.cellNumber )   ,
			   new SqlParameter("@userName " , obj.userName )   ,
			   new SqlParameter("@status " , obj.status )   ,
			   new SqlParameter("@response_code" , obj.response_code )   ,
			   new SqlParameter("@operatorid " , obj.operatorid )   ,
			   new SqlParameter("@ackno " , obj.ackno )   ,
			   new SqlParameter("@opening " , obj.opening )   ,
			   new SqlParameter("@closing " , obj.closing )   ,
			   new SqlParameter("@message " , obj.message )
			};
			dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
			return dt;
		}

		#endregion


	}
}
