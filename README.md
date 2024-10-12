# UniWebGlClipboard

Library for sending text to browser clipboard.

# Install from git URL

Requires a version of unity that supports path query parameter for git packages (Unity 2021.3 or later). You can add a reference `https://github.com/arty-F/UniWebGlClipboard.git?path=Assets/UniWebGlClipboard` to Package Manager.

# Install from .unitypackage

Download the latest `.unitypackage` file from [releases](https://github.com/arty-F/UniWebGlClipboard/releases) page and import downloaded package into unity.

# Usage
```csharp
WebglClipboard.SendToClipboard("you text");
```
In order to work in the editor and WebGL build use these:
```csharp
  GUIUtility.systemCopyBuffer = _message;
#if UNITY_WEBGL && !UNITY_EDITOR
  WebglClipboard.SendToClipboard(GUIUtility.systemCopyBuffer);
#endif
```
