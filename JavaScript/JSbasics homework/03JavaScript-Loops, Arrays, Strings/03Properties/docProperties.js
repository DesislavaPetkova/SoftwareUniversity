function displayProperties(){
	var properties= [];
	for (var index in window){
		properties.push(index);
	}
	properties.sort();
	console.log(properties.join("\n"));	
}
displayProperties();