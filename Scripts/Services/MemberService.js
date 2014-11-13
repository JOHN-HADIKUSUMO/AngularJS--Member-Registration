var MemberService = function ($http) {
    var member = { Id: 0, Firstname: '', Lastname: '', Age: null, Gender: 0 };
    var read = function (id) {
        return member;
    };

    var create = function (member,onsuccess,onfail) {
        $http.post('/REST/MEMBERS/CREATE', member).success(onsuccess).error(onfail);
        return true;
    };

    return {
        Read:read,
        Create:create
    };
};