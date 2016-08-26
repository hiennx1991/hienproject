(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input == true)
                return 'Activate';
            else
                return 'Locked';
        }
    });
})(angular.module('tedushop.common'));