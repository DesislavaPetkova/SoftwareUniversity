app.controller('NewAdController',['$scope', '$location', '$log', '$adsData', function($scope, $location, $log, adsData) {
	$scope.addAd = function (ad) {
		adsData.create(ad)
			.$promise
			.then(function (data) {
				alert('Ad added: ' + data);
				$location.path('#/ads');
			},
			function (error) {
				$log.error(error);
			});
	}

	$scope.cancelAdd = function () {
		
	}
}]);