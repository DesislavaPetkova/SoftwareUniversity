// Write a JavaScript function findNthDigit(arr) that accepts as a parameter an array of two numbers num and n and returns the n-th digit of given decimal number num counted from right to left. Return undefined when the number does not have n-th digit. Write a JS program nthDigitOfNumber.js that invokes your function with the sample input data below and prints the output at the console
function findNthDigit(argument) {
	var n = argument[0];
	var number = argument[1].toString().replace('.', '').replace('-', '');	
	var reversed = number.toString().split('').reverse();	
	if (reversed[n-1] == undefined) {
		console.log("The number doesn’t have "+ n + " digits");
	}else {
		console.log(reversed[n-1]);
	}
	
}
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]); 
findNthDigit([6, 888.88]);
findNthDigit([1, 6]);
findNthDigit([2, -55]);	