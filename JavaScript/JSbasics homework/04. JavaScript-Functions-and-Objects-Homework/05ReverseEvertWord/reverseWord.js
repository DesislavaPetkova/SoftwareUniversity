// Write a JavaScript function reverseWordsInString(str) to reverse the characters of every word in the string but leaves the words in the same order. Words are considered to be sequences of characters separated by spaces. Write a JavaScript program reverseWords.js that prints on the console the output of the examples below:
function reverseWordsInString(str) {
	var arr = str.split(' ');
	var result;
	var resultarr= [];
	
	for (var i = 0; i < arr.length; i++) {
		result = arr[i].split('').reverse().join('');
		resultarr.push(result);

	}
	console.log(resultarr.join(' '));
}
reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');
