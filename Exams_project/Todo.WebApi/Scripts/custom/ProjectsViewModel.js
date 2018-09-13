class User {
    constructor(Id, FirstName, LastName, MiddleName, MobilePhone, Email) {
        this.Id = Id
        this.FirstName = FirstName
        this.LastName = LastName
        this.MiddleName = MiddleName
        this.MobilePhone = MobilePhone
        this.Email = Email
    };
};

class ProjectsListViewModel {
    constructor () {
        this.users = ko.observableArray();
        this.loadJson();

        this.userFirstName = ko.observable();
        this.userLastName = ko.observable();
        this.userMiddleName = ko.observable();
        this.userMobilePhone = ko.observable();
        this.userEmail = ko.observable();
    };

    parse(data) {
        data.forEach(element => {
            var p = new User(
                this.Id = element.Id, 
                this.FirstName = element.FirstName, 
                this.LastName = element.LastName,
                this.MiddleName = element.MiddleName,
                this.MobilePhone = element.MobilePhone,
                this.Email = element.Email
            );
            this.users.push(p);
        });
    };

    loadJson() {
        var self = this;
        $.getJSON("/api/values", function(data){
            self.parse(data);
        });
    };

    addNew() {
        var newUser = new User(
            this.FirstName = this.userFirstName(),
            this.LastName = this.userLastName(),
            this.MiddleName = this.userMiddleName(),
            this.MobilePhone = this.userMobilePhone(),
            this.Email = this.userMobilePhone()
        );
        var userJson = ko.toJSON(newUser);
        $.post("/api/values", userJson, function (data) {
            console.log(data)
        });
    }
}

ko.applyBindings(new ProjectsListViewModel());