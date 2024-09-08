using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Grofinhub.Models
{
    public class WalletModal
    {
        static clsAdminLogic db=new clsAdminLogic();
       static DataTable dt=new DataTable();
       static DBHelper DB = new DBHelper();
      static  CommonClasses sm = new CommonClasses();
        public static double ToatalPartenMainBalance()
        {
            double wallet;
            try
            {
                dt = db.GETWallet("MAIN");
                if(dt!=null && dt.Rows.Count>0)
                {
                    wallet = Convert.ToDouble(dt.Rows[0]["mainbalence"]);
                }
                else
                {
                    wallet = 00.00;
                }
            }
            catch(Exception ex)
            {
                wallet = 0.0;
            }
            return wallet;
        }
        public static double ToatalPartenCashBalance()
        {
            double wallet;
            try
            {
                dt = db.GETWallet("CASH");
                if (dt != null && dt.Rows.Count > 0)
                {
                    wallet = Convert.ToDouble(dt.Rows[0]["aepsbalence"]);
                }
                else
                {
                    wallet = 00.00;
                }
            }
            catch (Exception ex)
            {
                wallet = 0.0;
            }
            return wallet;
        }
        public static double PaystprintMAINWalletBalance() {
            double wallet=0;

            WalletResponce res = new WalletResponce();
            try
            {
                var options = new RestClientOptions("https://sit.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/service-api/api/v1/service/balance/balance/mainbalance", Method.Post);
                request.AddHeader("accept", "application/json");

                request.AddHeader("Token", sm.GetToken());
                request.AddHeader("Authorisedkey", DB.AuthorizationKey);
                request.AddHeader("Content-Type", "application/json");

                //string body = JsonConvert.SerializeObject(body1);
                //request.AddStringBody(body, DataFormat.Json);
                request.AddStringBody("", DataFormat.Json);
                RestResponse response = client.Execute(request);
                //data = response.Content.ToString();
                res = JsonConvert.DeserializeObject<WalletResponce>(response.Content);
                wallet = Convert.ToDouble(res.wallet);
            }
            catch
            {
               wallet= 0.0;
            }

            return wallet;
        }
        public static double PaystprintCASHWalletBalance() {
            double wallet = 0;
            CashWalletResponce res = new CashWalletResponce();
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/service-api/api/v1/service/balance/balance/cashbalance", Method.Post);
                request.AddHeader("accept", "application/json");

                request.AddHeader("Token", sm.GetLiveToken());
                //request.AddHeader("Authorisedkey", DB.AuthorizationKey);
                request.AddHeader("Content-Type", "application/json");

                //string body = JsonConvert.SerializeObject(body1);
                //request.AddStringBody(body, DataFormat.Json);
                request.AddStringBody("", DataFormat.Json);
                RestResponse response = client.Execute(request);
                //data = response.Content.ToString();
                res = JsonConvert.DeserializeObject<CashWalletResponce>(response.Content);
                wallet = Convert.ToDouble(res.cdwallet);
            }
            catch
            {
                wallet= 0.0;
            }
            return wallet;
        }


        public static double GetPartenCreditBalanceByUser(string userid)
        {
            double wallet;
            try
            {

                dt = db.GETWalletUserWalletByUserId("credit", userid);
                if (dt != null && dt.Rows.Count > 0)
                {
                    wallet = Convert.ToDouble(dt.Rows[0]["creditbalance"]);
                }
                else
                {
                    wallet = 00.00;
                }
            }
            catch (Exception ex)
            {
                wallet = 0.0;
            }
            return wallet;
        }
        public static double GetPartenDebitBalanceByUser(string userid)
        {
            double wallet;
            try
            {

                dt = db.GETWalletUserWalletByUserId("debit", userid);
                if (dt != null && dt.Rows.Count > 0)
                {
                    wallet = Convert.ToDouble(dt.Rows[0]["debitbalance"]);
                }
                else
                {
                    wallet = 00.00;
                }
            }
            catch (Exception ex)
            {
                wallet = 0.0;
            }
            return wallet;
        }
        public static double RemainingAdminMainWallet()
        {
            double wallet,paysprintwallet,totalpartenerwallet;
            totalpartenerwallet = ToatalPartenMainBalance();
            paysprintwallet = PaystprintMAINWalletBalance();
            wallet = paysprintwallet - totalpartenerwallet;
            return wallet;
        }
        public static double RemainingAdminCashWallet()
        {
            double wallet, paysprintwallet, totalpartenerwallet;
            totalpartenerwallet = ToatalPartenCashBalance();
            paysprintwallet = PaystprintCASHWalletBalance();
            wallet = paysprintwallet - totalpartenerwallet;
            return wallet;
        }
        public static string UpdateUserMainWallet(string userid,string amount,string type)
        {
            
            try
            {
                dt = db.UpdateUserWallet(userid,amount,type);
                if (dt != null && dt.Rows.Count > 0)
                {
                     Convert.ToDouble(dt.Rows[0]["msg"]);
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }

		//get pipe details
		public static string GetPipe(string userid, ref double amount)
		{
			string mobile = userid;
            dt = db.GetMobileByUserId(userid);
            if (dt != null && dt.Rows.Count > 0)
                mobile = dt.Rows[0]["Mobile"].ToString();
            QueryParametercls p = new QueryParametercls();
			p.bank3_flag = "NO";
			p.mobile = mobile;
			RootQueryremiter racc = new RootQueryremiter();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/remitter/queryremitter", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootQueryremiter>(response.Content);
			double bank1 = 0.0;
			double bank2 = 0.0;
			double bank3 = 0.0;
			if (racc.data != null)
			{
				bank1 = Convert.ToDouble(racc.data.bank1_limit);
				bank2 = Convert.ToDouble(racc.data.bank2_limit);
				bank3 = Convert.ToDouble(racc.data.bank3_limit);
			}
			if (bank1 > 0)
			{
				if (bank1 >= amount)
				{
					amount = 0;
					return "bank1";

				}
				else
				{
					amount = amount - bank1;
					return "bank1";
				}
			}
			else if (bank2 > 0)
			{
				if (bank2 >= amount)
				{
					amount = 0;
					return "bank2";
				}
				else
				{
					amount = amount - bank2;
					return "bank2";
				}
			}
			else if (bank3 > 0)
			{
				if (bank3 >= amount)
				{
					amount = 0;
					return "bank3";
				}
				else
				{
					amount = amount - bank3;
					return "bank3";
				}
			}
			return "";
		}
	}
}
