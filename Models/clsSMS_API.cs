using System.Net;

namespace SportsBattle.Models
{
    public class clsSMS_API
    {
        public void SendSMS(string MobileNo, string Msg)
        {
            string strAPI = "";
            //strAPI = "http://mysmsshop.in/http-api.php?username=ridhi&password=Admin123$&senderid=RIDHIM&route=1&number=" + MobileNo + "&message=" + Msg + "";

            strAPI = "http://mysmsshop.in/http-api.php?username=prad11004&password=Saniya8957.&senderid=&route=1&number=" + MobileNo + "&message=" + Msg + "";

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(strAPI);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
        }
    }
}
