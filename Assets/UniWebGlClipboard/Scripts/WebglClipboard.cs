#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace UniWebGlClipboard
{
#if UNITY_WEBGL && !UNITY_EDITOR
    public class WebglClipboard
    {
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);

        public static void SendToClipboard(string str)
        {
            sendToClipboard(str);
        }
    }
#endif
}
