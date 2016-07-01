'use strict';

angular.module('vawn')
.value('$routerRootComponent', 'vawn')
.component('vawn', {
    templateUrl: '/app/app.html',
    $routeConfig: [
      { path: '/home', name: 'Home', component: 'home', useAsDefault: true },
      { path: '/movies', name: 'Movies', component: 'movies' },
      //{ path: '/disaster', name: 'Asteroid', redirectTo: ['CrisisCenter', 'CrisisDetail', {id:3}] }
    ]
});