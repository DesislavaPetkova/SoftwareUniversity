function bitChecker(value) {
	var n = value;
	n = n >> 3;
	if (n & 1 == 1) {
		console.log(true);
	} else {
		console.log(false);
	}
}	
bitChecker(438765);