function calcSupply(value, value1, value2){
	var age = value;
	var maxAge = value1;
	var foodConsum = value2;
	var kg = (maxAge-age)*365*foodConsum;
	console.log(kg + 'kg '+"of chocolate would be enough until I am " + maxAge + " years old.");
}
calcSupply(38, 118, 0.5);
calcSupply(20, 87, 2);
calcSupply(16, 102, 1.1);