function isPrime(value){
	var n = value;
	var n2 =2;
	var n3 =3;
	var n5 =5;
	var n7 =7;
	var divCheck = false;
	var divsCheck= false;
	if (value == 2 || value == 3 || value == 5 || value ==7) {
		console.log(true);
		return;
	}
	if (((n / n) == 1) && ((n/1) ==n)) {
		divCheck = true;
	}
	if (((n%n2)>0) &&
		((n%n3)>0) && 
		((n%n5)>0) && 
		((n%n7)>0))  {
		divsCheck = true;
	}
	if (divCheck == true && divsCheck == true) {		 
		 console.log(true);	
	} else {		
		 console.log(false);	
	}
}	
isPrime(113);