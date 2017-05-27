var app = angular.module("orderApp", []);
app.controller("OrderController", function () {
    this.order = "Test";
});

app.controller('userController', ['$scope','$http', function ($scope,$http) {
    //var userLogin = this;
    $scope.init = function () {
   
        $scope.users = [];
        $http.get('/User/GetUsers').then(function (jsonResult) {

            for (i = 0; i < jsonResult.data.length; i++)
                $scope.users.push(jsonResult.data[i]);
           
        });
    };

    $scope.submit = function () {

        var data = { firstName: $scope.firstName, lastName: $scope.lastName };
        var fn = $scope.firstName;
        $http.post('/User/CreateUser',data)
    };
  


}]);
