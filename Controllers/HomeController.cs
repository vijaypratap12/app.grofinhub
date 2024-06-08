using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsBattle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportsBattle.Controllers
{ 
    public class HomeController : Controller
    {       
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
           return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        #region [Save BBPS Bill Details 2023/05/09]
        public JsonResult EntryBBPSOperatorListDetails()
        {
          
           List<Root1> clslist= new List<Root1>() {

        new Root1(){
        id= "307",name= null,category= null,viewbill= "0",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "195",name= "AAVAS FINANCIERS LIMITED",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9-]+$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "52",name= "ACT BroadBand",category= "Broadband",viewbill= "1",regex= "^[0-9]{1,50}$",displayname= "Account Number/User Name",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "263",name= "Adani Capital Pvt Ltd",category= "EMI",viewbill= "1",regex= "^(\\\\d{3}[A-Z]{2}|\\\\d{5}|[A-Z]{5})[A-Z]\\\\d{9}$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "10",name= "Adani Electricity Mumbai Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{9}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "421",name= "ADANI GAS",category= "BILL PAYMENT",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "395",name= "Adani Total Gas Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "110",name= "Aditya Birla Finance ltd. (ABFL)",category= "EMI",viewbill= "1",regex= "^[a-zA-Z]{3}-[a-zA-Z][0-9]{5}-[0-9]{9}",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "188",name= "Aditya Birla Housing Finance Limited",category= "EMI",viewbill= "1",regex= "^[Ll][Nn][a-zA-Z]{3}[a-zA-Z0-9_]{3}[-][0-9]{11}$",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "284",name= "Aditya Birla Sun Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{7,9}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "160",name= "Aegon Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9 A-Z,a-z]{12,15}$",displayname= "POLICY NO",ad1_d_name= "Date Of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "216",name= "Ahmedabad Municipal Corporation",category= "Water",viewbill= "1",regex= "^[a-zA-Z0-9]{15}$",displayname= "Tenement No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "425",name= "AIRCEL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "9",name= "Airtel",category= "Postpaid",viewbill= "1",regex= "^[1-9]{1}[0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "423",name= "AIRTEL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "115",name= "Airtel Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{11}$",displayname= "Landline Number (with STD Code)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "440",name= "AIRTEL DTH",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "8",name= "Airtel Landline",category= "Landline",viewbill= "1",regex= "^[0-9]{11}$",displayname= "Landline Number (with STD Code)",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "54",name= "Ajmer Vidyut Vitran Nigam Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "325",name= "Ajmer Viyut Vitran Nigam",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "266",name= "Altum Credo Home Finance",category= "EMI",viewbill= "1",regex= "^\\\\d{13}$",displayname= "Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "237",name= "Annapurna Finance Private Limited-MSME",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "75",name= "APEPDCL - Eastern Power Distribution CO AP Ltd.",category= "Electricity",viewbill= "1",regex= "^[0-9A-Za-z]{8,20}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "76",name= "APSPDCL - Southern Power Distribution CO AP Ltd.",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{8,20}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "217",name= "Arohan Financial Services Ltd",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "150",name= "ASIANET Broadband (ASIANET)",category= "Broadband",viewbill= "0",regex= "^[0-9a-zA-Z]{6,8}$",displayname= "Sub Code",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "246",name= "Asianet Digital",category= "Cable",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Subscriber Code",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "70",name= "Assam Power Distribution Company Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{11,12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "103",name= "Assam Power Distribution Company Ltd (NON-RAPDR)",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "326",name= "Assam Power-Non Rapdr",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "327",name= "Assam Power-Rapdr",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "198",name= "Avail",category= "EMI",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Mobile Number (+91)",ad1_d_name= "Date Of Birth (ddMMyyyy) ",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "233",name= "Avanse Financial Services Ltd",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$\"",displayname= "Loan Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "151",name= "Aviva Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9 A-Z,a-z]{8,10}$",displayname= "POLICY NO",ad1_d_name= "Date Of Birth (yyyyMMdd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "280",name= "Axis Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "314",name= "Axis Bank",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "17",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "234",name= "Baid Leasing and Finance",category= "EMI",viewbill= "1",regex= "^([6-9]\\d{9})|(\\d{4,5})|(((HR)|(RJ))\\d{1,2}[A-Z]{0,3}\\d{4})$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "201",name= "Bajaj Allianz General Insurance",category= "Insurance",viewbill= "1",regex= "^[A-Za-z0-9]{1,20}$",displayname= "Policy Number (without hyphen) ",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "73",name= "Bajaj Allianz Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{1,20}$",displayname= "Policy Number",ad1_d_name= "Date of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "72",name= "Bajaj Finserv",category= "EMI",viewbill= "1",regex= ".+",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "111",name= "BajajAutoFinanceLtd",category= "EMI",viewbill= "1",regex= ".+",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "36",name= "Bangalore Electricity Supply",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Customer ID / Account ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "328",name= "Bangalore Electricity Supply Company",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "39",name= "Bangalore Water Supply and Sewerage Board",category= "Water",viewbill= "1",regex= ".+",displayname= "RR Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "276",name= "Bank Of Baroda",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "310",name= "Bank Of Baroda",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "13",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "232",name= "BERAR Finance Limited",category= "EMI",viewbill= "1",regex= "^[0-9]{6}$",displayname= "Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "29",name= "BEST",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "329",name= "Best Mumbai",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "43",name= "Bhagalpur Electricity Distribution Company (P) Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,15}$",displayname= "Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "400",name= "Bharat GAS",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "173",name= "Bharat Petroleum Corporation Limited (BPCL)",category= "LPG",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Registered Contact Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
         new Root1(){id= "286",name= "Indane Gas",category= "LPG",viewbill= "1",regex= "^[0-9]{10,17}$",displayname= "LPG ID/Registered Mobile number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "330",name= "Bharatpur Electricity Services Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "78",name= "Bharatpur Electricity Services Ltd. (BESL)",category= "Electricity",viewbill= "1",regex= "^[A-Za-z0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "42",name= "Bharti Axa Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9\\-]{11}$",displayname= "Policy Number",ad1_d_name= "Date of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "125",name= "Bhopal Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{8,10}$",displayname= "Connection ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "406",name= "Bhopal Municipal Corporation - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "441",name= "BIG TV",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "331",name= "Bikaner Electricity Supply Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "79",name= "Bikaner Electricity Supply Limited (BkESL)",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "248",name= "Brihan Mumbai Electric Supply And Transport Undertaking",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "249",name= "Brihanmumbai Electric Supply And Transport",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "388",name= "BSES Rajdhani - Delhi",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "11",name= "BSES Rajdhani Power Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,10}$",displayname= "CA Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "12",name= "BSES Yamuna Power Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,10}$",displayname= "CA Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "387",name= "BSES Yamuna Prepaid - Delhi",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "13",name= "BSNL",category= "Postpaid",viewbill= "1",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "96",name= "BSNL Landline - Corporate",category= "Landline",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "53",name= "BSNL Landline - Individual",category= "Landline",viewbill= "1",regex= "^[0-9]{11}$",displayname= "telephoneNumber",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "432",name= "BSNL SPECIAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "431",name= "BSNL TOPUP",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "332",name= "Calcutta Electric Supply Corporation",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "47",name= "Calcutta Electricity Supply Co. Ltd.",category= "Electricity",viewbill= "1",regex= "^[0-9]{11}$",displayname= "Customer ID (Not Consumer No)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "93",name= "Canara HSBC Oriental Bank of Commerce Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd-MM-yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "205",name= "Capri Global Capital Limited",category= "EMI",viewbill= "1",regex= "^[0-9A-Za-z]{10,20}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "210",name= "Capri Global Housing Finance",category= "EMI",viewbill= "1",regex= "^[0-9A-Za-z]{10,20}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "389",name= "Central Electricity Supply Of Odisha",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "391",name= "Central U P Gas Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "146",name= "CESU, Odisha",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{12}$",displayname= "Consumer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "270",name= "Chaitanya India Fin Credit Pvt Ltd",category= "EMI",viewbill= "1",regex= "^.{7,30}$",displayname= "Loan Application Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "333",name= "Chamundeshwari Electricity Supply Corp Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "104",name= "Chamundeshwari Electricity Supply Corp Ltd (CESCOM)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10}$",displayname= "Account ID(RAPDRP) OR Consumer No./Connection ID(Non-RAPDRP)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "207",name= "Chandigarh Electricity Department",category= "Electricity",viewbill= "1",regex= "^[0-9A-Za-z]{7,20}$",displayname= "Account No without(/)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "30",name= "Chhattisgarh Electricity Board",category= "Electricity",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Business Partner Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "334",name= "Chhattisgarh State Power Distribution Co. Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "199",name= "Clix",category= "EMI",viewbill= "1",regex= "^[A-Z]{2}[A-Z0-9]{11,18}$",displayname= "Loan application number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "148",name= "Comway Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9a-zA-Z]{1,15}$",displayname= "Customer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "58",name= "Connect BroadBand",category= "BroadBand",viewbill= "0",regex= "^[1-9a-zA-Z][0-9a-zA-Z]{3,11}$",displayname= "Directory Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "269",name= "Credit Wise Capital",category= "EMI",viewbill= "1",regex= "^[0-9]{10,10}$",displayname= "Mobile Number",ad1_d_name= "Date of Birth",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "335",name= "Dakshin Gujarat Vij Company Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "25",name= "Dakshin Gujarat Vij Company Ltd",category= "Electricity",viewbill= "0",regex= "^[0-9]{5,11}$",displayname= "Consumer Number",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "336",name= "Dakshin Haryana Bijli Vitran Nigam",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "98",name= "Dakshin Haryana Bijli Vitran Nigam (DHBVN)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{9,12}$",displayname= "Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "337",name= "Daman And Diu Electricity",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "46",name= "Daman and Diu Electricity Department",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,6}$",displayname= "Account number",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "418",name= "Delhi Development Authority",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "161",name= "Delhi Development Authority (DDA) - Water",category= "Water",viewbill= "1",regex= "^[a-zA-Z0-9]{1,13}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "154",name= "Delhi Jal Board (BBPS)",category= "Water",viewbill= "1",regex= "^[0-9]{10}$",displayname= "K No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "405",name= "Delhi Jal Board (DJB)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "169",name= "Den Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9A-Za-z]{1,25}$",displayname= "User Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "338",name= "Department Of Power Nagaland-Wss",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "142",name= "Department of Power, Nagaland",category= "Electricity",viewbill= "1",regex= "^[0-9]{11,12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "417",name= "Department Of Public Health Engineering Mizoram",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "163",name= "Department of Public Health Engineering-Water, Mizoram",category= "Water",viewbill= "1",regex= "^[0-9A-Za-z\\-]{5,15}$  ",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "135",name= "DHFL Pramerica Life Insurance Co. Ltd",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "271",name= "Digamber Capfin Limited",category= "EMI",viewbill= "1",regex= "^(JLG-[0-9]{9})|([0-9]{9})$",displayname= "Loan Application Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "442",name= "DISH TV",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "131",name= "DMI FInance",category= "EMI",viewbill= "1",regex= "^[dD][mM][iI][0-9]{10}$",displayname= "Loan ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "250",name= "Dnh Power Distribution Company Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,20}$",displayname= "Service Connection Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "339",name= "Eastern Power Distribution Company Of Andhra Pradesh Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "51",name= "Edelweiss Tokio Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{1,20}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd-MM-yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "340",name= "Electricity Department Chandigarh",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "316",name= "Equitas FASTag Recharge",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "19",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "202",name= "Ess Kay Fincorp Limited (Sk Finance)",category= "EMI",viewbill= "1",regex= "^[0-9]{7,18}$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "145",name= "Exide Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "POLICY NO",ad1_d_name= "Date Of Birth (yyyyMMdd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "203",name= "Faircent",category= "EMI",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "320",name= "Federal Bank - FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "23",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "262",name= "Fincare Small Finance Bank",category= "EMI",viewbill= "1",regex= "^[0-9]{14}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "192",name= "Flash Fibernet",category= "Broadband",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Customer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "268",name= "Flexi Loans",category= "EMI",viewbill= "1",regex= "^[A-Z]{4}\\\\d{9}$",displayname= "Loan ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "178",name= "Flexsalary",category= "EMI",viewbill= "1",regex= "^[5][0-9]{5}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "149",name= "Fusionnet Web Services Private Limited",category= "Broadband",viewbill= "1",regex= "^[0-9a-zA-Z]{1,15}$",displayname= "Customer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "197",name= "Future Generali India Life Insurance Company Limited",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd/MM/yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "140",name= "Goa Electricity Department",category= "Electricity",viewbill= "1",regex= "^[0-9]{11}$",displayname= "Contract Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "166",name= "Government of Puducherry Electricity Department",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{9,12}$",displayname= "Consumer Number",ad1_d_name= "Consumer Type",ad1_name= "consumerType",ad1_regex= "^[0-9a-zA-Z]{2}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "291",name= "Greater Warangal Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{7,15}$",displayname= "Connection ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "138",name= "Greater Warangal Municipal Corporation – Water",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{7,15}$",displayname= "CONNECTION ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "392",name= "Green Gas Limited (GGL)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "396",name= "Gujarat Gas Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "91",name= "Gulbarga Electricity Supply Company Limited",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "127",name= "Gwalior Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9]{1,8}$",displayname= "Connection ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "404",name= "Gwalior Municipal Corporation - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "155",name= "Haryana Urban Development Authority",category= "Water",viewbill= "1",regex= "^[0-9]{6,10}$",displayname= "Site Code",ad1_d_name= "Consumer Number",ad1_name= "consumerNumber",ad1_regex= "^[0-9]{1,12}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "57",name= "Hathway",category= "Broadband",viewbill= "1",regex= "^[0-9]{9,15}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "60",name= "Hathway Digital TV",category= "Cable",viewbill= "1",regex= "^[0-9]{10,15}$",displayname= "RMN/Acc No/VC No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "278",name= "HDFC Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "312",name= "HDFC Bank",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "15",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "171",name= "HDFC Life Insurance Co. Ltd.",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (ddMMyyyy) ",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "157",name= "Hero FinCorp Ltd",category= "EMI",viewbill= "1",regex= "",displayname= "Loan Id/Application Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "109",name= "Himachal Pradesh Electricity",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "341",name= "Himachal Pradesh State Electricity Board",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "168",name= "Hindustan Petroleum Corporation Ltd (HPCL)",category= "LPG",viewbill= "1",regex= "^[0-9]{1,8}$",displayname= "Consumer Number",ad1_d_name= "State",ad1_name= "state",ad1_regex= null,ad2_d_name= "District",ad2_name= "district",ad2_regex= null,ad3_d_name= "Distributor",ad3_name= "distributor",ad3_regex= null
        },
        new Root1(){id= "402",name= "HP GAS",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "342",name= "Hubli Electricity Supply Company Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "105",name= "Hubli Electricity Supply Company Ltd (HESCOM)",category= "Electricity",viewbill= "1",regex= "^([0-9]{10}|[0-9]{7}|[0-9]{5}|[0-9]{6})$",displayname= "Account ID(RAPDRP) OR Consumer No./Connection ID(Non-RAPDRP)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "112",name= "Hyderabad Metropolitan Water Supply and Sewerage Board",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{2,25}$",displayname= "CAN Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "204",name= "i2iFunding",category= "EMI",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Loan ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "277",name= "ICICI Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "311",name= "ICICI Bank",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "14",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "227",name= "ICICI Bank Ltd - Loans",category= "EMI",viewbill= "1",regex= "^[A-Z0-9]{1}[^Zz1][A-Z0-9]{14}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "16",name= "ICICI Prudential Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd-MM-yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "321",name= "IDBI Bank FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "24",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "106",name= "IDBI federal Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd/MM/yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "15",name= "Idea",category= "Postpaid",viewbill= "0",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "424",name= "IDEA",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "6",name= "Idea Netsetter",category= "Datacard Prepaid",viewbill= "0",regex= "[0-9]{10}$",displayname= "Data Card Number",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "279",name= "IDFC Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "313",name= "IDFC FIRST Bank - FasTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "16",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "61",name= "Incable Digital TV",category= "Cable",viewbill= "0",regex= "^[1,2][0-9]{7}$",displayname= "Customer Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "136",name= "INDIA FIRST Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{8,16}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "251",name= "India Power Corporation - West Bengal",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "252",name= "India Power Corporation Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "343",name= "India Power Corporation-West Bengal",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "238",name= "India Shelter Finance Corporation Limited",category= "EMI",viewbill= "1",regex= "^AP-\\d{3,}$",displayname= "Application ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "190",name= "Indiabulls Consumer Finance Limited",category= "EMI",viewbill= "1",regex= "^[0-9A-Za-z]{8,20}$",displayname= "Loan Agreement No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "196",name= "Indiabulls Housing Finance Limited",category= "EMI",viewbill= "1",regex= "^[0-9A-Za-z]{14}",displayname= "Loan Account No",ad1_d_name= "Date of Birth (dd-MM-yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "401",name= "INDIAN GAS",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "274",name= "Indian Highways Management Company Ltd",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "308",name= "Indian Highways Management Company Ltd-Indusind FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "11",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "126",name= "Indore Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9]{6,15}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "403",name= "Indore Municipal Corporation - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "397",name= "Indraprastha Gas Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "275",name= "Indusind Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "309",name= "Indusind Bank",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "12",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "267",name= "INDUSIND BANK - CFD",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "164",name= "Instalinks",category= "Broadband",viewbill= "1",regex= "\n^[0-9a-zA-Z\\@\\=\\.]{4,25}$",displayname= "Customer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "175",name= "Instanet Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9a-zA-Z\\@\\-\\_\\#\\/]{3,40}$",displayname= "User Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "324",name= "IOB FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "27",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "224",name= "ION",category= "Broadband",viewbill= "1",regex= "^[HWhw][0-9]{1,7}$",displayname= "Customer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "128",name= "Jabalpur Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9]{6,15}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "415",name= "Jabalpur Municipal Corporation - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "32",name= "Jaipur Vidyut Vitran Nigam Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K NO",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "292",name= "Jalkal Vibhag Nagar Nigam Prayagraj",category= "Water",viewbill= "1",regex= "^\\d{7,15}$",displayname= "Computer Code",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "319",name= "Jammu and Kashmir Bank Fastag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "22",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "247",name= "Jammu and Kashmir Power Development Department",category= "Electricity",viewbill= "1",regex= "^[0-9]{13}$",displayname= "Consumer Code",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "38",name= "Jamshedpur Utilities and Services Company",category= "Electricity",viewbill= "1",regex= "^[0-9]{6,10}$",displayname= "Business Partner Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "344",name= "Jamshedpur Utilities And Services Company Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "219",name= "Jana Small Finance Bank",category= "EMI",viewbill= "1",regex= "^[0-9]{14,16}$",displayname= "Loan Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "345",name= "Jharkhand Bijli Vitran Nigam Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "102",name= "Jharkhand Bijli Vitran Nigam Limited (JBVNL)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{3,15}$",displayname= "Consumer Number",ad1_d_name= "Subdivision Code",ad1_name= "subdivisionCode",ad1_regex= "^[0-9a-zA-Z]{3,15}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "62",name= "Jio",category= "Postpaid",viewbill= "0",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "63",name= "Jio Fi",category= "Datacard Prepaid",viewbill= "0",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "64",name= "Jio Fi",category= "Datacard Postpaid",viewbill= "0",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "33",name= "Jodhpur Vidyut Vitran Nigam Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "215",name= "Kalyan Dombivali Municipal Corporation",category= "Municipality",viewbill= "1",regex= "^[a-zA-Z0-9]{1,20}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "225",name= "Kalyan Dombivali Municipal Corporation - Water",category= "Water",viewbill= "1",regex= "^[a-zA-Z0-9]{1,20}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "239",name= "Kanakadurga Finance Limited",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "346",name= "Kanpur Electricity Supply Company",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "67",name= "Kanpur Electricity Supply Company Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "ACCOUNT NO",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "347",name= "Kerala State Electricity Board Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "147",name= "Kerala State Electricity Board Ltd. (KSEBL)",category= "Electricity",viewbill= "1",regex= "^[0-9]{13}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "413",name= "Kerala Water Authority",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "179",name= "Kerala Water Authority (KWA)",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{8,10}$",displayname= "Consumer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "228",name= "Kinara Capital",category= "EMI",viewbill= "1",regex= "^([A-Z]{5}[0-9]{7})|([0-9]{2,}[A-Z]{2,}[0-9]{1,}[A-Z0-9]{2,})$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "222",name= "Kissht",category= "EMI",viewbill= "1",regex= "^[0-9]{10,10}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "81",name= "Kota Electricity Distribution Limited (KEDL)",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "348",name= "Kota Electricity Distribution Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "281",name= "Kotak Mahindra Bank",category= null,viewbill= "1",regex= "",displayname= "Vehicle Registration Number",ad1_d_name= "Bank Name",ad1_name= "bankName",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "315",name= "Kotak Mahindra Bank",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "18",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "180",name= "L and T Financial Services",category= "EMI",viewbill= "1",regex= "^[Tt][0-9a-zA-Z]{17,19}|[1-9]{7}$",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "191",name= "L and T Housing Finance",category= "EMI",viewbill= "1",regex= "^([h,H]){1}([0-9]){17}?$|^([h,H]){1}([0-9]){17}([a-zA-Z]){1}?$|^([h,H]){1}([0-9]){17}([a-zA-Z]){2}?$|^([a-zA-Z]){3}([HL,hl,Hl,hL]){2}([0-9]){8}?$|^([a-zA-Z]){3}([FC,fc,Fc,fC]){2}([0-9]){8}?$|^([a-zA-Z]){3}([HF,hf,Hf,hF]){2}([0-9]){8}?$|^([a-zA-Z]){3}([-]){1}([0-9]){3}?$|^([a-zA-Z]){3}([-]){1}([0-9]){4}?$",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "241",name= "Life Insurance Corporation",category= "Insurance",viewbill= "1",regex= "^[0-9]{7,10}$",displayname= "Policy Number",ad1_d_name= "Email ID",ad1_name= "emailId",ad1_regex= "^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "220",name= "LOANTAP CREDIT PRODUCTS PRIVATE LIMITED",category= "EMI",viewbill= "1",regex= "^[0-9a-zA-Z]{15,35}$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "181",name= "Loksuvidha",category= "EMI",viewbill= "1",regex= "^[0-9]{5,6}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "253",name= "M.p. Madhya Kshetra Vidyut Vitaran - Agriculture",category= "Electricity",viewbill= "1",regex= "^[0-9]{5,20}$",displayname= "Consumer Number/IVRS ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "117",name= "M.P. Madhya Kshetra Vidyut Vitaran - RURAL",category= "Electricity",viewbill= "1",regex= "^[0-9]{7,15}$",displayname= "IVRS",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "116",name= "M.P. Madhya Kshetra Vidyut Vitaran - URBAN",category= "Electricity",viewbill= "1",regex= "^[0-9]{7,15}$",displayname= "IVRS",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "349",name= "M.P. Madhya Kshetra Vidyut Vitaran-Flat Rate Agriculture Bill",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "350",name= "M.P. Madhya Kshetra Vidyut Vitaran-Rural",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "351",name= "M.P. Madhya Kshetra Vidyut Vitaran-Urban",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "37",name= "M.P. Paschim Kshetra Vidyut Vitaran",category= "Electricity",viewbill= "1",regex= "^[A-Za-z0-9]{2,30}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "118",name= "M.P. Poorv Kshetra Vidyut Vitaran - URBAN",category= "Electricity",viewbill= "1",regex= "^[0-9A-Za-z]{7,10}$",displayname= "Consumer Number/IVRS",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "132",name= "M.P. Poorv Kshetra Vidyut Vitaran – RURAL",category= "Electricity",viewbill= "1",regex= "^[0-9A-Za-z]{7,20}$",displayname= "Consumer Number/IVRS",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "352",name= "M.P. Poorv Kshetra Vidyut Vitaran-Rural",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "353",name= "Madhya Gujarat Vij Company Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "24",name= "Madhya Gujarat Vij Company Ltd",category= "Electricity",viewbill= "0",regex= "^[0-9]{5,11}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "354",name= "Madhya Pradesh Paschim Kshetra Vidyut Vitaran Company Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "355",name= "Madhya Pradesh Poorv Kshetra Vidyut Vitaran",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "214",name= "Madhya Pradesh Urban (e-Nagarpalika) - Property",category= "Municipality",viewbill= "1",regex= "^[a-zA-Z0-9- ]+$",displayname= "ULB Code",ad1_d_name= "Property ID",ad1_name= "PropId",ad1_regex= "^[a-zA-Z0-9_]*$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "213",name= "Madhya Pradesh Urban Administration and Development - Water",category= "Water",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "ULB Code",ad1_d_name= "Con. Number",ad1_name= "ConNo",ad1_regex= "^[a-zA-Z0-9_]*$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "398",name= "Mahanagar Gas- Mumbai",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "393",name= "Maharashtra Natural Gas Limited (MNGL)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "356",name= "Maharashtra State Electricity Distribution Co Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "18",name= "Mahavitaran-Maharashtra State Electricity Distribution Company Ltd. (MSEDCL)",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= "Billing Unit",ad1_name= "billingUnit",ad1_regex= "^[0-9]{4}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "240",name= "Mahindra Rural Housing Finance",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "209",name= "Manappuram Finance Limited-Vehicle Loan",category= "EMI",viewbill= "1",regex= "^([a-zA-Z]){10}([0-9]){12}?$",displayname= "Agreement Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "357",name= "Mangalore Electricity Supply Co. Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "144",name= "Mangalore Electricity Supply Co. Ltd (MESCOM)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10}$",displayname= "Account ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "358",name= "Mangalore Electricity Supply Company Ltd-non Rapdr",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "230",name= "Max Bupa Health Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{14}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "137",name= "Max Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{9}$",displayname= "POLICY NO",ad1_d_name= "Date of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "264",name= "Maxvalue Credits And Investments Ltd",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]{5,20}$",displayname= "Account Number",ad1_d_name= "Mobile Number",ad1_name= "mobileNumber",ad1_regex= "^[0-9]{10}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "422",name= "MEGHALAYA ELECTRI CITY",category= "BILL PAYMENT",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "48",name= "Meghalaya Power Distribution Cor. Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "359",name= "Meghalaya Power Distribution Corporati On Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "272",name= "Midland Microfin Ltd",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "167",name= "Mnet Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9a-zA-Z]{3,40}$",displayname= "User Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "182",name= "Motilal Oswal Home Finance",category= "EMI",viewbill= "1",regex= "^[0-9A-Za-z]{20, 25}$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "45",name= "MP-Poorv Kshetra Vidyut Vitaran Co. Ltd.(Jabalpur)",category= "Electricity",viewbill= "1",regex= "^[0-9]{7,20}$",displayname= "Consumer Number/IVRS",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "19",name= "MTNL Delhi Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Telephone Number (Without STD Code)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "55",name= "MTNL Mumbai",category= "Landline",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Telephone Number (Without STD Code)",ad1_d_name= "Account Number",ad1_name= "accountNumber",ad1_regex= "^[0-9]{10}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "436",name= "MTNL SPECIAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "435",name= "MTNL TOPUP",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "426",name= "MTS",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "411",name= "Municipal Corporation Amritsar - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "208",name= "Municipal Corporation Chandigarh",category= "Water",viewbill= "1",regex= "^[0-9A-Za-z]{7,20}$",displayname= "Account No without(/)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "121",name= "Municipal Corporation Jalandhar",category= "Water",viewbill= "1",regex= "^[0-9]{1,9}$",displayname= "Account No",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "414",name= "Municipal Corporation Jalandhar- Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "289",name= "Municipal Corporation Ludhiana",category= "Water",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "412",name= "Municipal Corporation Ludhiana - Water",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "123",name= "Municipal Corporation Ludhiana – Water",category= "Water",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Consumer Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "165",name= "Municipal corporation of Amritsar",category= "Water",viewbill= "1",regex= "^[0-9]{1,9}$",displayname= "Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "92",name= "Municipal Corporation of Gurugram",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{7,20}$",displayname= "K No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "254",name= "Muzaffarpur Vidyut Vitran Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "158",name= "Mysuru Citi Corporation",category= "Water",viewbill= "1",regex= "^[0-9]{1,7}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "410",name= "Mysuru City Corporation",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "303",name= "nav2",category= "sal007",viewbill= "1",regex= "sd",displayname= "fdfdf",ad1_d_name= "",ad1_name= "",ad1_regex= "",ad2_d_name= "",ad2_name= "",ad2_regex= "",ad3_d_name= "",ad3_name= "",ad3_regex= ""
        },
        new Root1(){id= "83",name= "NESCO, Odisha",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "186",name= "Netplus Broadband",category= "EMI",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Billing Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "360",name= "New Delhi Municipal Council",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "120",name= "New Delhi Municipal Council (NDMC) - Electricity",category= "Electricity",viewbill= "1",regex= "^[0-9]{7,10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "119",name= "New Delhi Municipal Council (NDMC) - Water",category= "Water",viewbill= "1",regex= "^[0-9]{7,10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "65",name= "Nextra Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{5,15}$",displayname= "Customer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "31",name= "Noida Power Company Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "361",name= "North Bihar Power Distribution Company Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "82",name= "North Bihar Power Distribution Company Ltd.",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,12}$",displayname= "CA Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "362",name= "North Delhi Power Limited Tata Power–Ddl",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "363",name= "North Eastern Electricity Supply Company Of Odisha Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "255",name= "Northern Power Distribution Of Telanagana Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{8,15}$",displayname= "USC No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "256",name= "Odisha Discoms B2B",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "257",name= "Odisha Discoms B2C",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "364",name= "Odisha Discoms(b2b)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "365",name= "Odisha Discoms(b2c)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "235",name= "OHMYLOAN",category= "EMI",viewbill= "1",regex= "^[A-Z0-9]{2,9}$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "236",name= "OMLP2P.COM",category= "EMI",viewbill= "1",regex= "^[A-Z0-9]{2,9}$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "183",name= "Paisa Dukan-Borrower EMI",category= "EMI",viewbill= "1",regex= "^[l,L][n,N]\\d{6}$",displayname= "Loan ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "366",name= "Paschim Gujarat Vij Company Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "26",name= "Paschim Gujarat Vij Company Ltd",category= "Electricity",viewbill= "0",regex= "^[0-9]{5,11}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "318",name= "Paul Merchants",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "21",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "317",name= "Paytm Payments Bank FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "20",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "293",name= "Phed - Rajasthan",category= "Water",viewbill= "1",regex= "^[0-9]{12}$",displayname= "eMitra CID Code",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "409",name= "PHED Rajasthan",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "50",name= "PNB Metlife",category= "Insurance",viewbill= "1",regex= "^[0-9]{1,20}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "287",name= "Port Blair Municipal Council",category= "municipality",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Shop ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "258",name= "Power & Electricity Department Government Of Mizoram",category= "Electricity",viewbill= "1",regex= "^[0-9]{10,12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "193",name= "Pramerica Life Insurance Limited",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "229",name= "Prayagraj Nagar Nigam - Property",category= "Municipality",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Property Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "408",name= "Pune Municipal Corporation",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "71",name= "Pune Municipal Corporation Water",category= "Water",viewbill= "1",regex= "^[0-9A-Za-z]{1,20}$",displayname= "Consumer No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "407",name= "Punjab Municipal Corporations Councils",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "159",name= "Punjab Municipal Corporations/Councils",category= "Water",viewbill= "1",regex= "^[0-9]{1}[1-9]{1}[0-9]{8}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "367",name= "Punjab State Power Corporation Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "99",name= "Punjab State Power Corporation Ltd (PSPCL)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10,12}$",displayname= "Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "259",name= "Rajasthan Vidyut Vitran Nigam Limited",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "152",name= "Ranchi Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9A-Za-z]{6,25}$",displayname= "Consumer No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "437",name= "RELIANCE CDMA",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "226",name= "Reliance General Insurance Company Limited",category= "Insurance",viewbill= "1",regex= "^[0-9]{16,18}$",displayname= "Previous Policy Number",ad1_d_name= "Email ID",ad1_name= "emailId",ad1_regex= "^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$",ad2_d_name= "Mobile Number (+91)",ad2_name= "mobileNumber",ad2_regex= "^[6789][0-9]{9}$",ad3_d_name= "Date Of Birth (dd/MM/yyyy)",ad3_name= "dateofBirth",ad3_regex= ""
        },
        new Root1(){id= "427",name= "RELIANCE GSM",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "206",name= "Reliance Nippon Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{8}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "448",name= "RELIANCE POSTPAID",category= "POST PAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "187",name= "Religare Health Insurance Co Ltd.",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{8}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (yyyy-MM-dd)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "394",name= "Sabarmati Gas Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "419",name= "SBI LIFE",category= "BILL PAYMENT",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "56",name= "SBI Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{11}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (DD-MM-YYYY)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "162",name= "SBIG",category= "Insurance",viewbill= "0",regex= "",displayname= "",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "304",name= "sdsd",category= "dsds",viewbill= "0",regex= "sd",displayname= "dfdf",ad1_d_name= "",ad1_name= "",ad1_regex= "",ad2_d_name= "",ad2_name= "",ad2_regex= "",ad3_d_name= "",ad3_name= "",ad3_regex= ""
        },
        new Root1(){id= "416",name= "Shimla Jal Sansthan",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "189",name= "Shriram City Union Finance Ltd",category= "EMI",viewbill= "1",regex= "^[0-9a-zA-Z]{10,25}$",displayname= "Loan Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "231",name= "Shriram General Insurance",category= "Insurance",viewbill= "1",regex= "^[\\d]{1,}\\/[\\d]{1,}\\/[\\d]{1,}\\/[\\d]{1,}$",displayname= "Policy Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "221",name= "Shriram Housing Finance Limited",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Loan Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "223",name= "Shriram Life Insurance Co Ltd",category= "Insurance",viewbill= "1",regex= "^[a-zA-Z0-9_]*$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd/MM/yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "143",name= "Sikkim Power - URBAN",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,12}$",displayname= "Contract Acc Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "133",name= "Sikkim Power – RURAL",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,9}$",displayname= "Contract Acc Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "368",name= "Sikkim Power-Urban",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "369",name= "Sikkim Power–Rural",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "153",name= "Silvassa Municipal Council",category= "Water",viewbill= "1",regex= "^[0-9]{1,14}$",displayname= "Form No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "184",name= "Snapmint",category= "EMI",viewbill= "1",regex= "^[5-9][0-9]{9}$",displayname= "Registered Mobile Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "370",name= "South Bihar Power Distribution Company Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "77",name= "South Bihar Power Distribution Company Ltd.",category= "Electricity",viewbill= "1",regex= "^[0-9]{8,12}$",displayname= "CA Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "85",name= "SOUTHCO, Odisha",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "371",name= "Southern Electricity Supply Company Of Odisha Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "372",name= "Southern Power Distribution Company Ltd Of Andhra Pradesh",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "59",name= "SpectraNet Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{6,15}$",displayname= "Account Number (last 6 digit number)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "212",name= "Star Union Dai Ichi Life Insurance",category= "Insurance",viewbill= "1",regex= "^[0-9]{8}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth (dd/MM/yyyy)",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= "Mobile Number (+91)",ad2_name= "mobileNumber",ad2_regex= "^[6789][0-9]{9}$",ad3_d_name= "Email Address",ad3_name= "emailId",ad3_regex= "^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$"
        },
        new Root1(){id= "443",name= "SUN TV",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "130",name= "Surat Municipal Corporation",category= "Water",viewbill= "1",regex= "^[0-9a-zA-Z]{1,20}$",displayname= "Connection Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "265",name= "Svatantra Microfin Private Limited",category= "EMI",viewbill= "1",regex= "^[0-9]{2,8}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "243",name= "Swifttele Enterprises Private Limited",category= "Broadband",viewbill= "1",regex= "^[a-zA-Z0-9]{11}$",displayname= "Landline Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "373",name= "Tamil Nadu Electricity Board",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "94",name= "Tamil Nadu Electricity Board (TNEB)",category= "Electricity",viewbill= "1",regex= "^[0-9]{9,12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "21",name= "Tata AIA Life Insurance",category= "Insurance",viewbill= "1",regex= "^[ucUC][0-9]{9}$",displayname= "Policy Number",ad1_d_name= "Date Of Birth  ( dd-MM-yyyy )",ad1_name= "dateofBirth",ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "185",name= "Tata Capital Financial Services Limited",category= "EMI",viewbill= "1",regex= "^[a-zA-Z0-9]{7,21}$",displayname= "Loan Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "41",name= "Tata Docomo CDMA Postpaid",category= "Postpaid",viewbill= "0",regex= "^[1-9]{1}[0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "14",name= "Tata Docomo GSM Postpaid",category= "Postpaid",viewbill= "0",regex= "^[1-9]{1}[0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "447",name= "TATA DOCOMO GSM POSTPAID",category= "POSTPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "429",name= "TATA DOCOMO NORMAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "430",name= "TATA DOCOMO SPECIAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "428",name= "TATA INDICOM",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "420",name= "TATA LANDLINE",category= "BILL PAYMENT",viewbill= "0",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "7",name= "Tata Photon",category= "Datacard Prepaid",viewbill= "0",regex= "^[0-9]{10}$",displayname= "Data Card Number",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "20",name= "Tata Power Delhi Distribution Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{11,12}$",displayname= "Customer Account Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "66",name= "Tata Power Mumbai",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "374",name= "Tata Power–Mumbai",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "445",name= "TATA SKY",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "22",name= "Tata TeleServices (CDMA)",category= "Landline",viewbill= "0",regex= "^[0-9]{10}$",displayname= "Landline Number with STD Code (without 0)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "305",name= "test111",category= "test",viewbill= "0",regex= "4",displayname= "5",ad1_d_name= "",ad1_name= "",ad1_regex= "",ad2_d_name= "",ad2_name= "",ad2_regex= "",ad3_d_name= "",ad3_name= "",ad3_regex= ""
        },
        new Root1(){id= "28",name= "Tikona",category= "Landline",viewbill= "1",regex= "^[0-9]{10}$",displayname= "Service Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "170",name= "Timbl Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{7,10}$",displayname= "CustomerId/RMN",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "297",name= "Torrent power - Agra",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,15}$",displayname= "Service Number",ad1_d_name= "null",ad1_name= "null",ad1_regex= "null",ad2_d_name= "null",ad2_name= "null",ad2_regex= "null",ad3_d_name= "null",ad3_name= "null",ad3_regex= "null"
        },
        new Root1(){id= "40",name= "Torrent power - Ahmedabad",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,15}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "296",name= "Torrent power - Bhiwandi",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,15}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "295",name= "Torrent power - Surat",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,15}$",displayname= "Service Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "390",name= "Torrent Power Limited - Shilmumbrakalwa",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "378",name= "Torrent Power-Agra",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "375",name= "Torrent Power-Ahmedabad",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "377",name= "Torrent Power-Bhiwandi",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "376",name= "Torrent Power-Surat",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "379",name= "TP Ajmer Distribution Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "87",name= "TP Ajmer Distribution Ltd (TPADL)",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "K Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "260",name= "Tp Center Odisha Distribution Limited",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "323",name= "Transaction Analyst FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "26",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "44",name= "Tripura State Electricity Board",category= "Electricity",viewbill= "1",regex= "^[0-9]{1,12}$",displayname= "Consumer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "380",name= "Tripura State Electricity Corporation Ltd",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "114",name= "TTN BroadBand",category= "Broadband",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "322",name= "UCO Bank FASTag",category= "Fastag",viewbill= "1",regex= null,displayname= "Vehicle Registration Number",ad1_d_name= null,ad1_name= null,ad1_regex= "25",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "290",name= "Ujjain Nagar Nigam - PHED",category= "Water",viewbill= "1",regex= "^[0-9]{8,10}$",displayname= "Business Partner Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "134",name= "Ujjain Nagar Nigam – PHED",category= "Water",viewbill= "1",regex= "^[0-9]{8,10}$",displayname= "Business Partner Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "434",name= "UNINOR",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "446",name= "UNINOR SPECIAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "88",name= "Urban Improvement Trust (UIT) - Bhiwadi",category= "Water",viewbill= "1",regex= "^[0-9]{3,20}$",displayname= "Customer ID",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "381",name= "Uttar Gujarat Vij Company Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "27",name= "Uttar Gujarat Vij Company Ltd",category= "Electricity",viewbill= "0",regex= "^[0-9]{5,11}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "97",name= "Uttar Haryana Bijli Vitran Nigam (UHBVN)",category= "Electricity",viewbill= "1",regex= "^[0-9a-zA-Z]{10,12}$",displayname= "Account Number",ad1_d_name= "Mobile Number (+91)",ad1_name= "mobileNumber",ad1_regex= "^[6789][0-9]{9}$",ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "382",name= "Uttar Haryana Bijli Vitran Nigam Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "386",name= "Uttar Haryana Bijli Vitran Nigam Limited-Prepaid",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "95",name= "Uttar Pradesh Power Corp Ltd (UPPCL) - RURAL",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "383",name= "Uttar Pradesh Power Corp Ltd-Rural",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "384",name= "Uttar Pradesh Power Corp Ltd-Urban",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "74",name= "Uttar Pradesh Power Corp. Ltd. (UPPCL) - URBAN",category= "Electricity",viewbill= "1",regex= "^[0-9]{10,12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "69",name= "Uttarakhand Jal Sansthan",category= "Water",viewbill= "1",regex= "^[0-9]{7}$",displayname= "Consumer Number (Last 7 Digits)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "89",name= "Uttarakhand Power Corporation Limited",category= "Electricity",viewbill= "1",regex= "^[A-Za-z0-9]{13}$",displayname= "Service Connection Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "399",name= "Vadodara Gas Limited (VGL)",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "200",name= "Varthana",category= "EMI",viewbill= "1",regex= "^(([A-Z]{3})+(-)+([A-Z]{3})+(-)\\w+([0-9])\\w+([A-Z]{2}))|(([A-Z]{3})+([0-9])+([A-Z]{1}))|(([A-Z]{1})+([0-9]{2})+([A-Z]{3})+(-)+([A-Z]{3})+(-)+([0-9]{6}))$",displayname= "Loan Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "211",name= "Vastu Housing Finance Corporation Limited",category= "Insurance",viewbill= "1",regex= "^[0-9A-Za-z]{5,15}$",displayname= "Loan Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "174",name= "Vfibernet Broadband",category= "Broadband",viewbill= "1",regex= "^[0-9]{1,10}$",displayname= "Account No",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "438",name= "VIDEOCON MOBILE SPECIAL",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "439",name= "VIDEOCON MOBILE TOPUP",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "444",name= "VIDEOCOND2H",category= "DTH",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "23",name= "Vodafone",category= "Postpaid",viewbill= "0",regex= "^[6789][0-9]{9}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "433",name= "VODAFONE",category= "PREPAID",viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "288",name= "Vodafone Idea Postpaid",category= "Postpaid",viewbill= "0",regex= "^[1-9]{1}[0-9]{9}$",displayname= "Mobile Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "90",name= "WESCO Utility",category= "Electricity",viewbill= "1",regex= "^[0-9]{12}$",displayname= "Consumer Number",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "108",name= "West Bengal State Electricity Distribution Co. Ltd",category= "Electricity",viewbill= "1",regex= "^[0-9]{9}$",displayname= "Consumer Id",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "385",name= "Western Electricity Supply Company Of Orissa Limited",category= null,viewbill= "1",regex= null,displayname= null,ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        },
        new Root1(){id= "218",name= "ZestMoney",category= "EMI",viewbill= "1",regex= "^[0-9]{10,13}$",displayname= "Mobile Number (+91)",ad1_d_name= null,ad1_name= null,ad1_regex= null,ad2_d_name= null,ad2_name= null,ad2_regex= null,ad3_d_name= null,ad3_name= null,ad3_regex= null
        }

           };
            int i = 0,j=0;
            foreach (Root1 obj in clslist)
            {
                DataTable dt=new DataTable();
                 // dt = new clsAdminLogic().EntryBBPSOperatorListDetails(obj.id, obj.name, obj.category, obj.viewbill,obj.regex, obj.displayname,obj.ad1_d_name, obj.ad1_name,obj.ad1_regex, obj.ad2_d_name, obj.ad2_name, obj.ad2_regex, obj.ad3_d_name, obj.ad3_name, obj.ad3_regex);
                if (dt != null && dt.Rows.Count > 0)
                    i++;
                else
                    j++;

            }
            
            return Json("Save Operator "+i +" & Not save "+ j);
        }
        public class Root1
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
            public string ad3_d_name { get; set; }
            public string ad3_name { get; set; }
            public string ad3_regex { get; set; }
        }

        #endregion

    }
}
