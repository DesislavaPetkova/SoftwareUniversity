'user strict';

var app = angular.module('app', ['ngRoute']);
app.constant('baseServiceUrl', 'https://api.parse.com/1/');



app.config(['$routeProvider',function($routeProvider) {
	$routeProvider.when('/', {
		templateUrl: 'templates/user/guest-home.html'
		
	});

	$routeProvider.when('/login', {
		templateUrl: 'templates/user/login.html',
		controller: 'LoginController'
	});

	$routeProvider.when('/register', {
		templateUrl: 'templates/user/register.html',
		controller: 'RegisterController'
	});

	$routeProvider.when('/user-home', {
		templateUrl: 'templates/user/user-home.html',
		controller: 'UserHomeController'
	});

	$routeProvider.when('/edit-profile', {
		templateUrl: 'templates/user/edit-profile.html',
		controller: 'EditProfileController'
	});

	$routeProvider.otherwise({
		redirectTo: '/'
	})
}]);