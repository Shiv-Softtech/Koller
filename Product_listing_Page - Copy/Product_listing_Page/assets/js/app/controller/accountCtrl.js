app.controller('accountCtrl', ['$scope', '$cookies', '$timeout', '$http' , function ($scope, $cookies, $timeout, $http) {

    //registration

    //hobbies validation
    $scope.hobbies = [{ key: "Cricket", isSelected: false },
        { key: "Football",isSelected: false },
        { key: "Singing", isSelected: false },
        { key: "Writing", isSelected: false }
    ]
    $scope.validation = function () {
        var selectedHobbies = [];
        angular.forEach($scope.hobbies, function (val) {
            if (val.isSelected)
                selectedHobbies.push(val.key);


        });


        if (selectedHobbies.length == 0) {
            return $scope.errormsg = "please select hobbies";

        } else {
            $scope.errormsg = "";
        }

        var hobbydata = selectedHobbies.join(","); //"red,blue,green"
        /* $scope.isValidationFail = false;*/


        //set cookies

        if (typeof ($scope.user.name) != "undefined" && typeof
            ($scope.user.email) != "undefined" && typeof
            ($scope.user.password) != "undefined" && typeof
            ($scope.user.gender) != "undefined" && typeof
            ($scope.user.deparment) != "undefined") {

            var userInfo = [];
            var usersCookie = $cookies.get("users");
            if (usersCookie != null && usersCookie != undefined)
                userInfo = JSON.parse(usersCookie);



            var user = {
                "name": $scope.user.name, "email": $scope.user.email, "password": $scope.user.password,
                "gender": $scope.user.gender, "department": $scope.user.deparment, "hobbies": hobbydata
            };
            $http.post('/Account/insertdata', { postdata: user })


        } 


                userInfo.push(user);
                var datadetails = JSON.stringify(userInfo);
                var now = new Date(),
                    // this will set the expiration to 12 months
                    exp = new Date(now.getFullYear(), now.getMonth(), now.getDate() + 1);
                $cookies.put('users', datadetails, { expires: exp, path: '/' });
                window.location.href = "/Account/login";
         
    }
        

    $scope.checkhobby = function () {
        var selectedHobbies = [];
        angular.forEach($scope.hobbies, function (val) {
     if (val.isSelected)
        selectedHobbies.push(val.key);


        });


     if (selectedHobbies.length == 0) {
         $scope.errormsg = "please select hobbies";

        } else {
            $scope.errormsg = "";
        }
    }
  //login 

    $scope.loginvalidation = function () {



        if ($scope.email != undefined && 
            $scope.password != undefined) { 
            var users_cookie = $cookies.get("users");
        if (users_cookie != null && users_cookie != undefined) {
            var userdata = JSON.parse(users_cookie);
            var userExists = false;
            for (var i = 0; i < userdata.length; i++) {
                if (userdata[i].email == $scope.email && userdata[i].password == $scope.password) {
                    userExists = true;
                    var user = { "name": userdata[i].name, "email": userdata[i].email, "password": userdata[i].password, "hoob": userdata[i].hobbies };
                    var now = new Date(),
                        // this will set the expiration to 12 months
                        exp = new Date(now.getFullYear(), now.getMonth(), now.getDate() + 1);
                    $cookies.put("currentUser", JSON.stringify(user), { expires: exp, path: '/' });
                }
            }

            if (userExists) {
                $scope.hbbiesdisplay = user.hoob.split(",");
                $scope.loginsuccess = "Login success";
                $timeout(function () {
                    $scope.loginsuccess = false;
                }, 8000);
                window.location.replace(location.origin + "/Product/Index");
            }
            else
                $scope.loginfaild = "User Not Exists";
            $timeout(function () {
                $scope.loginfaild = false;
            }, 2000);
            /*  alert("User Not Exists");*/
        }
        else {
            alert("User Not Exists.Please register");
            return false;
        }
        }
        return false;
    }


   
    

}]);
