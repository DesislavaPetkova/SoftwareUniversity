function evenNumber(value){
	var evenNumber = value;
	if (evenNumber % 2 == 0) {
		document.write(true + "<br>");
		console.log(true);
	} else {
		document.write(false + "<br>");
		console.log(false);
	}
}

evenNumber(3);
evenNumber(127);
evenNumber(588);