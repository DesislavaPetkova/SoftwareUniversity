'use strict';

app.controller('LoginController',
    function ($scope, $rootScope, $location, authService, notifyService) {
        $scope.login = function(username, password) {
            authService.login(username, password,
                function success() {
                    notifyService.showInfo("Login successful");
                    $location.path("/user-home");
                },
                function error(err) {
                    notifyService.showError('login failed', err);
                }
            );
        };
    }
);
