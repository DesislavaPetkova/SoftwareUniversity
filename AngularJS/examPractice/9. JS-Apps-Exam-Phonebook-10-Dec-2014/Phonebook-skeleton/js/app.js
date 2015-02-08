'use strict';

var app = angular.module('app', ['ngRoute', 'ngResource']);
app.constant('baseServiceUrl', 'https://api.parse.com/1/');

app.config(['$routeProvider',function($routeProvider) {
	$routeProvider.when('/', {
		templateUrl: 'templates/user/welcome.html',
		controller: 'WelcomeController'
	});

	$routeProvider.when('/login', {
		templateUrl: 'templates/user/login.html',
		controller: 'LoginController'
	});

	$routeProvider.when('/register', {
		templateUrl: 'templates/user/registration.html',
		controller: 'RegisterController'
	});

	$routeProvider.when('/user-home', {
		templateUrl: 'templates/user/user-home.html',
		controller: 'UserHomeController'
	});

	$routeProvider.otherwise({
		redirectTo: '/'
	});

}])