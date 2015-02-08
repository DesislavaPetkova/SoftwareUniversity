var specialConsole = function () {

    function writeLine() {

        var message = arguments[0];

        if (arguments.length === 1) {
            consoleWrite(message);
        } else if (arguments.length > 1) {
            var args = Array.prototype.slice.call(arguments); // convert object to array
            message = fillPlaceholders(message, args.slice(1, args.length));
            consoleWrite(message);
        }
    }
    
    function fillPlaceholders(str, args) {
        for (var i = 0; i < args.length; i++) {
            str = str.replace('{' + i + '}', args[i].toString());
        }
        
        return str;
    }
    
    function consoleWrite(str) {
        console.log(str.toString());
    }

    var self = {
        writeLine: writeLine,
        writeError: writeLine,
        writeWarning: writeLine
    };

    return self;
}();