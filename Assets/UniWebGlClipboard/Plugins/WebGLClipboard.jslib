const WebglClipboard = { };

function sendToClipboard(str) {
    navigator.clipboard.writeText(UTF8ToString(str));
}

const WebglClipboardLib = {
    $WebglClipboard: WebglClipboard,
    sendToClipboard
};

autoAddDeps(WebglClipboardLib, '$WebglClipboard');
mergeInto(LibraryManager.library, WebglClipboardLib);
