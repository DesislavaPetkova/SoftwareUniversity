// Write a JavaScript function biggerThanNeighbors(index,  arr) that accept a number and an integer array as parameters. The function should return a Boolean number: whether the element at the given position in the array is bigger than its two neighbors (when such exist). It should return undefined when the index doesn't exist. 
function biggerThanNeighbors() {
	var n = arguments[0];
	var array = arguments[1].toString().split(/[,. ]+/g);
	var numbers = [];
	for (var i = 0; i < array.length; i++) {
		numbers[i]= Number(array[i]);
	}	
	if (numbers[n] == undefined) {
		console.log('invalid index');
		return;
	}
	if ((numbers[n-1] == undefined && numbers[n+1]>0) || (numbers[n-1] > 0 && numbers[n+1] == undefined)) {
		console.log('only one neighbor');
		return;
	}
	if (numbers[n] >  numbers[n+1] && numbers[n-1] ) {
		console.log('bigger');
	} else {
		console.log('not bigger');
	}
}
biggerThanNeighbors(2, [1, 2, 3, 3, 5]);
biggerThanNeighbors(2, [1, 2, 5, 3, 4]);
biggerThanNeighbors(5, [1, 2, 5, 3, 4]);
biggerThanNeighbors(0, [1, 2, 5, 3, 4]);