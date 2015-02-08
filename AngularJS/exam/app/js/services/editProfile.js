'use strict';

app.factory('editProfile', function($http, baseServiceUrl, authService){
	return {

		editProfile: function(password, name, about, gender, picture, success, error) {
              var currentUser = authService.getCurrentUser();
              var userId = currentUser.objectId;
              var token = currentUser.sessionToken;
              var header = {
                'X-Parse-Application-Id' : '5G7Er0ILcd1oACnnChnXS7UGwkIEwGgFyGpE25uQ',
                'X-Parse-REST-API-Key' : 'ajgxsfKJLsKkFjuvgZmJUd5uYvXDHFq37X99Bg4D',
                'X-Parse-Session-Token' : token
              };
              var request = {
                  method: 'PUT',
                  headers: header,
                  url: baseServiceUrl + 'users/'+userId,
                  data: JSON.stringify({                  
                      "password":password,
                      "name":name,
                      "about":about,
                      "gender":gender,
                      "picture":picture            
                 }),
              };

              $http(request).success(function(data) {
                  sessionStorage['currentUser'] = JSON.stringify(data);
                  success(data);
              }).error(error);
    },

    getUser : function (success, error) {
            var currentUser = authService.getCurrentUser();
            var userId = currentUser.objectId;
            var request = {
              method: 'GET',
              headers: headers,
              url: baseServiceUrl + 'users/'+ userId
            };

            $http(request).success(function (data) {
              sessionStorage['currentUser'] = JSON.stringify(data);
              success(data);
            }).error(error);
    }

	};
});