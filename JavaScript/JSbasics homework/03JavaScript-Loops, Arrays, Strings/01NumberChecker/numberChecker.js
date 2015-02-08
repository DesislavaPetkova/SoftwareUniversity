function printNumbers(n) {
	var arr = [];
	for (var i = 0; i <= n; i++) {		
		if ((i%4>0)&&(i%5>0)) {
			arr.push(i);
		} else {
			continue;
		}		
	}
	if (arr.length == 1) {
			arr[0] = 'no';				
		}	
	var number = arr.join();
	console.log(number);
}
printNumbers(20);
printNumbers(13);
printNumbers(1);