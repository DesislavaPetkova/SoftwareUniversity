Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }

    Object.prototype.validateNonEmptyString = function (value, variableName) {
    	if (typeof (value) != 'string' || !value) {
    		throw new Error(variableName + " should be nonempty string");
    	};    	
    }

    Object.prototype.validateIntegerRange = function(value, variableName, min, max) {
    	if(!value === parseInt(value, 10)){
    		throw new Error(variableName +"number should be Integer");
    	};
    	if ((typeof value != 'number') || (value < min || value > max)) {
    		throw new Error(variableName +' number should be number in right range');
    	};
    }

    Object.prototype.validateBoolean = function(value, variableName) {
        if (typeof value != 'boolean') {
            throw new Error (variableName+' should be a boolean');
        };
    }

    Object.prototype.validateNonEmptyObject = function(value, className, variableName){
        if (! (value instanceof className) || !value) {
            throw new Error(variableName + " should be non empty object " + className.prototype.constructor.name);
        };
    }

    if (this.constructor === methodName) {
	      throw new Error("Can't instantiate abstract class!");	      
	    }


    var AbstractClass = (function() {
    	'use strict';
    
    	function AbstractClass(args) {
    		
    		if (!(this instanceof AbstractClass)) {
    			return new AbstractClass(args);
    		}
    		if (this.constructor === AbstractClass) {
	      throw new Error("Can't instantiate abstract class!");	      
	    }
    	}
    
    	AbstractClass.prototype.methodName = function(args) {
    		
    	};
    
    	return AbstractClass;
    
    }());


    var standartMethod = (function() {
    	'use strict';
    
    	function standartMethod(args) {
    		
    		if (!(this instanceof standartMethod)) {
    			return new standartMethod(args);
    		}
    		
    	}
    	standartMethod.extends(AbstractClass);

    	standartMethod.prototype.methodName = function(args) {
    		// method body
    	};
    
    	return standartMethod;
    
    }());




