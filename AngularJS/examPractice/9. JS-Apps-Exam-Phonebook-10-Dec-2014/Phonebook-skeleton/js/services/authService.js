'use strict';

app.factory('authService',
  function ($http, baseServiceUrl) {
      return {
          login: function(username, password, success, error) {
              var request = {
                  method: 'GET',
                  headers: {
                    'X-Parse-Application-Id' : 'LkhGG82INW9iV1L0uwlWfY6KwK4HoaCsgrvRyVQw',
                    'X-Parse-REST-API-Key' : 'I44dGaY0vlcxl9rbLJhpx2FwDT1heffLjGXI7n3t'
                  },
                  url: baseServiceUrl + 'login/',
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

          // TODO: implement “register” function (just like the login)

          logout: function() {
              delete sessionStorage['currentUser'];
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
              return sessionStorage['currentUser'] != undefined;
          },

          isNormalUser : function() {
              var currentUser = this.getCurrentUser();
              return (currentUser != undefined) && (!currentUser.isAdmin);
          },

          isAdmin : function() {
              // TODO: implement this (similar to isNormalUser())
          },

          getAuthHeaders : function() {
              var headers = {};
              var currentUser = this.getCurrentUser();
              if (currentUser) {
                  headers['Authorization'] = 'Bearer ' + currentUser.access_token;
              }
              return headers;
          }
      }
  }
);
