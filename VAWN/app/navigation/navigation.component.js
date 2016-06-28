angular.module('vawn').component('navigation', {
    templateUrl: '/app/navigation/navigation.html',
    controller: function () {
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
    }
});