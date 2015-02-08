function checkDigit(value){
	var n = Number(Math.floor(value%1000/100));
	if (n == 3) {
		console.log(true);
	} else {
		console.log(false);
	}
}	
checkDigit(25368);