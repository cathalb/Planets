app.controller('PlanetController', function ($scope, $http) {
    //$http.get('http://localhost:58358/api/planets').
    //    success(function (data) {
    //        $scope.planets = data;
    //    }).
    //    error(function() {
    //        alert("error");
    //});
    //$http.get('http://localhost:58358/api/planets')
    //    .success(function (response) { $scope.planets = response; })
    //    .error(function(err) {
    //        alert(err);
    //    });

    //$http.get("http://localhost:58358/api/planets").then(function(resp) {
    //    console.log("Success", resp);
    //    // For JSON responses, resp.data contains the result
    //}, function() {
    //    console.error("error");
    //    // err.status will contain the status code
    //});

    //$scope.submitRules = function() {
    var responsePromise = $http(
    {
        method: 'GET',
        url: 'http://localhost:58358/api/planets',
        headers: { 'X-Parse-Application-Id': 'XXX', 'X-Parse-REST-API-Key': 'YYY' }
    });

    //var responsePromise = $http.get("http://localhost:58358/api/planets");
    responsePromise.success(function (data, status, headers, config) {
        $scope.planets = data;
    });
    responsePromise.error(function (data, status, headers, config) {
        alert("AJAX failed!");
    });
    //}
});