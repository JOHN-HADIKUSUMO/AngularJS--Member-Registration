(function () {
    var memberapp = angular.module("MemberApp", []);
    memberapp.service('MemberService',MemberService);
    memberapp.controller("MemberController", ["$scope","$http","MemberService",MemberController]);
}());