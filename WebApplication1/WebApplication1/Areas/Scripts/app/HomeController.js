var app = angular.module("app", ["ngResource"]);
app.controller("MyCtrl", ["$scope", "translationService",
    function ($scope, translationService) {
    $scope.hello = "Hello World !";
    $scope.lang ="en";
    $scope.translate = function () {
        translationService.getTranslation($scope, $scope.lang);
    };
    $scope.translate();
}]);

app.service("translationService", function ($resource) {
    this.getTranslation = function ($scope, lang) {
        var translationFilePath = "/Areas/dictionary/translation_"+lang+".json";
        $resource(translationFilePath).get(function(data){
            $scope.translation = data;
        });
        
    };
});