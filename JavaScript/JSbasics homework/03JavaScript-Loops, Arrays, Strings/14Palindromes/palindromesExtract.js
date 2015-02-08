// Write a JavaScript function findPalindromes(value) that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe". Write JS program palindromesExtract.js that invokes your function with the sample input data below and prints the output at the console. 
function findPalindromes(argument) {	
	var lower = argument.toLowerCase();	
	var arr = lower.split(/[., ]+/g);
	var result = [];	
	for (var i = 0; i < arr.length; i++) {		
		if (arr[i] == "") {
			continue;
		}
		var check = arr[i].split('').reverse().join('');
		if (arr[i] == check) {
			result.push(arr[i]);
		}
	}
	var resultArray = result.join(', ');
	console.log(resultArray);
	
	
}
findPalindromes('There is a man, his name was Bob.');