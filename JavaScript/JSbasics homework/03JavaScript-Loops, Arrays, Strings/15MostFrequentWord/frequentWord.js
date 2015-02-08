// Write a JavaScript function findMostFreqWord(value) that finds the most frequent word in a text and prints it, as well as how many times it appears in format "word -> count". Consider any non-letter character as a word separator. Ignore the character casing. If several words have the same maximal frequency, print all of them in alphabetical order. Write JS program frequentWord.js that invokes your function with the sample input data below and prints the output at the console.
function findMostFreqWord(argument) {
	var array = argument.split(/[ .,]+/g);
	var counter = 0;
	var maxFreq = 1;
	var content;
	for (var i = 0; i < array.length; i++) {
		for (var j = 0; j < array.length; j++) {
			if (array[i]==array[j]) {
				counter+=1;
			}
			if (counter >= maxFreq){
				maxFreq = counter;
				content = array[i];				
			}
		}
		counter = 0;		
	}
	
	console.log(content +" -> "+ maxFreq+" times");
}
findMostFreqWord('in the middle of the night');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');	