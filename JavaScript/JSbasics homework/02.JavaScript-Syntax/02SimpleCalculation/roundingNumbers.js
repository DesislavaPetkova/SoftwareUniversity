function roundNumber(value){
	var floatingNumber = value;
	var floor = Math.floor(floatingNumber);
	var round = Math.round(floatingNumber);
	document.write(floor + "</br>");
 	document.write(round + "</br>");
 	console.log(floor);
 	console.log(round);
}
roundNumber(22.7);
roundNumber(12.3);
roundNumber(58.7);