var MemberController = function ($scope, $http) {

    var onCreateSuccess = function (data, status, headers, config)
    {
        $scope.success = 'The information has been saved.';
        $scope.member = { Id: 0, Firstname: '', Lastname: '', Age: null, Gender: 0 };
    };

    var onCreateFail = function (data, status, headers, config) {
        $scope.error = JSON.stringify(data);
    };

    $scope.member = { Id: 0, Firstname: '', Lastname: '', Age: null, Gender: 0 };
    $scope.error = '';
    $scope.success = '';
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
            $http.post('/REST/MEMBERS/CREATE', $scope.member).success(onCreateSuccess).error(onCreateFail);
        };
    };

}

