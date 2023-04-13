app.controller("addtocart", ['$scope', '$cookies', function ($scope, $cookies) {

    var getcartdatadetail = $cookies.get("addtocart");
    $scope.cartdata= JSON.parse(getcartdatadetail);


    $scope.removeaddtocart = function (index) {
        $scope.cartdata.splice(index,1);

    }

}]);