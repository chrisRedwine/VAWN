'use strict';

angular.module('vawn').component('vawn', {
    templateUrl: '/app/app.template.html',
    $routeConfig: [
      { path: '/home', name: 'Home', component: 'home', useAsDefault: true },
      { path: '/movies', name: 'Movies', component: 'movies' },
      //{ path: '/disaster', name: 'Asteroid', redirectTo: ['CrisisCenter', 'CrisisDetail', {id:3}] }
    ]
});