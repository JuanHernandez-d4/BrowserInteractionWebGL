using System.Runtime.InteropServices;
using System.Collections.Generic;
using JWT;
using UnityEngine.UI;
using UnityEngine;

namespace Scripts.Utilities.JavaScriptInteraction
{
    public static class JavaScript
    {
        #region Import Funtions

        [DllImport("__Internal")]
        private static extern void SayHello(string message);
        
        [DllImport("__Internal")]   
        private static extern void GetURL();

        [DllImport("__Internal")]   
        private static extern void PutToken();


        #endregion

        #region Methods

        
        public static void SendMessage(string message)
        {
            SayHello(message);

           
        }

        public static void WebTokenEncode(){
            var payload = new Dictionary<string, object>()
                {
                    { "username", "Juan Diego Quintero" },
                    { "id", "123456789" }
                };
                var secretKey = "1BYzVqcEYNnnI48aCX2q7CQM6ISxlGtBKBO0FUdVD50";
                string token = JWT.JsonWebToken.Encode(payload, secretKey, JWT.JwtHashAlgorithm.HS256);
                Debug.Log(token);
                WebTokenDecode(token);

        }

        public static void WebTokenDecode(string token){
            var secretKey = "1BYzVqcEYNnnI48aCX2q7CQM6ISxlGtBKBO0FUdVD50";
            try
            {
                string jsonPayload = JWT.JsonWebToken.Decode(token, secretKey);
                Debug.Log(jsonPayload);
            }
            catch (JWT.SignatureVerificationException)
            {
                Debug.Log("Invalid token!");
            }
        }

        public static void PutToken1(){
            GetURL();
            PutToken();
        }

        #endregion
    }
}
