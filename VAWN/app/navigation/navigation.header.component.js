'use strict';

angular.module('vawn').component('navigationHeader', {
    templateUrl: 'app/navigation/navigation.header.template.html',
    controller: function ($http) {
        var ctrl = this;

        ctrl.links = [{
            href: '#/home',
            name: 'Home'
        }, {
            href: '#/movies',
            name: 'Movie Graph'
        }];

        ctrl.searchOptions = {
            debounce: {
                'default': 200,
                'blur': 0
            }
        };

        ctrl.search = function (value) {
            $http({
                method: 'GET',
                url: 'api/default/user'
            }).then(function success(response) {
                console.log(response.data);
            }, function failure(response) {
                console.log(response);
            })
        };
    }
});