'use strict';

app.controller('RegisterController',
    function ($scope, $rootScope, $location, authService, notifyService) {
        $scope.register = function(username, password, name, about, gender, picture) {
            authService.register(username, password, name, about, gender, picture,
                function success() {
                    notifyService.showInfo("Register successful");
                    $location.path("/login");
                },
                function error(err) {
                    notifyService.showError("Register failed", err);
                }
            );
        };
    }
);
