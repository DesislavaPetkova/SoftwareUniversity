app.directive('loggedInSidebar',function(){
	// Runs during compile
	return {		
		controller: 'LoggedInSidebarCtrl',		
		restrict: 'E', // E = Element, A = Attribute, C = Class, M = Comment		
		templateUrl: 'templates/directives/logged-in-sidebar.html',
		replace: true		
	};
	
});