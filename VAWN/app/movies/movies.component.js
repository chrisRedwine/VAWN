'use strict';

angular.module('vawn').component('movies', {
    templateUrl: 'app/movies/movies.template.html',
    controller: function ($http) {
        var ctrl = this;

        ctrl.tags = [];

        ctrl.loadTags = function (query) {
            return [
              { "text": "ACTED_IN" },
              { "text": "DIRECTED" },
              { "text": "FOLLOWS" },
              { "text": "PRODUCED" },
              { "text": "REVIEWED" },
              { "text": "WROTE" }
            ];
            //return $http.get('/app/services/mock/relationship_types.json')
            //            .then(function (response) { return response.data });
        };

        ctrl.tags = ctrl.loadTags();
    }
});