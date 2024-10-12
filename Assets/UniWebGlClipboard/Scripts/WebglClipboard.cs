using System.Runtime.InteropServices;

namespace UniWebGlClipboard
{
    public class WebglClipboard
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);

        public static void SendToClipboard(string str)
        {
            sendToClipboard(str);
        }
#endif
    }
}
