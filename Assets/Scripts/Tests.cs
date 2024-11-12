using UnityEngine;
using UniWebGlClipboard;

public class Tests : MonoBehaviour
{
    [SerializeField]
    private string _message;

    void Start()
    {
        WebglClipboard.SendToClipboard(_message);
        Debug.Log($"\"{_message}\" are copied to clipboard");
    }
}
