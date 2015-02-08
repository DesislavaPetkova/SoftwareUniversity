jQuery(document).ready(function($) {
	var PARSE_APP_ID = "YBL3EWRPsCtxDHvtLfpjoXMUeaIxsZIYQGTn5VqW"; 
	var PARSE_REST_API_KEY = "WTgwx7KavITUKemVRH4bGyXWsiKZpuzmf9OvFTpm";

	(function loadingCountries (selector) {
		if(selector == undefined){
				$.ajax({
				method: "GET",
				headers: {
					"X-Parse-Application-Id": PARSE_APP_ID,
					"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
				},
				url: "https://api.parse.com/1/classes/Country",
				}).success(function(data) {
					for (c in data.results) {
						var country = data.results[c];
						var countryItem = $('<li>');
						var countryLink = $('<a href="#">');
						countryLink.text(country.Name);
						countryLink.appendTo($('#countries'));
					}
				}).error(function() {
					alert('Cannot load questions.');
				});
		}else{
			$.ajax({
				method: "GET",
				headers: {
					"X-Parse-Application-Id": PARSE_APP_ID,
					"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
				},
				url: "https://api.parse.com/1/classes/Country",
				}).success(function(data) {
					for (c in data.results) {
						var country = data.results[c];
						var countryItem = $('<li>');
						countryItem.text(country.Name);
						countryItem.appendTo($('#'+selector+''));
					}
				}).error(function() {
					alert('Cannot load questions.');
				});
		}	
	}());

	

	$('#submit').click(function() {		
		var oldName = $('#oldName').val();
		var oldNameId;
		var newName = $('#newName').val();
		

		$.ajax({
			method:'GET',
			headers: {
				"X-Parse-Application-Id": PARSE_APP_ID,
				"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
			},
			url: 'https://api.parse.com/1/classes/Country'
		}).success(function(data) {
			for (c in data.results) {
				var count = data.results[c];				
				var item = count.Name;				
				if(item == oldName){
					oldNameId = count.objectId;
					$.ajax({			
					method:"PUT",
					headers: {
						"X-Parse-Application-Id": PARSE_APP_ID,
						"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
					},
					data: JSON.stringify(
						{'Name':newName}
					),
					url: 'https://api.parse.com/1/classes/Country/'+oldNameId,
					}).success(function(data) {						
						location.reload();
					})									
					break;
				}
			}			
		})	
		
	});

	$('#submitCountry').click(function() {
		var newCountry = $('#add').val();		
		$.ajax({
			method:'POST',
			headers: {
				"X-Parse-Application-Id": PARSE_APP_ID,
				"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
			},
			data: JSON.stringify(
				{"Name": newCountry}
			),
		  	contentType: "application/json",
			url: 'https://api.parse.com/1/classes/Country'
		}).success(function(data) {
			location.reload();
		})
	});

	$('#removeCountry').click(function() {		
		var name = $('#remove').val();

		$.ajax({
			method:'GET',
			headers: {
				"X-Parse-Application-Id": PARSE_APP_ID,
				"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
			},
			url: 'https://api.parse.com/1/classes/Country'
		}).success(function(data) {
			for (c in data.results) {
				var count = data.results[c];				
				var item = count.Name;				
				if(item == name){
					name = count.objectId;
					$.ajax({			
					method:"DELETE",
					headers: {
						"X-Parse-Application-Id": PARSE_APP_ID,
						"X-Parse-REST-API-Key": PARSE_REST_API_KEY 
					},					
					url: 'https://api.parse.com/1/classes/Country/'+name,
					}).success(function(data) {						
						location.reload();
					})									
					break;
				}
			}			
		})	
	});

	$('a').click(function() {
		alert('wew');
	});
	
});