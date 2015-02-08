$(document).ready(function($) {
	var	json = $('textarea').val();
	var obj = jQuery.parseJSON(json);
	

	$('body').append('<table id="cars">')
	$.each(obj[0], function(index, val) {
		$('<th>').text(index).appendTo('#cars');
	});

	// for (var i = 0; i < obj.length; i++) {
	// 	$('<tr>').appendTo('#cars');
	// 	$.each(obj[i], function(index, val) {
	// 		console.log(val);
	// 		var text = val; 
	// 		 $('tr').append($('<td>').text(text));
	// 	});
	// };
	
	$(function () {
	    $.each(obj, function (i, item) {
	        var $tr = $('<tr>').append(
	            $('<td>').text(item.manufacturer),
	            $('<td>').text(item.model),
	            $('<td>').text(item.year),
	            $('<td>').text(item.price),
	            $('<td>').text(item.class)
	        ).appendTo('#cars');
	        
	    });
	    
	});

});

