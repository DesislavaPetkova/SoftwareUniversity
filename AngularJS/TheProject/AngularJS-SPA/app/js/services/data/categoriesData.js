app.factory('categoriesData', ['$resource', 'baseServiceUrl', function($resource, baseServiceUrl){
	var resource = $resource(baseServiceUrl + 'categories');
	

	function getCaterogires () {
		return resource.query();
	}

	return {
		getCaterogires: getCaterogires
	};
}])