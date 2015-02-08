app.directive('categories', function(){	
	return {		
		controller: 'CategoriesCtrl',		
		restrict: 'E', // E = Element, A = Attribute, C = Class, M = Comment		
		templateUrl: 'templates/public/categories.html',
		replace: true		
	};
});