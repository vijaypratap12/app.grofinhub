using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using SportsBattle.Models;
using System;
using System.Data.SqlClient;

namespace SportsBattle.ViewComponents
{
    public class ArticleCarouselViewComponent : ViewComponent
    {
		PropertyClass pcobj = new PropertyClass();
		DBHelper db = new DBHelper();
		CommonClasses sm = new CommonClasses();
		//clsAdminLogic db;
		
		private readonly IHttpContextAccessor httpContextAccessor;
        public ArticleCarouselViewComponent(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;

        }
     
        public IViewComponentResult Invoke()
        {
			DataTable dt1 = UserMenuPermission("3", Convert.ToString(HttpContext.Session.GetString("UserId")));
			ViewBag.pertbl = dt1;
			return View();
            
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

	}
}
