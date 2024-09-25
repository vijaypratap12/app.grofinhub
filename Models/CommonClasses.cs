using Microsoft.AspNetCore.Http;
using System;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.Security;
using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
using Nancy.Json;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using RestSharp;
using Newtonsoft.Json;
using System.Security.Claims;

namespace SportsBattle.Models
{
    public class CommonClasses
    {
        public const string agentid = "CORP0000407";
        public const string crypt_key = "13a7d8a5d4f9822b";
        public const string IV = "ce139809a5359fc7";
        public void SendSMS(string MobileNo, string Msg)
        {
            string strAPI = "";
            strAPI = "http://mysmsshop.in/http-api.php?username=prad11004&password=Saniya8957.&senderid=PANRNG&route=1&number=" + MobileNo + "&message=" + Msg + "";

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(strAPI);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
        }
        public int GenerateOTP()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public int GeneratePassword()
        {
            int _min = 100000;
            int _max = 999999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        public void GetNotification(string FCMID, string title, string body)
        {
            try
            {
                string MyFCMID = FCMID;
                string Response = "";
                string SERVERKEY = "";
                SERVERKEY = "AAAAeUTFLn4:APA91bHN5SL2RqhRcOlZ7YORu3QjT2Uq_LG5hxhFP0F0YxTGhJNVfK7R_9lUMNyCPRyU5EAFH6LP-jPPIn0nC6Hrg_o5H3kRaIa97L4gCNzl5prLzfkbSZWCs_n-C62TxZnfNzhSDkPj";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVERKEY));
                tRequest.Headers.Add(string.Format("Sender: id={0}", MyFCMID));
                tRequest.ContentType = "application/json";
                var payload = new
                {
                    to = MyFCMID,
                    priority = "high",
                    content_available = true,
                    notification = new
                    {
                        body = body,
                        title = title,
                    },
                };
                byte[] byteArray = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(payload));
                tRequest.ContentLength = byteArray.Length;
                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse tResponse = tRequest.GetResponse();
                dataStream = tResponse.GetResponseStream();
                StreamReader tReader = new StreamReader(dataStream);
                string sResponseFromServer = tReader.ReadToEnd();
                tReader.Close();
                dataStream.Close();
                tResponse.Close();
                Response = sResponseFromServer;
            }
            catch (Exception ex)
            {

            }
        }
        public void GetNotification2(string FCMID, string title, string body, string Image)
        {
            //string deviceId1 = "f2uJodIwQymfa1Z6j0sE9-:APA91bF5OMQtGnrkCml4_k8zNh0p-8t9zaZ-xFmWBO1MoRECvONk0M_PyZLDbl9qLwHs669PeN9jXPNGLd9AcSaf0Of4xFcD4yLh32U2j5ZRry-B1tTM0KDgW-cS1iZ2wBHX5n41BwVN";
            //string deviceId2 = "f2uJodIwQymfa1Z6j0sE9-:APA91bF5OMQtGnrkCml4_k8zNh0p-8t9zaZ-xFmWBO1MoRECvONk0M_PyZLDbl9qLwHs669PeN9jXPNGLd9AcSaf0Of4xFcD4yLh32U2j5ZRry-B1tTM0KDgW-cS1iZ2wBHX5n41BwVN";
            //string deviceId3 = "f2uJodIwQymfa1Z6j0sE9-:APA91bF5OMQtGnrkCml4_k8zNh0p-8t9zaZ-xFmWBO1MoRECvONk0M_PyZLDbl9qLwHs669PeN9jXPNGLd9AcSaf0Of4xFcD4yLh32U2j5ZRry-B1tTM0KDgW-cS1iZ2wBHX5n41BwVN";

            //string[] str1;
            //str1 = new string[2] { deviceId1, deviceId2 };

            string[] str2;
            str2 = FCMID.Split(',');

            try
            {
                string MyFCMID = FCMID;
                string Response = "";
                string SERVERKEY = "";
                // SERVERKEY = "AAAAeUTFLn4:APA91bHN5SL2RqhRcOlZ7YORu3QjT2Uq_LG5hxhFP0F0YxTGhJNVfK7R_9lUMNyCPRyU5EAFH6LP-jPPIn0nC6Hrg_o5H3kRaIa97L4gCNzl5prLzfkbSZWCs_n-C62TxZnfNzhSDkPj";

                SERVERKEY = "AAAAFgaU530:APA91bEFV6v6QkUM5HOo11xeHloLee0ePa9ZVY_v88CJbomZx8INg8XNzk1Cq9fqvjLjwHy3_iIhM6GuPhHrXA6uRc8v0MkXGtwiXLvuL8IVmAT7_0ghAWvQuFy67gCNkqSrDgXt-Jem";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVERKEY));
                tRequest.Headers.Add(string.Format("Sender: id={1}", str2));
                tRequest.ContentType = "application/json";
                var payload = new
                {
                    registration_ids = str2,
                    priority = "high",
                    content_available = true,
                    notification = new
                    {
                        body = body,
                        title = title,
                        Image = Image,
                    },
                };
                byte[] byteArray = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(payload));
                tRequest.ContentLength = byteArray.Length;
                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse tResponse = tRequest.GetResponse();
                dataStream = tResponse.GetResponseStream();
                StreamReader tReader = new StreamReader(dataStream);
                string sResponseFromServer = tReader.ReadToEnd();
                tReader.Close();
                dataStream.Close();
                tResponse.Close();
                Response = sResponseFromServer;
            }
            catch (Exception ex)
            {

            }
        }

        //#region 03/03/2023
        //public string GenerateReferenceId()
        //{
        //    string rendomchar = "A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5QR6STUV7WX8YZ9ab0cd2ef4gh3ij1kl5mn6op7qr8st9uvw70x6y1z";
        //    string referenceId = "";

        //    for (int i = 0; i < 20; i++)
        //    {
        //        int rdm = new Random().Next(0, rendomchar.Length);
        //        referenceId += rendomchar[rdm];
        //    }
        //    return referenceId;
        //}
        //#endregion



        #region Atul Singh 2023/03/01
        public string GenerateReferenceId()
        {
            string rendomchar = "A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5QR6STUV7WX8YZ9ab0cd2ef4gh3ij1kl5mn6op7qr8st9uvw70x6y1z";
            string referenceId = "";

            for (int i = 0; i < 20; i++)
            {
                int rdm = new Random().Next(0, rendomchar.Length);
                referenceId += rendomchar[rdm];
            }
            return referenceId;
        }
        #endregion



        public string Random20Degit()
        {
            string rendomchar = "1234567890";
            string referenceId = "";

            for (int i = 0; i < 20; i++)
            {
                int rdm = new Random().Next(0, rendomchar.Length);
                referenceId += rendomchar[rdm];
            }
            return referenceId;
        }

        public string GetToken()
        {
            // Console.WriteLine("");

            // Define const Key this should be private secret key  stored in some safe place
            //string key = "UFMwMDEyNGQ2NTliODUzYmViM2I1OWRjMDc2YWNhMTE2M2I1NQ==";
            string key = "UFMwMDExMjEyYzY5MzliODkwMmI0NDU4OWM0MDhlYTZmZWI2OGE5NQ==";

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
               .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, "HS256");

            //  Finally create a Token
            var header = new JwtHeader(credentials);

            //Some PayLoad that contain information about the  customer
            var payload = new JwtPayload
            {
                {"timestamp", DateTimeOffset.Now.ToUnixTimeMilliseconds()},
                {"partnerId","PS001121" },
                //{ "reqid","12233773"},
                { "reqid",Random20Degit().ToString()},
             };
            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);

            // Console.WriteLine(tokenString);

            //Console.ReadLine();

            return tokenString.ToString();
        }



        //public static string ConvertTableToList(DataTable dt)
        //{
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    if (dt != null && dt.Rows.Count > 0)
        //    {


        //        Hashtable[] pr = new Hashtable[dt.Rows.Count];

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Hashtable ch = new Hashtable();
        //            for (int j = 0; j < dt.Columns.Count; j++)
        //            {
        //                string columnName = Convert.ToString(dt.Columns[j]).Replace("'", "").Replace('"', ' ');
        //                string columnValue = Convert.ToString(dt.Rows[i][columnName]).Replace("'", "").Replace('"', ' '); ;
        //                ch.Add(columnName, columnValue);
        //            }
        //            pr[i] = ch;
        //        }
        //        //js.MaxJsonLength = 999999999;
        //        return js.Serialize(pr);
        //    }


        //    return "False";
        //}

        public static string ConvertTableToList(DataTable dt)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            if (dt != null && dt.Rows.Count > 0)
            {
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, string.IsNullOrEmpty(dr[col].ToString()) == true ? "" : dr[col].ToString());

                    }
                    rows.Add(row);
                }
                return js.Serialize(rows);
            }
            else
            {
                return "False";
            }
        }

        #region GetLiveToken 2023/05/17


        public string GetLiveToken()
        {

            // Define const Key this should be private secret key  stored in some safe place
            //string key = "UFMwMDExMjEyYzY5MzliODkwMmI0NDU4OWM0MDhlYTZmZWI2OGE5NQ==";
            string key = "UFMwMDM4NzNhZGM4MGEzZWUzMGVkNWFjYjBjYzYxYTY1OTBkODllZjE2ODM2MTE5MjQ=";

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
               .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, "HS256");

            //  Finally create a Token
            var header = new JwtHeader(credentials);

            //Some PayLoad that contain information about the  customer
            var payload = new JwtPayload
           {
                {"timestamp", DateTimeOffset.Now.ToUnixTimeMilliseconds()},
               {"partnerId","PS003873" },
              // {"partnerId","PS001121" },
                { "reqid",GenerateReferenceId().ToString()},
    };


            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);


            return tokenString.ToString();
        }

        #endregion

        #region GetLiveToken 2023/05/17


        public string GetLiveVerifyToken()
        {

            // Define const Key this should be private secret key  stored in some safe place 
            // string key = "UTA5U1VEQXdNREF4VFZSSmVrNUVWVEpPZWxVd1RuYzlQUT09";
            string key = "UTA5U1VEQXdNREEwTURkT2VrRjNUa1JWTVU1cVNUVk5RVDA5";

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
               .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, "HS256");

            //  Finally create a Token
            var header = new JwtHeader(credentials);

            //Some PayLoad that contain information about the  customer
            var payload = new JwtPayload
           {
                {"timestamp", DateTimeOffset.Now.ToUnixTimeMilliseconds()},
               {"partnerId","CORP0000407" },
                { "reqid",GenerateReferenceId().ToString()},
    };


            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);


            return tokenString.ToString();
        }

        #endregion


        #region AEPS Encription 
        public static string CryptAESIn(string textToCrypt, string crypt_key, string init_Vector)
        {
            try
            {
                byte[] cryptkey = Encoding.ASCII.GetBytes(crypt_key);
                byte[] initVector = Encoding.ASCII.GetBytes(init_Vector);
                using (var rijndaelManaged =
                       new RijndaelManaged { Key = cryptkey, IV = initVector, Mode = CipherMode.CBC })
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream =
                       new CryptoStream(memoryStream,
                           rijndaelManaged.CreateEncryptor(cryptkey, initVector),
                           CryptoStreamMode.Write))
                {
                    using (var ws = new StreamWriter(cryptoStream))
                    {
                        ws.Write(textToCrypt);
                    }
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            catch (CryptographicException e)
            {
                return "A Cryptographic error occurred: {0} " + e.Message;
            }
        }
        public static string DecryptAESIn(string cipherData, string crypt_key, string init_Vector)
        {
            try
            {
                byte[] cryptkey = Encoding.ASCII.GetBytes(crypt_key);
                byte[] initVector = Encoding.ASCII.GetBytes(init_Vector);
                using (var rijndaelManaged =
                       new RijndaelManaged { Key = cryptkey, IV = initVector, Mode = CipherMode.CBC })
                using (var memoryStream =
                       new MemoryStream(Convert.FromBase64String(cipherData)))
                using (var cryptoStream =
                       new CryptoStream(memoryStream,
                           rijndaelManaged.CreateDecryptor(cryptkey, initVector),
                           CryptoStreamMode.Read))
                {
                    return new StreamReader(cryptoStream).ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                return "A Cryptographic error occurred: {0} " + e.Message;
            }
        }
        public static ClaimsPrincipal DecyptJWTData(string authToken)
        {
            var Key = Convert.FromBase64String("UFMwMDEyNGQ2NTliODUzYmViM2I1OWRjMDc2YWNhMTE2M2I1NQ==");

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Key)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(authToken, tokenValidationParameters, out SecurityToken securityToken);
            JwtSecurityToken? jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }
            return principal;
        }
        public static OnboardingResponse DecryptOnboardingToken(string token)
        {
            OnboardingResponse onboardingResponse = new OnboardingResponse();
            // Split the JWT token into parts
            string[] parts = token.Split('.');

            // Decode the header
            string header = Base64UrlDecode(parts[0]);

            // Decode the payload (claims)
            string payload = Base64UrlDecode(parts[1]);
            onboardingResponse = JsonConvert.DeserializeObject<OnboardingResponse>(payload);
            return onboardingResponse;
        }
      
        public static string Base64UrlDecode(string input)
        {
            string output = input.Replace('-', '+').Replace('_', '/');
            switch (output.Length % 4)
            {
                case 2: output += "=="; break;
                case 3: output += "="; break;
            }
            var converted = Convert.FromBase64String(output);
            return Encoding.UTF8.GetString(converted);
        }
        public static string EncryptTestWa(string plainText, string crypt_key, string init_Vector)
        {
            byte[] Key = Encoding.ASCII.GetBytes(crypt_key);
            byte[] IV = Encoding.ASCII.GetBytes(init_Vector);
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return Convert.ToBase64String(encrypted);
        }
        public static string DecryptTestWa(string cipher_Text, string crypt_key, string init_Vector)
        {
            byte[] cipherText = Encoding.ASCII.GetBytes(cipher_Text);
            byte[] Key = Encoding.ASCII.GetBytes(crypt_key);
            byte[] IV = Encoding.ASCII.GetBytes(init_Vector);
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
        public static string EncryptStringToBytesAes(string plainText, string key_k, string iv_v, Int32 KeySize = 256)
        {
            Int32 blockSize = 128;
            byte[] key = Encoding.ASCII.GetBytes(key_k);
            byte[] iv = Encoding.ASCII.GetBytes(iv_v);

            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");

            // Declare the stream used to encrypt to an in memory
            // array of bytes.
            MemoryStream msEncrypt;

            // Declare the RijndaelManaged object
            // used to encrypt the data.
            RijndaelManaged aesAlg = null;

            try
            {
                // Create a RijndaelManaged object
                // with the specified key and IV.
                aesAlg = new RijndaelManaged { Mode = CipherMode.CBC, KeySize = KeySize, BlockSize = blockSize, Key = key, IV = iv };

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                msEncrypt = new MemoryStream();
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {

                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                        swEncrypt.Flush();
                        swEncrypt.Close();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            // Return the encrypted bytes from the memory stream.
            return Convert.ToBase64String(msEncrypt.ToArray());
        }
        public static string DecryptStringFromBytesAes(string cipherText_c, string key_k, string iv_v, Int32 KeySize = 256)
        {
            Int32 blockSize = 128;
            byte[] cipherText = Encoding.ASCII.GetBytes(cipherText_c);
            byte[] key = Encoding.ASCII.GetBytes(key_k);
            byte[] iv = Encoding.ASCII.GetBytes(iv_v);

            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext;

            try
            {
                // Create a RijndaelManaged object
                // with the specified key and IV.
                aesAlg = new RijndaelManaged { Mode = CipherMode.CBC, KeySize = KeySize, BlockSize = blockSize, Key = key, IV = iv };

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                            srDecrypt.Close();
                        }
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            return plaintext;
        }

        #endregion

        public RootAEPS AEPSBankList()
        {
            RootAEPS obj = new RootAEPS();
            try
            {
                var client = new RestClient("https://api.paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aeps/banklist/index", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", GetLiveToken());
                //request.AddHeader("Authorisedkey", new DBHelper().AuthorizationKey);
                // request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.PostAsync(request).Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                obj = js.Deserialize<RootAEPS>(response.Content);

            }
            catch
            {

            }
            return obj;
        }


        public string WithdrawThreeway(AEPSTreeWay obj)
        {
            try
            {
                var client = new RestClient("https://paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aeps/threeway/threeway", Method.Post);
                request.AddHeader("accept", "application/json");
                string body = JsonConvert.SerializeObject(obj);
                body = CryptAESIn(body, crypt_key, IV);
                RootAEPSinpt data = new RootAEPSinpt() { body = body };
                body = JsonConvert.SerializeObject(data);
                request.AddHeader("Token", GetToken());
                request.AddHeader("Authorisedkey", new DBHelper().AuthorizationKey);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                return response.Content;
            }
            catch
            {
                return "Something Went Wrong !!";
            }

        }

        public string GetReferencenceId(string amount, string userid, string type)
        {
        again:
            string referenceid = Convert.ToString(GenerateReferenceId());

            DataTable dt = new clsLogic().GetReferenceId(referenceid, new GetReferenceModel() { amount = amount, UserId = userid, type = type });
            if (dt.Rows.Count > 0 && dt != null)
            {

                return referenceid;
            }
            else
            {
                goto again;
            }

        }
        public string GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            string ipaddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return ipaddress;
        }
    }

}
