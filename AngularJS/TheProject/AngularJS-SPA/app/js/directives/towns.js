app.directive('towns',function(){
	// Runs during compile
	return {
		
		controller: 'TownsCtrl',
		restrict: 'E', // E = Element, A = Attribute, C = Class, M = Comment
		
		templateUrl: 'templates/public/towns.html',
		replace: true		
			
		};	
});