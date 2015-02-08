app.controller('Problem3', function($scope){
	var obj = {
		'Name': 'Pesho',
		'Born': 'Asia',
		'BirthDate': '2006',
		'Live': 'Sofia Zoo'
	};
	$scope.obj = obj;
	$scope.img = "http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg";
	$scope.divStyle = {
		backgroundColor: "silver",
		width: '50%',
		display: "inline-block"
	};
	$scope.liStyle = {
		listStyleType: 'none',
		border: 'none',
        color: 'rgb(43,61,79)',
        fontWeight: 'bolder',
        fontSize: '22px',
        fontWeight: 'normal'

	}
	$scope.imgStyle = {
		width: '350px',
		height: '200px',
		display: "inline-block",
		float: 'right',
		position: 'relative',
		top: '-115px'
	}

	
});