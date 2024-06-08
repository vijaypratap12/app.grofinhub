using GoogleMaps.LocationServices;
using Grofinhub.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Nancy.Json;
//using Microsoft.VisualStudio.Web.CodeGeneration;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;
using System.Device.Location;
using System.Threading;
using System.Reflection;
using System.Security.Cryptography.Xml;
using Nancy;
using static SportsBattle.Controllers.HomeController;
using System.ComponentModel;
using static GoogleMaps.LocationServices.Constants;
using Microsoft.SqlServer.Server;

namespace SportsBattle.Controllers
{
	[Sessioncheck]
	public class AdminController : Controller
	{

		PropertyClass pcobj = new PropertyClass();
		DBHelper DB = new DBHelper();
		CommonClasses sm = new CommonClasses();
		clsAdminLogic db;
		private readonly IHostingEnvironment _hostingEnvironment;
		static string base64String = null;
		public AdminController(IHostingEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
			db = new clsAdminLogic();
		}
		public IActionResult Dashboard()
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt1 = db.UserMenuPermission("3", Convert.ToString(HttpContext.Session.GetString("UserId")));
			ViewBag.pertbl = dt1;
			clsHomePageDetails obj = new clsHomePageDetails();
			return View(obj);

		}
		// code to select member details
		public IActionResult UserDetails(string Type, string FromDate, string ToDate)
		{
			clsPlayer objP = new clsPlayer();
			if (Type == "GetUser")
			{
				objP.Action = Type;
				objP.dtDetails = db.PlayerDetails(objP);
				return View(objP);
			}
			else if (Type == "GetAlluser")
			{
				objP.Action = Type;
				objP.FromDate = FromDate;
				objP.ToDate = ToDate;

				DataTable dtDetails = db.PlayerAllDetails(objP);
				List<MemberDetailsModel> mlist = new List<MemberDetailsModel>();
				foreach (DataRow row in dtDetails.Rows)
				{
					MemberDetailsModel member = new MemberDetailsModel();
					member.Member_Unique_ID = row["Member_Unique_ID"].ToString();
					member.Member_Name = row["Member_Name"].ToString();
					member.Mobile_No = row["Mobile_No"].ToString();
					member.Member_DOB = row["Member_DOB"].ToString();
					member.Gender = row["Gender"].ToString();
					member.Address = row["Address"].ToString();
					member.Pincode = row["Pincode"].ToString();
					member.RefferId = row["RefferId"].ToString();
					member.DrivingLicence = row["DrivingLicence"].ToString();
					member.OwnerShips = row["OwnerShips"].ToString();
					member.FrontImage = row["FrontImage"].ToString();
					member.BackImage = row["BackImage"].ToString();
					member.SideImage = row["SideImage"].ToString();
					member.UserType_ID = row["UserType_ID"].ToString();
					member.ErCount = row["ErCount"].ToString();
					member.ChCount = row["ChCount"].ToString();
					member.BatCount = row["BatCount"].ToString();
					member.AdCount = row["AdCount"].ToString();
					member.EntryDate = row["EntryDate"].ToString();
					member.ER_BuyCount = row["ER_BuyCount"].ToString();
					member.ER_SellCount = row["ER_SellCount"].ToString();
					member.ER_RentCount = row["ER_RentCount"].ToString();
					member.B_ChargingCount = row["B_ChargingCount"].ToString();
					member.B_SwappingCount = row["B_SwappingCount"].ToString();
					member.B_RentalCount = row["B_RentalCount"].ToString();
					mlist.Add(member);
				}
				return Json(mlist);
			}
			return View(objP);
		}

