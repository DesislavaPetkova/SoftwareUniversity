$('#color').css("background-color", 'blue');

$('#paint').click(function(event) {
	 var target = $('#class').val(); 
	 
	 console.log(target);
	$('.'+target).css("background-color", 'blue');
});


