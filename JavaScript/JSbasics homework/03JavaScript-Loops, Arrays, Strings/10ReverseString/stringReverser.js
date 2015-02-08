// Write a JavaScript function reverseString(value) that reverses string and returns it. Write JS program stringReverser.js that invokes your function with the sample input data below and prints the output at the console.
function reverseString(argument) { 	
 	var word;
 	var arr = [];
 	for (var i = argument.length-1; i >=0 ; i--) {
 		word= argument[i];
 		arr.push(word); 		
 	}
 	
 	console.log(arr.join(''));
 } 
 reverseString('sample');
 reverseString('softUni');
 reverseString('java script');