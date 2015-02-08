'use strict';

app.controller('EditProfileController',function($scope, authService, $location, editProfile, notifyService){
	$scope.currentUser = authService.getCurrentUser();
	$scope.name = $scope.currentUser.name;
	$scope.username = $scope.currentUser.username;
	
	$scope.editProfile = function(password, name, about, gender, picture) {
            editProfile.editProfile(password, name, about, gender, picture,
                function success() {
                    notifyService.showInfo("Profile successfully updated");                    
                    $location.path("/user-home");                    
                },
                function error(err) {
                    notifyService.showError('Edit failed', err);
                }
            );
    };
    $scope.cancel = function () {
    	$location.path('user-home');
    }

    $scope.getUser = function () {
        editProfile.getUser(function success () {
            
        }),
        function error (err) {
            notifyService.showError('Geting user failed', err);
        }
    };

});