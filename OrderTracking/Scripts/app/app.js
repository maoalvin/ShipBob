var app = angular.module("orderApp", []);
app.controller('orderController', ['$scope', '$http', function ($scope, $http) {
    //var userLogin = this;
    $scope.init = function () {

        $scope.orders = [];
        $http.get('/Order/GetOrdersForUser', { params: { userID: $scope.id } }).then(function (jsonResult) {

            for (i = 0; i < jsonResult.data.length; i++)
                $scope.orders.push(jsonResult.data[i]);

        });
    };

    $scope.submit = function () {

        var data = { firstName: $scope.firstName, lastName: $scope.lastName };
        
        $http.post('/Order/CreateOrder', data)
    };



}]);

app.controller('userController', ['$window','$scope','$http', function ($window,$scope,$http) {
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
        var response = $http.post('/User/CreateUser', data).then(function (data) { $window.location.href = "/User/Index"; });

    };
  


}]);
