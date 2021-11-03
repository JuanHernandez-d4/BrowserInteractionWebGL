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


        #endregion

        #region Methods

        
        public static void SendMessage(string message)
        {
            SayHello(message);
            GetURL();
           
        }

        public static void WebTokenEncode(){
            var payload = new Dictionary<string, object>()
                {
                    { "userId", "123456789" },
                    { "createdAt", "Forest" }
                };
                var secretKey = "Rjs8hiE2pSDvoZGmWpeD826VrE5xo0B9";
                string token = JWT.JsonWebToken.Encode(payload, secretKey, JWT.JwtHashAlgorithm.HS256);
                Debug.Log(token);

        }

        public static void WebTokenDecode(string token){
            var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VySWQiOiIxMjM0NTY3ODkiLCJjcmVhdGVkQXQiOiJGb3Jlc3QifQ._jqIGHQP4NVNOTq0PvyoTIBM1pu3uxEQ3c9Dxd22TMw";
            var secretKey = "Rjs8hiE2pSDvoZGmWpeD826VrE5xo0B9";
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

        #endregion
    }
}
