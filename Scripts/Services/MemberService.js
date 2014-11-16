var MemberService = function ($http) {
    var member = { Id: 0, Firstname: '', Lastname: '', Age: null, Gender: 0 };
    var read = function (id, onsuccess, onfail) {
        $http.post('/REST/MEMBERS/READ/' + id).success(onsuccess).error(onfail);
    };

    var readall = function (onsuccess, onfail) {
        $http.get('/REST/MEMBERS/READALL').success(onsuccess).error(onfail);
    };

    var create = function (member,onsuccess,onfail) {
        $http.post('/REST/MEMBERS/CREATE', member).success(onsuccess).error(onfail);
    };

    var update = function (member, onsuccess, onfail) {
        $http.post('/REST/MEMBERS/CREATE', member).success(onsuccess).error(onfail);
    };

    return {
        Read: read,
        ReadAll:readall,
        Create: create,
        Update: update
    };
};