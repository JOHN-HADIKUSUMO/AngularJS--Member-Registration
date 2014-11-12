(function () {
    var memberapp = angular.module("MemberApp", []);
    memberapp.controller("MemberController", ["$scope","$http",MemberController]);
}());