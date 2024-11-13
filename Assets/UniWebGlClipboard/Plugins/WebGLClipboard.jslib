const WebglClipboard = { };

function sendToClipboard(str) {
    navigator.clipboard.writeText(UTF8ToString(str));
}

function readFromClipboard(callback) {
    navigator.clipboard.readText().then(val => {
        var bufferSize = lengthBytesUTF8(val) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(val, buffer, bufferSize);
        {{{ makeDynCall('vi', 'callback') }}} (buffer);
        _free(buffer);
    });
}

const WebglClipboardLib = {
    $WebglClipboard: WebglClipboard,
    sendToClipboard,
    readFromClipboard
};

autoAddDeps(WebglClipboardLib, '$WebglClipboard');
mergeInto(LibraryManager.library, WebglClipboardLib);
