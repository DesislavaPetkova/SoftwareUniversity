// Write a JavaScript function findLargestBySumOfDigits(nums) that takes as an input a sequence of positive integer numbers and returns the element with the largest sum of its digits. The function should take a variable number of arguments. It should return undefined when 0 arguments are passed or when some of the arguments is not an integer number. Write a JS program largestSumOfDigits.js that invokes your function with the sample input data below and prints its output at the console.
function findLargestBySumOfDigits() {
	var maxsum = 1;
	for(var i = 0; i < arguments.length; i++){
		var numbers = arguments[i].toString().replace(/\D/g, 0);
		var arr = numbers.toString().split('');
		var sum = 0;
		
		var value;
		for (var j = 0; j < arr.length; j++) {
			var check=Number(arr[j]);
			
			sum+=check;
			if (sum >= maxsum) {
				maxsum = sum;
				value = arguments[i];
			}
		}
		sum = 0;		
	}
	console.log(value);
}

findLargestBySumOfDigits(5, 10, 15, 111);
findLargestBySumOfDigits(33, 44, -99, 0, 20);
findLargestBySumOfDigits('hello');
findLargestBySumOfDigits(5, 3.3);