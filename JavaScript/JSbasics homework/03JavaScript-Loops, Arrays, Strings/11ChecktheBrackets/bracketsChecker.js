// Write a JavaScript function checkBrackets(value) to check if in a given expression the brackets are put correctly. Write JS program bracketsChecker.js that invokes your function with the sample input data below and prints the output at the console.

function checkBrackets(arguments) {
	var brackets= 0;
	for (var index in arguments){
		if (arguments[index] == '(') {
			brackets +=1;
		}
		if (arguments[index] == ')') {
			brackets --;
		}
	}
	if (brackets != 0 ) {
		console.log('incorrect');
	} else {
		console.log('correct');
	}
}
checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');