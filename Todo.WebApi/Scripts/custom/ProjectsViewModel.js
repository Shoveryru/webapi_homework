class Project {
    constructor(Id, Title, DateCreated) {
        this.Id = Id
        this.Title = Title
        this.DateCreated = DateCreated
    };
};

class ProjectsListViewModel {
    constructor () {
        this.allProjects = ko.observableArray();
        this.isVisible = ko.observable(false);
        this.buttonText = ko.observable('Показать...');
    };

    parse(data) {
        data.forEach(element => {
            var p = new Project(this.Id = element.Id, 
                                this.Title = element.Title, 
                                this.DateCreated = element.DateCreated);

            p.DateCreated = this.momentjsFormat(p.DateCreated);
            p.Title = this.lodashFormat(p.Title);
            this.allProjects.push(p);
        });
    };

    loadJson() {
        var self = this;
        $.getJSON("/api/values", function(data){
            self.parse(data);
        });
    };

    lodashFormat(title) {
        return _.snakeCase(title);
    }

    momentjsFormat(time) {
        var date = moment(time);
        var locale = date.locale('ru');
        var added = locale.add(3, 'd');
        return added.format('Do MMMM YYYY');
    };

    clickButton() {
        this.allProjects.removeAll();
        var bool = false;
        var text = 'Показать...';
        if (this.isVisible() === false) {
            bool = true;
            this.loadJson();
            text = 'Скрыть...';
        };
        this.isVisible(bool);
        this.buttonText(text);
    }
}

ko.applyBindings(new ProjectsListViewModel());