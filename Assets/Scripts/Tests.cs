using UnityEngine;
using UniWebGlClipboard;

public class Tests : MonoBehaviour
{
    [SerializeField]
    private string _message;

    void Start()
    {
        GUIUtility.systemCopyBuffer = _message;
#if UNITY_WEBGL && !UNITY_EDITOR
            WebglClipboard.SendToClipboard(GUIUtility.systemCopyBuffer);
#endif
        Debug.Log($"\"{_message}\" are copied to clipboard");
    }
}
