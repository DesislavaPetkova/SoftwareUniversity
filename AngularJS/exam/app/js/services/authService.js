'use strict';
var headers = {
  'X-Parse-Application-Id' : '5G7Er0ILcd1oACnnChnXS7UGwkIEwGgFyGpE25uQ',
  'X-Parse-REST-API-Key' : 'ajgxsfKJLsKkFjuvgZmJUd5uYvXDHFq37X99Bg4D'
};
app.factory('authService',
  function ($http, baseServiceUrl) {
      return {


          login: function(username, password, success, error) {
              var request = {
                  method: 'GET',
                  headers: headers,
                  url: baseServiceUrl + 'login',
                  params: {
                    username : username,
                    password : password
                  }
              };
              $http(request).success(function(data) {
                  sessionStorage['currentUser'] = JSON.stringify(data);
                  success(data);
              }).error(error);
          },

          register: function(username, password, name, about, gender, picture, success, error) {
              var request = {
                  method: 'POST',
                  headers: headers,
                  url: baseServiceUrl + 'users',
                  data: JSON.stringify({                    
                      "username":username,
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


          logout: function() {
              delete sessionStorage['currentUser'];
          },

          addPost: function (content, success, error) {
            var request = {
                  method: 'POST',
                  headers: headers,
                  url: baseServiceUrl + 'classes/Post',
                  data: JSON.stringify({                    
                      "content":content,
                      "createdBy": {
                        "__type":"Pointer",
                        "className":"_User",
                        "objectId":"userObjectId"   
                 
                    }
                  })
                }
            $http(request).success(function (data) {
              success(data);
            }).error(error);
          },
          
          getAllPosts : function (success, error) {
            var request = {
                method: 'GET',
                headers: headers,
                url: baseServiceUrl + 'classes/Post',
                params: {
                  include : 'createdBy'
                }
                  // data: JSON.stringify({                    
                  //     "content":"postContent",
                  //     "createdBy": {
                  //       "__type":"Pointer",
                  //       "className":"_User",
                  //       "objectId":"userObjectId"   
                 
                  //   }
                  // })
            };

            $http(request).success(function (data) {
              success(data)
            }).error(error);
          },

          getCurrentUser : function() {
              var userObject = sessionStorage['currentUser'];
              if (userObject) {
                  return JSON.parse(sessionStorage['currentUser']);
              }
          },                

          isAnonymous : function() {
              return sessionStorage['currentUser'] == undefined;
          },

          isLoggedIn : function() {
              // TODO: implement this (similar to isAnonymous())
          },

          isNormalUser : function() {
              var currentUser = this.getCurrentUser();
              return (currentUser != undefined) && (!currentUser.isAdmin);
          },

          isAdmin : function() {
              // TODO: implement this (similar to isNormalUser())
          },

          // getAuthHeaders : function() {
          //     var headers = {};
          //     var currentUser = this.getCurrentUser();
          //     if (currentUser) {
          //         headers['Authorization'] = 'Bearer ' + currentUser.access_token;
          //     }
          //     return headers;
          // }
      }
  }
);
