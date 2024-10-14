using System.Runtime.InteropServices;
using UnityEngine;

namespace UniWebGlClipboard
{
#if UNITY_WEBGL
    public class WebglClipboard
    {
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);

        public static void SendToClipboard(string str)
        {
            if (Application.isEditor)
            {
                return;
            }
            sendToClipboard(str);
        }
    }
#endif
}
