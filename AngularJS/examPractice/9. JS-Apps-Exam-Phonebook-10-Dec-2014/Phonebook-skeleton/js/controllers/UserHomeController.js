'user strict';

app.controller('UserHomeController', function($scope, authService){
	$scope.currentUser = authService.getCurrentUser();
	$scope.fullname = $scope.currentUser.fullName;
	$scope.username = $scope.currentUser.username;

});