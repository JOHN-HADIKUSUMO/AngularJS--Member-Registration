var BrowseMemberController = function ($scope, $http, MemberService) {
    var onReadAllSuccess = function (data, status, headers, config) {
        $scope.memberlist = data;
    };

    var onReadAllFail = function (data, status, headers, config) {
        $scope.error = JSON.stringify(data);
    };

    $scope.toGender = function (i) {
        return i == 0 ? 'MALE' : 'FEMALE';
    };

    $scope.edit = function (i) {
        alert(i);
    };

    $scope.delete = function (i) {
        alert(i);
    };

    MemberService.ReadAll(onReadAllSuccess, onReadAllFail);
}

