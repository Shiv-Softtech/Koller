app.controller("wishlistCtrl", ['$scope', '$cookies', function ($scope, $cookies) {

    var getwishlistdatadetail = $cookies.get("wishlist");
    $scope.wishlistdata = JSON.parse(getwishlistdatadetail);


    $scope.removetowishlist = function (index) {
        $scope.wishlistdata.splice(index,1);

    }

}]);