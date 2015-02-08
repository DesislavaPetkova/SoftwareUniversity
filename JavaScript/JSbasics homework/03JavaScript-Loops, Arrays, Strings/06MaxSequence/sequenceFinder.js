function findMaxSequence(value) {
	var current = 1;
	var array= [];
	var maxsequence=1;
	var content;
	for (var i = 1; i < value.length; i++) {
		if (value[i-1] === value[i]) {
			current+=1;
			if (current >= maxsequence) {
				content = value[i];
				maxsequence= current;			} 
		}else{
				current = 1;
				
		}
	}
	for (var i = 0; i < maxsequence; i++) {
		array.push(content)
	}
	if (value.length == 1 ) {
		console.log(value);
		return;
	}
	if (maxsequence >1){
	console.log(array);
	}
	if (maxsequence == 1) {
		console.log('no');
	}
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([3, 2, 1]);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);