function compareChars(arrayOne, arrayTwo) {
	
	if (arrayOne.length != arrayTwo.length) {
		console.log('Not equal');
		return;
	}
	for (var i = 0; i < arrayOne.length; i++) {
		if (arrayOne[i] === arrayTwo[i]) {
			continue;
		} else {
			console.log('Not equal');
			return;
		}
	}
	console.log('Equal');
}
compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], 
['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
);	
compareChars(['3', '5', 'g', 'd'], 
['5', '3', 'g', 'd']);
compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
['6', 'f', 'w', 'q', ':', 'â€', 'd', '}', ']', 's', 'r']
);