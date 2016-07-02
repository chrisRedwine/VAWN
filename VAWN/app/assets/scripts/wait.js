'use strict';

(function () {
    window.pleasewait_loading_screen = window.pleaseWait({
        logo: 'app/assets/images/blank.png',
        backgroundColor: '#53868B',
        loadingHtml: '<h2 style="color:white">Loading VAWN Demo Application...</h2>' +
                      '<div class=\"sk-cube-grid\">' +
                      '<div class=\"sk-cube sk-cube1\"></div>' +
                      '<div class=\"sk-cube sk-cube2\"></div>' +
                      '<div class=\"sk-cube sk-cube3\"></div>' +
                      '<div class=\"sk-cube sk-cube4\"></div>' +
                      '<div class=\"sk-cube sk-cube5\"></div>' +
                      '<div class=\"sk-cube sk-cube6\"></div>' +
                      '<div class=\"sk-cube sk-cube7\"></div>' +
                      '<div class=\"sk-cube sk-cube8\"></div>' +
                      '<div class=\"sk-cube sk-cube9\"></div>' +
                    '</div>'
    });
}());