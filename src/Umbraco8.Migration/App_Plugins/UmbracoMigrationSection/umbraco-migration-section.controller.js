(function (angular) {
    'use strict';

    var controller = function ($scope, sectionService) {
        var self = this;
        

        function init() {
            self.navigation = [
                {
                    'name': 'Config',
                    'icon': 'icon-umb-settings',
                    'alias': 'config'
                },
                {
                    'name': 'Fkg Client',
                    'icon': 'icon-traffic',
                    'alias': 'fkgClient'
                },
                {
                    'name': 'Fkg Sync Log',
                    'icon': 'icon-list',
                    'alias': 'fkgSyncLog'
                },
                {
                    'name': 'Fkg logs',
                    'icon': 'icon-settings',
                    'alias': 'fkgLogs'
                }
            ];

            //initConfig();
        }

        function initConfig() {
            if (!self.appConfig) {
                self.loading = true;
                sectionService.getConfig().then(function (response) {
                    self.appConfig = response.data;

                    self.pointFkgType.url = decodeURIComponent(self.appConfig.fkgDataSettings.pointsUrl);
                    self.lineFkgType.url = decodeURIComponent(self.appConfig.fkgDataSettings.linesUrl);
                    self.polygonFkgType.url = decodeURIComponent(self.appConfig.fkgDataSettings.polygonsUrl);

                    initTab();

                    self.loading = false;
                });
            }
        }

        function initTab() {
            if (self.active === 'fkgClient') {
                if (!self.fkgItemFields) {
                    self.loading = true;
                    sectionService.getFkgItemFields().then(function (response) {
                        self.fkgItemFields = Object.keys(response.data).map(i => { return { key: i, value: response.data[i] } });
                        self.fkgItemFields.unshift({ key: "Search by all fields", value: "" });

                        self.loading = false;
                    });
                }
            }
            else if (self.active === 'fkgSyncLog') {
                self.loading = true;
                self.syncLogFilter = {};

                sectionService.find(self.syncLogFilter).then(function (response) {
                    self.syncLogs = response.data;
                    self.loading = false;
                });
            }
            else if (self.active === 'fkgLogs') {
                self.loading = true;

                sectionService.getLogsInfo().then(function (response) {
                    self.logsInfo = response.data;
                    self.loading = false;
                });
            }
        }

        init();
    };

    controller.$inject = ['$scope', 'migrationSectionService'];

    angular.module('umbraco').controller('migrationSectionController', controller);
})(angular);