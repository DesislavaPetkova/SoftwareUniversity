app.factory('filter',function(){
	
	var params = {};

	function filterByCategory(category) {
		params.categoryId = category.id;

	}

	function filterByTown(town) {
		params.townId =town.id;
	}

	function getParams () {
		return params;
	}

	function setPageParams (pageParams) {
		 //TODO
	}

	return{
		filterByCategory: filterByCategory,
		filterByTown: filterByTown,
		getParams: getParams,
		page: setPageParams
	}
});