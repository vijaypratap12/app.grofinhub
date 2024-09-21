using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SportsBattle.Models
{

    public class clsAdminLogic
    {
        DBHelper db = new DBHelper();

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
        public DataTable GetAdminDetails(string UserId, string Password, string IpAddress, string BrowserName, string OSName)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action","GetLoginAdminDetails"),
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@Password", Password),
                new SqlParameter("@IpAddress", IpAddress),
                new SqlParameter("@BrowserName", BrowserName),
                new SqlParameter("@OSName", OSName),
            };
            dt = db.ExecProcDataTable("USP_GetAdministratorLogin", parm);
            return dt;
        }
        public DataTable AddBanner(clsBanner obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@id",obj.Id),
                new SqlParameter("@ImageURL",obj.ImageURL),

            };
            dt = db.ExecProcDataTable("USP_BannerDetails", parm);
            return dt;
        }
        public DataTable PlayerDetails(clsPlayer obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action","GetUser"),
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate",obj.ToDate),

            };
            dt = db.ExecProcDataTable("USP_PlayerDetails", parm);
            return dt;
        }
        public DataTable PlayerAllDetails(clsPlayer obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action","GetAlluser"),
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate",obj.ToDate),

            };
            dt = db.ExecProcDataTable("USP_PlayerDetails", parm);
            return dt;
        }
        public DataSet UserHistory(clsPlayer obj)
        {
            DataSet dt = new DataSet();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@UserID",obj.UserID),
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate",obj.ToDate),
                new SqlParameter("@ChallengeId",obj.ChallengeId),

            };
            dt = db.ExecProcDataSet("USP_PlayerDetails", parm);
            return dt;
        }

        public int InsertError(string message)
        {
           int res  = db.InsertErrorDatabase(message);
            return res;
        }
        public DataTable GetDashbordDetails(string action)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",action),
            };
            dt = db.ExecProcDataTable("USP_AdminDetails", parm);
            return dt;
        }
        public DataTable WithdrawDetails(clsWithdraw obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate",obj.ToDate),
                new SqlParameter("@UserId",obj.UserId),
                new SqlParameter("@Status",obj.Status),
                new SqlParameter("@TransferId",obj.TransferId),
                new SqlParameter("@TransferRemark",obj.TransferRemark),
                new SqlParameter("@ProofId",obj.ProofId),
            };
            dt = db.ExecProcDataTable("USP_WithdrawDetails", parm);
            return dt;
        }
        public DataTable Commission(clsCommission obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@Commission",obj.Commission),
                new SqlParameter("@ImageURL",obj.ImageURL),
                new SqlParameter("@IsPopup",obj.IsPopup),
                 new SqlParameter("@IsAppUnderMaintance",obj.IsAppUnderMaintance),
                new SqlParameter("@RefferalCommission",obj.RefferalCommission),
            };
            dt = db.ExecProcDataTable("USP_BannerDetails", parm);
            return dt;
        }

        public DataTable Notification(clsNotification obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@NotificationTitle",obj.NotificationTitle),
                new SqlParameter("@NotificationDescription",obj.NotificationDescription),
                new SqlParameter("@ImageURL",obj.ImageURL),
                new SqlParameter("@Type",obj.Type),
                new SqlParameter("@UserId",obj.UserId),
                new SqlParameter("@Id",obj.Id),

            };
            //dt = db.ExecProcDataTable("USP_SendNotification", parm);
            return dt;
        }

        public DataTable AdminDashboard(clsHomePageDetails obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@WhatsappNo", obj.WhatsappNo),
                new SqlParameter("@WhatsappLink", obj.WhatsappLink),
                new SqlParameter("@YouTubeLink", obj.YouTubeLink),
                new SqlParameter("@FacebookLink", obj.FacebookLink),
                new SqlParameter("@TelegramLink", obj.TelegramLink),
                new SqlParameter("@InstagramLink", obj.InstagramLink),
                new SqlParameter("@Id", obj.Id),
            };
            dt = db.ExecProcDataTable("USP_AdminDetails", parm);
            return dt;
        }

        public DataTable AdminCommissionReport(clsAdminCommissionReport obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate",obj.ToDate),
                new SqlParameter("@NewPassword",obj.NewPassword),
                new SqlParameter("@OldPassword",obj.OldPassword),
            };
            dt = db.ExecProcDataTable("USP_AdminDetails", parm);
            return dt;
        }

        #region nadeem 
        internal DataTable BindQualificationDropDown()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT '' AS Id,'Select Qualification' AS QaulificationName UNION ALL select Id, QaulificationName from tbl_qualification";
            dt = db.ExecAdaptorDataTable(Query);
            return dt;
        }

        internal DataTable BindStateDropDown()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT '' AS Id,'Select State' AS StateName UNION ALL select Id,StateName from tbl_State";
            dt = db.ExecAdaptorDataTable(Query);
            return dt;
        }

        internal DataTable BindDistrictDropDown(string StateId)
        {
            DataTable dt = new DataTable();
            string Query = "SELECT '' AS Id,'Select District' AS DistrictName UNION ALL select Id,DistrictName from tbl_District where StateId=" + StateId + "";
            dt = db.ExecAdaptorDataTable(Query);
            return dt;
        }



        internal DataTable BindBlockDropDown(string DistrictCode)
        {
            DataTable dt = new DataTable();
            string Query = "SELECT '' AS Id,'Select Block' AS BlockName UNION ALL select Id,BlockName from tbl_Block where DistrictId=" + DistrictCode + "";
            dt = db.ExecAdaptorDataTable(Query);
            return dt;
        }



        public DataTable InsertupdateregistrationNew(RegistrationCls obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                 new SqlParameter("@Name",obj.Name),
                 new SqlParameter("@Mobile",obj.Mobile),
                 new SqlParameter("@State",obj.State),
                 new SqlParameter("@District",obj.District),
                 new SqlParameter("@Address",obj.Address),
                 new SqlParameter("@Block",obj.Block),
                  new SqlParameter("@Password",obj.Password),
                 new SqlParameter("@AadharCard",obj.AadharCard),
                 new SqlParameter("@PanCard",obj.PanCard),
                 new SqlParameter("@Qualification",obj.Qualification),
                new SqlParameter("@AssociateCompany",obj.AssociateCompany),
                 new SqlParameter("@AssociateCompanyAgent",obj.AssociateCompanyAgent),
                 new SqlParameter("@StateId",obj.StateId),
                 new SqlParameter("@DistrictId",obj.DistrictId),
                 new SqlParameter("@BlockId",obj.BlockId),
                 new SqlParameter("@Dob",obj.Dob),
                 new SqlParameter("@Qualification1",obj.Qualification1),
                 new SqlParameter("@AssociateMutual",obj.AssociateMutual),
                 new SqlParameter("@EntryBy",obj.EntryBy),

                    new SqlParameter("@BankId",obj.BankId),
                   new SqlParameter("@AccountNo",obj.AccountNo),
                   new SqlParameter("@IFSCCode",obj.IFSCCode),
                   new SqlParameter("@AccountHolderName",obj.AccountHolderName),
                   new SqlParameter("@AadharNo",obj.AadharNo),
                   new SqlParameter("@PANNo",obj.PANNo),


            };
            dt = db.ExecProcDataTable("Usp_Registration", parm);
            return dt;
        }


        internal DataTable BindBankdetailDropDown()
        {
            DataTable dt = new DataTable();
            string Query = "select 0 as Id,'Select Bank' as BankName union all select Id,BankName from tbl_Bankmaster";
            dt = db.ExecAdaptorDataTable(Query);
            return dt;
        }


        public DataTable InsertupdateregistrationRemitter(RegisterRemitercls obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",obj.Action),
                 new SqlParameter("@Firstname",obj.FirstName),
                 new SqlParameter("@Lastname",obj.LastName),
                 new SqlParameter("@Address",obj.Address),
                 new SqlParameter("@Otp",obj.OTP),
                 new SqlParameter("@Pincode",obj.Pincode),
                 new SqlParameter("@Stateresp",obj.Stateresp),
                  new SqlParameter("@Bank3_flag",obj.Bank3_flag),
                 new SqlParameter("@dob",obj.dob),
                 new SqlParameter("@gst_state",obj.gst_state),



            };
            dt = db.ExecProcDataTable("proc_registerremitter", parm);
            return dt;
        }

        #endregion

        #region  02/03/2023

        //public DataTable InsertTransaction(Transactioncls obj , TransactionstatusData ob )
        //{
        //    DataTable dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[] {
        //        new SqlParameter("@ReferenceId",obj.Referenceid),
        //        new SqlParameter("@Pincode",obj.Pincode),
        //         new SqlParameter("@MobileNo",obj.Mobile),
        //         new SqlParameter("@Pipe",obj.Pipe),
        //         new SqlParameter("@Address",obj.Address),
        //         new SqlParameter("@Gst_State",obj.Gst_state),
        //         new SqlParameter("@bene_id",obj.Bene_id),
        //          new SqlParameter("@Txntype",obj.TxnType),
        //         new SqlParameter("@Amount",obj.Amount),
        //         new SqlParameter("@bankid",obj.Bankid),



        //    };
        //    dt = db.ExecProcDataTable("sp_transaction", parm);
        //    return dt;
        //}

        public DataTable InsertTransaction(Transactioncls obj, RootTransaction ob, string userid)
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
                 new SqlParameter("@tnx_status",ob.txn_status),
                 new SqlParameter("@utr",ob.utr),
                 new SqlParameter("@paysprint_share",ob.paysprint_share),
                 new SqlParameter("@balance",ob.balance),
                 new SqlParameter("@account_number",ob.account_number),
                 new SqlParameter("@tds",ob.tds),
                 new SqlParameter("@gst",ob.gst),
                 new SqlParameter("@customercharge",ob.customercharge),
                 new SqlParameter("@benename",ob.benename),
                 new SqlParameter("@ackno",ob.ackno),
                 new SqlParameter("@message",ob.message),
                 new SqlParameter("@userid",userid)



            };
            dt = db.ExecProcDataTable("sp_transaction", parm);
            return dt;
        }


        #endregion

        #region Atul Singh 2023/03/02

        public DataTable DeleteBeneficiary(string mob)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@mobile",mob),
            };
            dt = db.ExecProcDataTable("sp_deleteBeneficiary", parm);
            return dt;
        }
        public DataTable InsertBeneficiary(RootBeneficiaryRegister p, string sAgentID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@pincode",p.pincode),
                new SqlParameter("@address",p.address),
                new SqlParameter("@dob",p.dob),
                new SqlParameter("@gst_state",p.gst_state),
                new SqlParameter("@verified",p.verified),
                new SqlParameter("@ifsccode",p.ifsccode),
                new SqlParameter("@accno",p.accno),
                new SqlParameter("@bankid",p.bankid),
                new SqlParameter("@benename",p.benename),
                new SqlParameter("@mobile",p.mobile),
                new SqlParameter("@action",1),
                new SqlParameter("@agentID", sAgentID)
            };
            dt = db.ExecProcDataTable("proc_AddBeneficiaryRegistration", parm);
            return dt;
        }

        public DataTable WaterBillPay(WaterBillPayInpt p, WaterBillPayRes racc)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@pincode",p.pincode),
                //new SqlParameter("@address",p.address),
                //new SqlParameter("@dob",p.dob),
                //new SqlParameter("@gst_state",p.gst_state),
                //new SqlParameter("@verified",p.verified),
                //new SqlParameter("@ifsccode",p.ifsccode),
                //new SqlParameter("@accno",p.accno),
                //new SqlParameter("@bankid",p.bankid),
                //new SqlParameter("@benename",p.benename),
                //new SqlParameter("@mobile",p.mobile),
                new SqlParameter("@action",1),
                new SqlParameter("@ackno",racc.ackno),
                new SqlParameter("@operatorid",racc.operatorid),
                new SqlParameter("@response_code",racc.response_code),
                new SqlParameter("@status",racc.status),
                new SqlParameter("@longitude",p.longitude),
                new SqlParameter("@latitude",p.latitude),
                new SqlParameter("@referenceid",p.referenceid),
                new SqlParameter("@ad3",p.ad3),
                new SqlParameter("@ad2",p.ad2),
                new SqlParameter("@ad1",p.ad1),
                new SqlParameter("@amount",p.amount),
                new SqlParameter("@operator",p.@operator),
                new SqlParameter("@canumber",p.canumber)

            };
            dt = db.ExecProcDataTable("sp_WaterDetails", parm);
            return dt;
        }
        #endregion


        #region   14/03/2023 shani   
        public DataTable GetTransactionList()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

            };
            dt = db.ExecProcDataTable("sp_transaction_report", parm);
            return dt;
        }

        public DataTable RemitterReport()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

            };
            dt = db.ExecProcDataTable("sp_Remitter_List", parm);
            return dt;
        }

        //public DataTable BeneficiaryReport()
        //{
        //    DataTable dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[] {

        //    };
        //    dt = db.ExecProcDataTable("sp_Register_BeneficiaryList", parm);
        //    return dt;
        //}

        //public DataTable RechargeList()
        //{
        //    DataTable dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[] {

        //    };
        //    dt = db.ExecProcDataTable("sp_RechargeReport", parm);
        //    return dt;
        //}
        #endregion

        #region dorecharge[mobile] 2023/03/15

        public DataTable DoRecharge(RootDoRecharge p, RootResMobRecharg racc, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@MobileNo",p.canumber),
                new SqlParameter("@ReferenceID",p.referenceid),
                new SqlParameter("@Amount",p.amount),
                new SqlParameter("@ackno",racc.ackno),
                new SqlParameter("@ResponseCode",racc.response_code),
                new SqlParameter("@Status",racc.status),
                new SqlParameter("@OperatorID",racc.operatorid),
                 new SqlParameter("@Message",racc.message),
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type", "DTH")


            };
            dt = db.ExecProcDataTable("sp_customerRecharge", parm);
            return dt;
        }
        #endregion

        // cls admin logic


        #region  2023/03/21
        public DataTable PanUrlEncdata(PanBody p, string url, string encdata)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@url",url),
                new SqlParameter("@encdata",encdata),

                new SqlParameter("@refid",p.refid),
                new SqlParameter("@title",p.title),
                new SqlParameter("@email",p.email),
                new SqlParameter("@gender",p.gender),
                new SqlParameter("@mode",p.mode),
                new SqlParameter("@lname",p.lastname),
                new SqlParameter("@mname",p.middlename),
                new SqlParameter("@fname",p.firstname)

            };
            dt = db.ExecProcDataTable("PanUrlEncdata", parm);
            return dt;
        }

        public DataTable LicBillPayDetails(RootBodyLic racc, RootLicBillPayRes p)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@canumber",racc.canumber),
                new SqlParameter("@mode",racc.mode),

                new SqlParameter("@amount",racc.amount),
                new SqlParameter("@ad1",racc.ad1),
                new SqlParameter("@ad2",racc.ad2),
                new SqlParameter("@ad3",racc.ad3),
                new SqlParameter("@referenceid",racc.referenceid),
                new SqlParameter("@latitude",racc.latitude),
                new SqlParameter("@longitude",racc.longitude),
                new SqlParameter("@billnumber",racc.bill_fetch.billNumber),
                new SqlParameter("@billamount",racc.bill_fetch.billAmount),
                new SqlParameter("@billnetamount",racc.bill_fetch.billnetamount),
                new SqlParameter("@billdate",racc.bill_fetch.billdate),
                new SqlParameter("@acceptpayment",racc.bill_fetch.acceptPayment),
                new SqlParameter("@acceptpartpay",racc.bill_fetch.acceptPartPay),
                new SqlParameter("@cellnumber",racc.bill_fetch.cellNumber),
                new SqlParameter("@duefrom",racc.bill_fetch.dueFrom),
                new SqlParameter("@dueto",racc.bill_fetch.dueTo),
                new SqlParameter("@validationId",racc.bill_fetch.validationId),
                new SqlParameter("@billid",racc.bill_fetch.billId),
                new SqlParameter("@status",p.status),
                new SqlParameter("@operatorid",p.operatorid),
                new SqlParameter("@ackno",p.ackno),
                new SqlParameter("@message",p.message),
                 new SqlParameter("@response_code",p.response_code)

            };
            dt = db.ExecProcDataTable("sp_LicBillPayDetails", parm);
            return dt;
        }
        #endregion

        #region REport 2023/03/24
        public DataTable PanReport1(string action, string FormDate, string ToDate, string PartnerID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@FromDate",FormDate =="" ? null:FormDate),
                 new SqlParameter("@ToDate",ToDate =="" ? null:ToDate),
                 new SqlParameter("@userid", PartnerID),
            };
            dt = db.ExecProcDataTable("sp_AllReports", parm);
            return dt;
        }

        #endregion
        #region manage user 2023/03/25
        public DataTable ManageUser(string id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@id",id)


            };
            dt = db.ExecProcDataTable("sp_ManageUser", parm);
            return dt;
        }
        public DataTable SaveDocDetails(SaveComplianceAllDetailsPara p)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action","1"),
                new SqlParameter("@Aadharno",p.Adharno),
                new SqlParameter("@AadharPicFront",p.AdharPicFrontfilename),
                new SqlParameter("@AadharPicBack",p.AdharPicBackfilename),
                new SqlParameter("@Panno",p.Panno),
                new SqlParameter("@PanPicFront",p.PanPicFrontfilename),
                new SqlParameter("@PanPicBack",p.PanPicBackfilename),
                new SqlParameter("@Ad1",p.Ad1),
                new SqlParameter("@Ad1PicFront",p.Ad1PicFrontfilename),
                new SqlParameter("@Ad1PicBack",p.Ad1PicBackfilename),
                new SqlParameter("@Ad2",p.Ad2),
                new SqlParameter("@Ad2PicFront",p.Ad2PicFrontfilename),
                new SqlParameter("@Ad2PicBack",p.Ad2PicBackfilename),
                new SqlParameter("@Ad3",p.Ad3),
                new SqlParameter("@Ad3PicFront",p.Ad3PicFrontfilename),
                new SqlParameter("@Ad3PicBack",p.Ad3PicBackfilename),
                new SqlParameter("@Userid",p.UserId),
                new SqlParameter("@Mobile",p.Mobile),
                new SqlParameter("@Email",p.Email),
                new SqlParameter("@Billno",p.BillNo),
                new SqlParameter("@DocType",p.DocType),
                new SqlParameter("@EntryType","WEB"),
                new SqlParameter("@Ad4",p.Ad4),
                new SqlParameter("@Ad4PicFront",p.Ad4PicFrontfilename),
                new SqlParameter("@Ad4PicBack",p.Ad4PicBackfilename),
                new SqlParameter("@Ad5",p.Ad5),
                new SqlParameter("@Ad5PicFront",p.Ad5PicFrontfilename),
                new SqlParameter("@Ad5PicBack",p.Ad5PicBackfilename),

                new SqlParameter("@Ad6",p.Ad6),
                new SqlParameter("@Ad6PicFront",p.Ad6PicFrontfilename),
                new SqlParameter("@Ad6PicBack",p.Ad6PicBackfilename),


                new SqlParameter("@Ad7",p.Ad7),
                new SqlParameter("@Ad7PicFront",p.Ad7PicFrontfilename),
                new SqlParameter("@Ad7PicBack",p.Ad7PicBackfilename),



                new SqlParameter("@Ad8",p.Ad8),
                new SqlParameter("@Ad8PicFront",p.Ad8PicFrontfilename),
                new SqlParameter("@Ad8PicBack",p.Ad8PicBackfilename),



                new SqlParameter("@Ad9",p.Ad9),
                new SqlParameter("@Ad9PicFront",p.Ad9PicFrontfilename),
                new SqlParameter("@Ad9PicBack",p.Ad9PicBackfilename),



                new SqlParameter("@Ad10",p.Ad10),
                new SqlParameter("@Ad10PicFront",p.Ad10PicFrontfilename),
                new SqlParameter("@Ad10PicBack",p.Ad10PicBackfilename),

                 new SqlParameter("@name",p.name),
                new SqlParameter("@address",p.address),
                new SqlParameter("@income",p.income)


            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }
        #endregion
        #region 25/03/2023

        public DataTable AddCommission(Commission obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@CommissionPer",obj.commissonPer),
                 new SqlParameter("@EntryBy",obj.EntryBy)

            };
            dt = db.ExecProcDataTable("sp_commission", parm);
            return dt;
        }
        #endregion

        #region 2023/03/27
        public DataTable UserMenuPermission(string action)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action",action)
            };
            dt = db.ExecProcDataTable("sp_menupermission", parm);
            return dt;
        }

        public DataTable UserMenuPermission(string menu, string id, string action)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action",action),
                new SqlParameter("@menu",menu),
                new SqlParameter("@userid",id)
            };
            dt = db.ExecProcDataTable("sp_menupermission", parm);
            return dt;
        }
        public DataTable UserMenuPermission(string action, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action",action),
                new SqlParameter("@userid",userid)
            };
            dt = db.ExecProcDataTable("sp_menupermission", parm);
            return dt;
        }
        #endregion

        #region 27/03/2023 

        public DataTable PartnerWallet()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action","1")

            };
            dt = db.ExecProcDataTable("sp_wallet", parm);
            return dt;
        }

        public DataTable PartnerRecharge(PartnerRecharge obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@WalletAmt",obj.WalletAmt),
                new SqlParameter("@ApesAmt",obj.APESAmt),
                new SqlParameter("@Id",obj.Id)

            };
            dt = db.ExecProcDataTable("sp_RechargeWallet", parm);
            return dt;
        }

        #endregion



        public DataTable Savebil_paydetails(PayBillModel obj, BillPayResponse req)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@operatorId",obj.OperatorID),
                //new SqlParameter("@Amount",obj.Amount),
                //new SqlParameter("@CaNumber",obj.Canumber),
                //new SqlParameter("@Mode",obj.Mode),
                //new SqlParameter("Name",obj.UserName),
                //new SqlParameter("@Longitude",obj.Longitude),
                //new SqlParameter("@Latitude",obj.Latitude),
                //new SqlParameter("@ReferenceID",obj.Referenceid),
                //new SqlParameter("@DueDate",obj.DueDate),
                //new SqlParameter("@closing",req.closing),
                //new SqlParameter("@opening",req.opening),
                //new SqlParameter("@operatorId",req.operatorid),
                //new SqlParameter("@Msg",req.message),
                //new SqlParameter("@status",req.status),
                //new SqlParameter("@ackno",req.ackno)


                new SqlParameter("@Action","B"),
                new SqlParameter("@amount",obj.Amount),
                new SqlParameter("@canumber",obj.Canumber),
                new SqlParameter("@mode",obj.Mode),
                new SqlParameter("@userName",obj.UserName),
                new SqlParameter("@longitude",obj.Longitude),
                new SqlParameter("@latitude",obj.Latitude),
                new SqlParameter("@referenceid",obj.Referenceid),
                new SqlParameter("@dueDate",obj.DueDate),
                new SqlParameter("@closing",req.closing),
                new SqlParameter("@opening",req.opening),
                new SqlParameter("@operatorid",req.operatorid),
                new SqlParameter("@message",req.message),
                new SqlParameter("@status",req.status),
                new SqlParameter("@ackno",req.ackno),
                new SqlParameter("@Ad1",obj.Ad1),
                new SqlParameter("@Ad2",obj.Ad2),
                new SqlParameter("@Ad3",obj.Ad3)

            };
            dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
            return dt;
        }

        public DataTable SaveDocDetails(string userid, string action, string doctype)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",action),
                new SqlParameter("@Userid",userid),
                new SqlParameter("@DocType",doctype)
            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }

        #region 2023/03/29

        public DataTable ServiecsCommission()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@Action","1")


            };
            dt = db.ExecProcDataTable("sp_ServiecsCommission", parm);
            return dt;
        }
        public DataTable ServiecsCommission(UserCommissionBody p)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@Action",p.Action),
                 new SqlParameter("@Id",p.Id),
                 new SqlParameter("@Dmt",p.Dmt),
                 new SqlParameter("@Aeps",p.Aeps),
                 new SqlParameter("@Matm",p.Matm),
                 new SqlParameter("@Bbps",p.Bbps),
                 new SqlParameter("@Recharge",p.Recharge),
                 new SqlParameter("@Dth",p.Dth),
                 new SqlParameter("@Electricity",p.Electricity),
                 new SqlParameter("@Fastag",p.Fastag),
                 new SqlParameter("@Waterbill",p.Waterbill),
                 new SqlParameter("@Muncipality",p.Muncipality),
                 new SqlParameter("@Lic",p.Lic),
                 new SqlParameter("@Pan",p.Pan),
                 new SqlParameter("@Epfo",p.Epfo),
                 new SqlParameter("@Lpg",p.Lpg),
                 new SqlParameter("@Irctc",p.Irctc),
                 new SqlParameter("@Flight",p.Flight),
                 new SqlParameter("@Bus",p.Bus),
                 new SqlParameter("@Hotel",p.Hotel),
                 new SqlParameter("@Holidaysbooking",p.Holidaysbooking)


            };
            dt = db.ExecProcDataTable("sp_ServiecsCommission", parm);
            return dt;
        }



        #endregion

        public DataTable BillPayReport(string FormDate, string ToDate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@Action",obj.Action),
                //new SqlParameter("@id",obj.Id),
                //new SqlParameter("@ImageURL",obj.ImageURL),
                 new SqlParameter("@FromDate",FormDate =="" ? null:FormDate),
                 new SqlParameter("@ToDate",ToDate =="" ? null:ToDate),
            };
            dt = db.ExecProcDataTable("sp_BilPayReport", parm);
            return dt;
        }

        #region 29/03/2023
        public DataTable saveusercomplain(usercomplain obj, string action)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",action),
                new SqlParameter("@Title",obj.Title),
                new SqlParameter("@Description",obj.Description),
                new SqlParameter("@UserID",obj.UseriID),
                new SqlParameter("@ServiceId",obj.serviceId),
            };
            dt = db.ExecProcDataTable("sp_complainuserdetails", parm);
            return dt;
        }


        public DataTable usercomplain_Report()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
              // new SqlParameter("@UserID",obj.UseriID),
            };
            dt = db.ExecProcDataTable("sp_Usercomplain_Report", parm);
            return dt;
        }

        #endregion


        public DataTable uploadvideolink(uploadvideoCls obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Link",obj.Title),
                new SqlParameter("@Description",obj.Description),
                new SqlParameter("@UserID",obj.UseriID),
                new SqlParameter("@ServiceType", obj.ServiceType),
            };
            dt = db.ExecProcDataTable("sp_uploadvidolink", parm);
            return dt;
        }
        public DataTable uploadvideolink()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
              new SqlParameter("@action",1)
            };
            dt = db.ExecProcDataTable("sp_videouploadList", parm);
            return dt;
        }


        public DataTable Paysprintaddmount(PaysprintRecharge obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action",1),
                new SqlParameter("@Amount",obj.Amount),
            };
            dt = db.ExecProcDataTable("sp_AddPaysprtamount", parm);
            return dt;
        }

        public DataTable PaysprintwalletList()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@Action",2),

            };
            dt = db.ExecProcDataTable("sp_AddPaysprtamount", parm);
            return dt;
        }

        public DataTable mailwallet()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@Action",3),

            };
            dt = db.ExecProcDataTable("sp_AddPaysprtamount", parm);
            return dt;
        }



        public DataTable SaveDocDetails(MemberDetails p)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",p.Action),
                new SqlParameter("@FromDate",p.FromDate),
                new SqlParameter("@Todate",p.ToDate)


            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }

        #region [MemberKYC] 2023/04/10


        public DataTable KYCDetails(KYCDetailsBody p)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@partnerid",p.Partnerid),
                new SqlParameter("@BankName",p.Bankname),
                new SqlParameter("@BankHolderName",p.Bankholdername),
                new SqlParameter("@BankAccountNo",p.Bankaccountno),
                new SqlParameter("@IFSCCode",p.Ifsccode),
                new SqlParameter("@Aadharpicfront",p.Aadharpicfrontname),
                new SqlParameter("@AadharpicBack",p.Aadharpicbackname),
                new SqlParameter("@PanpicFront",p.Panpicfrontname),
                new SqlParameter("@PanpicBack",p.Panpicbackname),
                new SqlParameter("@PanNo",p.PanNo),
                new SqlParameter("@AadhaarNo",p.AadhaarNo),
                new SqlParameter("@Action",p.Action)


            };
            dt = db.ExecProcDataTable("sp_KYCDetails", parm);
            return dt;
        }


        #endregion

        #region [MemberKYC] 2023/04/10


        public DataSet GetMasterDetails(string action)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action)

            };
            ds = db.ExecProcDataSet("sp_AllReports", parm);
            return ds;
        }
        public DataTable GetMasterDetails(string action, string state, string district, string block)
        {
            DataTable ds = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@stateid",state),
                 new SqlParameter("@districtid",district),
                 new SqlParameter("@blockid",block)

            };
            ds = db.ExecProcDataTable("sp_AllReports", parm);
            return ds;
        }
        #endregion
        #region [New Member Permission] 2023/04/11


        public DataSet NewMemberAllotPermission(string action)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action)

            };
            ds = db.ExecProcDataSet("sp_newmemberpermission", parm);
            return ds;
        }
        public DataTable NewMemberAllotPermission(string action, string Partenerid, string role)
        {
            DataTable ds = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@agentid",Partenerid),
                 new SqlParameter("@role",role)

            };
            ds = db.ExecProcDataTable("sp_newmemberpermission", parm);
            return ds;
        }

        #endregion

        #region [MemberKYC] 2023/04/12
        public DataTable DoRechargeEnquiry(DoRechargeEnqueryres res)
        {
            DataTable ds = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",res.action),
                 new SqlParameter("@status",res.data.status),
                 new SqlParameter("@message",res.message),
                 new SqlParameter("@referenceid",res.data.refid)




            };
            ds = db.ExecProcDataTable("sp_refundStates", parm);
            return ds;
        }
        #endregion



        #region banklist 2023/04/19
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
        public DataTable InsertGSTState(string StateId, string StateName, string Action)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Name",StateName),
                new SqlParameter("@Id",StateId),
                new SqlParameter("@Action",Action)
            };

                dt = db.ExecProcDataTable("MSP_GSTState", parm);
                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion



        #region UserTaransactionReport 2023/04/26
        public DataTable GetTransactionList(string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@UserId",userid),
                 new SqlParameter("@action",1)
            };
            dt = db.ExecProcDataTable("sp_transaction_report", parm);
            return dt;
        }
        public DataTable RechargeList(string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@UserId",userid),
                 new SqlParameter("@action",1)
            };
            dt = db.ExecProcDataTable("sp_RechargeReport", parm);
            return dt;
        }

        public DataTable PanReport(string action, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@userid",userid)

            };
            dt = db.ExecProcDataTable("sp_AllReports", parm);
            return dt;
        }
        public DataTable BillPayReport(string userid, string FormDate, string ToDate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action",1),
                new SqlParameter("@userid",userid),
                  new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                  new SqlParameter("@Todate",ToDate=="" ? null: ToDate),

            };
            dt = db.ExecProcDataTable("sp_BilPayReport", parm);
            return dt;
        }

        #endregion
        #region shani 26/04/2023

        public DataTable GetDetailsQueryRemitter(string userid)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@UserID",userid),

            };

                dt = db.ExecProcDataTable("USP_GetDetailsAssosiate", parm);
                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
        #region wallet 2023/04/27
        public DataTable GETWallet(string action)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action)

            };
            dt = db.ExecProcDataTable("sp_wallet", parm);
            return dt;
        }
        #endregion
        #region wallet 2023/04/29
        public DataTable GETWalletUserWalletByUserId(string action, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@userid",userid)

            };
            dt = db.ExecProcDataTable("UB_SP_GetUserWallet", parm);
            return dt;
        }


        #endregion
        #region update userwallet 2023/04/29

        public DataTable UpdateUserWallet(string userid, string amount, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@amount",amount)
            };
            dt = db.ExecProcDataTable("WB_SP_UserMainWalletHistory", parm);
            return dt;
        }

        #endregion
        #region getreference id by userid 
        public DataTable GetReferenceIdByuserUd(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type)

            };
            dt = db.ExecProcDataTable("Ref_SP_GetReferenceId", parm);
            return dt;
        }



        public DataTable GetReferenceIdDMTTransaction(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","DMT")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }

        public DataTable GetMobileRechargeDetails(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                    new SqlParameter("@type",type),
                 new SqlParameter("@Action","Mobile")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }

        #endregion

        #region 02/05/2023

        public DataTable saveRecordElectricityDetails(PayBillModel obj, BillPayResponse req)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@operatorId",obj.OperatorID),
                //new SqlParameter("@Amount",obj.Amount),
                //new SqlParameter("@CaNumber",obj.Canumber),
                //new SqlParameter("@Mode",obj.Mode),
                //new SqlParameter("Name",obj.UserName),
                //new SqlParameter("@Longitude",obj.Longitude),
                //new SqlParameter("@Latitude",obj.Latitude),
                //new SqlParameter("@ReferenceID",obj.Referenceid),
                //new SqlParameter("@DueDate",obj.DueDate),
                //new SqlParameter("@closing",req.closing),
                //new SqlParameter("@opening",req.opening),
                //new SqlParameter("@operatorId",req.operatorid),
                //new SqlParameter("@Msg",req.message),
                //new SqlParameter("@status",req.status),
                //new SqlParameter("@ackno",req.ackno)


                new SqlParameter("@Action","E"),
                new SqlParameter("@amount",obj.Amount),
                new SqlParameter("@canumber",obj.Canumber),
                new SqlParameter("@mode",obj.Mode),
                new SqlParameter("@userName",obj.UserName),
                new SqlParameter("@longitude",obj.Longitude),
                new SqlParameter("@latitude",obj.Latitude),
                new SqlParameter("@referenceid",obj.Referenceid),
                new SqlParameter("@dueDate",obj.DueDate),
                new SqlParameter("@closing",req.closing),
                new SqlParameter("@opening",req.opening),
                new SqlParameter("@operatorid",req.operatorid),
                new SqlParameter("@message",req.message),
                new SqlParameter("@status",req.status),
                new SqlParameter("@ackno",req.ackno),
                  new SqlParameter("@Ad1",obj.Ad1),
                new SqlParameter("@Ad2",obj.Ad2),
                new SqlParameter("@Ad3",obj.Ad3)

            };
            dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
            return dt;
        }



        #endregion


        #region 02/05/2023

        public DataTable SaveRecordLPGDetails(PayBillModel obj, BillPayResponse req)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@operatorId",obj.OperatorID),
                //new SqlParameter("@Amount",obj.Amount),
                //new SqlParameter("@CaNumber",obj.Canumber),
                //new SqlParameter("@Mode",obj.Mode),
                //new SqlParameter("Name",obj.UserName),
                //new SqlParameter("@Longitude",obj.Longitude),
                //new SqlParameter("@Latitude",obj.Latitude),
                //new SqlParameter("@ReferenceID",obj.Referenceid),
                //new SqlParameter("@DueDate",obj.DueDate),
                //new SqlParameter("@closing",req.closing),
                //new SqlParameter("@opening",req.opening),
                //new SqlParameter("@operatorId",req.operatorid),
                //new SqlParameter("@Msg",req.message),
                //new SqlParameter("@status",req.status),
                //new SqlParameter("@ackno",req.ackno)


                new SqlParameter("@Action","L"),
                new SqlParameter("@amount",obj.Amount),
                new SqlParameter("@canumber",obj.Canumber),
                new SqlParameter("@mode",obj.Mode),
                new SqlParameter("@userName",obj.UserName),
                new SqlParameter("@longitude",obj.Longitude),
                new SqlParameter("@latitude",obj.Latitude),
                new SqlParameter("@referenceid",obj.Referenceid),
                new SqlParameter("@dueDate",obj.DueDate),
                new SqlParameter("@closing",req.closing),
                new SqlParameter("@opening",req.opening),
                new SqlParameter("@operatorid",req.operatorid),
                new SqlParameter("@message",req.message),
                new SqlParameter("@status",req.status),
                new SqlParameter("@ackno",req.ackno),
                  new SqlParameter("@Ad1",obj.Ad1),
                new SqlParameter("@Ad2",obj.Ad2),
                new SqlParameter("@Ad3",obj.Ad3)

            };
            dt = db.ExecProcDataTable("Usp_insertBBPSDetailsForApi", parm);
            return dt;
        }



        #endregion

        public DataTable GetReferenceIdBBPSBillDetails(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","BBPS")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }

        public DataTable GetReferencLICBillDetails(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","LIC")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }


        public DataTable GetReferencPan_Details(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","Pan")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }

        public DataTable GetReferencElectricity_Details(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","Electricity")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }


        public DataTable GetReferencLPG_Details(string userid, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),
                 new SqlParameter("@type",type),
                 new SqlParameter("@Action","LPG")

            };
            dt = db.ExecProcDataTable("sp_GetTransactionRefID", parm);
            return dt;
        }


        public DataTable BindAllservicesType()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                //new SqlParameter("@Title",obj.Title),
                //new SqlParameter("@Description",obj.Description),
                //new SqlParameter("@UserID",obj.UseriID),
            };
            dt = db.ExecProcDataTable("Usp_BindAllservicesType", parm);
            return dt;
        }

        public DataTable UserDebitBlanceforservices(string userId, string Amount, string Type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@Amount",Amount),
                 new SqlParameter("@UserId",userId),
                 new SqlParameter("@type",Type)

            };
            dt = db.ExecProcDataTable("Usp_UserDebitBlance", parm);
            return dt;
        }

        public DataTable SaveUserOnboardin(OnboardingRes p, string entryby, string partenerid)
        {
            DataTable dt;
            try
            {
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@onboard_pending", p.onboard_pending),
                 new SqlParameter("@status", p.status),
                 new SqlParameter("@responce_code",p.response_code),
                 new SqlParameter("@redirect_url",p.redirecturl),
                 new SqlParameter("@message",p.message),
                 new SqlParameter("@entryby",entryby),
                 new SqlParameter("@action",1),
                 new SqlParameter("@partenerid",partenerid)
                  };
                dt = db.ExecProcDataTable("Onboarding_SP", parm);
            }
            catch
            {
                dt = new DataTable();
            }
            return dt;
        }


        #region AdminDashboard 2023/05/06

        public DataTable AdminDashboard(string Action)
        {
            DataTable dt;
            try
            {
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action",Action)
            };
                dt = db.ExecProcDataTable("Total_Admin_Dashboard_SP", parm);
            }
            catch (Exception ex)
            {
                dt = new DataTable();
            }
            return dt;
        }
        #endregion
        public DataTable ChangePassword(ChangePasswordModel obj)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@NewPassword",obj.NewPassword),
                new SqlParameter("@OldPassword",obj.OldPassword),
                new SqlParameter("@UserId",obj.UserID),

            };
            dt = db.ExecProcDataTable("Usp_ChangPassword", parm);
            return dt;
        }
        #region [Save BBPS Bill Details 2023/05/09]
        public DataTable EntryBBPSOperatorListDetails(string id, string name, string category, string viewbill, string regex, string displayname, string ad1_d_name, string ad1_name, string ad1_regex, string ad2_d_name, string ad2_name, string ad2_regex, string ad3_d_name, string ad3_name, string ad3_regex)
        {

            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action","2"),
                 new SqlParameter("@Operator_Responce_Id",id),
                 new SqlParameter("@name",name),
                 new SqlParameter("@category",category),
                 new SqlParameter("@viewbill",viewbill),
                 new SqlParameter("@regex",regex),
                 new SqlParameter("@displayname",displayname),
                 new SqlParameter("@ad1_d_name",ad1_d_name),
                 new SqlParameter("@ad1_name",ad1_name),
                 new SqlParameter("@ad1_regex",ad1_regex),
                 new SqlParameter("@ad2_d_name",ad2_d_name),
                 new SqlParameter("@ad2_name",ad2_name),
                 new SqlParameter("@ad2_regex",ad2_regex),
                 new SqlParameter("@ad3_d_name",ad3_d_name),
                 new SqlParameter("@ad3_name",ad3_name),
                 new SqlParameter("@ad3_regex",ad3_regex)
 };
            DataTable dt = db.ExecProcDataTable("BBPSOperatorDetails_SP", parm);


            return dt;
        }
        #endregion

        public DataTable GetOpetatorDetailsByOperatorId(string OpetatorId)
        {

            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action","1"),
                 new SqlParameter("@Operator_Responce_Id",OpetatorId)
 };
            DataTable dt = db.ExecProcDataTable("BBPSOperatorDetails_SP", parm);
            return dt;
        }
        public DataTable GetMobileByUserId(string Userid)
        {

            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action","1"),
                 new SqlParameter("@Userid",Userid)
 };
            DataTable dt = db.ExecProcDataTable("Get_Mobile_by_UserId_SP", parm);
            return dt;
        }
        #region new 2023/05/17
        public DataTable UpdateDocDetailsApproveReject(string Action, string Status, string PId, string UserId)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",Action),
                new SqlParameter("@Id",PId),
                new SqlParameter("@Action_Status",Status),
                new SqlParameter("@Action_By",UserId),
            };
            dt = db.ExecProcDataTable("Manager_Action_DocDetails_SP", parm);
            return dt;
        }
        public DataTable FastTagRecharge(FastTagRechargeRequest obj, RootNewAddQueryremiter responce, string userid)
        {
            DataTable dt;
            try
            {
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action", "1"),
                new SqlParameter("@API_status", responce.status),
                new SqlParameter("@response_code", responce.response_code),
                new SqlParameter("@message",responce.message ),
                new SqlParameter("@reference_id", obj.referenceid),
                new SqlParameter("@operator", obj.@operator),
                new SqlParameter("@canumber", obj.canumber),
                new SqlParameter("@amount", obj.amount),
                new SqlParameter("@latitude", obj.latitude),
                new SqlParameter("@longitude",obj.longitude ),
                new SqlParameter("@billAmount", obj.bill_fetch.billAmount),
                new SqlParameter("@billnetamount",obj.bill_fetch.billnetamount ),
                new SqlParameter("@dueDate",obj.bill_fetch.dueDate ),
                new SqlParameter("@maxBillAmount", obj.bill_fetch.maxBillAmount),
                new SqlParameter("@acceptPayment", obj.bill_fetch.acceptPayment),
                new SqlParameter("@acceptPartPay",obj.bill_fetch.acceptPartPay ),
                new SqlParameter("@cellNumber",obj.bill_fetch.cellNumber ),
                new SqlParameter("@userName", obj.bill_fetch.userName),
                new SqlParameter("@Entry_by", userid)

                  };
                dt = db.ExecProcDataTable("Fastag_Details_SP", parm);
            }
            catch
            {
                dt = new DataTable();
            }
            return dt;
        }
        public DataTable FastTagRecharge(fastagapi1 obj)
        {
            DataTable dt;
            try
            {
                SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action", "1"),
                new SqlParameter("@API_status", obj.status),
                new SqlParameter("@response_code", obj.response_code),
                new SqlParameter("@message",obj.message ),
                new SqlParameter("@reference_id", obj.referenceid),
                new SqlParameter("@operator", obj.@operator),
                new SqlParameter("@canumber", obj.canumber),
                new SqlParameter("@amount", obj.amount),
                new SqlParameter("@latitude", obj.latitude),
                new SqlParameter("@longitude",obj.longitude ),
                new SqlParameter("@billAmount", obj.billAmount),
                new SqlParameter("@billnetamount",obj.billnetamount ),
                new SqlParameter("@dueDate",obj.dueDate ),
                new SqlParameter("@maxBillAmount", obj.maxBillAmount),
                new SqlParameter("@acceptPayment", obj.acceptPayment),
                new SqlParameter("@acceptPartPay",obj.acceptPartPay ),
                new SqlParameter("@cellNumber",obj.cellNumber ),
                new SqlParameter("@userName", obj.userName),
                new SqlParameter("@Entry_by", obj.userid)

                  };
                dt = db.ExecProcDataTable("Fastag_Details_SP", parm);
            }
            catch
            {
                dt = new DataTable();
            }
            return dt;
        }

        #endregion

        #region AEPS Withdrow

        public DataTable AEPSWithdrow(AEPSWithdrowlRes responce, AEPSWithdraw request)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {


            };
            dt = db.ExecProcDataTable("Withdrowl_Details_sp", parm);
            return dt;
        }
        #endregion
        #region shani 14/06/2023




        public DataTable GetTransactionList1(string FormDate, string ToDate, string sPartnerID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
               new  SqlParameter("@FromDate",FormDate  == "" ? null:FormDate ),
               new  SqlParameter("@ToDate",ToDate =="" ? null : ToDate),
               new  SqlParameter("@PartnerId",sPartnerID =="" ? null : sPartnerID),
            };
            dt = db.ExecProcDataTable("sp_transaction_report", parm);

            return dt;
        }
        public DataTable GetPartnerList()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
               new  SqlParameter("@action",2),
               //new  SqlParameter("@ToDate",ToDate =="" ? null : ToDate),
            };
            dt = db.ExecProcDataTable("Get_Mobile_by_UserId_SP", parm);

            return dt;
        }
        public DataTable GetTransactionList(string userid, string FormDate, string ToDate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@UserId",userid),
                new  SqlParameter("@FromDate",FormDate  == "" ? null:FormDate ),
               new  SqlParameter("@ToDate",ToDate =="" ? null : ToDate),


                 new SqlParameter("@action",1)
            };
            dt = db.ExecProcDataTable("sp_transaction_report", parm);
            return dt;
        }

        public DataTable RechargeList(string userid, string FormDate, string ToDate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@UserId",userid),
                 new SqlParameter("@FromDate",FormDate=="" ? null:FormDate),
                 new SqlParameter("@Todate",ToDate=="" ? null:ToDate),

                 new SqlParameter("@action",1)
            };
            dt = db.ExecProcDataTable("sp_RechargeReport", parm);
            return dt;
        }



        public DataTable PanReport(string action, string userid, string FormDate, string ToDate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@action",action),
                 new SqlParameter("@FromDate",FormDate=="" ? null:FormDate),
                 new SqlParameter("@Todate",ToDate=="" ? null:ToDate),
                 new SqlParameter("@userid",userid)

            };
            dt = db.ExecProcDataTable("sp_AllReports", parm);
            return dt;
        }

        public DataTable ComplainResolved(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@id",ID),
                    new SqlParameter("@Action","R"),

            };
            dt = db.ExecProcDataTable("sp_UserComplainResolvedQuery", parm);
            return dt;
        }
        public DataTable ComplainUnResolved(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@id",ID),
                new SqlParameter("@Action","UR"),

            };
            dt = db.ExecProcDataTable("sp_UserComplainResolvedQuery", parm);
            return dt;
        }


        public DataTable ViewGetMemberDocumentDetails(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Id",ID),
                new SqlParameter("@Action","8"),

            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }
        public DataTable BeneficiaryReport(string FormDate, string ToDate, string sPartnerID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@PartnerId",sPartnerID=="" ? null: sPartnerID),
            };
            dt = db.ExecProcDataTable("sp_Register_BeneficiaryList", parm);
            return dt;
        }


        public DataTable RechargeList1(string FormDate, string ToDate, string partner, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                  new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@UserId", partner==""?null:partner),
                new SqlParameter("@action", 1),
                new SqlParameter("@Type", type)
            };
            dt = db.ExecProcDataTable("sp_RechargeReport", parm);
            return dt;
        }

        #region 
        public DataTable RechargeList(string UserId, string FormDate, string ToDate, string type)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@UserId", UserId==""?null:UserId),
                new SqlParameter("@action", 1),
                new SqlParameter("@Type", type)
            };
            dt = db.ExecProcDataTable("sp_RechargeReport", parm);
            return dt;
        }
        #endregion


        public DataTable MemberDetailsCloseDate(int ID, string datetimes, string Remarks, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Id",ID),
                new SqlParameter("@Action","10"),
                new SqlParameter("@CloseDate",datetimes),
                new SqlParameter("@CloseStatus",Remarks),
                new SqlParameter("@Updatedby",userid),
            };

            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }



        public DataTable MemberDetailsDelete(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Id",ID),
                new SqlParameter("@Action","9"),

            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }
        public DataTable ComplainCloseDate(int ID, string datetimes, string Remarks, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Id",ID),
                new SqlParameter("@CloseDate",datetimes),
                new SqlParameter("@CloseStatus",Remarks),
                new SqlParameter("@updatedby ",userid),
            };

            dt = db.ExecProcDataTable("sp_ComplainCloseDate", parm);
            return dt;
        }
        //public DataTable MemberDetailsCloseDate(int ID, string datetimes, string Remarks)
        //{
        //    DataTable dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[] {

        //        new SqlParameter("@Id",ID),
        //        new SqlParameter("@Action","10"),
        //        new SqlParameter("@CloseDate",datetimes),
        //        new SqlParameter("@CloseStatus",Remarks),
        //    };

        //    dt = db.ExecProcDataTable("sp_DocDetails", parm);
        //    return dt;
        //}
        public DataTable uploadvideolinkDelete(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
              new SqlParameter("@action",2),
              new SqlParameter("@ID", ID)
            };
            dt = db.ExecProcDataTable("sp_videouploadList", parm);
            return dt;
        }
        #endregion
        public DataTable saveusercomplainnew(usercomplain obj, int action, string status)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",action),
                new SqlParameter("@UserID",obj.UseriID),
                new SqlParameter("@status",status),
            };
            dt = db.ExecProcDataTable("sp_complainuserdetails", parm);
            return dt;
        }

        #region Vishwajeet 07/07/2023


        public DataTable LeadList(string FormDate, string ToDate, string partner)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                  new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@UserId", partner==""?null:partner),
            };
            dt = db.ExecProcDataTable("getlead", parm);
            return dt;
        }


        public DataTable UserBeneficiaryReport(string FormDate, string ToDate, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@PartnerId",userid=="" ? null: userid),
            };
            dt = db.ExecProcDataTable("sp_Register_BeneficiaryList", parm);
            return dt;
        }

        public DataTable UserLeadList(string FormDate, string ToDate, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                  new SqlParameter("@FromDate",FormDate=="" ? null: FormDate),
                new SqlParameter("@Todate",ToDate=="" ? null: ToDate),
                new SqlParameter("@UserId", userid==""?null:userid),
            };
            dt = db.ExecProcDataTable("getlead", parm);
            return dt;
        }



        public DataTable SaveUserDocDetails(string userid, string action, string doctype)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",action),
                new SqlParameter("@Userid",userid),
                new SqlParameter("@DocType",doctype)
            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }
        public DataTable SaveUserDocDetails(MemberDetails p, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@Action",p.Action),
                new SqlParameter("@FromDate",p.FromDate),
                new SqlParameter("@Todate",p.ToDate),
                new SqlParameter("@Userid",userid),


            };
            dt = db.ExecProcDataTable("sp_DocDetails", parm);
            return dt;
        }

        public DataTable getprofile(profile rr, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action",1),
                new SqlParameter("@Userid",userid),
            };
            dt = db.ExecProcDataTable("profile", parm);
            return dt;
        }
        public DataTable getprofileupdate(profile rr, string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {

                new SqlParameter("@Action",1),
                new SqlParameter("@Userid",userid),
                new SqlParameter("@Name",rr.name),
                new SqlParameter("@Pincode",rr.Pincode),
                new SqlParameter("@Dob",rr.Dob),
                new SqlParameter("@Address",rr.Address),
            };
            dt = db.ExecProcDataTable("updateprofile", parm);
            return dt;
        }

        #region [31/07/2023]
        public DataTable KYCDetailsfilter(string userid, string fromdate, string todate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@partnerid",userid),
                new SqlParameter("@FromDate",fromdate),
                new SqlParameter("@Todate",todate),
                new SqlParameter("@Action",6)


            };
            dt = db.ExecProcDataTable("sp_KYCDetails", parm);
            return dt;
        }
        public DataTable usercomplain_Report_filter(string memberid, string fromdate, string todate)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
              new SqlParameter("@Memberid",memberid),
              new SqlParameter("@FromDate",fromdate),
              new SqlParameter("@ToDate",todate),
            };
            dt = db.ExecProcDataTable("sp_Usercomplain_Report_Filter", parm);
            return dt;
        }

        #endregion
        #endregion


        public DataTable GetAePS2FADetails(string userid)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userid),

            };
            dt = db.ExecProcDataTable("sp_GetAePS2FADetails", parm);
            return dt;
        }

        public int UpdateAeps2FARegistrationStatus(string userId, int status, string fingerprintData)
        {
            int result = 0;
            SqlParameter[] parm = new SqlParameter[] {
                 new SqlParameter("@userid",userId),
                 new SqlParameter("@status", status),
                 new SqlParameter("@fingerprintData", fingerprintData),
                 new SqlParameter("@Type", "2FARegistration"),
            };
            result = db.ExecuteNonQueryProc("sp_updateAePS2FAStatus", parm);
            return result;
        }

    }

}
