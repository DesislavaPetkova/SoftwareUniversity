function divisionChecker(num){
	var sumGet = 0;
	while (num > 0){
		sumGet += num%10;
		num = Math.floor(num/10);
	}
	if (sumGet % 3 == 0) {
		console.log("the number is divided by 3 without remainder");
	} else {
		console.log('the number is not divided by 3 without remainder');
	}

}
divisionChecker(189);