'use strict';

// Close the loading screen ASAP
window.pleasewait_loading_screen.finish();

// Define the top level `vawn` module
angular.module('vawn', [
  'ngRoute',
  'ngComponentRouter',
  'ngplus',
  'ngTagsInput'//,
  //'vawn.view1',
  //'vawn.view2'
]);