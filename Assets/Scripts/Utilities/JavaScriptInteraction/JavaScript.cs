using System.Runtime.InteropServices;

namespace Scripts.Utilities.JavaScriptInteraction
{
    public static class JavaScript
    {
        #region Import Funtions

        [DllImport("__Internal")]
        private static extern void SayHello(string message);

        #endregion

        #region Methods

        public static void SendMessage(string message)
        {
            SayHello(message);
        }

        #endregion
    }
}
