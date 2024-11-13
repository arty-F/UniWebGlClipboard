using UnityEngine;
using UnityEngine.UI;
using UniWebGlClipboard;

public class Tests : MonoBehaviour
{
    [SerializeField]
    private Button _copyBtn;
    [SerializeField]
    private Button _pasteBtn;
    [SerializeField]
    private InputField _output;

    void Start()
    {
        _copyBtn.onClick.AddListener(OnCopy);
        _pasteBtn.onClick.AddListener(OnPaste);
    }

    private void OnCopy()
    {
        WebglClipboard.SendToClipboard(_output.text);
    }

    private void OnPaste()
    {
        WebglClipboard.ReadFromClipboard(OnClipboardReaded);
    }

    private void OnClipboardReaded(string clipboard)
    {
        _output.text = clipboard;
    }

    public void MyFunction(string result)
    {
        _output.text = result;
    }
}
