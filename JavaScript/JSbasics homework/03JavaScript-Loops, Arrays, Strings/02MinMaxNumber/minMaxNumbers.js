function findMinAndMax(value) {
	var min = Number.MAX_VALUE;
	var max = Number.MIN_VALUE;
	for (var index in value) {
		if (value[index] > max) {
			max = value[index];
		} 
		if (value[index] < min) {
			min = value[index];
		}
	}
	console.log('Min ->'+ min);
	console.log('Max ->'+max);
}
findMinAndMax([1,2,1,15,20,5,7,31]);
findMinAndMax([2,2,2,2,2]);
findMinAndMax([500,1,-23,0,-300,28,35,12]);