'use strict';

// Close the loading screen ASAP
(function() {
    setTimeout(function() {
        window.pleasewait_loading_screen.finish();
    }, 3000);
}());

// Define the top level `vawn` module
angular.module('vawn', [
  'ngComponentRouter',
  'ui.bootstrap',
  'angular-loading-bar',
  'angular-spinkit',
  'ngTagsInput'
])
.config(['$provide', 'cfpLoadingBarProvider', function ($provide, cfpLoadingBarProvider) {
    $provide.value('$routerRootComponent', 'vawn');
    cfpLoadingBarProvider.includeSpinner = false;
}]);