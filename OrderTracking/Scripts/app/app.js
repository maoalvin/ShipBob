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

        var data = {
            streetAddress: $scope.streetAddress,
            city: $scope.city,
            state: $scope.state,
            zipcode: $scope.zipCode
        };
        
        $http.post('/Order/CreateNewOrder', data).then(function(resp){
            $window.location.href = "/User/Index";
        });
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
        var response = $http.post('/User/CreateUser', data).then(function (dataResult) { $alert(dataResult.result); });

    };

    $scope.login = function () {
        var data = { firstName: $scope.firstName, lastName: $scope.lastName };
        var fn = $scope.firstName;
       // alert(data);
        var response = $http.post('/User/LoginUser', data).then(function (resp) {
            if(resp!=null)
                $window.location.href = "/User/Index";
        });
   //     if(response.data!=null)
           
    }
  


}]);
