// Write a JavaScript function lastDigitAsText(number) that returns the last digit of given integer as an English word. Write a JS program lastDigitOfNumber.js that invokes your function with the sample input data below and prints the output at the console. 
function lastDigitAsText(argument) {
	
	var arr = argument.toString().split('');
	var lastDigit = arr.length-1;
	var digit = arr[lastDigit];
	switch (Number(digit)){
		case 1: console.log('one');
		break;
		case 2: console.log('two');
		break;
		case 3: console.log('three');
		break;
		case 4: console.log('four');
		break;
		case 5: console.log('five');
		break;
		case 6: console.log('six');
		break;
		case 7: console.log('seven');
		break;
		case 8: console.log('eight');
		break;
		case 9: console.log('nine');
		break;
	}
	
}
lastDigitAsText(133);
lastDigitAsText(14567);
lastDigitAsText(-55);
lastDigitAsText(6);