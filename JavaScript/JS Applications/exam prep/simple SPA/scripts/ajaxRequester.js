var ajaxRequester = (function () {
	var makeRequest = function makeRequest (method, url, data, success, error) {
		return $.ajax({
			type: method,
			url: url,
			data: JSON.stringify(data),
			contentType: 'application/json',
			success: success,
			error: error
		});
	}

	function makeGetRequest (url, success, error) {
		return makeRequest("GET", url, null, success, error);
	}

	function makePostRequest (url, data, success, error) {
		return makeRequest("POST", url, data, success, error);
	}
	function makePutRequest (url, data, success, error) {
		return makeRequest("PUT", url, data, success, error);
	}
	function makeDeleteRequest (url, data, success, error) {
		return makeRequest("DELETE", url, data, success, error);
	}

	return {
		get: makeGetRequest,
		post: makePostRequest,
		put: makePutRequest,
		delete: makeDeleteRequest
	}
}());