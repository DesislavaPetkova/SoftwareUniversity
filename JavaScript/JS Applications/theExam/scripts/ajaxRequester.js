'use strict';
var ajaxRequester = (function() {

	var headers = {
		"X-Parse-Application-Id": "qGmRoizRNzuCQ2ClcrmWoYpJBdviZU3nEKSOTyAU",
		"X-Parse-REST-API-Key": "0sJPDzgg3pvb62VPRePGFDilo9WTBMFv87GcwTir"
	};
	var baseUrl = "https://api.parse.com/1/";

	function getHeadersWithSessionToken(sessionToken) {
        var headersWithToken = JSON.parse(JSON.stringify(headers));
        headersWithToken['X-Parse-Session-Token'] = sessionToken;
        return headersWithToken;
    }


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

    function getProducts(sessionToken, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "GET",
            headers: headersWithToken,
            url: baseUrl + "classes/Products",
            success: success,
            error: error
        });
    }

    function addProduct(name, category, price, userId, success, error) {
        var product = {Name: name, Category: category, Price: price, ACL : {}};
        product.ACL[userId] = {"write": true, "read": true};
        jQuery.ajax({
            method: "POST",
            headers: headers,
            url: baseUrl + "classes/Products",
            data: JSON.stringify(product),
            success: success,
            error: error
        });
    }
    
    function deleteProduct(sessionToken, productId, success, error) {
        var headersWithToken = getHeadersWithSessionToken(sessionToken);
        jQuery.ajax({
            method: "DELETE",
            headers: headersWithToken,
            url: baseUrl + "classes/Products/" + productId,
            success: success,
            error: error
        });
    }

    function editProduct(sessionToken, name, category, price, productId, success, error) {
    	var headersWithToken = getHeadersWithSessionToken(sessionToken);
        var product = {Name: name, Category: category, Price: price};        
        jQuery.ajax({
            method: "PUT",
            headers: headersWithToken,
            contentType: "javascript/json",
            url: baseUrl + "classes/Products/"+ productId,
            data: JSON.stringify(product),
            success: success,
            error: error
        });
    }

	return {
		login: login,
		register: register,
		getProducts: getProducts,
		logout: logout,
		addProduct: addProduct,
		deleteProduct: deleteProduct,
		editProduct: editProduct
	}



}());