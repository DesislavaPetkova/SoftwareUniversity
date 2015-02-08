(function  () {
	var rootUrl = "https://api.parse.com/1/";
	var dataPersister = app.persister.get(rootUrl);
	var controller = app.controller.get(dataPersister);
	controller.load('#wrapper');
}());