using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UniWebGlClipboard
{
    public class WebglClipboard
    {
#if UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);

        [DllImport("__Internal")]
        private static extern string readFromClipboard(Action<string> callback);

        private static Action<string> _userCallback;
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

        public static void ReadFromClipboard(Action<string> callback)
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            _userCallback = callback;
            readFromClipboard(ReadClipboardCallback);
#endif
            callback.Invoke(GUIUtility.systemCopyBuffer);
        }

#if UNITY_WEBGL
        [MonoPInvokeCallback(typeof(Action<string>))]
        public static void ReadClipboardCallback(string message)
        {
            _userCallback.Invoke(message);
        }
#endif
    }
}
