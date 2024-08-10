using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsBattle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
//using System.IO;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Nancy.Json;

namespace SportsBattle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {

        CommonClasses sm = new CommonClasses();
        clsLogic db;
        private readonly IHostingEnvironment _hostingEnvironment;

        static string base64String = null;
        public ServicesController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            db = new clsLogic();
        }


        #region shani 02/03/2023
        [HttpPost]
        [Route("api/UserLoginbyMobile")]
        public IActionResult UserLoginbyMobile(ReqUserLogin objP)
        {
            try
            {
                if (objP.MobileNo != "" && objP.MobileNo.Length == 10)
                {
                    string otp = Convert.ToString(sm.GenerateOTP());
                    //string otp = "1234";
                    //string msg = "Dear Customer, Your OTP is " + otp + " Do not share This OTP with any One and can be used only once [PANRNG]";
                    //  sm.SendSMS(objP.MobileNo, msg); 
                    List<GetOtpModel> res = new List<GetOtpModel>();
                    DataTable dt = db.GetMobileNoforOtp(objP.MobileNo);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            res.Add(new GetOtpModel
                            {
                                OTP = otp
                            });
                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }

                    else
                    {
                        return Ok(new { status = false, message = "faild", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = " Enter valid Mobile No.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }



        #endregion

        #region   01/03/2023 GetBank_List
        [HttpPost]
        [Route("api/GetBankList")]
        public IActionResult GetBankList()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = db.BindGetBankList();
                List<BankDetailsModel> res = new List<BankDetailsModel>();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        res.Add(new BankDetailsModel
                        {
                            BankCode = item["BankCode"].ToString(),
                            BankName = item["BankName"].ToString()
                        }); ;
                    }

                    return Ok(new { status = true, message = "success", response = res });
                }
                else
                {
                    return Ok(new { status = false, message = "Record not found", response = res });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region  Trasaction

        [HttpPost]
        [Route("api/GetTransactionDetails")]
        public IActionResult GetTransactionDetails(TrnsRequst req)
        {
            try
            {

                DataTable dt = new DataTable();
                if (req.MobileNo != "" && req.MobileNo.Length == 10)
                {
                    dt = db.GetTransactionDetailsApi(req);
                    List<TrnsacResponse> res = new List<TrnsacResponse>();
                    if (dt != null && dt.Rows.Count > 0)
                    {

                        foreach (DataRow item in dt.Rows)
                        {
                            res.Add(new TrnsacResponse
                            {
                                Address = item["Address"].ToString(),
                                ReferenceId = item["ReferenceId"].ToString(),
                                MobileNo = item["MobileNo"].ToString(),
                                Pipe = item["Pipe"].ToString(),
                                Pincode = item["Pincode"].ToString(),
                                Dob = item["Dob"].ToString(),
                                Gst_State = item["Gst_State"].ToString(),
                                bene_id = item["bene_id"].ToString(),
                                Txntype = item["Txntype"].ToString(),
                                Amount = item["Amount"].ToString(),
                                bankid = item["bankid"].ToString(),
                                ackno = item["ackno"].ToString(),
                                txn_status = item["txn_status"].ToString(),
                                benename = item["benename"].ToString(),
                                customercharge = item["customercharge"].ToString(),
                                gst = item["gst"].ToString(),
                                tds = item["tds"].ToString(),
                                account_number = item["account_number"].ToString(),
                                balance = item["balance"].ToString(),
                                paysprint_share = item["paysprint_share"].ToString(),
                                utr = item["utr"].ToString()
                            }); ;

                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }

                    else
                    {
                        return Ok(new { status = false, message = "faild", response = (dynamic)null });
                    }
                }

                else
                {
                    return Ok(new { status = false, message = "invalid MobileNo !", response = (dynamic)null });
                }


            }

            catch (Exception ex)
            {

                return Ok(new { status = false, message = ex.Message, response = (dynamic)null });
            }
        }


        #endregion


        #region Atul Singh 2023/03/01

        [HttpPost]
        [Route("api/GetUserProfile")]
        public IActionResult UserProfile(ReqUserLogin objP)
        {
            try
            {
                if (objP.MobileNo != "" && objP.MobileNo.Length == 10)
                {
                    //string otp = Convert.ToString(sm.GenerateOTP());
                    //string otp = "1234";
                    //string msg = "Dear Customer, Your OTP is " + otp + " Do not share This OTP with any One and can be used only once [PANRNG]";
                    //  sm.SendSMS(objP.MobileNo, msg); 
                    List<UserProfileModel> res = new List<UserProfileModel>();
                    DataTable dt = db.GetUserProfile(objP.MobileNo);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            res.Add(new UserProfileModel
                            {
                                id = Convert.ToInt32(row["ID"]),
                                Name = Convert.ToString(row["Name"]),
                                Mobile = row["Mobile"].ToString(),
                                District = row["District"].ToString(),
                                StateId = row["StateId"].ToString(),
                                State = row["State"].ToString(),
                                DistrictId = row["DistrictId"].ToString(),
                                Block = row["Blockname"].ToString(),
                                Blockid = row["Blockid"].ToString(),
                                Dob = row["Fdob"].ToString(),
                                AgentId = row["AgentId"].ToString(),
                                Address = row["Address"].ToString(),
                                Password = row["Password"].ToString(),
                                Qualification = row["QaulificationName"].ToString(),
                                Pin = row["Pincode"].ToString()
                            });
                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Record Not Found !!", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter Valid Mobile No.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }



        [HttpPost]
        [Route("api/GetReferenceId")]
        public IActionResult GetReferenceId(GetReferenceModel objP)
        {
            try
            {

                if (objP.UserId != "" && objP.type != "")
                {
                again:
                    string referenceid = Convert.ToString(sm.GenerateReferenceId());
                    //string referenceid = "1fQ21DG1xv08t9Y0BF96";

                    //List<UserProfileModel> res = new List<UserProfileModel>();
                    DataTable dt = db.GetReferenceId(referenceid, objP);
                    if (dt.Rows.Count > 0 && dt != null)
                    {

                        return Ok(new { status = true, message = "success", response = referenceid });
                    }
                    else
                    {
                        goto again;
                        //return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter User Id.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }


        #endregion

        #region Atul Singh 2023/03/04
        [HttpPost]
        [Route("api/GetBeneficiaryDetails")]
        public IActionResult GetBeneficiaryDetails(ReqUserDetails p)
        {
            try
            {
                //p.UserId = "4";
                if (p.UserId != "")
                {
                    //string otp = Convert.ToString(sm.GenerateOTP());
                    //string otp = "1234";
                    //string msg = "Dear Customer, Your OTP is " + otp + " Do not share This OTP with any One and can be used only once [PANRNG]";
                    //  sm.SendSMS(objP.MobileNo, msg); 
                    List<GetBeneficiaryDetails> res = new List<GetBeneficiaryDetails>();
                    DataTable dt = db.GetBeneficiaryDetails(p.UserId);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            res.Add(new GetBeneficiaryDetails
                            {
                                Bene_code = row["BenificaryCode"].ToString(),
                                mobile = Convert.ToString(row["mobile"]),
                                benename = row["benename"].ToString(),
                                bankid = row["bankid"].ToString(),
                                accno = row["accno"].ToString(),
                                ifsccode = row["ifsccode"].ToString(),
                                verified = row["verified"].ToString(),
                                gst_state = row["gst_state"].ToString(),
                                dob = row["dob"].ToString(),
                                address = row["address"].ToString(),
                                pincode = row["pincode"].ToString(),
                                RegDate = row["EntryDate1"].ToString()
                            });
                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Record Not Found !!", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter Valid Mobile No.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }

        [HttpPost]
        [Route("api/GetBeneficiaryDetailsById")]
        public IActionResult GetBeneficiaryDetailsById(ReqUserDetails p)
        {
            try
            {
                if (p.UserId != "")
                {
                    List<GetBeneficiaryDetails> res = new List<GetBeneficiaryDetails>();
                    DataTable dt = db.GetBeneficiaryDetails(p.UserId);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            res.Add(new GetBeneficiaryDetails
                            {
                                Bene_code = row["BenificaryCode"].ToString(),
                                mobile = Convert.ToString(row["mobile"]),
                                benename = row["benename"].ToString(),
                                bankid = row["bankid"].ToString(),
                                accno = row["accno"].ToString(),
                                ifsccode = row["ifsccode"].ToString(),
                                verified = row["verified"].ToString(),
                                gst_state = row["gst_state"].ToString(),
                                dob = row["dob"].ToString(),
                                address = row["address"].ToString(),
                                pincode = row["pincode"].ToString(),
                                RegDate = row["EntryDate1"].ToString()
                            });
                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Record Not Found !!", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter Valid Mobile No.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }

        [HttpPost]
        [Route("api/GetRemitterDetails")]
        public IActionResult GetRemitterDetails(ReqUserDetails p)
        {
            try
            {
                //p.UserId = "4";
                if (p.UserId != "")
                {
                    //string otp = Convert.ToString(sm.GenerateOTP());
                    //string otp = "1234";
                    //string msg = "Dear Customer, Your OTP is " + otp + " Do not share This OTP with any One and can be used only once [PANRNG]";
                    //  sm.SendSMS(objP.MobileNo, msg); 
                    List<RemiterDetails> res = new List<RemiterDetails>();
                    DataTable dt = db.GetRemitterDetails(p.UserId);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            res.Add(new RemiterDetails
                            {
                                Id = row["Id"].ToString(),
                                FirstName = Convert.ToString(row["FirstName"]),
                                LastName = row["LastName"].ToString(),
                                // Ammount = row["Ammount"].ToString(),
                                dob = row["dob"].ToString(),
                                // Verified = row["Verified"].ToString(),
                                //mobile = row["mobile"].ToString(),
                                Address = row["Address"].ToString(),
                                OTP = row["OTP"].ToString(),
                                Pincode = row["Pincode"].ToString(),
                                Stateresp = row["Stateresp"].ToString(),
                                Bank3_flag = row["Bank3_flag"].ToString(),
                                gst_state = row["gst_state"].ToString(),
                                RegDate = row["Regdate"].ToString(),
                                RemitterCode = row["RemitterCode"].ToString()
                            });
                        }
                        return Ok(new { status = true, message = "success", response = res });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Record Not Found !!", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter Valid Mobile No.", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }

        #endregion

        #region Atul Singh 2023/03/11

        [HttpPost]
        [Route("api/GetAuthToken")]
        public IActionResult GetAuthToken(ReqUserDetails p)
        {
            // string any = AES.CryptAESIn(new AEPSEnqueriModel(), "d", "d") ;
            try
            {
                // p.UserId = "4";
                if (p.UserId != "" && p.UserId != null)
                {
                    DataTable dt = db.GetBeneficiaryDetails(p.UserId);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        string res = sm.GetToken().ToString();
                        return Ok(new { status = true, message = "success", response = res });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                    }

                }
                else
                {
                    return Ok(new { status = false, message = "Enter User Id", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }


        #endregion


        #region  2023/03/13

        [HttpPost]
        [Route("api/GetDTHOperator")]
        public IActionResult GetDTHOperator()
        {
            // string any = AES.CryptAESIn(new AEPSEnqueriModel(), "d", "d") ;
            try
            {
                // p.UserId = "4";

                DataTable dt = db.GetDTHOperatorList("1");

                if (dt != null && dt.Rows.Count > 0)
                {
                    List<DTHOperatorList> list = new List<DTHOperatorList>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(new DTHOperatorList() { id = dr["id"].ToString(), name = dr["Operator"].ToString() });
                    }
                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }


        [HttpPost]
        [Route("api/GetCircleList")]
        public IActionResult GetCircleList()
        {
            // string any = AES.CryptAESIn(new AEPSEnqueriModel(), "d", "d") ;
            try
            {
                // p.UserId = "4";

                DataTable dt = db.GetDTHOperatorList("2");

                if (dt != null && dt.Rows.Count > 0)
                {
                    List<DTHOperatorList> list = new List<DTHOperatorList>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(new DTHOperatorList() { id = dr["id"].ToString(), name = dr["CircleName"].ToString() });
                    }
                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }
        #endregion

        #region  2023/03/14
        [HttpPost]
        [Route("api/GetRechargePlanOperatorList")]
        public IActionResult GetRechargePlanOperatorList()
        {
            // string any = AES.CryptAESIn(new AEPSEnqueriModel(), "d", "d") ;
            try
            {
                // p.UserId = "4";

                DataTable dt = db.GetDTHOperatorList("3");

                if (dt != null && dt.Rows.Count > 0)
                {
                    List<DTHOperatorList> list = new List<DTHOperatorList>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(new DTHOperatorList() { id = dr["id"].ToString(), name = dr["operator"].ToString() });
                    }
                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }
        #endregion

        #region insert Transactions 2023/03/21

        [HttpPost]
        [Route("api/InsertDMTTransaction")]
        public IActionResult InsertDMTTransaction(TransactionclsForAPI req)
        {
            //TransactionclsForAPI req=new TransactionclsForAPI(); 
            try
            {
                if (req.Mobile.Length == 10 || req.Mobile.Length == 12)
                {
                    DataTable dt = db.InsertDMTTransaction(req);
                    //List<ResponseTransDetails> list = new List<ResponseTransDetails>();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "SAVE SUCCESSFULL" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception)
            {

                return Ok(new { status = false, message = "fail", response = (dynamic)null });
            }

        }
        [HttpPost]
        [Route("api/InsertDoMobileRecharge")]
        public IActionResult InsertDoMobileRecharge(RootDoRechargeForAPI req)
        {
            //TransactionclsForAPI req=new TransactionclsForAPI(); 
            try
            {
                if (req.canumber.Length == 10 || req.canumber.Length == 12)
                {
                    DataTable dt = db.DoRecharge(req);
                    //List<ResponseTransDetails> list = new List<ResponseTransDetails>();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "SAVE SUCCESSFULL" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        #endregion

        //---------- ServiceController ----------
        #region  LICBILLPAY 2023/03/22

        [HttpPost]
        [Route("api/InsertLICBillPay")]
        public IActionResult InsertLICBillPay(RootBodyLicForApi req)
        {
            //TransactionclsForAPI req=new TransactionclsForAPI(); 
            try
            {
                if (req.canumber != "" && req.mode != "")
                {
                    DataTable dt = db.LicBillPayDetails(req);
                    //List<ResponseTransDetails> list = new List<ResponseTransDetails>();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "SAVE SUCCESSFULL" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }


        [HttpPost]
        [Route("api/InsertPANNSDLDetails")]
        public IActionResult InsertPANNSDLDetails(PanBodyForApi req)
        {
            //TransactionclsForAPI req=new TransactionclsForAPI(); 
            try
            {
                if (req.gender != "" && req.lastname != "" && req.refid != "")
                {
                    DataTable dt = db.PanUrlEncdata(req);
                    //List<ResponseTransDetails> list = new List<ResponseTransDetails>();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "SAVE SUCCESSFULL" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        #endregion
        #region  GetTransactionDetails 22/03/2023
        [HttpPost]
        [Route("api/GetTransactionDetailsbyType")]
        public IActionResult GetTransactionDetailsbyType(GetReqTranDetails req)
        {
            try
            {
                if (req.UserID != "" && req.UserID != null)
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    DataTable dt = db.GetTransaction(req);
                    List<ResponseTransDetails> list = new List<ResponseTransDetails>();

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        if (req.Type.ToUpper() == "DMT" || req.Type.ToUpper() == "WATER" || req.Type.ToUpper() == "MUNCIPULITY")
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                list.Add(new ResponseTransDetails()
                                {
                                    mobile = dr["MobileNo"].ToString(),
                                    referenceid = dr["ReferenceId"].ToString(),
                                    pipe = dr["Pipe"].ToString(),
                                    pincode = dr["Pincode"].ToString(),
                                    address = dr["Address"].ToString(),
                                    dob = dr["Dob"].ToString(),
                                    gst_state = dr["Gst_State"].ToString(),
                                    bene_id = dr["bene_id"].ToString(),
                                    amount = dr["Amount"].ToString(),
                                    txntype = dr["Txntype"].ToString(),
                                    type = dr["Type"].ToString(),
                                    tds = dr["tds"].ToString(),
                                    ackno = dr["ackno"].ToString(),
                                    utr = dr["utr"].ToString(),
                                    txn_status = dr["txn_status"].ToString(),
                                    customercharge = dr["customercharge"].ToString(),
                                    gst = dr["gst"].ToString(),
                                    balance = dr["balance"].ToString(),
                                    benename = dr["benename"].ToString(),

                                    account_number = dr["account_number"].ToString(),
                                    message = dr["message"].ToString(),
                                    EntryDate = dr["CreatedDate"].ToString(),

                                });
                            }
                        }
                        else if (req.Type.ToUpper() == "MOBILE")
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                list.Add(new ResponseTransDetails()
                                {
                                    mobile = dr["MobileNo"].ToString(),
                                    referenceid = dr["ReferenceId"].ToString(),
                                    operatorid = dr["OperatorID"].ToString(),

                                    amount = dr["Amount"].ToString(),

                                    type = dr["Type"].ToString(),

                                    txn_status = dr["Status"].ToString(),



                                    message = dr["message"].ToString(),
                                    EntryDate = dr["EntryDate"].ToString(),
                                });
                            }
                        }
                        else if (req.Type.ToUpper() == "PAN")
                        {
                            List<PanListAPiRes> listpan = new List<PanListAPiRes>();
                            foreach (DataRow dr in dt.Rows)
                            {
                                listpan.Add(new PanListAPiRes()
                                {
                                    email = dr["email"].ToString(),
                                    encdata = dr["encdata"].ToString(),
                                    entrydate = dr["entrydate"].ToString(),
                                    fname = dr["fname"].ToString(),
                                    gender = dr["gender"].ToString(),
                                    id = dr["id"].ToString(),
                                    lname = dr["lname"].ToString(),
                                    mname = dr["mname"].ToString(),
                                    mode = dr["mode"].ToString(),
                                    refid = dr["refid"].ToString(),
                                    title = dr["title"].ToString(),
                                    url = dr["url"].ToString(),

                                });
                            }
                            return Ok(new { status = true, message = "success", response = listpan });
                        }
                        else if (req.Type.ToUpper() == "BBPS")
                        {
                            List<ListBillPay_BELResponse> listBBPS = new List<ListBillPay_BELResponse>();
                            foreach (DataRow dr in dt.Rows)
                            {
                                listBBPS.Add(new ListBillPay_BELResponse()
                                {
                                    Type = dr["BillType"].ToString(),
                                    @operator = dr["operator"].ToString(),
                                    canumber = dr["canumber"].ToString(),
                                    amount = dr["amount"].ToString(),
                                    referenceid = dr["referenceid"].ToString(),
                                    latitude = dr["latitude"].ToString(),
                                    longitude = dr["longitude"].ToString(),
                                    mode = dr["mode"].ToString(),
                                    billAmount = dr["billAmount"].ToString(),
                                    billnetamount = dr["billnetamount"].ToString(),
                                    billdate = dr["billdate"].ToString(),
                                    dueDate = dr["dueDate"].ToString(),
                                    acceptPayment = dr["acceptPayment"].ToString(),
                                    acceptPartPay = dr["acceptPartPay"].ToString(),
                                    cellNumber = dr["cellNumber"].ToString(),
                                    userName = dr["userName"].ToString(),
                                    status = dr["status"].ToString(),
                                    response_code = dr["response_code"].ToString(),
                                    operatorid = dr["operatorid"].ToString(),
                                    ackno = dr["ackno"].ToString(),
                                    opening = dr["opening"].ToString(),
                                    closing = dr["closing"].ToString(),
                                    message = dr["message"].ToString(),
                                    EntryDate = dr["EntryDate"].ToString(),


                                });
                            }
                            return Ok(new { status = true, message = "success", response = listBBPS });
                        }


                        else if (req.Type.ToUpper() == "LIC")
                        {
                            List<LicListApiResponse> listLic = new List<LicListApiResponse>();
                            foreach (DataRow dr in dt.Rows)
                            {
                                listLic.Add(new LicListApiResponse()
                                {
                                    canumber = dr["canumber"].ToString(),
                                    mode = dr["mode"].ToString(),
                                    amount = dr["amount"].ToString(),
                                    ad1 = dr["ad1"].ToString(),
                                    ad2 = dr["ad2"].ToString(),
                                    ad3 = dr["ad3"].ToString(),
                                    referenceid = dr["referenceid"].ToString(),
                                    latitude = dr["latitude"].ToString(),
                                    longitude = dr["longitude"].ToString(),
                                    billnumber = dr["billnumber"].ToString(),
                                    billamount = dr["billamount"].ToString(),
                                    billnetamount = dr["billnetamount"].ToString(),
                                    billdate = dr["billdate"].ToString(),
                                    acceptpayment = dr["acceptpayment"].ToString(),
                                    acceptpartpay = dr["acceptpartpay"].ToString(),
                                    cellnumber = dr["cellnumber"].ToString(),
                                    duefrom = dr["duefrom"].ToString(),
                                    dueto = dr["dueto"].ToString(),
                                    validationId = dr["validationId"].ToString(),
                                    billid = dr["billid"].ToString(),
                                    status = dr["status"].ToString(),
                                    response_code = dr["response_code"].ToString(),
                                    operatorid = dr["operatorid"].ToString(),
                                    ackno = dr["ackno"].ToString(),
                                    message = dr["message"].ToString(),
                                    entrydate = dr["entrydate"].ToString(),
                                    type = dr["type"].ToString(),


                                });
                            }
                            return Ok(new { status = true, message = "success", response = listLic });
                        }
                        else if (req.Type.ToUpper() == "ELECTRICITY")
                        {
                            List<ListBillPay_BELResponse> Electricity_List = new List<ListBillPay_BELResponse>();

                            foreach (DataRow dr in dt.Rows)
                            {
                                Electricity_List.Add(new ListBillPay_BELResponse
                                {
                                    Type = dr["BillType"].ToString(),
                                    @operator = dr["operator"].ToString(),
                                    canumber = dr["canumber"].ToString(),
                                    amount = dr["amount"].ToString(),
                                    referenceid = dr["referenceid"].ToString(),
                                    latitude = dr["latitude"].ToString(),
                                    longitude = dr["longitude"].ToString(),
                                    mode = dr["mode"].ToString(),
                                    billAmount = dr["billAmount"].ToString(),
                                    billnetamount = dr["billnetamount"].ToString(),
                                    billdate = dr["billdate"].ToString(),
                                    dueDate = dr["dueDate"].ToString(),
                                    acceptPayment = dr["acceptPayment"].ToString(),
                                    acceptPartPay = dr["acceptPartPay"].ToString(),
                                    cellNumber = dr["cellNumber"].ToString(),
                                    userName = dr["userName"].ToString(),
                                    status = dr["status"].ToString(),
                                    response_code = dr["response_code"].ToString(),
                                    operatorid = dr["operatorid"].ToString(),
                                    ackno = dr["ackno"].ToString(),
                                    opening = dr["opening"].ToString(),
                                    closing = dr["closing"].ToString(),
                                    message = dr["message"].ToString(),
                                    EntryDate = dr["EntryDate"].ToString(),
                                });
                            }
                            return Ok(new { status = false, message = "fail", response = Electricity_List });
                        }

                        else if (req.Type.ToUpper() == "LPG")
                        {
                            List<ListBillPay_BELResponse> LPG_List = new List<ListBillPay_BELResponse>();

                            foreach (DataRow dr in dt.Rows)
                            {
                                LPG_List.Add(new ListBillPay_BELResponse
                                {
                                    Type = dr["BillType"].ToString(),
                                    @operator = dr["operator"].ToString(),
                                    canumber = dr["canumber"].ToString(),
                                    amount = dr["amount"].ToString(),
                                    referenceid = dr["referenceid"].ToString(),
                                    latitude = dr["latitude"].ToString(),
                                    longitude = dr["longitude"].ToString(),
                                    mode = dr["mode"].ToString(),
                                    billAmount = dr["billAmount"].ToString(),
                                    billnetamount = dr["billnetamount"].ToString(),
                                    billdate = dr["billdate"].ToString(),
                                    dueDate = dr["dueDate"].ToString(),
                                    acceptPayment = dr["acceptPayment"].ToString(),
                                    acceptPartPay = dr["acceptPartPay"].ToString(),
                                    cellNumber = dr["cellNumber"].ToString(),
                                    userName = dr["userName"].ToString(),
                                    status = dr["status"].ToString(),
                                    response_code = dr["response_code"].ToString(),
                                    operatorid = dr["operatorid"].ToString(),
                                    ackno = dr["ackno"].ToString(),
                                    opening = dr["opening"].ToString(),
                                    closing = dr["closing"].ToString(),
                                    message = dr["message"].ToString(),
                                    EntryDate = dr["EntryDate"].ToString(),
                                });
                            }
                            return Ok(new { status = true, message = "success", response = LPG_List });
                        }
                        else if (req.Type.ToUpper() == "FASTAG")
                        { 
                            string tlist = CommonClasses.ConvertTableToList(dt);
                            List<FastagApiResponce> Fastag_List = js.Deserialize<List<FastagApiResponce>>(tlist);
                            return Ok(new { status = true, message = "success", response = Fastag_List });
                        } 
                        else
                        {
                            return Ok(new { status = false, message = "fail", response = (dynamic)null });
                        } 
                        return Ok(new { status = true, message = "success", response = list });
                    }

                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }

                else
                {
                    return Ok(new { status = false, message = "Please Enter UserID", response = (dynamic)null });
                }


            }
            catch (Exception)
            { 
                return Ok(new { status = false, message = "fail", response = (dynamic)null });
            }

        }

        #endregion

        #region get referenceids by id 2023/03/23

        [HttpPost]
        [Route("api/GetReferenceIdsByUserID")]
        public IActionResult GetReferenceIdsByUserID(GetReqTranDetails req)
        {
            //TransactionclsForAPI req=new TransactionclsForAPI(); 
            try
            {
                if (req.UserID != "" && req.Type != "")
                {
                    DataTable dt = db.GetReferenceIdsByUserID(req);
                    List<ReferelenceListRes> list = new List<ReferelenceListRes>();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            list.Add(new ReferelenceListRes()
                            {
                                Amount = dr["Amount"].ToString(),
                                ReferenceId = dr["ReferenceId"].ToString(),
                                Entrydate = dr["CreatedDate"].ToString()
                            });
                        }
                        return Ok(new { status = true, message = "success", response = list });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "Data Not Found !!", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Enter UserID And Type Both...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }


        #endregion


        #region Compliance 2023/03/24

        [HttpPost]
        [Route("api/SaveDocDetails")]
        public IActionResult SaveComplianceDocDetails(ConplainsApiReq req)
        {

            try
            {

                if (req.AdharPicFront != null && req.AdharPicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "AdharFront_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.AdharPicFront);
                    pic.Save(DefaultImagePath1);
                    req.AdharPicFront = DefaultImagePath;

                }
                else
                {
                    req.AdharPicFront = null;
                }
                if (req.AdharPicBack != null && req.AdharPicBack != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "AdharBack_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.AdharPicBack);
                    pic.Save(DefaultImagePath1);
                    req.AdharPicBack = DefaultImagePath;

                }
                else
                {
                    req.AdharPicBack = null;
                }
                if (req.PanPicFront != null && req.PanPicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "PanFront_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.PanPicFront);
                    pic.Save(DefaultImagePath1);
                    req.PanPicFront = DefaultImagePath;

                }
                else
                {
                    req.PanPicFront = null;
                }
                //if (req.PanPicBack != null && req.PanPicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "PanBack_" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.PanPicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.PanPicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.PanPicBack = null;
                //}
                if (req.Ad1PicFront != null && req.Ad1PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad1Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad1PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad1PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad1PicFront = null;
                }
                //if (req.Ad1PicBack != null && req.Ad1PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad1Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad1PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad1PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad1PicBack = null;
                //}
                if (req.Ad2PicFront != null && req.Ad2PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad2Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad2PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad2PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad2PicFront = null;
                }
                //if (req.Ad2PicBack != null && req.Ad2PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad2Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad2PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad2PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad2PicBack = null;
                //}
                if (req.Ad3PicFront != null && req.Ad3PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad3Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad3PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad3PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad3PicFront = null;
                }
                //if (req.Ad3PicBack != null && req.Ad3PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad3Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad3PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad3PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad3PicBack = null;
                //}
                //ad4
                if (req.Ad4PicFront != null && req.Ad4PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad4Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad4PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad4PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad4PicFront = null;
                }
                //if (req.Ad4PicBack != null && req.Ad4PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad4Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad4PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad4PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad4PicBack = null;
                //}
                //ad5


                if (req.Ad5PicFront != null && req.Ad5PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad5Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad5PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad5PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad5PicFront = null;
                }
                //if (req.Ad5PicBack != null && req.Ad5PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad5Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad5PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad5PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad5PicBack = null;
                //}
                //ad6

                if (req.Ad6PicFront != null && req.Ad6PicFront != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad6Front_" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.Ad6PicFront);
                    pic.Save(DefaultImagePath1);
                    req.Ad6PicFront = DefaultImagePath;

                }
                else
                {
                    req.Ad6PicFront = null;
                }
                //if (req.Ad6PicBack != null && req.Ad6PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad6Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad6PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad6PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad6PicBack = null;
                //}
                //ad7
                //if (req.Ad7PicFront != null && req.Ad7PicFront != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad7Front_" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad7PicFront);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad7PicFront = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad7PicFront = null;
                //}
                //if (req.Ad7PicBack != null && req.Ad7PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad7Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad7PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad7PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad7PicBack = null;
                //}
                ////ad8
                //if (req.Ad8PicFront != null && req.Ad8PicFront != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad8Front_" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad8PicFront);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad8PicFront = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad8PicFront = null;
                //}
                //if (req.Ad8PicBack != null && req.Ad8PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad8Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad8PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad8PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad8PicBack = null;
                //}
                ////ad9
                //if (req.Ad9PicFront != null && req.Ad9PicFront != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad9Front_" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad9PicFront);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad9PicFront = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad9PicFront = null;
                //}
                //if (req.Ad9PicBack != null && req.Ad9PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad9Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad9PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad9PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad9PicBack = null;
                //}
                ////ad10
                //if (req.Ad10PicFront != null && req.Ad10PicFront != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad10Front_" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad10PicFront);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad10PicFront = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad10PicFront = null;
                //}
                //if (req.Ad10PicBack != null && req.Ad10PicBack != "")
                //{
                //    string DefaultImagePath = "/Upload/ScreenShot/" + req.Userid + "Ad10Back" + DateTime.Now.Ticks + ".jpg";
                //    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                //    Image pic = db.Change64toImage(req.Ad10PicBack);
                //    pic.Save(DefaultImagePath1);
                //    req.Ad10PicBack = DefaultImagePath;

                //}
                //else
                //{
                //    req.Ad10PicBack = null;
                //}
                req.Aadharno = (req.Aadharno == "") ? null : req.Aadharno;
                req.Panno = (req.Panno == "") ? null : req.Panno;
                req.Mobileno = (req.Mobileno == "") ? null : req.Mobileno;
                req.Billno = (req.Billno == "") ? null : req.Billno;

                req.Ad1 = (req.Ad1 == "") ? null : req.Ad1;
                req.Ad2 = (req.Ad2 == "") ? null : req.Ad2;
                req.Ad3 = (req.Ad3 == "") ? null : req.Ad3;
                req.Ad4 = (req.Ad4 == "") ? null : req.Ad4;
                req.Ad5 = (req.Ad5 == "") ? null : req.Ad5;
                req.Ad6 = (req.Ad6 == "") ? null : req.Ad6;
                //req.Ad7 = (req.Ad7 == "") ? null : req.Ad7;
                //req.Ad8 = (req.Ad8 == "") ? null : req.Ad8;
                //req.Ad9 = (req.Ad9 == "") ? null : req.Ad9;
                //req.Ad10 = (req.Ad10 == "") ? null : req.Ad10;


                DataTable dt = db.SaveDocDetails(req);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string msg = dt.Rows[0]["msg"].ToString();
                    return Ok(new { status = true, message = "success", response = msg });
                }
                else
                {
                    return Ok(new { status = false, message = "fail", response = "Data Not Save Try Again !!!" });
                }


            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        [HttpPost]
        [Route("api/DeleteDocDetails")]
        public IActionResult DeleteDocDetails(DocDetailsReq req)
        {
            try
            {
                string msg = "";
                DataTable dt = db.SaveDocDetails(req.id, "3");
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Not Deteled Try Agani!!";
                }
                return Ok(new { status = true, message = "success", response = msg });

            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        [HttpPost]
        [Route("api/FetchAllDocDetails")]
        public IActionResult FetchAllDocDetails(ReqUserDetails req)
        {
            try
            {

                DataTable dt = db.SaveDocDetails(req.UserId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<DocDetailsApiRes> list = new List<DocDetailsApiRes>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new DocDetailsApiRes()
                        {
                            Id = row["id"].ToString(),
                            Aadharno = row["AadharNo"].ToString(),
                            Ad1 = row["Ad1"].ToString(),

                            Ad1PicBack = "https://app.grofinhub.com" + row["Ad1PicBack"].ToString(),
                            Ad2PicBack = "https://app.grofinhub.com" + row["Ad2PicBack"].ToString(),
                            Ad3PicBack = "https://app.grofinhub.com" + row["Ad3PicBack"].ToString(),
                            Ad1PicFront = "https://app.grofinhub.com" + row["Ad1PicFront"].ToString(),
                            Ad2PicFront = "https://app.grofinhub.com" + row["Ad2PicFront"].ToString(),
                            Ad3PicFront = "https://app.grofinhub.com" + row["Ad3PicFront"].ToString(),
                            Ad2 = row["Ad2"].ToString(),
                            Ad3 = row["Ad3"].ToString(),
                            AdharPicBack = "https://app.grofinhub.com" + row["AadharPicBack"].ToString(),
                            AdharPicFront = "https://app.grofinhub.com" + row["AadharPicFront"].ToString(),
                            Billno = row["Billno"].ToString(),
                            Doctype = row["DocType"].ToString(),
                            Email = row["Email"].ToString(),
                            Entrydate = row["EntryDate"].ToString(),
                            Entrytype = row["EntryType"].ToString(),
                            Mobileno = row["Mobileno"].ToString(),
                            Panno = row["PanNo"].ToString(),
                            PanPicBack = "https://app.grofinhub.com" + row["PanPicBack"].ToString(),
                            PanPicFront = "https://app.grofinhub.com" + row["PanPicFront"].ToString(),
                            Userid = row["Userid"].ToString(),

                            Ad4 = row["Ad4"].ToString(),
                            Ad4PicFront = "https://app.grofinhub.com" + row["Ad4PicFront"].ToString(),
                            Ad4PicBack = "https://app.grofinhub.com" + row["Ad4PicBack"].ToString(),

                            Ad5 = row["Ad5"].ToString(),
                            Ad5PicFront = "https://app.grofinhub.com" + row["Ad5PicFront"].ToString(),
                            Ad5PicBack = "https://app.grofinhub.com" + row["Ad5PicBack"].ToString(),

                            Ad6 = row["Ad6"].ToString(),
                            Ad6PicFront = "https://app.grofinhub.com" + row["Ad6PicFront"].ToString(),
                            Ad6PicBack = "https://app.grofinhub.com" + row["Ad6PicBack"].ToString(),

                            Ad7 = row["Ad7"].ToString(),
                            Ad7PicFront = "https://app.grofinhub.com" + row["Ad7PicFront"].ToString(),
                            Ad7PicBack = "https://app.grofinhub.com" + row["Ad7PicBack"].ToString(),

                            Ad8 = row["Ad8"].ToString(),
                            Ad8PicFront = "https://app.grofinhub.com" + row["Ad8PicFront"].ToString(),
                            Ad8PicBack = "https://app.grofinhub.com" + row["Ad8PicBack"].ToString(),

                            Ad9 = row["Ad9"].ToString(),
                            Ad9PicFront = "https://app.grofinhub.com" + row["Ad9PicFront"].ToString(),
                            Ad9PicBack = "https://app.grofinhub.com" + row["Ad9PicBack"].ToString(),

                            Ad10 = row["Ad10"].ToString(),
                            Ad10PicFront = "https://app.grofinhub.com" + row["Ad10PicFront"].ToString(),
                            Ad10PicBack = "https://app.grofinhub.com" + row["Ad10PicBack"].ToString(),
                            Name = row["Name"].ToString(),
                            Income = row["Income"].ToString(),
                            Address = row["Address"].ToString()





                        });
                    }
                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Data Not Found !!!", response = (dynamic)null });
                    //msg = "Not Deteled Try Agani!!";
                }


            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }
        #endregion


        #region FetchPMMenuPermissionByUserId 2023/03/28


        [HttpPost]
        [Route("api/FetchPMMenuPermissionByUserId")]
        public IActionResult FetchPermissionByUserId(ReqUserDetails req)
        {
            try
            {
                string UserId = "";
                DataTable dt = db.UserMenuPermission(req.UserId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<UserMenuPermission> list = new List<UserMenuPermission>();
                    foreach (DataRow row in dt.Rows)
                    {
                        UserId = row["userid"].ToString();
                        list.Add(new UserMenuPermission()
                        {
                            Dmt = Convert.ToBoolean(row["DMT"]),
                            AEPS = Convert.ToBoolean(row["AEPS"]),
                            MATM = Convert.ToBoolean(row["MATM"]),
                            BBPS = Convert.ToBoolean(row["BBPS"]),
                            RECHARGE = Convert.ToBoolean(row["RECHARGE"]),
                            DTH = Convert.ToBoolean(row["DTH"]),
                            ELECTRICITY = Convert.ToBoolean(row["ELECTRICITY"]),
                            FASTAG = Convert.ToBoolean(row["FASTAG"]),
                            WATER_BILL = Convert.ToBoolean(row["WATER_BILL"]),
                            MUNCIPALITY = Convert.ToBoolean(row["MUNCIPALITY"]),
                            LIC = Convert.ToBoolean(row["LIC"]),
                            PAN = Convert.ToBoolean(row["PAN"]),
                            EPFO = Convert.ToBoolean(row["EPFO"]),
                            LPG = Convert.ToBoolean(row["LPG"]),
                            IRCTC = Convert.ToBoolean(row["IRCTC"]),
                            FLIGHT = Convert.ToBoolean(row["FLIGHT"]),
                            BUS = Convert.ToBoolean(row["BUS"]),
                            HOTEL = Convert.ToBoolean(row["HOTEL"].ToString()),
                            HOLIDAYS_BOOKING = Convert.ToBoolean(row["HOLIDAYS_BOOKING"])
                        }); ;
                    }
                    return Ok(new { status = true, message = "Data Fetch Successful", UserId = UserId, response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Data Not Found !!!", UserId = UserId, response = (dynamic)null });
                    //msg = "Not Deteled Try Agani!!";
                }


            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, UserId = "", response = (dynamic)null });
            }

        }

        [HttpPost]
        [Route("api/FetchAllDocDetailByUserId")]
        public IActionResult FetchAllDocDetailByUserId(DocDetailBody req)
        {
            try
            {

                DataTable dt = db.SaveDocDetails(req);
                if (dt != null && dt.Rows.Count > 0)
                {
                    List<DocDetailsApiRes> list = new List<DocDetailsApiRes>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new DocDetailsApiRes()
                        {
                            Id = row["id"].ToString(),
                            Aadharno = row["AadharNo"].ToString(),
                            Ad1 = row["Ad1"].ToString(),
                            Ad1PicBack = row["Ad1PicBack"].ToString(),
                            Ad2PicBack = row["Ad2PicBack"].ToString(),
                            Ad3PicBack = row["Ad3PicBack"].ToString(),
                            Ad1PicFront = row["Ad1PicFront"].ToString(),
                            Ad2PicFront = row["Ad2PicFront"].ToString(),
                            Ad3PicFront = row["Ad3PicFront"].ToString(),
                            Ad2 = row["Ad2"].ToString(),
                            Ad3 = row["Ad3"].ToString(),
                            AdharPicBack = row["AadharPicBack"].ToString(),
                            AdharPicFront = row["AadharPicFront"].ToString(),
                            Billno = row["Billno"].ToString(),
                            Doctype = row["DocType"].ToString(),
                            Email = row["Email"].ToString(),
                            Entrydate = row["EntryDate"].ToString(),
                            Entrytype = row["EntryType"].ToString(),
                            Mobileno = row["Mobileno"].ToString(),
                            Panno = row["PanNo"].ToString(),
                            PanPicBack = row["PanPicBack"].ToString(),
                            PanPicFront = row["PanPicFront"].ToString(),
                            Userid = row["Userid"].ToString(),

                            Ad4 = row["Ad4"].ToString(),
                            Ad4PicFront = row["Ad4PicFront"].ToString(),
                            Ad4PicBack = row["Ad4PicBack"].ToString(),

                            Ad5 = row["Ad5"].ToString(),
                            Ad5PicFront = row["Ad5PicFront"].ToString(),
                            Ad5PicBack = row["Ad5PicBack"].ToString(),

                            Ad6 = row["Ad6"].ToString(),
                            Ad6PicFront = row["Ad6PicFront"].ToString(),
                            Ad6PicBack = row["Ad6PicBack"].ToString(),

                            Ad7 = row["Ad7"].ToString(),
                            Ad7PicFront = row["Ad7PicFront"].ToString(),
                            Ad7PicBack = row["Ad7PicBack"].ToString(),

                            Ad8 = row["Ad8"].ToString(),
                            Ad8PicFront = row["Ad8PicFront"].ToString(),
                            Ad8PicBack = row["Ad8PicBack"].ToString(),

                            Ad9 = row["Ad9"].ToString(),
                            Ad9PicFront = row["Ad9PicFront"].ToString(),
                            Ad9PicBack = row["Ad9PicBack"].ToString(),

                            Ad10 = row["Ad10"].ToString(),
                            Ad10PicFront = row["Ad10PicFront"].ToString(),
                            Ad10PicBack = row["Ad10PicBack"].ToString()



                        });
                    }
                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Data Not Found !!!", response = (dynamic)null });
                    //msg = "Not Deteled Try Agani!!";
                }


            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }
        #endregion

        #region forpaysprint 

        private string GenerateJwtToken(string username, List<string> roles)
        {
            var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, username)
        };

            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            });
            DBHelper db = new DBHelper();
            var configuation = db.GetConfiguration();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuation.GetSection("JwtKey").GetSection("Key").Value));
            var Expiry = (configuation.GetSection("JwtKey").GetSection("JwtExpireDays").Value);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(Expiry));

            var token = new JwtSecurityToken(
                configuation.GetSection("JwtKey").GetSection("Issuer").Value,
                configuation.GetSection("JwtKey").GetSection("Issuer").Value,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpPost]
        [Route("GenerateToken")]
        public IActionResult GenerateToken([FromBody] LoginRequest request)
        {
            var response = new Dictionary<string, string>();
            if (!(request.UserName == "Grofin" && request.Password == "Grofin@321"))
            {
                response.Add("Error", "Invalid username or password");
                return BadRequest(response);
            }

            var roles = new string[] { "Role1", "Role2" };
            var token = GenerateJwtToken(request.UserName, roles.ToList());
            return Ok(new LoginResponse()
            {
                Access_Token = token

            });
        }



        #endregion




        #region shani 28/04/2023 WalletRequest

        [HttpPost]
        [Route("api/WalletRequest")]
        public IActionResult WallerRequest(WalletRequestApiCls req)
        {

			try
			{
                if (req.images != null && req.images != "")
                {
                    string DefaultImagePath = "/Upload/ScreenShot/" + "WalletReq" + DateTime.Now.Ticks + ".jpg";
                    string DefaultImagePath1 = "wwwroot" + DefaultImagePath;
                    Image pic = db.Change64toImage(req.images);
                    pic.Save(DefaultImagePath1);
                    req.images = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;

                }
                //if (req.Amount != null)
                //{
                DataTable dt = db.WalletRequest(req);

				if (dt != null && dt.Rows.Count > 0)
				{
					return Ok(new { status = true, message = "success", response = "success" });
				}
				else
				{
					return Ok(new { status = false, message = "fail", response = (dynamic)null });
				}
				//}
				//else
				//{
				//    return Ok(new { status = false, message = "Enter Amount !", response = (dynamic)null });
				//}
			}
			catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }


        #endregion

        #region GetUserBalanceDetails 29/04/2023

        [HttpPost]

        [Route("api/GetUserBalanceDetails")]
        public IActionResult GetUserBalanceDetails(GetuserBalanceReq req)
        {

            try
            {

                DataTable dt = db.GetUserBalanceDetails(req);
                GetuserBalanceResponse obj = new GetuserBalanceResponse();
                if (dt != null && dt.Rows.Count > 0)
                {

                    obj.Debit = dt.Rows[0]["DebitBalance"].ToString();
                    obj.Credit = dt.Rows[0]["CreditBalance"].ToString();

                    return Ok(new { status = true, message = "success", response = obj });
                }
                else
                {
                    return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }



        #endregion



        #region GetUserWalletHistory29/04/2023

        [HttpPost]

        [Route("api/GetUserWalletHistory")]
        public IActionResult GetUserWalletHistory(GetuserBalanceReq req)
        {

            try
            {

                DataTable dt = db.GetUserWalletHistory(req);
                List<GetuserWalletHistoryResponse> list = new List<GetuserWalletHistoryResponse>();
                if (dt != null && dt.Rows.Count > 0)
                {

                    foreach (DataRow item in dt.Rows)
                    {
                        list.Add(new GetuserWalletHistoryResponse
                        {
                            Amount = item["Amount"].ToString(),
                            DepositedDate = item["DepositedDate"].ToString(),
                            Entrydate = item["Entrydate"].ToString(),
                            TransactionType = item["TransactionType"].ToString(),
                            BankName = item["BankName"].ToString(),
                            Status = item["Status"].ToString(),
                            TransactionID = item["TransactionID"].ToString(),

                        });
                    }

                    return Ok(new { status = true, message = "success", response = list });
                }
                else
                {
                    return Ok(new { status = false, message = "Fail", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }
        }



        #endregion

        #region remove Api
        //#region GetTransactionReport/04/2023

        //[HttpPost]

        //[Route("api/GetTransactionReport")]
        //public IActionResult GetTransactionReport()
        //{

        //    try
        //    {

        //        DataTable dt = db.GetTransactionReport();
        //        List<GetTransactionResponse> list = new List<GetTransactionResponse>();
        //        if (dt != null && dt.Rows.Count > 0)
        //        {

        //            foreach (DataRow item in dt.Rows)
        //            {
        //                list.Add(new GetTransactionResponse
        //                {
        //                    benename = item["benename"].ToString(),
        //                    mobile = item["MobileNo"].ToString(),
        //                    balance = item["balance"].ToString(),
        //                    pipe = item["Pipe"].ToString(),
        //                    referenceid = item["ReferenceId"].ToString(),
        //                    pincode = item["Pincode"].ToString(),
        //                    address = item["Address"].ToString(),
        //                    dob = item["DOB"].ToString(),
        //                    gst_state = item["Gst_State"].ToString(),
        //                    txnType = item["Txntype"].ToString(),
        //                    amount = item["Amount"].ToString(),
        //                    ackno = item["ackno"].ToString(),
        //                    txn_status = item["txn_status"].ToString(),
        //                    message = item["message"].ToString(),
        //                    customercharge = item["customercharge"].ToString(),
        //                    gst = item["gst"].ToString(),
        //                    tds = item["tds"].ToString(),
        //                    account_number = item["account_number"].ToString(),
        //                    paysprint_share = item["paysprint_share"].ToString(),
        //                    EntryDate = item["CreatedDate"].ToString(),


        //                });
        //            }

        //            return Ok(new { status = true, message = "success", response = list });
        //        }
        //        else
        //        {
        //            return Ok(new { status = false, message = "Fail", response = (dynamic)null });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { status = false, message = e.Message, response = (dynamic)null });
        //    }
        //}



        //#endregion

        //#region MobileRechargeReport/04/2023

        //[HttpPost]

        //[Route("api/MobileRechargeReport")]
        //public IActionResult MobileRechargeReport()
        //{

        //    try
        //    {

        //        DataTable dt = db.MobileRechargeReport();
        //        List<MobileRechargeResponseApiCls> list = new List<MobileRechargeResponseApiCls>();
        //        if (dt != null && dt.Rows.Count > 0)
        //        {

        //            foreach (DataRow item in dt.Rows)
        //            {
        //                list.Add(new MobileRechargeResponseApiCls
        //                {
        //                    MobileNo = item["MobileNo"].ToString(),
        //                    amount = item["Amount"].ToString(),
        //                    referenceid = item["ReferenceID"].ToString(),
        //                    operatorid = item["OperatorID"].ToString(),
        //                    refunddate = item["refunddate"].ToString(),
        //                    ackno = item["ackno"].ToString(),
        //                    message = item["MESSAGE"].ToString(),
        //                    EntryDate = item["EntryDate"].ToString(),


        //                });
        //            }

        //            return Ok(new { status = true, message = "success", response = list });
        //        }
        //        else
        //        {
        //            return Ok(new { status = false, message = "Fail", response = (dynamic)null });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { status = false, message = e.Message, response = (dynamic)null });
        //    }
        //}



        //#endregion

        //#region LicGetDetailsPayBill/04/2023

        //[HttpPost]

        //[Route("api/LicGetDetailsPayBill")]
        //public IActionResult LicBillPayReport()
        //{

        //    try
        //    {

        //        DataTable dt = db.LicGetDetailsPayBill();
        //        List<LicBillPayResponseApiCls> list = new List<LicBillPayResponseApiCls>();
        //        if (dt != null && dt.Rows.Count > 0)
        //        {

        //            foreach (DataRow item in dt.Rows)
        //            {
        //                list.Add(new LicBillPayResponseApiCls
        //                {
        //                    billNumber = item["billnumber"].ToString(),
        //                    cannumber = item["canumber"].ToString(),
        //                    amount = item["amount"].ToString(),
        //                    referenceid = item["referenceid"].ToString(),
        //                    operatorid = item["operatorid"].ToString(),
        //                    mode = item["mode"].ToString(),
        //                    ackno = item["ackno"].ToString(),
        //                    ad1 = item["ad1"].ToString(),
        //                    ad2 = item["ad2"].ToString(),
        //                    ad3 = item["ad3"].ToString(),
        //                    message = item["message"].ToString(),
        //                    latitude = item["latitude"].ToString(),
        //                    longitude = item["longitude"].ToString(),
        //                    billnetamount = item["billnetamount"].ToString(),
        //                    billAmount = item["billamount"].ToString(),
        //                    billdate = item["billdate"].ToString(),
        //                    acceptPayment = item["acceptpayment"].ToString(),
        //                    acceptPartPay = item["acceptpartpay"].ToString(),
        //                    cellNumber = item["cellnumber"].ToString(),
        //                    dueFrom = item["duefrom"].ToString(),
        //                    dueTo = item["dueto"].ToString(),
        //                    validationId = item["validationId"].ToString(),
        //                    billId = item["billid"].ToString(),
        //                    EntryDate = item["entrydate"].ToString(),





        //                });
        //            }

        //            return Ok(new { status = true, message = "success", response = list });
        //        }
        //        else
        //        {
        //            return Ok(new { status = false, message = "Fail", response = (dynamic)null });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { status = false, message = e.Message, response = (dynamic)null });
        //    }
        //}



        //#endregion

        //#region GetPanNsdlDetails 29/04/2023

        //[HttpPost]

        //[Route("api/GetPanNsdlDetails")]
        //public IActionResult GetPanNsdlDetails()
        //{

        //    try
        //    {

        //        DataTable dt = db.GetPanNsdlDetails();
        //        List<GetPanDetailsResponseApiCls> list = new List<GetPanDetailsResponseApiCls>();
        //        if (dt != null && dt.Rows.Count > 0)
        //        {

        //            foreach (DataRow item in dt.Rows)
        //            {
        //                list.Add(new GetPanDetailsResponseApiCls
        //                {
        //                    firstname = item["fname"].ToString(),
        //                    lastname = item["lname"].ToString(),
        //                    middlename = item["mname"].ToString(),
        //                    refid = item["refid"].ToString(),
        //                    gender = item["gender"].ToString(),
        //                    mode = item["mode"].ToString(),
        //                    email = item["email"].ToString(),
        //                    url = item["url"].ToString(),
        //                    encdata = item["encdata"].ToString(),
        //                    type = item["type"].ToString(),
        //                    title = item["title"].ToString(),
        //                    EntryDate = item["entrydate"].ToString(),

        //                });
        //            }

        //            return Ok(new { status = true, message = "success", response = list });
        //        }
        //        else
        //        {
        //            return Ok(new { status = false, message = "Fail", response = (dynamic)null });
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { status = false, message = e.Message, response = (dynamic)null });
        //    }
        //}



        //#endregion

        #endregion End 

        #region shani 02/05/2023  InsertBBPSDetails

        [HttpPost]
        [Route("api/InsertBBPSDetails")]
        public IActionResult InsertBBPSDetails(BBPSInsertApiCls req)
        {

            try
            {
                if (req.canumber != "" && req.mode != "")
                {
                    DataTable dt = db.InsertBBPSDetailsForApi(req);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        #endregion


        #region  02/05/2023  InsertLPGBillPay

        [HttpPost]
        [Route("api/InsertLPGBillPay")]
        public IActionResult InsertLPGBillPay(BBPSInsertApiCls req)
        {

            try
            {
                if (req.canumber != "" && req.mode != "")
                {
                    DataTable dt = db.InsertLPGForApi(req);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        #endregion

        # region InsertElectricityBillPay 02/05/2023 

        [HttpPost]
        [Route("api/InsertElectricityBillPay")]
        public IActionResult InsertElectricityBillPay(BBPSInsertApiCls req)
        {

            try
            {
                if (req.canumber != "" && req.mode != "")
                {
                    DataTable dt = db.InsertElectricityDetailsForApi(req);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        return Ok(new { status = true, message = "success", response = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "fail", response = (dynamic)null });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "Please Chack Mobile Number...", response = (dynamic)null });
                }
            }
            catch (Exception e)
            {

                return Ok(new { status = false, message = e.Message, response = (dynamic)null });
            }

        }

        #endregion 
        #region CallBack 
        [HttpPost]
        [Route("api/callback1")]
        public IActionResult CallBack(OnboardRequesBody objP)
        {
            return Ok(new { status =   "200", message = "Transaction completed successfully" });
           // DataTable dt = db.UserCallbackDetails(objP);
            //IActionResult CallbackRes = CallbackReturn(dt);
            //return CallbackRes;
        }


        private IActionResult CallbackReturn(DataTable dt)
        {
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    return Ok(new { status = "200", message = "Transaction completed successfully" });
                }
                else
                {
                    return Ok(new { status = 400, message = "Transaction Failed" });
                }
            }
            catch
            {
                return Ok(new { status = 400, message = "Transaction Failed" });
            }
        }

        #endregion




    }
}
