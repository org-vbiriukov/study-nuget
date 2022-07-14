(function (angular) {
    'use strict';

    var service = function ($http, umbRequestHelper) {
        var self = this;

        const baseUrl = '/umbraco/backoffice/api/migrationApi/';

        self.export = function () {
            $http.get(baseUrl + "Export");
        }

    };

    service.$inject = ['$http', "umbRequestHelper"];

    angular.module('umbraco').service('migrationSectionService', service);
})(angular);