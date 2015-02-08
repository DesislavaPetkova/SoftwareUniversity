app.directive('publicAds', function(){
	// Runs during compile
	return {
		
		controller: 'PublicAdsCtrl',
		
		restrict: 'E', // E = Element, A = Attribute, C = Class, M = Comment
		// template: '',
		templateUrl: 'templates/public/public-ads.html',
		replace: true,
		// transclude: true,
		// compile: function(tElement, tAttrs, function transclude(function(scope, cloneLinkingFn){ return function linking(scope, elm, attrs){}})),
		// link: function($scope, iElm, iAttrs, controller) {
			
		};	
});