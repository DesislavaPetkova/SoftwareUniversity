var app = app || {};

app.ajaxRequester = (function  () {
	function AjaxRequester () {
		this.get = makeGetRequest;
		this.post= makePostRequest;
		this.put = makePutRequest;
		this.delete = makeDeleteRequest;
	}

	var makeRequest = function (url, method, data, headers) {
		var defer = Q.defer;

		$.ajax({
			url:url,
			method: method,
			data: JSON.stringify(data),
			headers: headers,
			contentType: "application/json"
			success: function  (data) {
				defer.resolve(data);
			},
			error: function  (error) {
				defer.reject(error)
			}
		});

		return defer.promise;
	}

	var makeGetRequest = function  (url, headers) {
		return makeRequest(url, "GET", null, headers);
	}
	var makePostRequest = function  (url, data, headers) {
		return makeRequest (url, "POST", data, headers)
	}
	var makePutRequest = function  (url, method, data, headers) {
		return makeRequest (url, "PUT", data, headers);
	}
	var makeDeleteRequest = function  (url, method, data, headers) {
		return makeRequest(url, "DELETE", data, headers);
	}


	return{
		get: function  () {
			return new AjaxRequester();
		}
	}	
}());