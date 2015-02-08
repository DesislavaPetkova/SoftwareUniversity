(function () {
	var demoApp = angular.module('demoApp', ['ngRoute']);	

	demoApp.config(['$routeProvider', function ($routeProvider) {
			
			$routeProvider.when('/', 
			{
				controller:'SimpleController',
				templateUrl:'View1.html'
			})
			.when('/view2',
			{
				controller:'SimpleController',
				templateUrl:'View2.html'
			})
			.otherwhise({redirectTo: '/'});
		}]);	
		
	demoApp.controller('SimpleController', function($scope){
			$scope.customers = [
			{name: 'Ivan', city:'Varna'}, 
			{name:'Napur', city: 'Sofia'}, 
			{name:'Shriva', city:'Plovdiv'}, 
			{name:'Heedy', city:'Vraca'}
			];		
	

		$scope.AddCustomer = function  ($scope) {
			$scope.customers.push(
			{
				name:$scope.newCustomer.name,
				city:$scope.newCustomer.city
			});
		}
	
	});

		

	



}());