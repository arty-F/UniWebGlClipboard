#if UNITY_WEBGL && !UNITY_EDITOR
using AOT;
using System.Runtime.InteropServices;
#endif
using System;
using UnityEngine;

namespace UniWebGlClipboard
{
    public class WebglClipboard
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void sendToClipboard(string str);

        [DllImport("__Internal")]
        private static extern string readFromClipboard(Action<string> callback);

        private static Action<string> _userCallback;
#endif

        public static void SendToClipboard(string str)
        {
            GUIUtility.systemCopyBuffer = str;
#if UNITY_WEBGL && !UNITY_EDITOR
            sendToClipboard(str);
#endif
        }

        public static void ReadFromClipboard(Action<string> callback)
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            _userCallback = callback;
            readFromClipboard(ReadClipboardCallback);
#else
            callback.Invoke(GUIUtility.systemCopyBuffer);
#endif
        }

#if UNITY_WEBGL && !UNITY_EDITOR
        [MonoPInvokeCallback(typeof(Action<string>))]
        public static void ReadClipboardCallback(string message)
        {
            _userCallback.Invoke(message);
        }
#endif
    }
}
