'use strict';

app.controller('UserHomeController', ['$scope', '$location', '$route', 'authService', 'notifyService', 'editProfile', function($scope, $location, $route, authService, notifyService, editProfile){
	$scope.currentUser = authService.getCurrentUser();
	$scope.name = $scope.currentUser.name;
	$scope.username = $scope.currentUser.username;

	$scope.logout = function () {
		authService.logout();
		$location.path('/login');
	}

	$scope.clicked = false;

	$scope.postClicked = function () {
		$scope.clicked = !$scope.clicked;
	}

	$scope.addPost = function (content) {
		authService.addPost(content, 
			function success () {			
			notifyService.showInfo('Post successfuly added!');
			$route.reload();
		}, function error (err) {
			notifyService.showError('Posting failed', err)
		} );
	}

	$scope.getAllPosts = (function () {		
			authService.getAllPosts(
            
            function success(data) {
                $scope.posts = data.results;
                
            },
            function error(err) {
                notifyService.showError("Cannot load posts", err);
            }
        );
 
	})();

}]);