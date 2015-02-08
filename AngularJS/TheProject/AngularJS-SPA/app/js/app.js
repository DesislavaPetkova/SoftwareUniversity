'use strict';

var app = angular.module('app', ['ngRoute', 'ngResource', 'LocalStorageModule', 'ui.bootstrap.pagination']);
app.constant('baseServiceUrl', 'http://softuni-ads.azurewebsites.net/api/');

app.config(['$routeProvider',  function ($routeProvider) {
	$routeProvider.when('/', {
		templateUrl:'templates/home.html',
		controller:'SoftUniController'
	});
	$routeProvider.when('/public-ads',{
		templateUrl:'templates/all-ads.html'
	});
	$routeProvider.when('/login',{
		templateUrl:'templates/login.html',
		controller: "LoginCtrl"
	});
	$routeProvider.when('/register',{
		templateUrl:'templates/register.html',
		controller: "RegisterCtrl"
	});
	$routeProvider.when('/publish>', {
			templateUrl: 'templates/newAd.html',
			controller: 'NewAdController'
	});
	$routeProvider.otherwise({redirectTo:'/'});


	//Web storage data
	// localStorageServiceProvider.setStorageType('localStorage');
	// localStorageServiceProvider.setPrefix('adsApp');
}]);
 