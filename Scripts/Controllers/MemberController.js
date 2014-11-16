var MemberController = function ($scope, $http, MemberService) {
    var resetSuccess = function () {
        $scope.success = '';
    };

    var resetError = function () {
        $scope.error = '';
    };

    var resetMember = function () {
        $scope.member = { Id: 0, Firstname: '', Lastname: '', Age: null, Gender: 0 };
    };

    var onCreateSuccess = function (data, status, headers, config) {
        resetMember();
        resetError();
        $scope.success = 'The information has been saved.';
    };

    var onCreateFail = function (data, status, headers, config) {
        resetSuccess();
        $scope.error = JSON.stringify(data);
    };

    $scope.options = [{ key: 0, value: 'Male' }, { key: 1, value: 'Female' }]

    resetMember();
    resetSuccess();
    resetError();

    $scope.Create = function () {
        
        if ($scope.member.Firstname == '') {
            $scope.error = 'Firstname must be supplied.';
        }
        else if ($scope.member.Lastname == '') {
            $scope.error = 'Lastname must be supplied.';
        }
        else if ($scope.member.Age == null) {
            $scope.error = 'Age must be supplied.';
        }
        else if (isNaN($scope.member.Age)) {
            $scope.error = 'Age must be a numeric.';
        }
        else if ($scope.member.Age < 18 || $scope.member.Age > 50) {
            $scope.error = 'Age must between 18 and 50 years old.';
        }
        else {
            MemberService.Create($scope.member, onCreateSuccess, onCreateFail);
        };
    };

}

