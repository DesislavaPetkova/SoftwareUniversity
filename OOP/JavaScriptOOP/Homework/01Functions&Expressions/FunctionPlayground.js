function getFunctionInfo () {
	if(arguments.length == 0){
		console.log("Invalid number of arguments");
		return;
	}
	console.log("Name of the Functon is "+getFunctionInfo.name);
	console.log("The number of its arguments is " + arguments.length);
	for (var i = 0; i < arguments.length; i++) {
		console.log("The type of argument "+(i+1)+" is: " + typeof arguments[i]);
	}
}

getFunctionInfo("hey", 23, 24, 65, "wewe", true);
console.log();
getFunctionInfo();
console.log();

function person(){
	console.log(this.name);	
	console.log(this.age);
}
// person("gosho", 24);
person.call({name:"gosho",age: 23});
person();