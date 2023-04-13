app.controller('homeCtrl', ['$scope', '$cookies','$http', function ($scope, $cookies,$http) {
    $scope.hideregisterbutton = true;
    $scope.hideloginbutton = true;
    $scope.showLogoutButton = false;
    $scope.checkUserCookie = checkUserCookie;


    function checkUserCookie() {
        var user = $cookies.get('currentUser');
        if (user != null && user != undefined) {
            var user = JSON.parse(user);
            $scope.showLogoutButton = true;
            $scope.hideregisterbutton = false;
            $scope.hideloginbutton = false;
            $scope.currentUserName = "Hi  "+user.name;
        }
    }
   
    $scope.logoutCurrentUser = function () {
        $scope.hideregisterbutton = true;
        $scope.hideloginbutton = true;
        $scope.currentUserName = ""
        $scope.showLogoutButton = false;
        $cookies.remove("currentUser", { path:'/' });
    }

   
    $http.get('/Product/GetList').then(function (result) {
        $scope.productData=result.data
    });


    $http.get('/Product/GetIndex').then(function (result) {
        $scope.detail = result.data
    });

   /* $http.get('/Product/sortBy').then(function (result) {
        $scope.detail = result.data
    });
*/

   $http.get('/Product/GetFilter').then(function (Filterresult) {
        $scope.filterdata = Filterresult.data
   });

    $scope.addTowishlist = function (imgpath, Catogries, price) {
        $scope.productData = [];
        $scope.checklist = $cookies.get("wishlist");
        if ($scope.checklist != null && $scope.checklist != undefined)
        {
            $scope.productData = JSON.parse($scope.checklist);
        }
        $scope.data = { 'imgpath': imgpath, 'Catogries ': Catogries,'Catogries': price }
        $scope.productData.push($scope.data);
        var expireDate = new Date();
        expireDate.setDate(expireDate.getDate + 19);
        $cookies.put('wishlist', JSON.stringify($scope.productData), { expires: expireDate, path: '/' });

        
    }

    $scope.addTocart = function (imgpath, Catogries, price) {
        $scope.productData = [];
        $scope.checklist = $cookies.get("cart");
        if ($scope.checklist != null && $scope.checklist != undefined) {
            $scope.productData = JSON.parse($scope.checklist);
        }
        $scope.data = { 'imgpath': imgpath, 'Catogries ': Catogries, 'Catogries': price }
        $scope.productData.push($scope.data);
        var expireDate = new Date();
        expireDate.setDate(expireDate.getDate + 19);
        $cookies.put('cart', JSON.stringify($scope.productData), { expires: expireDate, path: '/' });

  
    }

   /* $scope.addToCart = function (a, price, Name) {

        $scope.itemToAdd = [
            { id: 1, qty: a, price: price, Name: Name }
        ]
        $scope.cart.push(($scope.itemToAdd));

    }*/


}]);