var app = app || {};

app.data = (function () {
	function Data (baseUrl, ajaxRequester) {
		this.users = new Users(baseUrl, ajaxRequester);
		this.bookmarks = new Bookmarks(baseUrl, ajaxRequester);


	}

	var Users = (function (argument) {
		function Users (baseUrl, ajaxRequester) {			
		
		}


		return Users;
	}());

	return {
		get: function  (baseUrl, ajaxRequester) {
			return new Data(baseUrl, ajaxRequester);
		}
	}	
}());