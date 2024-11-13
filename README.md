# UniWebGlClipboard

Library for working with clipboard from Unity Webgl build.

# Install from git URL

Requires a version of unity that supports path query parameter for git packages (Unity 2021.3 or later). You can add a reference `https://github.com/arty-F/UniWebGlClipboard.git?path=Assets/UniWebGlClipboard` to Package Manager.

# Install from .unitypackage

Download the latest `.unitypackage` file from [releases](https://github.com/arty-F/UniWebGlClipboard/releases) page and import downloaded package into unity.

# Usage

Sending text to clipboard:
```csharp
WebglClipboard.SendToClipboard("you text");
```

Getting text from clipboard:
```csharp
WebglClipboard.ReadFromClipboard(OnClipboardReaded);
...
void OnClipboardReaded(string clipboard)
{
    var youText = clipboard;
}
```