		//code to SelectMemberDetails for popup
		[HttpPost]
		public ActionResult SelectMemberDetails(string id)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Action",4),
				new SqlParameter("@id",id),
			};
			DataTable table = DB.ExecProcDataTable("member_registrations", parameters);
			List<MemberDetailsModel> mlist = new List<MemberDetailsModel>();
			foreach (DataRow row in table.Rows)
			{
				MemberDetailsModel member = new MemberDetailsModel();
				member.Member_Unique_ID = row["Member_Unique_ID"].ToString();
				member.Member_Name = row["Member_Name"].ToString();
				member.Mobile_No = row["Mobile_No"].ToString();
				member.Member_DOB = row["Member_DOB"].ToString();
				member.Gender = row["Gender"].ToString();
				member.Address = row["Address"].ToString();
				member.Pincode = row["Pincode"].ToString();
				member.RefferId = row["RefferId"].ToString();
				member.DrivingLicence = row["DrivingLicence"].ToString();
				member.OwnerShips = row["OwnerShips"].ToString();
				member.FrontImage = row["FrontImage"].ToString();
				member.BackImage = row["BackImage"].ToString();
				member.SideImage = row["SideImage"].ToString();
				member.UserType_ID = row["UserType_ID"].ToString();
				member.ErCount = row["ErCount"].ToString();
				member.ChCount = row["ChCount"].ToString();
				member.BatCount = row["BatCount"].ToString();
				member.AdCount = row["AdCount"].ToString();
				member.EntryDate = row["EntryDate"].ToString();
				member.ER_BuyCount = row["ER_BuyCount"].ToString();
				member.ER_SellCount = row["ER_SellCount"].ToString();
				member.ER_RentCount = row["ER_RentCount"].ToString();
				member.B_ChargingCount = row["B_ChargingCount"].ToString();
				member.B_SwappingCount = row["B_SwappingCount"].ToString();
				member.B_RentalCount = row["B_RentalCount"].ToString();
				member.VAMember_Unique_ID = row["Member_Unique_ID"].ToString();
				member.decentroTxnId = row["decentroTxnId"].ToString();
				member.status = row["status"].ToString();
				member.responseCode = row["responseCode"].ToString();
				member.message = row["message"].ToString();
				member.bank = row["bank"].ToString();
				member.bankstatus = row["bankstatus"].ToString();
				member.bankmessage = row["bankmessage"].ToString();
				member.accountNumber = row["accountNumber"].ToString();
				member.ifsc = row["ifsc"].ToString();
				member.allowedMethods = row["allowedMethods"].ToString();
				member.currency = row["currency"].ToString();
				member.transactionLimit = row["transactionLimit"].ToString();
				member.minimumBalance = row["minimumBalance"].ToString();
				member.upiId = row["upiId"].ToString();
				member.upiQrCode = row["upiQrCode"].ToString();
				member.upiOnboardingStatus = row["upiOnboardingStatus"].ToString();
				member.upiOnboardingStatusDescription = row["upiOnboardingStatusDescription"].ToString();
				member.virtualAccountBalanceSettlement = row["virtualAccountBalanceSettlement"].ToString();
				member.VDEntryDate = row["EntryDate"].ToString();
				mlist.Add(member);
			}
			return Json(mlist);
		}


		public IActionResult VenderDetails()
		{
			SqlParameter[] para = new SqlParameter[]
			{
				 new SqlParameter("@Action","Show_Vendor")
			};
			DataTable res = DB.ExecProcDataTable("USP_VendorDetails", para);
			return View(res);
		}
		[HttpPost]
		public IActionResult VenderDetails(VenderModel v)
		{
			string ID = String.Empty;
			if (TempData["id"] != null)
			{
				ID = TempData["id"].ToString();
			}

			v.Password = Convert.ToString(sm.GeneratePassword());
			string ac = "Save_Vendor";
			SqlParameter[] para = new SqlParameter[]
			{
				new SqlParameter("@vendername",v.vendor_Name),
				new SqlParameter("@mobno",v.Mobile_No),
				new SqlParameter("@password",v.Password),
				new SqlParameter("@dob",v.vendor_DOB),
				new SqlParameter("@gender",v.Gender),
				new SqlParameter("@address",v.Address),
				new SqlParameter("@pincode",v.Pincode),
				new SqlParameter("@Action",ac),
				new SqlParameter("@id",ID)
			};
			int res = DB.ExeCUD("USP_VendorDetails", para);
			return RedirectToAction("VenderDetails");
		}

		//code to update vendor
		public ActionResult UpdateVender(VenderModel v)
		{
			try
			{
				SqlParameter[] param = new SqlParameter[]
				{
				new SqlParameter("@Action","Update_Vendor"),
				new SqlParameter("@id",v.id),
				new SqlParameter("@vendername",v.vendor_Name),
				new SqlParameter("@mobileno",v.Mobile_No),
				new SqlParameter("@password",v.Password),
				new SqlParameter("@dob",v.vendor_DOB),
				new SqlParameter("@gender",v.Gender),
				new SqlParameter("@address",v.Address),
				new SqlParameter("@pincode",v.Pincode)
				};
				int res = DB.ExeCUD("USP_VendorDetails", param);
				if (res > 0)
				{
					return Json("Updated Succesfully");
				}
				else
					return Json("Something Went Wrong! Please Try Again");
			}
			catch (Exception ex)
			{
				return Content("<script>alert(" + ex.Message + ");location.href='admin/VenderDetails'</script>");
			}


		}
		//code to delete vendor
		public ActionResult DeleteVender(string id)
		{
			try
			{
				SqlParameter[] param = new SqlParameter[]
				{
					new SqlParameter("@Action","Delete_Vendor"),
					new SqlParameter("@id",id)
				};
				int res = DB.ExeCUD("USP_VendorDetails", param);
				return Json(res);
			}
			catch (Exception ex)
			{
				return Content("<script>alert(" + ex.Message + ");location.href='admin/VenderDetails'</script>");
			}
		}

		//code to SelectVendorDetails for popup

		public ActionResult SelectVendorDetails(string id)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Action","Merge_Vendor"),
				new SqlParameter("@id",id),
			};
			DataTable dt = DB.ExecProcDataTable("USP_VendorDetails", parameters);
			List<VenderModel> vlist = new List<VenderModel>();
			foreach (DataRow row in dt.Rows)
			{
				VenderModel vendors = new VenderModel();
				vendors.id = row["vendor_Unique_ID"].ToString();
				vendors.vendor_Name = row["vendor_Name"].ToString();
				vendors.Mobile_No = row["Mobile_No"].ToString();
				vendors.Password = row["Password"].ToString();
				vendors.vendor_DOB = row["vendor_DOB"].ToString();
				vendors.Gender = row["Gender"].ToString();
				vendors.Address = row["Address"].ToString();
				vendors.Pincode = row["Pincode"].ToString();
				vendors.BranchName = row["BranchName"].ToString();
				vendors.IsActive = Convert.ToInt32(row["IsActive"]);
				vendors.EntryBy = row["EntryBy"].ToString();
				vendors.EntryDate = row["EntryDate"].ToString();
				vendors.UpdateBy = row["UpdateBy"].ToString();
				vendors.UpdateDate = row["UpdateDate"].ToString();
				vendors.decentroTxnId = row["decentroTxnId"].ToString();
				vendors.status = row["status"].ToString();
				vendors.bankstatus = row["bankstatus"].ToString();
				vendors.responseCode = row["responseCode"].ToString();
				vendors.bankmessage = row["message"].ToString();
				vendors.BankName = row["bank"].ToString();
				vendors.bankstatus = row["bankstatus"].ToString();
				vendors.bankmessage = row["bankmessage"].ToString();
				vendors.accountNumber = row["accountNumber"].ToString();
				vendors.ifsc = row["ifsc"].ToString();
				vendors.allowedMethods = row["allowedMethods"].ToString();
				vendors.currency = row["currency"].ToString();
				vendors.transactionLimit = row["transactionLimit"].ToString();
				vendors.minimumBalance = row["minimumBalance"].ToString();
				vendors.UPIId = row["upiId"].ToString();
				vendors.upiQrCode = row["upiQrCode"].ToString();
				vendors.upiOnboardingStatus = row["upiOnboardingStatus"].ToString();
				vendors.upiOnboardingStatusDescription = row["upiOnboardingStatusDescription"].ToString();
				vendors.virtualAccountBalanceSettlement = row["virtualAccountBalanceSettlement"].ToString();
				vendors.VEntryDate = row["EntryDate1"].ToString();
				vlist.Add(vendors);
			}
			return Json(vlist);
		}
		public JsonResult BindPendingCount()
		{
			clsBindPendingCount objp = new clsBindPendingCount();
			string msg = "";
			try
			{
				DataTable dt = db.GetDashbordDetails("BindPendingCount");
				if (dt != null && dt.Rows.Count > 0)
				{

					objp.TotalGamePending = Convert.ToInt32(dt.Rows[0]["TotalGamePending"].ToString());
					objp.TotalWithdraPending = Convert.ToInt32(dt.Rows[0]["TotalWithdraPending"].ToString());
				}
			}
			catch (Exception ex)
			{
				msg = "0";
			}
			return Json(objp);
		}
		public IActionResult AddBanner(clsBanner obj, IFormFile ImageURL)
		{
			string msg = "";
			var allowedExtensions = new[] {
			".Jpg", ".png",".pdf", ".doc",".jpg", ".jpeg"
		};
			if (ImageURL != null)
			{
				var ext = Path.GetExtension(ImageURL.FileName);
				if (allowedExtensions.Contains(ext))
				{
					string wwwPath = this._hostingEnvironment.WebRootPath;
					string contentPath = this._hostingEnvironment.ContentRootPath;
					string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Upload/Banner");
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					List<string> uploadedFiles = new List<string>();
					string fileName = Path.GetFileName(ImageURL.FileName);
					using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
					{
						ImageURL.CopyTo(stream);
						uploadedFiles.Add(fileName);
						ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
					}
					obj.ImageURL = "/Upload/Banner/" + fileName;
					obj.Action = "Insert";
					DataTable dt = db.AddBanner(obj);
					if (dt.Rows.Count > 0)
					{
						obj.msg = "1";
					}
				}
				else
				{
					obj.msg = "0";
				}
			}
			obj.Action = "Details";
			obj.dt = db.AddBanner(obj);
			return View(obj);
		}
		public JsonResult DeleteBanner(string Sid)
		{
			string msg = "0";
			clsBanner obj = new clsBanner();
			obj.Id = Sid;
			obj.Action = "Delete";
			DataTable dt = db.AddBanner(obj);
			if (dt != null && dt.Rows.Count > 0)
			{
				msg = Convert.ToString(dt.Rows[0]["msg"]);
			}
			return Json(msg);
		}
		public IActionResult AddCommission(clsCommission obj, IFormFile ImageURL)
		{
			if (Convert.ToDecimal(obj.Commission) > 0)
			{

				var allowedExtensions = new[] {
			".Jpg", ".png",".pdf", ".doc",".jpg", ".jpeg"
		};

				if (ImageURL != null)
				{
					var ext = Path.GetExtension(ImageURL.FileName);
					if (allowedExtensions.Contains(ext))
					{
						string wwwPath = this._hostingEnvironment.WebRootPath;
						string contentPath = this._hostingEnvironment.ContentRootPath;
						string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Upload/Banner");
						if (!Directory.Exists(path))
						{
							Directory.CreateDirectory(path);
						}
						List<string> uploadedFiles = new List<string>();
						string fileName = Path.GetFileName(ImageURL.FileName);
						using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
						{
							ImageURL.CopyTo(stream);
							uploadedFiles.Add(fileName);
							ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
						}
						obj.ImageURL = "/Upload/Banner/" + fileName;
					}
				}
				obj.Action = "UpdateCommisson";
				DataTable dt1 = db.Commission(obj);
				if (dt1.Rows.Count > 0)
				{
					TempData["msg"] = "Record Updated";
				}
			}
			obj.Action = "GetCommisson";
			DataTable dt = db.Commission(obj);
			obj.Commission = dt.Rows[0]["PrizePoolPer"].ToString();
			obj.RefferalCommission = dt.Rows[0]["RefferalCommission"].ToString();
			obj.IsPopup = Convert.ToBoolean(dt.Rows[0]["IsPopup"]);
			obj.IsAppUnderMaintance = Convert.ToBoolean(dt.Rows[0]["IsAppUnderMaintance"]);
			obj.ImageURL = dt.Rows[0]["ImageURL"].ToString();
			return View(obj);
		}
		public IActionResult Notification()
		{
			clsNotification obj = new clsNotification();
			obj.Action = "GetNotification";
			obj.dt = db.Notification(obj);
			return View(obj);
		}
		[HttpPost]
		public IActionResult Notification(clsNotification obj, IFormFile ImageURL)
		{
			obj.Action = "GetNotification";
			obj.dt = db.Notification(obj);
			if (!ModelState.IsValid)
			{
				return View(obj);
			}
			if ((obj.NotificationTitle) != "")
			{

				var allowedExtensions = new[] {
			".Jpg", ".png",".pdf", ".doc",".jpg", ".jpeg"
		};
				if (ImageURL != null)
				{
					var ext = Path.GetExtension(ImageURL.FileName);
					if (allowedExtensions.Contains(ext))
					{
						string wwwPath = this._hostingEnvironment.WebRootPath;
						string contentPath = this._hostingEnvironment.ContentRootPath;
						string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Upload/Notification");
						if (!Directory.Exists(path))
						{
							Directory.CreateDirectory(path);
						}
						List<string> uploadedFiles = new List<string>();
						string fileName = Path.GetFileName(ImageURL.FileName);
						using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
						{
							ImageURL.CopyTo(stream);
							uploadedFiles.Add(fileName);
							ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
						}
						obj.ImageURL = "http://sportsbattleapi.sigmasoftwares.co/Upload/Notification/" + fileName;
					}
					else
					{
						obj.ImageURL = null;
					}
				}

				if (obj.Type != "SpecificUser")
				{
					obj.Action = "GetUserList";
					DataTable dt1 = db.Notification(obj);
					obj.UserId = dt1.Rows[0]["UserId"].ToString();
				}
				else
				{

				}
				sm.GetNotification2(obj.UserId, obj.NotificationTitle, obj.NotificationDescription, obj.ImageURL);

				if (obj.IsSave == true)
				{
					obj.Action = "Insert";
					obj.dt = db.Notification(obj);
				}
			}
			obj.Action = "GetNotification";
			obj.dt = db.Notification(obj);
			return View(obj);
		}
		public JsonResult DeleteNotification(string Sid)
		{
			string msg = "0";
			clsNotification obj = new clsNotification();
			obj.Id = Sid;
			obj.Action = "Delete";
			DataTable dt = db.Notification(obj);
			if (dt != null && dt.Rows.Count > 0)
			{
				msg = Convert.ToString(dt.Rows[0]["msg"]);
			}
			return Json(msg);
		}

		public ActionResult DailyLimit()
		{

			return View();
		}
		public IActionResult AdminCommissionReport()
		{
			clsAdminCommissionReport obj = new clsAdminCommissionReport();
			obj.Action = "AdminCommissionReport";
			obj.dt = db.AdminCommissionReport(obj);
			return View(obj);
		}
		[HttpPost]
		public IActionResult AdminCommissionReport(clsAdminCommissionReport obj)
		{
			obj.Action = "AdminCommissionReport";
			obj.dt = db.AdminCommissionReport(obj);
			return View(obj);
		}
		public JsonResult PasswordChange(ChangePasswordModel Pro)
		{
			ChangePasswordModel obj = new ChangePasswordModel();

			string msg = "";
			try
			{
				Pro.UserID = Convert.ToString(HttpContext.Session.GetString("UserId"));
				DataTable dt = db.ChangePassword(Pro);
				if (dt != null && dt.Rows.Count > 0)
				{
					if (dt.Rows[0]["response"].ToString() == "success")
					{
						obj.Message = dt.Rows[0]["Message"].ToString();
						obj.Flag = "1";
					}

					else
					{
						obj.Message = dt.Rows[0]["Message"].ToString();
						obj.Flag = "0";
					}

				}
			}
			catch (Exception ex)
			{
				msg = ex.Message;
			}

			return Json(obj);
		}
		public IActionResult AdminDetails()
		{
			clsHomePageDetails obj = new clsHomePageDetails();
			DataTable dt1 = new DataTable();
			obj.Action = "GetLoginHistory";
			obj.dt = db.AdminDashboard(obj);
			obj.Action = "GetAdminDetails";
			dt1 = db.AdminDashboard(obj);
			if (dt1.Rows.Count > 0)
			{
				obj.FacebookLink = dt1.Rows[0]["FacebookLink"].ToString();
				obj.WhatsappNo = dt1.Rows[0]["WhatsappNo"].ToString();
				obj.WhatsappLink = dt1.Rows[0]["WhatsappLink"].ToString();
				obj.YouTubeLink = dt1.Rows[0]["YouTubeLink"].ToString();
				obj.TelegramLink = dt1.Rows[0]["TelegramLink"].ToString();
				obj.InstagramLink = dt1.Rows[0]["InstagramLink"].ToString();
			}
			return View(obj);
		}
		[HttpPost]
		public IActionResult AdminDetails(clsHomePageDetails obj)
		{
			obj.Action = "UpdateSocialMediaLink";
			obj.dt = db.AdminDashboard(obj);
			return View(obj);
		}
		public JsonResult Resend(string NotificationId)
		{
			clsHomePageDetails obj1 = new clsHomePageDetails();
			obj1.Action = "GetNotificationDetails";
			obj1.Id = NotificationId;
			DataTable dt = new DataTable();
			dt = db.AdminDashboard(obj1);

			clsNotification obj = new clsNotification();

			if (dt.Rows[0]["Type"].ToString() != "SpecificUser")
			{
				obj.Action = "GetUserList";
				obj.Type = dt.Rows[0]["Type"].ToString();
				DataTable dt1 = db.Notification(obj);
				obj.UserId = dt1.Rows[0]["UserId"].ToString();
			}

			sm.GetNotification2(obj.UserId, dt.Rows[0]["NotificationTitle"].ToString(), dt.Rows[0]["NotificationDescription"].ToString(), dt.Rows[0]["ImageURL"].ToString());
			return Json("1");
		}

		public IActionResult PaymentAction()
		{
			return View();
		}







		//public IActionResult DMT()
		//{
		//    return View();
		//}

		public IActionResult QueryRemmiter()
		{

			DataTable dt = db.BindGetBankList();
			ViewBag.GSTState = db.InsertGSTState("", "", "1");

			DataTable dtaddress = db.BindGetBankList();

			ViewBag.RechargeRefId = db.GetReferenceIdDMTTransaction(Convert.ToString(HttpContext.Session.GetString("UserId")), "DMT");




			return View(dt);

		}





		public IActionResult RegisterRemmiter(string Mobile, string stateresp)
		{
			ViewBag.Mobile = Mobile;
			ViewBag.Stateresp = stateresp;
			return View();
		}

		#region mohd nadeem 23-02-2023

		public IActionResult PartnerRegistration()
		{
			ViewBag.Qualist = PropertyClass.BindDDL(db.BindQualificationDropDown());
			ViewBag.Statelist = PropertyClass.BindDDL(db.BindStateDropDown());
			ViewBag.Distlist = PropertyClass.BindDDL(db.BindDistrictDropDown(""));
			ViewBag.blocklist = PropertyClass.BindDDL(db.BindBlockDropDown(""));
			ViewBag.Banklist = PropertyClass.BindDDL(db.BindBankdetailDropDown());
			return View();
		}

		public JsonResult getBlockCode(string DistrictCode)
		{
			CommonMasterCls objp = new CommonMasterCls();
			try
			{

				DataTable dt = db.BindBlockDropDown(DistrictCode);
				if (dt != null && dt.Rows.Count > 0)
				{
					List<CommonMasterCls> list = new List<CommonMasterCls>();

					foreach (DataRow dr in dt.Rows)
					{
						list.Add(new CommonMasterCls() { id = dr["Id"].ToString(), name = dr["BlockName"].ToString() });

					}

					objp.DataList = list;
				}
			}
			catch (Exception ex)
			{

			}
			return Json(objp);


		}

		public JsonResult getDistrictCode(string StateId)
		{
			CommonMasterCls objp = new CommonMasterCls();
			try
			{

				DataTable dt = db.BindDistrictDropDown(StateId);
				if (dt != null && dt.Rows.Count > 0)
				{
					List<CommonMasterCls> list = new List<CommonMasterCls>();
					foreach (DataRow dr in dt.Rows)
					{
						list.Add(new CommonMasterCls() { id = dr["Id"].ToString(), name = dr["DistrictName"].ToString() });

						//string s = dr["DistrictName"].ToString();
						//string m = dr["Id"].ToString();
						//pcobj.DistList.Add(new SelectListItem { Text = Convert.ToString(dr["DistrictName"]), Value = Convert.ToString(dr["Id"]) });
					}
					objp.DataList = list;
				}
			}
			catch (Exception ex)
			{

			}
			return Json(objp);


		}

		public JsonResult InsertUpdateRegistrationDetails(RegistrationCls p)
		{
			Responsemsgcls objp = new Responsemsgcls();
			string msg = "";
			try
			{

				var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
				var stringChars = new char[8];
				var random = new Random();

				for (int i = 0; i < stringChars.Length; i++)
				{
					stringChars[i] = chars[random.Next(chars.Length)];
				}

				p.Password = new String(stringChars);


				p.EntryBy = HttpContext.Session.GetString("UserName");


				string statuscheck = AccountDetailValidate(p.AccountNo, p.IFSCCode);
				if (statuscheck == "1")
				{
					DataTable dt = db.InsertupdateregistrationNew(p);
					if (dt != null && dt.Rows.Count > 0)
					{
						objp.strId = dt.Rows[0]["id"].ToString();
						objp.msg = dt.Rows[0]["msg"].ToString();
					}
					else
					{
						objp.strId = "0";
						objp.msg = "Not Added Record";
					}
				}
				else
				{
					objp.strId = "0";
					objp.msg = "Account Detail Not Validate";
				}


			}
			catch (Exception ex)
			{
				objp.strId = "0";
				objp.msg = ex.Message;
			}
			return Json(objp);
		}

		public JsonResult AdharNoValidate(string aadharno)
		{
			Responsemsgcls res = new Responsemsgcls();

			//      Random ran = new Random();
			//string  refid= ran.Next(00000,99999).ToString();
			//      string licenceno = "UP32 20180041702";
			//      string dobs = "1995-07-01";
			//      var options = new RestClientOptions("https://paysprint.in")
			//      {
			//          MaxTimeout = -1,
			//      };
			//      var client = new RestClient(options);
			//      var request = new RestRequest("/service-api/api/v1/service/verification/drivinglicense/validate", Method.Post);

			//      request.AddHeader("accept", "application/json");
			//      request.AddHeader("Token", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ0aW1lc3RhbXAiOjE2NDk2Nzk1MTksInBhcnRuZXJJZCI6InBzMDAxIiwicmVxaWQiOiI0NXl1eWpoZ2Z2Y2QifQ.nk0kp4EDyVzS6hc9hhN14XYhg4aD3LlMy-cg4POmiAI");
			//      request.AddHeader("Authorisedkey", "MzNkYzllOGJmZGVhNWRkZTc1YTgzM2Y5ZDFlY2EyZTQ=");
			//      request.AddHeader("Content-Type", "application/json");
			//      request.AddParameter("application/json", "{\"refid\":"+ refid + ",\"license_number\":"+ licenceno+",\"dob\":"+ dobs + "}", ParameterType.RequestBody);

			//      RestResponse response = client.Execute(request);
			//      string statuscode = response.StatusCode.ToString();
			//      return Json(statuscode);

			Rootaadhar radhar = new Rootaadhar();
			Random ran = new Random();
			string refid = ran.Next(00000000, 99999999).ToString();
			//  string aadharno1 = "375477403141";

			var options = new RestClientOptions("https://paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/service-api/api/v1/service/verification/aadharcard/validate", Method.Post);

			request.AddHeader("accept", "application/json");
			//request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetToken());
			request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");

			AadharAPIcls apc = new AadharAPIcls();
			apc.refid = refid;
			apc.aadhar_number = aadharno;

			string body = JsonConvert.SerializeObject(apc);




			request.AddStringBody(body, DataFormat.Json);



			RestResponse response = client.Execute(request);
			radhar = JsonConvert.DeserializeObject<Rootaadhar>(response.Content);
			if (radhar.response_code == "1")
			{
				res.strId = "1";
				res.msg = "Sucess";
			}
			else
			{
				res.strId = "0";
				res.msg = "Aadhar Number Not Validate";
			}

			//string statuscode = response.StatusCode.ToString();
			//if (statuscode == "OK")
			//{
			//    res.strId = "1";
			//    res.msg = "Sucess";
			//}
			//else
			//{
			//    res.strId = "0";
			//    res.msg = "Aadhar Number Not Validate";
			//}
			return Json(res);

		}

		public JsonResult PANNoValidate(string panno)
		{
			Responsemsgcls res = new Responsemsgcls();

			RootPAN rootp = new RootPAN();


			Random ran = new Random();
			string refid = ran.Next(00000000, 99999999).ToString();


			var options = new RestClientOptions("https://paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/service-api/api/v1/service/pan/verify", Method.Post);

			request.AddHeader("accept", "application/json");
			//request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetToken());
			request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");

			PANNoAPICls pacl = new PANNoAPICls();
			pacl.pannumber = panno;
			pacl.referenceid = refid;

			string body = JsonConvert.SerializeObject(pacl);

			request.AddStringBody(body, DataFormat.Json);




			RestResponse response = client.Execute(request);


			rootp = JsonConvert.DeserializeObject<RootPAN>(response.Content);
			if (rootp.response_code == 1)
			{
				res.strId = "1";
				res.msg = "Sucess";
			}
			else
			{
				res.strId = "0";
				res.msg = "Aadhar Number Not Validate";
			}


			//string contenntdata = response.Content;
			//string statuscode = response.StatusCode.ToString();
			//if (statuscode == "OK")
			//{
			//    res.strId = "1";
			//    res.msg = "Sucess";
			//}
			//else
			//{
			//    res.strId = "0";
			//    res.msg = "PAN Number Not Validate";
			//}
			return Json(res);

		}

		public string AccountDetailValidate(string AccountNo, string IfscCode)
		{

			RootAccount racc = new RootAccount();

			Random ran = new Random();
			string refid = ran.Next(00000000, 99999999).ToString();

			bool IfscCode_status = false;
			if (!string.IsNullOrEmpty(IfscCode))
			{
				IfscCode_status = true;
			}


			var options = new RestClientOptions("https://paysprint.in")
			{
				MaxTimeout = -1,
			};


			var client = new RestClient(options);
			var request = new RestRequest("/service-api/api/v1/service/verification/bank/verify", Method.Post);

			request.AddHeader("accept", "application/json");
			//request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetToken());
			request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");

			Accountrequest accreq = new Accountrequest();
			accreq.refid = refid;
			accreq.account_number = AccountNo;
			accreq.ifsc = IfscCode;
			accreq.ifsc_details = IfscCode_status;

			string body = JsonConvert.SerializeObject(accreq);




			request.AddStringBody(body, DataFormat.Json);



			RestResponse response = client.Execute(request);

			racc = JsonConvert.DeserializeObject<RootAccount>(response.Content);
			if (racc.response_code == 1)
			{
				return "1";
			}
			else
			{
				return "0";
			}


		}

		public JsonResult SaveRecorddata(RegisterRemitercls p)
		{
			Rootaadhar res = new Rootaadhar();
			p.Stateresp = Convert.ToString(HttpContext.Session.GetString("Stateresp"));
			RootAccount statuscheck = RemitterReg(p);
			if (statuscheck.response_code == 1)
			{
				DataTable dt = db.InsertupdateregistrationRemitter(p);
				if (dt != null && dt.Rows.Count > 0)
				{
					res.response_code = dt.Rows[0]["id"].ToString();
					//res.msg = dt.Rows[0]["msg"].ToString();
					res.msg = statuscheck.message;
				}
				else
				{
					res.response_code = "0";
					res.msg = statuscheck.message;
				}

			}
			else
			{
				res.response_code = "0";
				res.msg = statuscheck.message;
			}


			return Json(res);
		}

		public RootAccount RemitterReg(RegisterRemitercls p)
		{

			RootAccount racc = new RootAccount();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};


			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/remitter/registerremitter", Method.Post);

			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			RegisterRemiterApicls regremcls = new RegisterRemiterApicls();
			// regremcls.otp = p.OTP;
			regremcls.otp = p.OTP;
			regremcls.stateresp = p.Stateresp;
			regremcls.gst_state = p.gst_state;
			regremcls.address = p.Address;
			regremcls.firstname = p.FirstName;
			regremcls.lastname = p.LastName;
			regremcls.pincode = p.Pincode;
			regremcls.bank3_flag = p.Bank3_flag;
			regremcls.dob = Convert.ToDateTime(p.dob).ToString("yyyy-MM-dd");
			regremcls.mobile = p.mobile;
			string body = JsonConvert.SerializeObject(regremcls);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootAccount>(response.Content);
			//if (racc.response_code == 1)
			//{
			//    return "1";
			//}
			//else
			//{
			//    return "0";
			//}
			return racc;


		}

		public JsonResult SendOtp(RegisterRemitercls p)
		{
			Responsemsgcls res = new Responsemsgcls();
			clsSMS_API smsapi = new clsSMS_API();

			try
			{
				Random rn = new Random();
				string otp = rn.Next(000000, 999999).ToString();
				//     smsapi.SendSMS(p.mobile, otp);

				HttpContext.Session.SetString("OTP", Convert.ToString(otp));

				res.strId = "1";
				res.msg = otp;

			}
			catch
			{
				res.strId = "0";
				res.msg = "";
			}




			return Json(res);
		}

		public JsonResult QueryRemmiterPost(string mobile, string bank3_flag)
		{
			RootQueryremiter racc = new RootQueryremiter();
			Responsemsgcls res = new Responsemsgcls();
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
			QueryParametercls accreq = new QueryParametercls();
			accreq.mobile = mobile;
			accreq.bank3_flag = bank3_flag;
			string body = JsonConvert.SerializeObject(accreq);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootQueryremiter>(response.Content);
			if (racc.response_code == 1)
			{
				string jsonobj = JsonConvert.SerializeObject(racc.data);
				// res.dt = (DataTable)JsonConvert.DeserializeObject("[" + jsonobj + "]", (typeof(DataTable)));
				racc.response_code = 1;
				return Json(racc);
			}
			else if (racc.response_code == 0 && racc.message == "Remitter not registered OTP sent for new registration.")
			{
				RootNewAddQueryremiter raccn = JsonConvert.DeserializeObject<RootNewAddQueryremiter>(response.Content);

				racc.response_code = 2;
				res.stateresp = raccn.stateresp;
				HttpContext.Session.SetString("Stateresp", raccn.stateresp);
				return Json(racc);
			}
			else
			{
				racc.response_code = 0;
				racc.message = racc.message;
				return Json(racc);
			}



		}

		#endregion

		#region AEPS  27-02-2023

		public IActionResult AEPS()
		{
			RootAEPS banklist = sm.AEPSBankList();
			return View(banklist);
		}

		public IActionResult AdharPay()
		{
			return View();
		}

		public IActionResult Operatorlist()
		{
			return View();
		}

		public IActionResult DoRecharge()
		{
			return View();
		}

		public IActionResult DTH()
		{
			try
			{

				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/recharge/recharge/getoperator", Method.Post);
				request.AddHeader("accept", "application/json");
				// string GetToken = sm.GetToken();
				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				RestResponse response = client.Execute(request);
				RootHLRdt dt = JsonConvert.DeserializeObject<RootHLRdt>(response.Content);
				//ViewBag.OperatorList = response.Content;

				var options1 = new RestClientOptions("https://app.grofinhub.com")
				{
					MaxTimeout = -1,
				};
				var client1 = new RestClient(options1);
				var request1 = new RestRequest("/api/Services/api/GetCircleList", Method.Post);
				RestResponse response1 = client1.Execute(request1);
				RootHLR dt1 = JsonConvert.DeserializeObject<RootHLR>(response1.Content);
				//Console.WriteLine(response.Content);
				ViewBag.rechargeplan = dt1.response;
				return View(dt.data);
			}
			catch
			{
				return View(new DataTable());
			}
		}

		public IActionResult DTHINFO()
		{
			return View();
		}

		public IActionResult DTHRecharge()
		{
			return View();
		}

		public IActionResult LIC()
		{

			ViewBag.LicRefId = db.GetReferencLICBillDetails(Convert.ToString(HttpContext.Session.GetString("UserId")), "LIC");

			return View();
		}

		public IActionResult LICBillPay()
		{
			return View();
		}

		public IActionResult LICBillInfo()
		{
			return View();
		}
		#endregion

		#region Atul Singh 2023/03/02

		public IActionResult GetBeneficiaryDetails(BeneficiaryParaMld p)
		{
			RootBeneficiaryDetailsMdl racc = new RootBeneficiaryDetailsMdl();
			Responsemsgclsbenefi res = new Responsemsgclsbenefi();
			if (p.mobile.Length == 10)
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/fetchbeneficiary", Method.Post);
				request.AddHeader("accept", "application/json");
				request.AddHeader("Token", sm.GetLiveToken());
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				RegisterRemiterApicls regremcls = new RegisterRemiterApicls();
				string body = JsonConvert.SerializeObject(p);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				racc = JsonConvert.DeserializeObject<RootBeneficiaryDetailsMdl>(response.Content);
				List<BeneficiaryDetailsMdl> list = new List<BeneficiaryDetailsMdl>();
				if (racc.response_code == 1 && racc.status == true)
				{
					string jsonobj = JsonConvert.SerializeObject(racc.data);
					DataTable dta = (DataTable)JsonConvert.DeserializeObject(jsonobj, (typeof(DataTable)));

					if (dta != null && dta.Rows.Count > 0)
					{
						foreach (DataRow row in dta.Rows)
						{
							list.Add(new BeneficiaryDetailsMdl()
							{
								accno = row["accno"].ToString(),
								bankid = row["bankid"].ToString(),
								bankname = row["bankname"].ToString(),
								banktype = row["banktype"].ToString(),
								bene_id = row["bene_id"].ToString(),
								ifsc = row["ifsc"].ToString(),
								name = row["name"].ToString(),
								paytm = row["paytm"].ToString(),
								verified = row["verified"].ToString(),
							});
						}
						res.dt = list;
						res.strId = "1";
					}
					else
					{
						res.msg = racc.message;
						res.strId = "3";
					}
					return Json(res);
				}
				else if (racc.response_code == 2)
				{
					res.msg = racc.message;
					res.strId = "2";
					return Json(res);
					// return "0";
				}
				else
				{
					res.msg = racc.message;
					res.strId = "3";
					return Json(res);
				}

				//return View();
			}
			else
			{
				res.msg = "Enter Valid Mobile No.";
				res.strId = "0";
				return Json(res);
			}
		}

		public IActionResult GetBeneficiaryDetailById(RootBeneficiaryMdlById p)
		{
			RootBeneficiaryDetailsMdl racc = new RootBeneficiaryDetailsMdl();
			Responsemsgclsbenefi res = new Responsemsgclsbenefi();
			if (p.mobile.Length == 10)
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/fetchbeneficiarybybeneid", Method.Post);
				request.AddHeader("accept", "application/json");
				request.AddHeader("Token", sm.GetLiveToken());
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				//RegisterRemiterApicls regremcls = new RegisterRemiterApicls();
				string body = JsonConvert.SerializeObject(p);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				racc = JsonConvert.DeserializeObject<RootBeneficiaryDetailsMdl>(response.Content);
				List<BeneficiaryDetailsMdl> list = new List<BeneficiaryDetailsMdl>();
				if (racc.response_code == 1 && racc.status == true)
				{
					string jsonobj = JsonConvert.SerializeObject(racc.data);
					DataTable dta = (DataTable)JsonConvert.DeserializeObject(jsonobj, (typeof(DataTable)));

					if (dta != null && dta.Rows.Count > 0)
					{
						foreach (DataRow row in dta.Rows)
						{
							list.Add(new BeneficiaryDetailsMdl()
							{
								accno = row["accno"].ToString(),
								bankid = row["bankid"].ToString(),
								bankname = row["bankname"].ToString(),
								banktype = row["banktype"].ToString(),
								bene_id = row["bene_id"].ToString(),
								ifsc = row["ifsc"].ToString(),
								name = row["name"].ToString(),
								paytm = row["paytm"].ToString(),
								verified = row["verified"].ToString(),
							});
						}
						res.dt = list;
						res.strId = "1";
					}
					else
					{
						res.msg = racc.message;
						res.strId = "3";
					}
					return Json(res);
				}
				else if (racc.response_code == 2)
				{
					res.msg = racc.message;
					res.strId = "2";
					return Json(res);
					// return "0";
				}
				else
				{
					res.msg = racc.message;
					res.strId = "3";
					return Json(res);
				}

				//return View();
			}
			else
			{
				res.msg = "Enter Valid Mobile No.";
				res.strId = "0";
				return Json(res);
			}
		}

		public RootAccount BenefiDel(BeneficiaryDelete p)
		{

			RootAccount racc = new RootAccount();

			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};


			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/deletebeneficiary", Method.Post);

			request.AddHeader("accept", "application/json");
			//request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");


			string body = JsonConvert.SerializeObject(p);



			request.AddStringBody(body, DataFormat.Json);



			RestResponse response = client.Execute(request);

			racc = JsonConvert.DeserializeObject<RootAccount>(response.Content);
			//if (racc.response_code == 1)
			//{

			//    return "1";
			//}
			//else if (racc.response_code == 3)
			//{
			//    return "3";
			//}
			//else
			//{
			//    return "0";
			//}
			return racc;


		}

		public IActionResult BeneficiaryDelete(BeneficiaryDelete p)
		{
			BeneficiaryDeleteret res = new BeneficiaryDeleteret();
			try
			{
				if (p.mobile.Length == 10)
				{
					RootAccount rescode = BenefiDel(p);
					if (rescode.response_code == 1)
					{
						DataTable dt = db.DeleteBeneficiary(p.mobile);
						if (dt != null && dt.Rows.Count > 0)
						{
							res.strId = "1";
							res.msg = rescode.message;



						}


					}
					else if (rescode.response_code == 3)
					{
						res.strId = "3";
						res.msg = rescode.message;
					}
					else
					{
						res.strId = "0";
						res.msg = rescode.message;
					}

					//return View();
				}
				else
				{
					res.msg = "Enter Valid Mobile No.";
					res.strId = "0";

				}
			}
			catch (Exception ex)
			{
				res.msg = "Somehting Went Wrong !!";
			}
			return Json(res);
		}

		public RootAccount BeneficiaryReg(RootBeneficiaryRegister p)
		{

			RootAccount racc = new RootAccount();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary", Method.Post);

			request.AddHeader("accept", "application/json");
			// request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			p.dob = Convert.ToDateTime(p.dob).ToString("yyyy-MM-dd");
			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootAccount>(response.Content);
			return racc;
		}

		public IActionResult BeneficiaryDetailInsert(RootBeneficiaryRegister p)
		{
			BeneficiaryDeleteret res = new BeneficiaryDeleteret();
			try
			{
				if (p.mobile.Length == 10)
				{
					string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
					RootAccount rescode = BeneficiaryReg(p);
					if (rescode.response_code == 1)
					{
						DataTable dt = db.InsertBeneficiary(p, userid);
						if (dt != null && dt.Rows.Count > 0)
						{
							res.strId = "1";
							res.msg = rescode.message;
						}
					}
					else
					{
						res.strId = "0";
						res.msg = rescode.message;
					}

					//return View();
				}
				else
				{
					res.msg = "Enter Valid Mobile No.";
					res.strId = "0";

				}
			}
			catch (Exception ex)
			{
				res.msg = "Something Went Wrong !!";
				res.strId = "0";
			}
			return Json(res);
		}

		#endregion

		#region 02/03/2023 Transaction 
		public JsonResult InsertTransaction(Transactioncls p)
		{
			Responsemsgcls res = new Responsemsgcls();
			RootTransaction racc = TransactionApi(p);
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.InsertTransaction(p, racc, userid);
			if (dt != null && dt.Rows.Count > 0)
			{
				res.strId = dt.Rows[0]["id"].ToString();
			}
			res.msg = racc.message;
			return Json(racc);
		}
		public RootTransaction TransactionApi(Transactioncls p)
		{
			p.UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			double payamount = Convert.ToDouble(p.Amount);
			RootTransaction racc = new RootTransaction();
			double pipeamount = Convert.ToDouble(p.Amount);
		transactionagain:
			string repipe = WalletModal.GetPipe(p.UserId, ref pipeamount);
			p.Pipe = repipe;
			payamount = payamount - pipeamount;
			p.Amount = payamount.ToString();
		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());

			DataTable dt = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = p.Amount, UserId = p.UserId, type = "DMT" });
			if (dt.Rows.Count > 0 && dt != null)
			{
				p.Referenceid = referenceid;
			}
			else
			{
				goto again;
			}
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};

			TansactionBody tbody = new TansactionBody();
			tbody.mobile = p.Mobile;
			tbody.referenceid = p.Referenceid;
			tbody.pipe = p.Pipe;
			tbody.pincode = p.Pincode;
			tbody.address = p.Address;
			tbody.dob = p.Dob;
			tbody.gst_state = p.Gst_state;
			tbody.bene_id = p.Bene_id;
			tbody.txntype = p.TxnType;
			tbody.amount = p.Amount;
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/transact/transact", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(tbody);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootTransaction>(response.Content);
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1" && racc.response_code == 1)
			{
				WalletModal.UpdateUserMainWallet(p.UserId, p.Amount, "DMT");
				HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(p.UserId)));
			}
			if (pipeamount > 0)
				goto transactionagain;
			else
				return racc;
		}
		public JsonResult TransactionPost(string RefeID)
		{
			TransactionstatusData racc = new TransactionstatusData();
			TranRe res = new TranRe();

			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};

			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/transact/transact/querytransact", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			request.AddHeader("Content-Type", "application/json");
			Transactionstatus accreq = new Transactionstatus();
			accreq.referenceid = RefeID;
			string body = JsonConvert.SerializeObject(accreq);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			//racc = JsonConvert.DeserializeObject<TransactionstatusData>(response.Content);
			//List<TransactionstatusData> list = new List<TransactionstatusData>();
			//if (racc.response_code == 1)
			//{
			//    DataTable dt = new DataTable();
			//    string jsonobj = JsonConvert.SerializeObject(racc);
			//    dt = (DataTable)JsonConvert.DeserializeObject("[" + jsonobj + "]", (typeof(DataTable)));
			//    //if (dt != null && dt.Rows.Count > 0)
			//    //{
			//    //    foreach (DataRow row in dt.Rows)
			//    //    {
			//    //        list.Add(new TransactionstatusData()
			//    //        {
			//    //            utr = row["utr"].ToString(),
			//    //            amount = row["amount"].ToString(),
			//    //            referenceid = row["referenceid"].ToString(),
			//    //            refundtxnid = row["refundtxnid"].ToString(),
			//    //            account = row["account"].ToString(),
			//    //            discount = row["discount"].ToString(),
			//    //            tds = row["tds"].ToString(),
			//    //            gst = row["gst"].ToString(),
			//    //            netcommission = row["netcommission"].ToString(),
			//    //            customercharge = row["customercharge"].ToString(),
			//    //            ackno = row["ackno"].ToString(),
			//    //            daterefunded = row["daterefunded"].ToString(),
			//    //        });
			//    //    }
			//    //    res.dtlist = list;
			//    //    res.strId = "1";
			//    //}
			//}
			//else
			//{
			//    res.strId = "0";
			//    //res.msg = "Record Not Found";
			//    res.msg = response.Content;
			//}
			res.msg = response.Content;
			return Json(res);

		}
		#endregion

		#region DTH Info 2023/03/14

		public JsonResult QueryDTHINFOPost(Rootdthinfobodyapi accreq)
		{
			string resdata = "";
			Rootdthapires racc = new Rootdthapires();
			try
			{
				if (accreq.op != null && accreq.canumber != "")
				{
					Responsemsgcls res = new Responsemsgcls();
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/recharge/hlrapi/dthinfo", Method.Post);
					request.AddHeader("accept", "application/json");
					//request.AddHeader("Token", DB.JWT);
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					RestResponse response = client.Execute(request);
					resdata = response.Content;

				}
				else
				{
					resdata = "Please Select Valid Operator & Phone No !!";
				}

			}
			catch (Exception)
			{
				//racc.message = "Something Went Wrong !!";

				resdata = "Something Went Wrong !!";
			}
			return Json(resdata);
		}

		public JsonResult DTHBrjowsPlan(RootDTHBrowsPlanPara accreq)
		{
			string resbody = "";

			try
			{

				if (accreq.circle != null && accreq.op != "")
				{
					Responsemsgcls res = new Responsemsgcls();

					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/recharge/hlrapi/browseplan", Method.Post);
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					request.AddHeader("accept", "application/json");
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					RestResponse response = client.Execute(request);

					//resbody = response.Content + "  # rques :  " + body +"  #Token: "+GetToken;
					resbody = response.Content;

				}
				else
				{
					//racc.response_code = "0";
				}
				return Json(resbody);
			}
			catch (Exception)
			{
				resbody = "Something Went Wrong !!";
				//racc.response_code = "0";
				return Json(resbody);
				//throw;
			}

		}

		#endregion

		#region shani 14/03/2023 shani
		//public IActionResult TransactionReport()
		//{

		//    DataTable dt = db.GetTransactionList();

		//    return View(dt);
		//}
		//public IActionResult BeneficiaryReport()
		//{
		//    DataTable dt = db.BeneficiaryReport();
		//    return View(dt);
		//}

		public IActionResult RemitterReport()
		{
			DataTable dt = db.RemitterReport();
			return View(dt);
		}
		public IActionResult TransactionStatus()
		{

			return View();
		}
		//public IActionResult RechargeReport()
		//{
		//    DataTable dt = db.RechargeList();
		//    return View(dt);
		//}
		#endregion

		#region DoRecharge Info 2023/03/15

		public IActionResult Recharge()
		{
			try
			{

				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/recharge/recharge/getoperator", Method.Post);
				request.AddHeader("accept", "application/json");

				// string GetToken = sm.GetToken();
				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				request.AddHeader("Content-Type", "application/json");
				RestResponse response = client.Execute(request);
				RootHLRdt dt = JsonConvert.DeserializeObject<RootHLRdt>(response.Content);
				ViewBag.OperatorList = response.Content;

				var options1 = new RestClientOptions("https://app.grofinhub.com")
				{
					MaxTimeout = -1,
				};
				var client1 = new RestClient(options1);
				var request1 = new RestRequest("/api/Services/api/GetCircleList", Method.Post);
				RestResponse response1 = client1.Execute(request1);
				RootHLR dt1 = JsonConvert.DeserializeObject<RootHLR>(response1.Content);
				ViewBag.rechargeplan = dt1.response;
				ViewBag.RechargeRefId = db.GetMobileRechargeDetails(Convert.ToString(HttpContext.Session.GetString("UserId")), "MOBILE");
				return View(dt.data);
			}
			catch
			{
				return View(new DataTable());
			}
			// return View();
		}

		#endregion

		#region 2023/03/21

		public IActionResult Pan()
		{
			ViewBag.RechargeRefId = db.GetReferencPan_Details(Convert.ToString(HttpContext.Session.GetString("UserId")), "PAN");
			return View();
		}

		#endregion

		#region  shani 21/03/2023

		public IActionResult EPFOKYC()
		{
			return View();
		}
		public JsonResult EPFOKYC_OTPSEND(EPFOAPIMODEL p)
		{
			Responsemsgcls res = new Responsemsgcls();


			string userid = HttpContext.Session.GetString("UserId");
		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());

			DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = "0", UserId = userid, type = "EPFO" });
			if (dt1.Rows.Count > 0 && dt1 != null)
			{

				p.refid = referenceid;

			}
			else
			{
				goto again;
			}

			string rques = EPFOKYC_OTPSENDAPI(p);
			if (rques == "1")
			{
				//res.OTP = Convert.ToString(sm.GenerateOTP());
				res.strId = "1";
				res.RefeID = p.refid;
			}
			else
			{
				res.strId = "0";
				res.msg = rques;

			}
			return Json(res);
		}
		public string EPFOKYC_OTPSENDAPI(EPFOAPIMODEL p)
		{

			RootEPFOSendOTP racc = new RootEPFOSendOTP();
			Responsemsgcls res = new Responsemsgcls();
			var options = new RestClientOptions("https://api.verifya2z.com")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/verification/sendOtp", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("User-Agent", CommonClasses.agentid);
			request.AddHeader("Token", sm.GetLiveVerifyToken());
			request.AddHeader("Content-Type", "application/json");

			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			if (response.Content != null)
				racc = JsonConvert.DeserializeObject<RootEPFOSendOTP>(response.Content);
			if (racc.statuscode == "200")
			{
				HttpContext.Session.SetString("EPFOClient_Id", racc.data.client_id);
				res.strId = "1";

			}
			else
			{
				res.strId = racc.message;
			}
			return res.strId;

		}

		public JsonResult KycDetailsGet(EPFOAPIMODELkyc p)
		{
			RootGetKYCDetailsRes kycdetailsres = new RootGetKYCDetailsRes();
			RootEPFOKycVerifyOPT racc = new RootEPFOKycVerifyOPT();
			p.client_id = HttpContext.Session.GetString("EPFOClient_Id");
			var options = new RestClientOptions("https://api.verifya2z.com")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/verification/VerifyOtp", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("User-Agent", CommonClasses.agentid);
			request.AddHeader("Token", sm.GetLiveVerifyToken());
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootEPFOKycVerifyOPT>(response.Content);
			if (racc.statuscode == "200")
			{
				string resdata = GetKYCDetailsByReferenceID(new EPFOAPIMODELGetkycDetails() { client_id = p.client_id });
				return Json(resdata);
			}
			else
			{
				return Json(racc.message);
			}



		}
		public string GetKYCDetailsByReferenceID(EPFOAPIMODELGetkycDetails p)
		{

			var options = new RestClientOptions("https://api.verifya2z.com")
			{
				MaxTimeout = -1,
			};

			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/verification/epfo_kyc_fetch", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("User-Agent", CommonClasses.agentid);
			request.AddHeader("Token", sm.GetLiveVerifyToken());
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			return response.Content;

		}

		public IActionResult BBPS()
		{

			ViewBag.BBPSRefId = db.GetReferenceIdBBPSBillDetails(Convert.ToString(HttpContext.Session.GetString("UserId")), "BBPS");
			return View();
		}

		public JsonResult BindOperatorList(BBPSReqModel model)
		{

			rootBBPS racc = new rootBBPS();
			Responsemsgcls res = new Responsemsgcls();


			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/bill-payment/bill/getoperator", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			// request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			operatorListbyBBPS accreq = new operatorListbyBBPS();
			accreq.mode = model.Mode;
			string body = JsonConvert.SerializeObject(model);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<rootBBPS>(response.Content);
			if (racc.response_code == 1)
			{
				string jsonobj = response.Content;


				racc.response_code = 1;
				return Json(jsonobj);
			}

			else
			{
				//racc.response_code = 0;
				//racc.message = "Not Found";
				return Json(response.Content);
			}



		}

		#endregion

		#region 22/03/2023 shani    
		public JsonResult FetchBillDetasilsApi(FillFecthModel model)
		{
			RootresponseBilldetails racc = new RootresponseBilldetails();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/bill-payment/bill/fetchbill", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			fillfecthRequest accreq = new fillfecthRequest();
			accreq.mode = model.Mode;
			accreq.@operator = model.OP;
			accreq.canumber = model.BillNo;
			string body = JsonConvert.SerializeObject(accreq);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootresponseBilldetails>(response.Content);
			//if (racc.response_code == 1)
			//{
			//    string jsonobj = response.Content;
			//    //racc.response_code = 1;
			//    return Json(jsonobj);
			//}

			//else
			//{
			//    racc.response_code = 0;
			//    racc.message = "Not Found";
			//    return Json(response.Content);
			//}
			return Json(response.Content);

		}

		public JsonResult FetchLicBillDetails(BillReq obj)
		{
			//Random ran = new Random();
			RootBillFetch racc = new RootBillFetch();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/bill-payment/bill/fetchlicbill", Method.Post);

			request.AddHeader("accept", "application/json");
			// request.AddHeader("Token", DB.JWT);
			string GetToken = sm.GetToken();
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(obj);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootBillFetch>(response.Content);
			if (racc.response_code == 1)
			{
				string jsonobj = response.Content;
				racc.response_code = 1;
				return Json(jsonobj);
			}

			else
			{
				racc.response_code = 0;
				racc.message = "Not Found";
				return Json(response.Content);
			}


		}

		#endregion

		#region [check pan status] 2023/03/22

		public IActionResult CheckPanStatus()
		{
			return View();
		}
		public JsonResult GetCheckPanStatus(CheckPanStatusBody reqq)
		{
			try
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/pan/V2/pan_status", Method.Post);
				request.AddHeader("accept", "application/json");
				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(reqq);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				var racc = JsonConvert.DeserializeObject(response.Content);
				string resdata = response.Content /*+ "    #Reques:  " + body + "   #token:  " + GetToken*/;
				return Json(resdata);
			}
			catch
			{
				string msg = "Something went Wrong!!";
				return Json(msg);
			}

		}
		#endregion

		public JsonResult Refund_opt(Transactioncls p)
		{
			RootQueryremiter rques = new RootQueryremiter();
			try
			{
				//Responsemsgcls res = new Responsemsgcls();      
				rques = Refund_optApi(p);
			}
			catch
			{
				rques.message = "Something Went Wrong !!";
			}
			return Json(rques);

		}
		public RootQueryremiter Refund_optApi(Transactioncls p)
		{
			RootQueryremiter racc = new RootQueryremiter();
			Responsemsgcls res = new Responsemsgcls();
			Random ran = new Random();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/refund/refund/resendotp", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			request.AddHeader("Content-Type", "application/json");
			RefundOpt accreq = new RefundOpt();
			accreq.ackno = p.Ackno;
			accreq.referenceid = p.Referenceid;
			string body = JsonConvert.SerializeObject(accreq);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootQueryremiter>(response.Content);
			return racc;

		}
		public JsonResult Claim_Refund(Transactioncls p)
		{
			RootQueryremiter racc = new RootQueryremiter();
			Responsemsgcls res = new Responsemsgcls();
			Random ran = new Random();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/refund/refund/", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			request.AddHeader("Content-Type", "application/json");
			Claim_refund accreq = new Claim_refund();
			accreq.ackno = p.Ackno;
			accreq.referenceid = p.Referenceid;
			accreq.otp = p.OTP;
			string body = JsonConvert.SerializeObject(accreq);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<RootQueryremiter>(response.Content);
			return Json(racc);

		}

		public IActionResult Refund()
		{
			return View();
		}
		#region report 2023/03/24


		public IActionResult PanReport()
		{
			DataTable dt = db.PanReport1("1", "", "", "");
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}

		[HttpPost]
		public IActionResult PanReport(string FormDate, string ToDate, string PartnerID)
		{
			DataTable dt = db.PanReport1("1", FormDate, ToDate, PartnerID);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}


		public IActionResult MemberList(string State = "0", string District = "0", string Block = "0")
		{

			//dt = new DataTable();
			DataTable dt = db.GetMasterDetails("3", State, District, Block);
			DataSet ds = db.GetMasterDetails("4");
			ViewBag.State = PropertyClass.BindDDL(ds.Tables[0]);
			ViewBag.District = PropertyClass.BindDDL(db.GetMasterDetails("5", State, District, Block));
			ViewBag.Block = PropertyClass.BindDDL(db.GetMasterDetails("6", State, District, Block));
			//DataTable dt1= ds.Tables[1];
			return View(dt);
		}
		#endregion
		#region 24/03/2023

		public IActionResult LicPayReport()
		{
			DataTable dt = new DataTable();
			dt = db.PanReport1("2", "", "","");
			return View(dt);
		}

		[HttpPost]
		public IActionResult LicPayReport(string FormDate, string ToDate, string PartnerID)
		{
			DataTable dt = new DataTable();
			dt = db.PanReport1("2", FormDate, ToDate, PartnerID);
			return View(dt);
		}


		#endregion

		#region Manage Member 2023/03/25
		[HttpPost]
		public JsonResult MemberList(string id)
		{

			//dt = new DataTable();
			DataTable dt = db.ManageUser(id);
			//DataTable dt = db.PanReport("3");
			string msg = dt.Rows[0]["msg"].ToString();
			return Json(msg);


		}

		//public IActionResult MainDashboard()
		//{
		//    return View();
		//}
		public IActionResult ComplianceAllDetails(string para, string paraPage)
		{
			try
			{
				string userid = HttpContext.Session.GetString("UserId");
				//string userid = "GSL00003";
				//para = "";
				//ViewBag.Type = paraPage.ToString();
				ViewBag.Type = paraPage.ToString();
				para = para.ToLower();
				ViewBag.TypeSaveDbB = para;
				DataTable dt = db.SaveDocDetails(userid, "4", para);
				DocDetailsApiRes obj = new DocDetailsApiRes();
				if (dt != null && dt.Rows.Count > 0)
				{
					obj.Id = dt.Rows[0]["id"].ToString();
					obj.Aadharno = dt.Rows[0]["AadharNo"].ToString();
					obj.Ad1 = dt.Rows[0]["Ad1"].ToString();
					obj.Ad1PicBack = dt.Rows[0]["Ad1PicBack"].ToString();
					obj.Ad2PicBack = dt.Rows[0]["Ad2PicBack"].ToString();
					obj.Ad3PicBack = dt.Rows[0]["Ad3PicBack"].ToString();
					obj.Ad1PicFront = dt.Rows[0]["Ad1PicFront"].ToString();
					obj.Ad2PicFront = dt.Rows[0]["Ad2PicFront"].ToString();
					obj.Ad3PicFront = dt.Rows[0]["Ad3PicFront"].ToString();
					obj.Ad2 = dt.Rows[0]["Ad2"].ToString();
					obj.Ad3 = dt.Rows[0]["Ad3"].ToString();
					obj.AdharPicBack = dt.Rows[0]["AadharPicBack"].ToString();
					obj.AdharPicFront = dt.Rows[0]["AadharPicFront"].ToString();
					obj.Billno = dt.Rows[0]["Billno"].ToString();
					obj.Doctype = dt.Rows[0]["DocType"].ToString();
					obj.Email = dt.Rows[0]["Email"].ToString();
					obj.Entrydate = dt.Rows[0]["EntryDate"].ToString();
					obj.Entrytype = dt.Rows[0]["EntryType"].ToString();
					obj.Mobileno = dt.Rows[0]["Mobileno"].ToString();
					obj.Panno = dt.Rows[0]["PanNo"].ToString();
					obj.PanPicBack = dt.Rows[0]["PanPicBack"].ToString();
					obj.PanPicFront = dt.Rows[0]["PanPicFront"].ToString();
					obj.Userid = dt.Rows[0]["Userid"].ToString();

					obj.Ad4 = dt.Rows[0]["Ad4"].ToString();
					obj.Ad4PicFront = dt.Rows[0]["Ad4PicFront"].ToString();
					obj.Ad4PicBack = dt.Rows[0]["Ad4PicBack"].ToString();

					obj.Ad5 = dt.Rows[0]["Ad5"].ToString();
					obj.Ad5PicFront = dt.Rows[0]["Ad5PicFront"].ToString();
					obj.Ad5PicBack = dt.Rows[0]["Ad5PicBack"].ToString();
					obj.Ad6 = dt.Rows[0]["Ad6"].ToString();
					obj.Ad6PicFront = dt.Rows[0]["Ad6PicFront"].ToString();
					obj.Ad6PicBack = dt.Rows[0]["Ad6PicBack"].ToString();

					obj.Ad7 = dt.Rows[0]["Ad7"].ToString();
					obj.Ad7PicFront = dt.Rows[0]["Ad7PicFront"].ToString();
					obj.Ad7PicBack = dt.Rows[0]["Ad7PicBack"].ToString();

					obj.Ad8 = dt.Rows[0]["Ad8"].ToString();
					obj.Ad8PicFront = dt.Rows[0]["Ad8PicFront"].ToString();
					obj.Ad8PicBack = dt.Rows[0]["Ad8PicBack"].ToString();

					obj.Ad9 = dt.Rows[0]["Ad9"].ToString();
					obj.Ad9PicFront = dt.Rows[0]["Ad9PicFront"].ToString();
					obj.Ad9PicBack = dt.Rows[0]["Ad9PicBack"].ToString();

					obj.Ad10 = dt.Rows[0]["Ad10"].ToString();
					obj.Ad10PicFront = dt.Rows[0]["Ad10PicFront"].ToString();
					obj.Ad10PicBack = dt.Rows[0]["Ad10PicBack"].ToString();

					obj.Name = dt.Rows[0]["Name"].ToString();
					obj.Income = dt.Rows[0]["Income"].ToString();
					obj.Address = dt.Rows[0]["Address"].ToString();


				}
				return View(obj);
			}


			catch (Exception ex)
			{
				return View();
			}

		}
		public JsonResult SaveComplianceAllDetails(SaveComplianceAllDetailsPara para)
		{
			string msg = "";
			try
			{

				para.UserId = HttpContext.Session.GetString("UserId").ToString();
				if (para.AdharPicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "AdharFront_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.AdharPicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.AdharPicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.AdharPicFrontfilename = DefaultImagePath;
				}
				if (para.AdharPicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "AdharBack_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.AdharPicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.AdharPicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.AdharPicBackfilename = DefaultImagePath;
				}
				if (para.PanPicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "PanFront_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.PanPicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);

					//para.PanPicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.PanPicFrontfilename = DefaultImagePath;
				}
				if (para.PanPicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "PanBack_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.PanPicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.PanPicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.PanPicBackfilename = DefaultImagePath;
				}
				if (para.Ad1PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad1Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad1PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad1PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad1PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad1PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad1Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad1PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad1PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad1PicBackfilename = DefaultImagePath;
				}
				if (para.Ad2PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad2Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad2PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad2PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad2PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad2PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad2Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad2PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad2PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad2PicBackfilename = DefaultImagePath;
				}
				if (para.Ad3PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad3Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad3PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad3PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad3PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad3PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad3Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad3PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad3PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad3PicBackfilename = DefaultImagePath;
				}

				//ad4
				if (para.Ad4PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad4Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad4PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad4PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad4PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad4PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad4Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad4PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad4PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad4PicBackfilename = DefaultImagePath;
				}
				//ad5
				if (para.Ad5PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad5Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad5PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad5PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad5PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad5PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad5Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad5PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad5PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad5PicBackfilename = DefaultImagePath;
				}
				//ad6
				if (para.Ad6PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad6Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad6PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad6PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad6PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad6PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad6Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad6PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad6PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad6PicBackfilename = DefaultImagePath;
				}
				//ad7
				if (para.Ad7PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad7Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad7PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad7PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad7PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad7PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad7Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad7PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad7PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad7PicBackfilename = DefaultImagePath;
				}
				//ad8
				if (para.Ad8PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad8Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad8PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad8PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad8PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad8PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad8Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad8PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad8PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad8PicBackfilename = DefaultImagePath;
				}
				//ad9
				if (para.Ad9PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad9Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad9PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					para.Ad9PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
				}
				if (para.Ad9PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad9Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad9PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad9PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad9PicBackfilename = DefaultImagePath;
				}
				//ad10

				if (para.Ad10PicFront != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad10Front_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad10PicFront.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad10PicFrontfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad10PicFrontfilename = DefaultImagePath;
				}
				if (para.Ad10PicBack != null)
				{
					string DefaultImagePath = "/Upload/ScreenShot/" + para.UserId + "Ad10Back_" + DateTime.Now.Ticks + ".jpg";
					string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

					using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
					{
						para.Ad10PicBack.CopyTo(stream);
					}
					//para.AdharPicFront.Save(DefaultImagePath1);
					//para.Ad10PicBackfilename = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
					para.Ad10PicBackfilename = DefaultImagePath;
				}
				DataTable dt = db.SaveDocDetails(para);
				msg = dt.Rows[0]["msg"].ToString();

			}
			catch (Exception ex)
			{
				//throw ex;
				msg = "Something Went Wrong !!";
			}
			return Json(msg);
		}

		#endregion

		#region Shani 25/03/2023

		public IActionResult Finance()
		{
			return View();
		}

		public IActionResult Investment()
		{
			return View();
		}


		public IActionResult Insurance()
		{
			return View();
		}

		public IActionResult Compliance()
		{
			return View();
		}


		#endregion

		#region shani 25/03./2023

		//public IActionResult Commission()
		//{
		//    return View();
		//}

		[HttpPost]
		public JsonResult Addcommission(Commission d)
		{

			try
			{
				string Msg = "";
				// string Code = null;
				DataTable dt = new DataTable();
				d.EntryBy = HttpContext.Session.GetString("UserName");
				dt = db.AddCommission(d);
				if (dt != null && dt.Rows.Count > 0)
				{
					Msg = dt.Rows[0]["Msg"].ToString();

				}
				else
				{
					Msg = "Server Not Found";

				}
				return Json(Msg);
			}
			catch (Exception)
			{

				throw;
			}

		}

		#endregion


		#region [USER PERMISSION] 2023/03/27

		public IActionResult UserPermissIon()
		{
			DataTable dt = db.UserMenuPermission("1");
			return View(dt);
		}
		[HttpPost]
		public IActionResult ManagePermission(string menu, string id)
		{

			string dt = db.UserMenuPermission(menu, id, "2").Rows[0]["msg"].ToString();
			return Json(dt);
		}

		#endregion

		#region 27/03/2023 shani

		public IActionResult PartnerWallet()
		{
			DataTable dt = new DataTable();
			dt = db.PartnerWallet();
			return View(dt);
		}

		[HttpPost]
		public JsonResult RechargePartnerwallet(PartnerRecharge model)
		{
			try
			{
				DataTable dt = new DataTable();
				model.EntryBy = Convert.ToString(HttpContext.Session.GetString("UserId"));

				dt = db.PartnerRecharge(model);
				if (dt != null && dt.Rows.Count > 0)
				{
					model.Message = dt.Rows[0]["Message"].ToString();
					model.Flag = dt.Rows[0]["Flag"].ToString();
				}
				else
				{
					model.Message = "server not foud  !";
					model.Flag = "0";
				}
				return Json(model);
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		#endregion

		#region [GetMemberDocuments] 2023/03/29

		public IActionResult GetMemberDocuments(string type)
		{
			string action = type == null ? "5" : "6";
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.SaveDocDetails(userid, action, type);
			//string c = dt.Rows[1][3].ToString();
			return View(dt);
		}

		public IActionResult Commission()
		{
			if (HttpContext.Session.GetString("Role") == "1")
			{
				DataTable dt = db.ServiecsCommission();
				return View(dt);
			}
			else
				return RedirectToAction("Login", "account");
		}
		public IActionResult SaveUserCommission(UserCommissionBody pbody)
		{
			pbody.Action = "2";
			string msg = db.ServiecsCommission(pbody).Rows[0][0].ToString();
			return Json(msg);
		}
		#endregion
		#region 28/03/2023 PayBil Report

		public IActionResult PayBillReport()
		{
			DataTable dt = new DataTable();
			dt = db.BillPayReport("", "");
			return View(dt);
		}
		[HttpPost]
		public IActionResult PayBillReport(string FormDate, string ToDate)
		{
			DataTable dt = new DataTable();
			dt = db.BillPayReport(FormDate, ToDate);
			return View(dt);
		}



		#endregion
		#region shani 29/03/2023
		public IActionResult complain()
		{
			clsAllClasses obj = new clsAllClasses();
			DataTable dt = db.BindAllservicesType();
			obj.dt1 = dt;
			dt = db.saveusercomplain(new usercomplain() { UseriID = HttpContext.Session.GetString("UserId") }, "2");
			obj.dt2 = dt;
			return View(obj);
		}

		[HttpPost]
		public JsonResult UsercomplainDetailsSave(usercomplain model)
		{
			try
			{

				model.UseriID = Convert.ToString(HttpContext.Session.GetString("UserId"));
				DataTable dt = db.saveusercomplain(model, "1");
				if (dt != null && dt.Rows.Count > 0)
				{
					model.Message = dt.Rows[0]["Message"].ToString();
					model.Code = dt.Rows[0]["Code"].ToString();
				}
			}
			catch (Exception)
			{

				throw;
			}
			return Json(model);
		}

		public IActionResult complainReport()
		{

			DataTable dt = db.usercomplain_Report();
			return View(dt);
		}

		#endregion

		public IActionResult Video()
		{
            DataTable dt = db.uploadvideolink();
            clsAllClasses obj = new clsAllClasses();
            DataTable dt11 = db.BindAllservicesType();
            obj.dt1 = dt11;
			obj.dt2 = dt;
            return View(obj);
		}

		[HttpPost]
		public IActionResult Video(uploadvideoCls model)

		{

			model.UseriID = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.uploadvideolink(model);
			if (dt != null && dt.Rows.Count > 0)
			{
				TempData["Msg"] = dt.Rows[0]["Message"].ToString();
				TempData["Code"] = dt.Rows[0]["Code"].ToString();
			}
			else
			{
				TempData["Msg"] = "Sever not Found !";
				TempData["Code"] = "0";
			}
            DataTable dt12 = db.uploadvideolink();
            clsAllClasses obj = new clsAllClasses();
            DataTable dt11 = db.BindAllservicesType();
            obj.dt1 = dt11;
            obj.dt2 = dt12;
            return View(obj);
		}

		#region [Videolink] 2023/03/30

		public IActionResult VideoLink()
		{
			DataTable dt = db.uploadvideolink();
			return View(dt);
		}

		#endregion

		public IActionResult Payspintwallet()
		{
			DataTable dt = db.PaysprintwalletList();

			return View(dt);
		}

		[HttpPost]
		public IActionResult Payspintwallet(PaysprintRecharge model)
		{
			DataTable dt = db.Paysprintaddmount(model);
			if (dt != null && dt.Rows.Count > 0)
			{
				TempData["Msg"] = dt.Rows[0]["Message"].ToString();
				TempData["Code"] = dt.Rows[0]["Code"].ToString();
			}
			else
			{
				TempData["Msg"] = "Sever not Found !";
				TempData["Code"] = "0";
			}

			return View();
		}


		#region [Other Service] 2023/04/01


		public IActionResult OtherServic()
		{
			return View();
		}

		public IActionResult CustomerLead()
		{
			return View();
		}

		public IActionResult TransactionReportDashBoard()
		{
			return View();
		}

		#endregion

		public IActionResult GetMemberDocumentsbyFilter(MemberDetails model)
		{

			model.Action = "7";
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.SaveDocDetails(model);

			//string c = dt.Rows[1][3].ToString();
			return View("GetMemberDocuments", dt);
		}


		#region [MemberKYC] 2023/04/10
		public IActionResult MemberKYC(string data)
		{
			if (data != null)
			{
				// string body = CommonClasses.DecryptAESIn(data, CommonClasses.crypt_key, CommonClasses.IV);
			}
			DataTable dt = db.KYCDetails(new KYCDetailsBody() { Action = "2" });
			return View(dt);
		}
		public IActionResult SaveUpdateKYCDetails(KYCDetailsBody obj)
		{
			string msg = "";
			try
			{
				//if (obj.Aadharpicfront != null)
				//{
				//	string DefaultImagePath = "/Upload/ScreenShot/" + obj.Partnerid + "AdharFrontKYC_" + DateTime.Now.Ticks + ".jpg";
				//	string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

				//	using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
				//	{
				//		obj.Aadharpicfront.CopyTo(stream);
				//	}
				//	//para.AdharPicFront.Save(DefaultImagePath1);
				//	obj.Aadharpicfrontname = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
				//}
				//if (obj.Aadharpicback != null)
				//{
				//	string DefaultImagePath = "/Upload/ScreenShot/" + obj.Partnerid + "AdharBackKYC_" + DateTime.Now.Ticks + ".jpg";
				//	string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

				//	using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
				//	{
				//		obj.Aadharpicback.CopyTo(stream);
				//	}
				//	//para.AdharPicFront.Save(DefaultImagePath1);
				//	obj.Aadharpicbackname = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
				//}
				//if (obj.Panpicfront != null)
				//{
				//	string DefaultImagePath = "/Upload/ScreenShot/" + obj.Partnerid + "PanFrontKYC_" + DateTime.Now.Ticks + ".jpg";
				//	string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

				//	using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
				//	{
				//		obj.Panpicfront.CopyTo(stream);
				//	}
				//	//para.AdharPicFront.Save(DefaultImagePath1);
				//	obj.Panpicfrontname = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
				//}
				//if (obj.Panpicback != null)
				//{
				//	string DefaultImagePath = "/Upload/ScreenShot/" + obj.Partnerid + "PanBackKYC_" + DateTime.Now.Ticks + ".jpg";
				//	string DefaultImagePath1 = "wwwroot" + DefaultImagePath;

				//	using (var stream = new FileStream(DefaultImagePath1, FileMode.Create))
				//	{
				//		obj.Panpicback.CopyTo(stream);
				//	}
				//	//para.AdharPicFront.Save(DefaultImagePath1);
				//	obj.Panpicbackname = "http://grofinapi.sigmasoftwares.org/" + DefaultImagePath;
				//}
				obj.Action = "1";

				DataTable dt = db.KYCDetails(obj);
				if (dt != null && dt.Rows.Count > 0)
				{
					msg = dt.Rows[0]["msg"].ToString();
				}
				else
				{
					msg = "Details Not Save!!";
				}
			}
			catch
			{
				msg = "Something Went Wrong!!";
			}
			return Json(msg);
		}

		#endregion


		#region [MEMBER ACCESS] 2023/04/11
		public IActionResult SetMemberAccess()
		{
			DataSet ds = db.NewMemberAllotPermission("1");
			return View(ds);
		}
		public JsonResult SavePermission(string agentid, string roleper)
		{
			string msg = "";
			try
			{	
				DataTable dt = db.NewMemberAllotPermission("2", agentid, roleper);
				if (dt != null && dt.Rows.Count > 0)
				{
					msg = dt.Rows[0]["msg"].ToString();
				}
				else
				{
					msg = "PERMISSION NOT ALOT !!";
				}
			}
			catch
			{
				msg = "Something Went Wrong !!";
			}
			return Json(msg);
		}
		#endregion


		#region [do recharge states enquiry] 2023/04/12
		public JsonResult DoRechargeStatesEnquiry(Transactionstatus accreq)
		{

			// accreq.referenceid = "1234567892";
			string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			try
			{
				if (accreq.referenceid != null)
				{
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/recharge/recharge/status", Method.Post);
					request.AddHeader("accept", "application/json");

					// request.AddHeader("Token", DB.JWT);
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					var response = client.Execute(request);
					string retu = response.Content.ToString();
					DoRechargeEnqueryres EnquiryRes = JsonConvert.DeserializeObject<DoRechargeEnqueryres>(response.Content);
					EnquiryRes.action = "1";
					// EnquiryRes.data = new EnquiryData() { refid = "6i5tz6v4ZjeM63IqLmTl" };
					if (EnquiryRes.data != null && EnquiryRes.data.status == "0")
					{
						db.DoRechargeEnquiry(EnquiryRes);
					}
					return Json(retu);

				}
				else
				{

					return Json("Enter Reference Number!!");
				}

			}
			catch (Exception)
			{
				return Json("Something Went Wrong!!");
			}
		}


		public JsonResult LICStatesEnquiry(Transactionstatus accreq)
		{

			// accreq.referenceid = "1234567892";
			string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			try
			{
				if (accreq.referenceid != null)
				{
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/bill-payment/bill/licstatus", Method.Post);
					request.AddHeader("accept", "application/json");



					// request.AddHeader("Token", DB.JWT);
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					var response = client.Execute(request);
					string retu = response.Content.ToString();

					DoRechargeEnqueryres EnquiryRes = JsonConvert.DeserializeObject<DoRechargeEnqueryres>(response.Content);

					EnquiryRes.action = "2";
					// EnquiryRes.data = new EnquiryData() { refid = "6i5tz6v4ZjeM63IqLmTl" };
					if (EnquiryRes.data != null && EnquiryRes.data.status == "0")
					{
						db.DoRechargeEnquiry(EnquiryRes);
					}
					return Json(retu);

				}
				else
				{

					return Json("Enter Reference Number!!");
				}

			}
			catch (Exception)
			{
				return Json("Something Went Wrong!!");
			}
		}



		//
		public JsonResult PanStatesEnquiry(CheckPanStatusBody accreq)
		{

			// accreq.referenceid = "1234567892";
			string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			try
			{
				if (accreq.refid != null)
				{
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/pan/V2/txn_status", Method.Post);
					request.AddHeader("accept", "application/json");
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					var response = client.Execute(request);
					string retu = response.Content.ToString() /*+"  #request:  "+body+"  #token:  "+ GetToken*/;

					return Json(retu);

				}
				else
				{

					return Json("Enter Reference Number!!");
				}

			}
			catch (Exception)
			{
				return Json("Something Went Wrong!!");
			}
		}

		#endregion

		#region Electricity 2023/04/2023
		public ActionResult Electricity()
		{

			ViewBag.BBPSRefId = db.GetReferencElectricity_Details(Convert.ToString(HttpContext.Session.GetString("UserId")), "Electricity");
			return View();
		}
		public ActionResult LPG()
		{

			ViewBag.BBPSRefId = db.GetReferencLPG_Details(Convert.ToString(HttpContext.Session.GetString("UserId")), "LPG");
			return View();
		}
		#endregion

		public IActionResult Transaction()
		{
			DataTable dt = db.InsertGSTState("", "", "1");
			return View(dt);
		}

		public IActionResult RegisterBenificiary(string Mobile)
		{

			ViewBag.RegMobile = Mobile;
			DataTable dt = db.BindGetBankList();
			ViewBag.GSTState = db.InsertGSTState("", "", "1");
			return View(dt);
		}

		#region 2023/03/21

		public JsonResult SaveLicBillPayDetails(RootBodyLic accreq, BillFetchLic bill_fetch)
		{
			RootLicBillPayRes d = new RootLicBillPayRes();
			string type = "LIC";
			accreq.bill_fetch = bill_fetch;
			//accreq.latitude = "26.8500992";
			//accreq.longitude = "80.9992192";
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			Random ran = new Random();
			string Amount = accreq.amount;
			double DebitAmount = WalletModal.GetPartenDebitBalanceByUser(userid);
			double rechargeamount = Convert.ToDouble(Amount);
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
			{
				if (DebitAmount < rechargeamount)
				{
					d.response_code = "0";
					d.message = "Insufficient balance !!";
					return Json(d);
				}
			}

			string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			try
			{
				if (accreq.mode != null && accreq.mode != "0")
				{
				again:
					string referenceid = Convert.ToString(sm.GenerateReferenceId());

					DataTable dt = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = accreq.amount, UserId = UserId, type = "LIC" });
					if (dt.Rows.Count > 0 && dt != null)
					{

						accreq.referenceid = referenceid;
					}
					else
					{
						goto again;
					}

					Responsemsgcls res = new Responsemsgcls();

					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/bill-payment/bill/paylicbill", Method.Post);
					request.AddHeader("accept", "application/json");
					request.AddHeader("Token", sm.GetLiveToken());
					//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					RestResponse response = client.Execute(request);
					d = JsonConvert.DeserializeObject<RootLicBillPayRes>(response.Content);
					DataTable dtres = db.LicBillPayDetails(accreq, d);
					if (d.response_code == "1")
					{
						DataTable obj = db.UserDebitBlanceforservices(userid, Amount, type);
						HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));
					}

				}
				else
				{
					d.status = "false";
					d.message = "Select Mode";


				}
				return Json(d);
			}
			catch (Exception)
			{
				d.status = "false";
				d.message = "Something Went Wrong..";
				d.response_code = "0";
				//racc.response_code = "0";
				//throw;
				return Json(d);
			}
		}

		#endregion

		public JsonResult SavePamCardDetails(PanBody accreq)
		{
			Geturlencdata obj = new Geturlencdata();
			RootResPan d = new RootResPan();
			accreq.redirect_url = "https://app.grofinhub.com/Admin/Dashboard";

			//accreq.@operator = "11";

			string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			try
			{
				if (accreq.mode != null && accreq.mode != "0")
				{
				again:
					string referenceid = Convert.ToString(sm.GenerateReferenceId());

					DataTable dt = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = "0", UserId = UserId, type = "PAN" });
					if (dt.Rows.Count > 0 && dt != null)
					{

						accreq.refid = referenceid;
					}
					else
					{
						goto again;
					}

					Responsemsgcls res = new Responsemsgcls();
					Random ran = new Random();
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/pan/V2/generateurl", Method.Post);
					//var request = new RestRequest("/service-api/api/v1/service/pan/V2/generateurl", Method.Post);
					request.AddHeader("accept", "application/json");
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					RestResponse response = client.Execute(request);
					d = JsonConvert.DeserializeObject<RootResPan>(response.Content);
					DataTable dtres = new DataTable();
					if (d.data != null)
					{
						dtres = db.PanUrlEncdata(accreq, d.data.url, d.data.encdata);
					}
					if (dtres != null && dtres.Rows.Count > 0)
					{

						obj.Url = dtres.Rows[0]["url"].ToString();
						obj.Encdata = dtres.Rows[0]["encdata"].ToString();
					}
					//obj.Msg = d.message + "  Body:  " + body + "   responce  :   " + response.Content + "  Token   :  " + GetToken;
					obj.Msg = d.message;
					obj.rescode = d.response_code;
				}
				else
				{
					d.status = "false";
					d.message = "Select Mode";

					// racc.response_code = "0";
					//  racc.message = "Enter All Field";
				}
				return Json(obj);
			}
			catch (Exception)
			{
				d.status = "false";
				d.message = "Something Went Wrong..";
				d.response_code = "0";
				//racc.response_code = "0";
				//throw;
				return Json(d);
			}
		}

		#region wallet 2023/04/26
		public IActionResult Mainwallert()
		{
			try
			{
				ViewBag.MainBalance = WalletModal.PaystprintMAINWalletBalance();
				ViewBag.CashBalance = WalletModal.PaystprintCASHWalletBalance();

				ViewBag.RemainCashBalance = WalletModal.RemainingAdminCashWallet();
				ViewBag.RemainMainBalance = WalletModal.RemainingAdminMainWallet();
			}
			catch
			{

			}
			return View();
		}

		#endregion

		#region UserTaransactionReport 2023/04/26
		//public IActionResult UserTaransactionReport()
		//{
		//    string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
		//    DataTable dt = db.GetTransactionList(userid);

		//    return View(dt);
		//}
		//public IActionResult UserRechargeReport()
		//{
		//    string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
		//    DataTable dt = db.RechargeList(userid);
		//    return View(dt);
		//}

		//public IActionResult UserLicPayReport()
		//{
		//    string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
		//    DataTable dt = new DataTable();
		//    dt = db.PanReport("7", userid);
		//    return View(dt);
		//}



		public IActionResult UserTransactionDashboard()
		{
			return View();
		}

		#endregion

		[HttpPost]
		public JsonResult GetRemitterDetails()
		{

			DataTable dt = new DataTable();
			GetRemitterDetails obj = new GetRemitterDetails();
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			dt = db.GetDetailsQueryRemitter(userid);
			if (dt != null && dt.Rows.Count > 0)
			{
				obj.Address = dt.Rows[0]["Address"].ToString();
				obj.Pincode = dt.Rows[0]["Pincode"].ToString();
				obj.Dob = dt.Rows[0]["Dob"].ToString();
			}
			return Json(obj);
		}

		#region shani 01/05/2023

		public JsonResult PennyDropVerificationy(PennyDropRequest p)
		{

			RootAccount racc = new RootAccount();
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());
			DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = "0", UserId = userid, type = "PENNYDROP" });
			if (dt1.Rows.Count > 0 && dt1 != null)
			{
				p.referenceid = referenceid;
			}
			else
			{
				goto again;
			}
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/benenameverify", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			//racc = JsonConvert.DeserializeObject<RootAccount>(response.Content);
			return Json(response.Content);

		}

		#endregion

		#region 02/05/2023

		public JsonResult GetBBPSStatusEnquiry(StatusBBPSEnquiryRequest reqq)
		{
			try
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/bill-payment/bill/status", Method.Post);

				request.AddHeader("accept", "application/json");

				// request.AddHeader("Token", DB.JWT);
				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(reqq);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				var racc = JsonConvert.DeserializeObject(response.Content);
				return Json(response.Content);
			}
			catch
			{
				string msg = "Something went Wrong!!";
				return Json(msg);
			}

		}

		#endregion

		#region   shani 03/05/2023

		public IActionResult FASTAG()
		{
			try
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/fastag/Fastag/operatorsList", Method.Post);
				request.AddHeader("accept", "application/json");
				// request.AddHeader("Token", DB.JWT);
				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				RestResponse response = client.Execute(request);
				RootHLRdt dt = JsonConvert.DeserializeObject<RootHLRdt>(response.Content);
				ViewBag.RechargeRefId = db.GetMobileRechargeDetails(Convert.ToString(HttpContext.Session.GetString("UserId")), "FASTAG");
				return View(dt.data);
			}
			catch
			{
				return View(new DataTable());
			}

		}

		public JsonResult FetchConsumerDetails(FetchConsumerRequestApi obj)
		{
			FetchConsumerDetailsRoot racc = new FetchConsumerDetailsRoot();
			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/fastag/Fastag/fetchConsumerDetails", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("Token", sm.GetLiveToken());
			//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");

			string body = JsonConvert.SerializeObject(obj);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			return Json(response.Content.ToString());
		}

		public JsonResult FastTagRecharge(FastTagRechargeRequest obj, string strdata)
		{
			JavaScriptSerializer js = new JavaScriptSerializer();
			try
			{
				obj.bill_fetch = js.Deserialize<FastTagRechargeRequest_BillFetch>(strdata);

				string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));

			again:
				string referenceid = Convert.ToString(sm.GenerateReferenceId());

				DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = obj.amount, UserId = userid, type = "FASTAG" });
				if (dt1.Rows.Count > 0 && dt1 != null)
				{

					obj.referenceid = referenceid;
				}
				else
				{
					goto again;
				}
				Responsemsgcls res = new Responsemsgcls();
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/fastag/Fastag/recharge", Method.Post);
				request.AddHeader("accept", "application/json");
				request.AddHeader("Token", sm.GetLiveToken());
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(obj);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				RootNewAddQueryremiter data = js.Deserialize<RootNewAddQueryremiter>(response.Content);
				if (data.stateresp != null)
				{
					DataTable dt = db.FastTagRecharge(obj, data, userid);
				}
				if (data.response_code == 1)
				{
					WalletModal.UpdateUserMainWallet(userid, obj.amount, "FASTAG");
					HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));
				}
				return Json(response.Content);
			}
			catch
			{

				string data = js.Serialize(new RootNewAddQueryremiter() { message = "Something Went Wrong !!", response_code = 0 });
				//throw;
				return Json(data);
			}

		}

		public JsonResult FasTagStatusApi(StatusBBPSEnquiryRequest reqq)
		{
			try
			{
				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/fastag/Fastag/status", Method.Post);

				request.AddHeader("accept", "application/json");


				string GetToken = sm.GetLiveToken();
				request.AddHeader("Token", GetToken);
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(reqq);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				//var racc = JsonConvert.DeserializeObject(response.Content);
				return Json(response.Content);
			}
			catch
			{
				string msg = "Something went Wrong!!";
				return Json(msg);
			}

		}
		#endregion

		#region [onboarding] 2023/05/05

		public JsonResult UserOnbloarding(string Mobile, string Merchantcode, string is_new)
		{
			OnboardingBody req = new OnboardingBody();
			req.mobile = Mobile;
			req.email = "md@grofinhub.com";
			req.callback = "https://app.grofinhub.com/Admin/MemberKYC";
			//req.callback = "https://localhost:44317/Admin/MemberKYC";
			req.firm = "GROFINHUB SERVICES PRIVATE LIMITED";
			req.merchantcode = Merchantcode;
			req.is_new = is_new;
			try
			{
				string userid = HttpContext.Session.GetString("UserId");
				var options = new RestClientOptions("https://paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/service-api/api/v1/service/onboard/onboardnew/getonboardurl", Method.Post);
				request.AddHeader("accept", "application/json");
				string GetToken = sm.GetToken();
				request.AddHeader("Token", GetToken);
				request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(req);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				OnboardingRes racc = JsonConvert.DeserializeObject<OnboardingRes>(response.Content);
				HttpContext.Session.SetString("Request", body);
				DataTable dt = db.SaveUserOnboardin(racc, userid, Merchantcode);
				racc.msgbody = "Request :  " + body + "  Responce :  " + response.Content + "   Token :  " + GetToken;
				return Json(racc);
			}
			catch
			{
				OnboardingRes racc = new OnboardingRes() { status = "false", response_code = "0", message = "Something went Wrong!!" };

				return Json(racc);
			}

		}

		#endregion

		//new code

		#region Main Dashboard Admin 2023/05/06

		public IActionResult MainDashboard()
		{

			if (HttpContext.Session.GetString("Role") == "1")
			{
				ViewBag.CreditWallet = WalletModal.RemainingAdminMainWallet();
				ViewBag.DebitWallet = WalletModal.RemainingAdminCashWallet();
				DataTable dt = db.AdminDashboard("1");
				return View(dt);
			}
			else
				return RedirectToAction("Login", "account");


		}

		#endregion

		public ActionResult DoMobileRecharge(RootDoRecharge accreq)
		{
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
			{
				return RedirectToAction("Login", "Account");
			}
			RootResMobRecharg racc = new RootResMobRecharg();
			accreq.UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
			double walletamount = WalletModal.GetPartenDebitBalanceByUser(accreq.UserId);
			double rechargeamount = Convert.ToDouble(accreq.amount);
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
			{
				if (walletamount < rechargeamount)
				{
					racc.response_code = "0";
					racc.message = "Insufficient balance !!";
					return Json(racc);
				}
			}


			try
			{
				if (accreq.canumber != null && accreq.amount != "")
				{
				again:
					string referenceid = Convert.ToString(sm.GenerateReferenceId());

					DataTable dt = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = accreq.amount, UserId = accreq.UserId, type = "MOBILE" });
					if (dt.Rows.Count > 0 && dt != null)
					{

						accreq.referenceid = referenceid;
					}
					else
					{
						goto again;
					}

					Responsemsgcls res = new Responsemsgcls();
					var options = new RestClientOptions("https://api.paysprint.in")
					{
						MaxTimeout = -1,
					};
					var client = new RestClient(options);
					var request = new RestRequest("/api/v1/service/recharge/recharge/dorecharge", Method.Post);
					request.AddHeader("accept", "application/json");
					string GetToken = sm.GetLiveToken();
					request.AddHeader("Token", GetToken);
					request.AddHeader("Content-Type", "application/json");
					string body = JsonConvert.SerializeObject(accreq);
					request.AddStringBody(body, DataFormat.Json);
					RestResponse response = client.Execute(request);
					racc = JsonConvert.DeserializeObject<RootResMobRecharg>(response.Content);
					string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
					DataTable dtres = db.DoRecharge(accreq, racc, userid);
					if (racc.response_code != "1")
					{
						var res1 = DoRechargeStatesEnquiry(new Transactionstatus() { referenceid = referenceid });
					}
					else
					{
						if (Convert.ToString(HttpContext.Session.GetString("Role")) == "2")
						{

							WalletModal.UpdateUserMainWallet(accreq.UserId, accreq.amount, "mobile");
							HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));

						}
					}

				}
				else
				{
					racc.response_code = "0";
					racc.message = "Enter All Field";
				}
				return Json(racc);
			}
			catch (Exception)
			{
				racc.response_code = "0";
				return Json(racc);
				//throw;
			}
		}

		public ActionResult PayBill(PayBillModel obj, BillFetch_BBPS bill_fetch1, string BillType, string AmountDir)
		{

			try
			{

				if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
				{
					return RedirectToAction("Login", "Account");
				}
				obj.Amount = (obj.Amount == "" || obj.Amount == null) ? AmountDir : obj.Amount;
				BillPayResponse racc = new BillPayResponse();
				Responsemsgcls res = new Responsemsgcls();
				string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
				string Amount = obj.Amount;
				double DebitAmount = WalletModal.GetPartenDebitBalanceByUser(userid);
				double rechargeamount = Convert.ToDouble(Amount);
				if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
				{
					if (DebitAmount < rechargeamount)
					{
						racc.response_code = 0;
						racc.message = "Insufficient balance !!";
						return Json(racc);
					}
				}

			again:
				string referenceid = Convert.ToString(sm.GenerateReferenceId());

				DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = obj.Amount, UserId = userid, type = "BBPS" });
				if (dt1.Rows.Count > 0 && dt1 != null)
				{

					obj.Referenceid = referenceid;
				}
				else
				{
					goto again;
				}


				var options = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/v1/service/bill-payment/bill/paybill", Method.Post);
				request.AddHeader("accept", "application/json");
				request.AddHeader("Token", sm.GetLiveToken());
				//request.AddHeader("Authorisedkey", DB.AuthorizationKey);
				request.AddHeader("Content-Type", "application/json");
				BBPS_Body p = new BBPS_Body();
				p.bill_fetch = bill_fetch1;
				p.mode = obj.Mode;
				p.longitude = obj.Longitude;
				p.latitude = obj.Latitude;
				p.referenceid = obj.Referenceid;
				p.amount = obj.Amount;
				p.canumber = obj.Canumber;
				p.@operator = obj.OperatorID;
				p.ad1 = obj.Ad1;
				p.ad2 = obj.Ad2;
				p.ad3 = obj.Ad3;

				string body = JsonConvert.SerializeObject(p);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				racc = JsonConvert.DeserializeObject<BillPayResponse>(response.Content);
				if (racc.response_code == 1 && BillType == "BBPS")
				{
					//string jsonobj = JsonConvert.SerializeObject(racc);
					res.strId = "1";
					DataTable dtde = db.UserDebitBlanceforservices(userid, Amount, BillType);
					DataTable dt = db.Savebil_paydetails(obj, racc);
					HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));
				}
				else
				{
					DataTable dt = db.Savebil_paydetails(obj, racc);
				}

				return Json(racc);

			}
			catch (Exception)
			{
				return Json(new BillPayResponse() { response_code = 0, message = "Something Went Wrong !!" });
				//throw;
			}


		}

		public ActionResult PayBillElectricity(PayBillModel obj, BillFetch_BBPS bill_fetch1, string BillType, string AmountDir)
		{

			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
			{
				return RedirectToAction("Login", "Account");
			}
			obj.Amount = (obj.Amount == "" || obj.Amount == null) ? AmountDir : obj.Amount;
			//obj.bill_fetch = bill_fetch1;
			//obj.Latitude = "26.8500992";
			//obj.Longitude = "80.9992192";
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			BillPayResponse racc = new BillPayResponse();
			Responsemsgcls res = new Responsemsgcls();
			Random ran = new Random();
			string Amount = obj.Amount;
			double DebitAmount = WalletModal.GetPartenDebitBalanceByUser(userid);
			double rechargeamount = Convert.ToDouble(Amount);
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
			{
				if (DebitAmount < rechargeamount)
				{
					racc.response_code = 0;
					racc.message = "Insufficient balance !!";
					return Json(racc);
				}
			}



		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());

			DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = obj.Amount, UserId = userid, type = "Electricity" });
			if (dt1.Rows.Count > 0 && dt1 != null)
			{

				obj.Referenceid = referenceid;
			}
			else
			{
				goto again;
			}



			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/bill-payment/bill/paybill", Method.Post);
			request.AddHeader("accept", "application/json");
			// request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetToken());
			request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			BBPS_Body p = new BBPS_Body();
			p.bill_fetch = bill_fetch1;
			p.mode = obj.Mode;
			p.longitude = obj.Longitude;
			p.latitude = obj.Latitude;
			p.referenceid = obj.Referenceid;
			p.amount = obj.Amount;
			p.canumber = obj.Canumber;
			p.@operator = obj.OperatorID;
			p.ad1 = obj.Ad1;
			p.ad2 = obj.Ad2;
			p.ad3 = obj.Ad3;

			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<BillPayResponse>(response.Content);
			if (racc.response_code == 1 && BillType.ToString() == "Electricity")
			{
				DataTable dt = db.saveRecordElectricityDetails(obj, racc);
				DataTable dtde = db.UserDebitBlanceforservices(userid, Amount, BillType);
				HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));
			}

			else
			{
				DataTable dt = db.saveRecordElectricityDetails(obj, racc);

			}

			return Json(racc);

		}

		public ActionResult PayBillLPG(PayBillModel obj, BillFetch_BBPS bill_fetch1, string BillType, string AmountDir)
		{

			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
			{
				return RedirectToAction("Login", "Account");
			}
			obj.Amount = (obj.Amount == "" || obj.Amount == null) ? AmountDir : obj.Amount;
			//obj.bill_fetch = bill_fetch1;
			//obj.Latitude = "26.8500992";
			//obj.Longitude = "80.9992192";
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			BillPayResponse racc = new BillPayResponse();
			Responsemsgcls res = new Responsemsgcls();
			Random ran = new Random();
			string Amount = obj.Amount;
			double DebitAmount = WalletModal.GetPartenDebitBalanceByUser(userid);
			double rechargeamount = Convert.ToDouble(Amount);
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
			{
				if (DebitAmount < rechargeamount)
				{
					racc.response_code = 0;
					racc.message = "Insufficient balance !!";
					return Json(racc);
				}
			}


		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());

			DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = obj.Amount, UserId = userid, type = "LPG" });
			if (dt1.Rows.Count > 0 && dt1 != null)
			{

				obj.Referenceid = referenceid;
			}
			else
			{
				goto again;
			}

			var options = new RestClientOptions("https://api.paysprint.in")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/service/bill-payment/bill/paybill", Method.Post);
			request.AddHeader("accept", "application/json");
			// request.AddHeader("Token", DB.JWT);
			request.AddHeader("Token", sm.GetToken());
			request.AddHeader("Authorisedkey", DB.AuthorizationKey);
			request.AddHeader("Content-Type", "application/json");
			BBPS_Body p = new BBPS_Body();
			p.bill_fetch = bill_fetch1;
			p.mode = obj.Mode;
			p.longitude = obj.Longitude;
			p.latitude = obj.Latitude;
			p.referenceid = obj.Referenceid;
			p.amount = obj.Amount;
			p.canumber = obj.Canumber;
			p.@operator = obj.OperatorID;
			p.ad1 = obj.Ad1;
			p.ad2 = obj.Ad2;
			p.ad3 = obj.Ad3;

			string body = JsonConvert.SerializeObject(p);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);
			racc = JsonConvert.DeserializeObject<BillPayResponse>(response.Content);
			if (racc.response_code == 1 && BillType.ToString() == "LPG")
			{
				DataTable dt = db.SaveRecordLPGDetails(obj, racc);
				DataTable dtde = db.UserDebitBlanceforservices(userid, Amount, BillType);
				HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));
			}

			else
			{
				DataTable dt = db.SaveRecordLPGDetails(obj, racc);
			}

			return Json(racc);

		}

		public ActionResult Otherservice()
		{
			DataTable dt1 = db.UserMenuPermission("3", Convert.ToString(HttpContext.Session.GetString("UserId")));
			ViewBag.pertbl = dt1;
			return View();
		}
		#region GetOperatorDetails 2023/05/06

		public JsonResult GetOpetatorDetailsByOperatorId(string OperatorId, string mode)
		{
			DataTable dt = new DataTable();
			try
			{
				var options = new RestClientOptions("https://grofinapi.sigmasoftwares.org")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(options);
				var request = new RestRequest("/api/GetOperatorList", Method.Post);
				request.AddHeader("Content-Type", "application/json");

				var body = @"{
" + "\n" +
			   @"  ""mode"": """+mode+@"""
" + "\n" +
			   @"}";
				request.AddParameter("application/json", body, ParameterType.RequestBody);
				RestResponse response = client.Execute(request);
				Console.WriteLine(response.Content);
				Root12 obj = new Root12();
				obj = JsonConvert.DeserializeObject<Root12>(JsonConvert.DeserializeObject<string>(response.Content));
				dt = db.ConvertToDataTable(obj.data);
				var dr = from row in dt.AsEnumerable() where row.Field<string>("id") == OperatorId select row;

				DataTable dtSelected = dr.CopyToDataTable();
				string data = CommonClasses.ConvertTableToList(dtSelected);
				return Json(data);
			}
			catch
			{
				return Json("Something Went Wrong !!");
			}


		}
		public class Datum
		{
			public string id { get; set; }
			public string name { get; set; }
			public string category { get; set; }
			public string viewbill { get; set; }
			public string regex { get; set; }
			public string displayname { get; set; }
			public string ad1_d_name { get; set; }
			public string ad1_name { get; set; }
			public string ad1_regex { get; set; }
			public string ad2_d_name { get; set; }
			public string ad2_name { get; set; }
			public string ad2_regex { get; set; }
			public object ad3_d_name { get; set; }
			public object ad3_name { get; set; }
			public object ad3_regex { get; set; }
		}
		
		public class Root12
		{
			public int response_code { get; set; }
			public bool status { get; set; }
			public List<Datum> data { get; set; }
			public string message { get; set; }
		}
		
		#endregion
		public JsonResult EpfoKYCDownloadPassword(EPFOAPIMODEL p)
		{
			Responsemsgcls res = new Responsemsgcls();


			string userid = HttpContext.Session.GetString("UserId");
		again:
			string referenceid = Convert.ToString(sm.GenerateReferenceId());

			DataTable dt1 = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = "0", UserId = userid, type = "EPFO" });
			if (dt1.Rows.Count > 0 && dt1 != null)
			{

				p.refid = referenceid;

			}
			else
			{
				goto again;
			}

			string rques = EPFOKYC_OTPSENDAPI(p);


			var options = new RestClientOptions("https://api.verifya2z.com")
			{
				MaxTimeout = -1,
			};
			var client = new RestClient(options);
			var request = new RestRequest("/api/v1/verification/epfo_passbook_download", Method.Post);
			request.AddHeader("accept", "application/json");
			request.AddHeader("User-Agent", CommonClasses.agentid);
			request.AddHeader("Token", sm.GetLiveVerifyToken());
			request.AddHeader("Content-Type", "application/json");
			EPFOAPIMODELGetkycDetails pbody = new EPFOAPIMODELGetkycDetails() { client_id = HttpContext.Session.GetString("EPFOClient_Id") };
			string body = JsonConvert.SerializeObject(pbody);
			request.AddStringBody(body, DataFormat.Json);
			RestResponse response = client.Execute(request);


			return Json(response.Content);
		}
		public JsonResult CheckHLR(CheckHLRRequestBody p)
		{
			string resbody = null;
			try
			{
				var option = new RestClientOptions("https://api.paysprint.in")
				{
					MaxTimeout = -1,
				};
				var client = new RestClient(option);
				var request = new RestRequest("/api/v1/service/recharge/hlrapi/hlrcheck", Method.Post);
				request.AddHeader("accept", "application/json");
				string token = sm.GetLiveToken();
				request.AddHeader("Token", token);
				request.AddHeader("Content-Type", "application/json");
				string body = JsonConvert.SerializeObject(p);
				request.AddStringBody(body, DataFormat.Json);
				RestResponse response = client.Execute(request);
				resbody = response.Content;
			}
			catch
			{
				resbody = "Something Went Wrong !!";
			}
			return Json(resbody);
		}

		#region shani


		public IActionResult TransactionReport()
		{

			DataTable dt = db.GetTransactionList1("", "", "");
			DataTable dt2 = db.GetPartnerList();
			ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}

		[HttpPost]
		public IActionResult TransactionReport(string FormDate, string ToDate, string PartnerID)
		{

			DataTable dt = db.GetTransactionList1(FormDate, ToDate, PartnerID);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}





        public IActionResult UserTaransactionReport()
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.GetTransactionList(userid, "", "");
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult UserTaransactionReport(string FormDate, string ToDate)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.GetTransactionList(userid, FormDate, ToDate);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }



        public IActionResult UserRechargeReport()
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.RechargeList(userid, "", "");
			return View(dt);
		}


		[HttpPost]
		public IActionResult UserRechargeReport(string FormDate, string ToDate)
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = db.RechargeList(userid, FormDate, ToDate);
			return View(dt);
		}



		public IActionResult UserLicPayReport()
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = new DataTable();
			dt = db.PanReport("7", userid, "", "");
			return View(dt);
		}




		[HttpPost]
		public IActionResult UserLicPayReport(string FormDate, string ToDate)
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = new DataTable();
			dt = db.PanReport("7", userid, FormDate, ToDate);
			return View(dt);
		}




		#endregion shani




		[HttpPost]
		public JsonResult UserComplianResoved(string Id)
		{
			DataTable dt = db.ComplainResolved(Convert.ToInt32(Id));
			string Msg = "";
			if (dt != null && dt.Rows.Count > 0)
			{
				Msg = dt.Rows[0]["Message"].ToString();
			}
			return Json(Msg);
		}

		[HttpPost]
		public JsonResult UserComplianUnResolve(string Id)
		{
			DataTable dt = db.ComplainUnResolved(Convert.ToInt32(Id));
			string Msg = "";
			if (dt != null && dt.Rows.Count > 0)
			{
				Msg = dt.Rows[0]["Message"].ToString();
			}
			return Json(Msg);
		}


		public IActionResult BeneficiaryReport()
		{
			DataTable dt = db.BeneficiaryReport("", "", "");
			DataTable dt2 = db.GetPartnerList();
			ViewBag.Partner = PropertyClass.BindDDL(dt2);
			return View(dt);
		}


		[HttpPost]
		public IActionResult BeneficiaryReport(string FormDate, string ToDate, string PartnerID)
		{
			DataTable dt = db.BeneficiaryReport(FormDate, ToDate, PartnerID);
			DataTable dt2 = db.GetPartnerList();
			ViewBag.Partner = PropertyClass.BindDDL(dt2);
			return View(dt);
		}



		public IActionResult RechargeReport()
		{
			DataTable dt = db.RechargeList1("", "", "", "");
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}

		[HttpPost]
		public IActionResult RechargeReport(string FormDate, string ToDate, string PartnerID)
		{
			DataTable dt = db.RechargeList1(FormDate, ToDate , PartnerID, "");
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
		}


		#region shani 14/06/2023

		[HttpPost]
		public JsonResult DocumentMemberDetailsDelete(string Id)
		{

			DataTable dt = db.MemberDetailsDelete(Convert.ToInt32(Id));
			string Msg = "";
			if (dt != null && dt.Rows.Count > 0)
			{
				Msg = dt.Rows[0]["Msg"].ToString();
			}
			return Json(Msg);
		}

        //[HttpPost]
        //public JsonResult DocumentCloseDate(string Id, string closedate, string Remarks)
        //{
        //    DataTable dt = db.MemberDetailsCloseDate(Convert.ToInt32(Id), closedate, Remarks);
        //    string Msg = "";
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        Msg = dt.Rows[0]["Msg"].ToString();
        //    }
        //    return Json(Msg);
        //}
        [HttpPost]
        public JsonResult DeleteTrainingVideo(string Id)
        {

            DataTable dt = db.uploadvideolinkDelete(Convert.ToInt32(Id));
            string Msg = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                Msg = dt.Rows[0]["Msg"].ToString();
            }
            return Json(Msg);
        }


        [HttpPost]
		public JsonResult GetMemberDocumentDetails(string Id)
		{
			ViewMemberDocDetailsCls obj = new ViewMemberDocDetailsCls();

			DataTable dt = db.ViewGetMemberDocumentDetails(Convert.ToInt32(Id));
			if (dt != null && dt.Rows.Count > 0)
			{

				obj.ID = dt.Rows[0]["Id"].ToString();
				obj.PartnerID = dt.Rows[0]["Userid"].ToString();
				obj.Name = dt.Rows[0]["Name"].ToString();

				obj.Mobile = dt.Rows[0]["Mobileno"].ToString();


				obj.Email = dt.Rows[0]["Email"].ToString();
				obj.DocType = dt.Rows[0]["DocType"].ToString();
				obj.BillNo = dt.Rows[0]["Billno"].ToString();
				obj.Aadharno = dt.Rows[0]["AadharNo"].ToString();
				obj.PanNo = dt.Rows[0]["PanNo"].ToString();
				obj.AadharFimage = dt.Rows[0]["AadharPicFront"].ToString();
				obj.AadharBimage = dt.Rows[0]["AadharPicBack"].ToString();
				obj.PanBimage = dt.Rows[0]["PanPicBack"].ToString();
				obj.PanFimage = dt.Rows[0]["PanPicFront"].ToString();
				obj.Ad1 = dt.Rows[0]["Ad1"].ToString();
				obj.Ad2 = dt.Rows[0]["Ad2"].ToString();
				obj.Ad3 = dt.Rows[0]["Ad3"].ToString();
				obj.Ad4 = dt.Rows[0]["Ad4"].ToString();
				obj.Ad5 = dt.Rows[0]["Ad5"].ToString();
				obj.Ad6 = dt.Rows[0]["Ad6"].ToString();
				obj.Ad7 = dt.Rows[0]["Ad7"].ToString();
				obj.Ad8 = dt.Rows[0]["Ad8"].ToString();
				obj.Ad9 = dt.Rows[0]["Ad9"].ToString();
				obj.Ad10 = dt.Rows[0]["Ad10"].ToString();
				obj.Ad1PicFront = dt.Rows[0]["Ad1PicFront"].ToString();
				obj.Ad1PicBack = dt.Rows[0]["Ad1PicBack"].ToString();
				obj.Ad2PicFront = dt.Rows[0]["Ad2PicFront"].ToString();
				obj.Ad2PicBack = dt.Rows[0]["Ad2PicBack"].ToString();
				obj.Ad3PicFront = dt.Rows[0]["Ad3PicFront"].ToString();
				obj.Ad3PicBack = dt.Rows[0]["Ad3PicBack"].ToString();
				obj.Ad4PicFront = dt.Rows[0]["Ad4PicFront"].ToString();
				obj.Ad4PicBack = dt.Rows[0]["Ad4PicBack"].ToString();
				obj.Ad5PicFront = dt.Rows[0]["Ad5PicFront"].ToString();
				obj.Ad5PicBack = dt.Rows[0]["Ad5PicBack"].ToString();
				obj.Ad6PicFront = dt.Rows[0]["Ad6PicFront"].ToString();
				obj.Ad6PicBack = dt.Rows[0]["Ad6PicBack"].ToString();
				obj.Ad7PicFront = dt.Rows[0]["Ad7PicFront"].ToString();
				obj.Ad7PicBack = dt.Rows[0]["Ad7PicBack"].ToString();
				obj.Ad8PicFront = dt.Rows[0]["Ad8PicFront"].ToString();
				obj.Ad8PicBack = dt.Rows[0]["Ad8PicBack"].ToString();
				obj.Ad9PicFront = dt.Rows[0]["Ad9PicFront"].ToString();
				obj.Ad9PicBack = dt.Rows[0]["Ad9PicBack"].ToString();
				obj.Ad10PicFront = dt.Rows[0]["Ad10PicFront"].ToString();
				obj.Ad10PicBack = dt.Rows[0]["Ad10PicBack"].ToString();
				obj.CloseStatus = dt.Rows[0]["CloseStatus"].ToString();


            }

			return Json(obj);
		}

		public IActionResult UserPayBillReport()
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = new DataTable();
			dt = db.BillPayReport(userid, "", "");
			return View(dt);
		}
		[HttpPost]
		public IActionResult UserPayBillReport(string FormDate, string ToDate)
		{
			string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
			DataTable dt = new DataTable();
			dt = db.BillPayReport(userid, FormDate, ToDate);
			return View(dt);
		}




        #endregion

        public IActionResult DTHReport(string typee)
        {
            DataTable dt = db.RechargeList1("", "", "", typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult DTHReport(string FormDate, string ToDate, string PartnerID, string typee)
        {
            DataTable dt = db.RechargeList1(FormDate, ToDate, PartnerID, typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }

        public IActionResult PANReportnew(string typee)
        {
            DataTable dt = db.RechargeList1("", "", "", typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult PANReportnew(string FormDate, string ToDate, string PartnerID, string typee)
        {
            DataTable dt = db.RechargeList1(FormDate, ToDate, PartnerID, typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }



        public IActionResult LICReport(string typee)
        {
            DataTable dt = db.RechargeList1("", "", "", typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult LICReport(string FormDate, string ToDate, string PartnerID, string typee)
        {
            DataTable dt = db.RechargeList1(FormDate, ToDate, PartnerID, typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }

        public IActionResult PayBillReportnew(string typee)
        {
            DataTable dt = db.RechargeList1("", "", "", typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult PayBillReportnew(string FormDate, string ToDate, string PartnerID, string typee)
        {
            DataTable dt = db.RechargeList1(FormDate, ToDate, PartnerID, typee);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }


        public IActionResult LeadReport()
        {
            DataTable dt = db.LeadList("", "", "");
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }
        [HttpPost]
        public IActionResult LeadReport(string FormDate, string ToDate, string PartnerID)
        {
            DataTable dt = db.LeadList(FormDate, ToDate, PartnerID);
            DataTable dt2 = db.GetPartnerList();
            ViewBag.Partner = PropertyClass.BindDDL(dt2);
            return View(dt);
        }


        public IActionResult UserBeneficiaryReport()
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.UserBeneficiaryReport("", "", userid);
            return View(dt);
        }


        [HttpPost]
        public IActionResult UserBeneficiaryReport(string FormDate, string ToDate)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.UserBeneficiaryReport(FormDate, ToDate, userid);
            return View(dt);
        }



        public IActionResult UserDTHReport(string typee)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.RechargeList(userid, "", "", typee);
            return View(dt);
        }
        [HttpPost]
        public IActionResult UserDTHReport(string FormDate, string ToDate, string typee)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.RechargeList(userid, FormDate, ToDate, typee);
            return View(dt);
        }



        public IActionResult UserPANReport(string typee)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.RechargeList(userid, "", "", typee);
            return View(dt);
        }
        [HttpPost]
        public IActionResult UserPANReport(string FormDate, string ToDate, string typee)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.RechargeList(userid, FormDate, ToDate, typee);
            return View(dt);
        }

        public IActionResult UserLeadReport()
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.UserLeadList("", "", userid);
            return View(dt);
        }
        [HttpPost]
        public IActionResult UserLeadReport(string FormDate, string ToDate)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.UserLeadList(FormDate, ToDate, userid);
            return View(dt);
        }
        public IActionResult GetUserMemberDocuments(string type)
        {
            string action = type == null ? "11" : "12";
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.SaveUserDocDetails(userid, action, type);
            return View(dt);
        }

        public IActionResult GetUserMemberDocumentsbyFilter(MemberDetails model)
        {

            model.Action = "13";
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.SaveUserDocDetails(model, userid);

            //string c = dt.Rows[1][3].ToString();
            return View("GetMemberDocuments", dt);
        }


        public IActionResult Profile()
        {
            profile rr = new profile();
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.getprofile(rr, userid);
            rr.name = dt.Rows[0]["Name"].ToString();
            rr.Pincode = dt.Rows[0]["Pincode"].ToString();
            rr.mobile = dt.Rows[0]["Mobile"].ToString();
            rr.Dob = dt.Rows[0]["DOBirth"].ToString();
            rr.State = dt.Rows[0]["State"].ToString();
            rr.District = dt.Rows[0]["District"].ToString();
            rr.Block = dt.Rows[0]["Block"].ToString();
            rr.Address = dt.Rows[0]["Address"].ToString();
            rr.BankName = dt.Rows[0]["BankName"].ToString();
            rr.BankHolderName = dt.Rows[0]["BankHolderName"].ToString();
            rr.BankAccountNo = dt.Rows[0]["BankAccountNo"].ToString();
            rr.IFSCCode = dt.Rows[0]["IFSCCode"].ToString();
            return View(rr);
        }


        [HttpPost]
        public IActionResult Profile(profile pf)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = new DataTable();
            dt = db.getprofileupdate(pf, userid);
            Profile();
            return View();

        }


        [HttpPost]
        public string getagentkycdetails(KYCDetailsBody obj)
        {
            string msg = "0";

            DataTable dt = new DataTable();
            try
            {
                obj.Action = "3";
                dt = db.KYCDetails(obj);
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = JsonConvert.SerializeObject(dt);
                }
            }
            catch (Exception exc)
            {
                //throw exc;
            }

            return msg;
        }


        public IActionResult UpdateKYCDetails(KYCDetailsBody obj)
        {
            string msg = "";
            try
            {
                obj.Action = "4";

                DataTable dt = db.KYCDetails(obj);
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Details Not Save!!";
                }
            }
            catch
            {
                msg = "Something Went Wrong!!";
            }
            return Json(msg);
        }


        public IActionResult deletekycdetail(KYCDetailsBody obj)
        {
            string msg = "";
            try
            {
                obj.Action = "5";

                DataTable dt = db.KYCDetails(obj);
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Something Went Wrong!!";
                }
            }
            catch
            {
                msg = "Something Went Wrong!!";
            }
            return Json(msg);
        }
        [HttpPost]
        public IActionResult complain(string Status)
        {
            clsAllClasses oc = new clsAllClasses();
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            oc.dt2 = db.saveusercomplainnew(new usercomplain() { UseriID = userid }, 3, Status);
            return View(oc);
        }
        [HttpPost]
        public JsonResult DocumentCloseDate(string Id, string closedate, string Remarks)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.MemberDetailsCloseDate(Convert.ToInt32(Id), closedate, Remarks, userid);
            string Msg = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                Msg = dt.Rows[0]["Msg"].ToString();
            }
            return Json(Msg);
        }
        [HttpPost]
        public JsonResult ComplainCloseDate(string Id, string closedate, string Remarks)
        {
            string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = db.ComplainCloseDate(Convert.ToInt32(Id), closedate, Remarks, userid);
            string Msg = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                Msg = dt.Rows[0]["Msg"].ToString();
            }
            return Json(Msg);
        }


		#region [Vishwajeet 31/07/2023]
		[HttpPost]
		public IActionResult MemberKYC(string userid,string FormDate, string ToDate)
		{ 
			DataTable dt = new DataTable();
            dt = db.KYCDetailsfilter(userid, FormDate, ToDate);
            return View(dt);
        }
		[HttpPost]
        public IActionResult complainReport(string Memberid, string FromDate, string ToDate)
        {

            DataTable dt = db.usercomplain_Report_filter(Memberid, FromDate, ToDate);
            return View(dt);
        }
        #endregion 

    }




}
