var app = angular.module("orderApp", []);
app.controller("OrderController", function () {
    this.order = "Test";
});

app.controller('userController', ['$scope','$http', function ($scope,$http) {
    //var userLogin = this;
    $scope.users = [];
    $http.get('/User/GetUsers').then(function (jsonResult) {

        for (i = 0; i < jsonResult.data.length; i++)
            $scope.users.push(jsonResult.data[i]);
      //  console.log(data);
    });
}]);
