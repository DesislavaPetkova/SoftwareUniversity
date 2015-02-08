
app.controller('SoftUniController',['$scope', 'authentication', '$location', 'userData', function($scope, authentication, $location, userData){
	$scope.pageTitle = 'Home';
	$scope.isLoggedIn = authentication.isLoggedIn();
	// $scope.loggedBar = 'templates/directives/logged-id-sidebar.html';

	$scope.logout = function (user) {
		userData.logout(user)
		.$promise
		.then(function (data) {
			$location.path('/')
		});
	};
	
}]);
