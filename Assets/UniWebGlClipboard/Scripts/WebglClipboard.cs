using System.Runtime.InteropServices;
using UnityEngine;

namespace UniWebGlClipboard
{
    public class WebglClipboard
    {
#if UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);
#endif

        public static void SendToClipboard(string str)
        {
            GUIUtility.systemCopyBuffer = str;
#if UNITY_WEBGL
            if (Application.isEditor)
            {
                return;
            }
            sendToClipboard(str);
#endif
        }
    }
}
