using SportsBattle.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Grofinhub.Models
{
    public class WalletLogic
    {

        DataTable dt = new DataTable();
        DBHelper DB = new DBHelper();
        CommonClasses sm = new CommonClasses();
        public DataTable GetRequestedWallet()
        {
            
            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action","S")
              
            };
            dt = DB.ExecProcDataTable("WB_SP_WalletRequesStatus", parm);
            return dt;
        }
        public DataTable ApprovedWallet(string PId,double Amount,string Type, string Userid)
        {

            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action","A"),
                new SqlParameter("@id",PId),
                new SqlParameter("@type",Type),
                new SqlParameter("@amount",Amount),
                new SqlParameter("@Userid",Userid)

            };
            dt = DB.ExecProcDataTable("WB_SP_WalletRequesStatus", parm);
            return dt;
        }
        public DataTable RejectedWallet(string PId)
        {

            SqlParameter[] parm = new SqlParameter[] {
                new SqlParameter("@action","R"),
                new SqlParameter("@id",PId)
                

            };
            dt = DB.ExecProcDataTable("WB_SP_WalletRequesStatus", parm);
            return dt;
        }


        public DataTable InsertBalanceRequest(BalanceReq obj)
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[]{
                  new SqlParameter("@TransactionType",obj.TransactionType),
                  new SqlParameter("@TransactionID",obj.TransactionID),
                  new SqlParameter("@BankName",obj.BankName),
                  new SqlParameter("@Amount",obj.Amount),
                  new SqlParameter("@DepositedDate",obj.DepositedDate),
                  new SqlParameter("@images",obj.images),
                  new SqlParameter("@UserID",obj.UserID)
                };

                DataTable dt = DB.ExecProcDataTable("Usp_InsertUserbalanceReq", Param);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable UserWalletHistory(string userId , string type)
        {
            try
            {
                SqlParameter[] Param = new SqlParameter[]{
             
                  new SqlParameter("@UserID",userId),
                  new SqlParameter("@type",type)
                };

                DataTable dt = DB.ExecProcDataTable("Usp_ShowUserwalletHistory", Param);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }




		public DataTable TransferBlance(BalanceReq obj)
		{
			try
			{
				SqlParameter[] Param = new SqlParameter[]{
				  new SqlParameter("@TransactionType",obj.TransactionType),
				  new SqlParameter("@Amount",obj.Amount),	
				  new SqlParameter("@TransferTo",obj.TransferTo),
				  new SqlParameter("@UserID",obj.UserID)
				};

				DataTable dt = DB.ExecProcDataTable("Usp_TransferBlanceByUser", Param);
				return dt;
			}
			catch (Exception)
			{

				throw;
			}
		}
	

	}
}
