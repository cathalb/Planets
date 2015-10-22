app.factory('planetsService', ['$http', function ($http) {
    return $http.get('http://localhost:59783/api/planets')
              .success(function (data) {
                  return data;
              })
              .error(function (err) {
                  return err;
              });
}]);