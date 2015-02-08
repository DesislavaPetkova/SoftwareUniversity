'use strict';
var ajaxRequester = (function() {

	var headers = {
		"X-Parse-Application-Id": "0cpTclNQ5tY9SKcXg0IZZJKJNsvODrPy0DNuvmmh",
		"X-Parse-REST-API-Key": "NYqnr2ot672qka6YxQqJofi5MOObJEoW8bYG0Kel"
	};
	var baseUrl = "https://api.parse.com/1/";


	function login (username, password, success, error)	 {
		jQuery.ajax({
			method: "GET",
			headers: headers,
			url: baseUrl + "login",
			data: {username: username, password: password},
			success: success,
			error: error
		})
	}


	function register (username, password, success, error)	 {
		jQuery.ajax({
			method: "POST",
			headers: headers,
			url: baseUrl + "users",
			data: JSON.stringify({username: username, password: password}),
			success: success,
			error: error
		})
	}

	function getHeadersWithSessionToken(sessionToken) {
        var headersWithToken = JSON.parse(JSON.stringify(headers));
        headersWithToken['X-Parse-Session-Token'] = sessionToken;
        return headersWithToken;
    }

    function getBookmarks(sessionToken, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "GET",
            headers: headers,
            url: baseUrl + "classes/Bookmark",
            success: success,
            error: error
        });
    }

    function logout (argument) {
    	// body...
    }


	return {
		login: login,
		register: register,
		getBookmarks: getBookmarks,
		logout: logout,
		// createBookmark: createBookmark,
		// deleteBookmark: deleteBookmark
	}



}());