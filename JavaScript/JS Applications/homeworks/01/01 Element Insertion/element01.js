$('#target').parent().prepend('<div id="beforeResult">');
$('#target').next().parent().append('<div id="after">');
$('<div id="insideDIv">').appendTo('#target');
