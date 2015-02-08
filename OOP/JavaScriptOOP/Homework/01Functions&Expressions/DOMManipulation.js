var domModule = function() {


	function addChildElement () {
		
	var element = arguments[0];
	var append = document.querySelector(arguments[1]);

	append.appendChild(element);


	};

	function removeChild() {
		var selector = arguments[0];
		var target = arguments[1];
		selector.removeChild(target);
	}
	function addHandler() {
        
        var elements = document.querySelectorAll(arguments[0]);
        var event = arguments[1];
        var expression = arguments[2];
        
        for (i = 0; i < elements.length; i++) {
            elements[i].addEventListener(event, expression);
        }
    };
    
    function retrieveElements() {
        
        var elements = document.querySelectorAll(arguments[0]);
        
        return elements;
    }
    
    var self = {
        appendChild: addChildElement,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };
    
    return self;
	
}();