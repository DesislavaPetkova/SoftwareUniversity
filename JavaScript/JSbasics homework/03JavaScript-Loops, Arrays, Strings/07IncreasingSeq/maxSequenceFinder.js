//Write a JavaScript function findMaxSequence(value) that finds the maximal increasing sequence in an array of numbers and returns the result as an array. If there is no increasing sequence the function returns 'no'.
// Write JS program maxSequenceFinder.js that invokes your function with the sample input data below and prints the output at the console. Examples:
// Input	Output
// [3, 2, 3, 4, 2, 2, 4]		[2, 3, 4]
// [3, 5, 4, 6, 1, 2, 3, 6, 10, 32]	[1, 2, 3, 6, 10, 32]
// [3, 2, 1]	no


function findMaxSequence (argument) {
	argument.push(1);
	var tempArray = [];
	var resultArray = [];
	for (var i = 0; i < argument.length; i++) {			
		if(argument[i] > argument[i-1]){	
			tempArray.push(argument[i]);
			
		} else{
			tempArray= [];
			continue;
		}
		if (argument[i] < argument[i-1] && argument[i] < argument[i+1]) {
					
					tempArray.push(argument[i]);
		} 
		if (tempArray.length >= resultArray.length) {
			resultArray= tempArray;
		} else {
			tempArray=[];
		}

	}
	console.log(tempArray);
	console.log(resultArray);
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);